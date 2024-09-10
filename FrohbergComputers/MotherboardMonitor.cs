using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace FrohbergComputers
{
    public class MotherboardMonitor
    {
        private readonly Label _systemManufacturerLabel;
        private readonly Label _baseboardManufacturerLabel;
        private readonly Label _baseboardProductLabel;
        private readonly Label _baseboardVersionLabel;
        private readonly Label _biosVersionLabel;
        private readonly Label _secureBootStatusLabel;

        public MotherboardMonitor(
            Label systemManufacturerLabel, Label baseboardManufacturerLabel, Label baseboardProductLabel,
            Label baseboardVersionLabel, Label biosVersionLabel, Label secureBootStatusLabel)
        {
            _systemManufacturerLabel = systemManufacturerLabel;
            _baseboardManufacturerLabel = baseboardManufacturerLabel;
            _baseboardProductLabel = baseboardProductLabel;
            _baseboardVersionLabel = baseboardVersionLabel;
            _biosVersionLabel = biosVersionLabel;
            _secureBootStatusLabel = secureBootStatusLabel;
        }

        public void UpdateMotherboardInfo()
        {
            try
            {
                var baseBoardQuery = "SELECT Manufacturer, Product, Version FROM Win32_BaseBoard";
                var biosQuery = "SELECT SMBIOSBIOSVersion FROM Win32_BIOS";

                using (var searcherBaseBoard = new ManagementObjectSearcher(baseBoardQuery))
                using (var searcherBios = new ManagementObjectSearcher(biosQuery))
                {
                    var baseBoard = searcherBaseBoard.Get().Cast<ManagementObject>().FirstOrDefault();
                    var bios = searcherBios.Get().Cast<ManagementObject>().FirstOrDefault();

                    if (baseBoard != null)
                    {
                        SetLabelText(_systemManufacturerLabel, baseBoard["Manufacturer"]?.ToString() ?? "N/A");
                        SetLabelText(_baseboardManufacturerLabel, baseBoard["Manufacturer"]?.ToString() ?? "N/A");
                        SetLabelText(_baseboardProductLabel, baseBoard["Product"]?.ToString() ?? "N/A");
                        SetLabelText(_baseboardVersionLabel, baseBoard["Version"]?.ToString() ?? "N/A");
                    }
                    else
                    {
                        SetLabelText(_systemManufacturerLabel, "No baseboard information found.");
                    }

                    if (bios != null)
                    {
                        SetLabelText(_biosVersionLabel, bios["SMBIOSBIOSVersion"]?.ToString() ?? "N/A");
                    }
                    else
                    {
                        SetLabelText(_biosVersionLabel, "No BIOS information found.");
                    }
                }

                UpdateSecureBootStatus();
            }
            catch (Exception ex)
            {
                SetLabelText(_systemManufacturerLabel, $"Error: {ex.Message}");
            }
        }

        private void UpdateSecureBootStatus()
        {
            try
            {
                string command = "Confirm-SecureBootUEFI";
                string output = ExecutePowerShellCommand(command);
                string secureBootEnabled = output.Contains("True") ? "Enabled" : "Disabled";
                SetLabelText(_secureBootStatusLabel, secureBootEnabled);
            }
            catch (Exception ex)
            {
                SetLabelText(_secureBootStatusLabel, $"Error: {ex.Message}");
            }
        }

        private string ExecutePowerShellCommand(string command)
        {
            try
            {
                using (var process = new Process())
                {
                    process.StartInfo.FileName = "powershell.exe";
                    process.StartInfo.Arguments = $"-Command \"{command}\"";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode != 0)
                    {
                        string error = process.StandardError.ReadToEnd();
                        throw new Exception($"PowerShell command failed with error: {error}");
                    }

                    return output.Trim();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"PowerShell execution error: {ex.Message}");
                return string.Empty;
            }
        }

        private void SetLabelText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => label.Text = text));
            }
            else
            {
                label.Text = text;
            }
        }
    }
}
