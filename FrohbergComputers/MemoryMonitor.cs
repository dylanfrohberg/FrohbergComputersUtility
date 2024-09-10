using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace FrohbergComputers
{
    public class MemoryMonitor
    {
        private readonly Label _memoryModelLabel;
        private readonly Label _memoryCapacityLabel;
        private readonly Label _memoryDIMMLocationLabel;
        private readonly Label _memoryFrequencyLabel;
        private readonly Label _memoryUsageLabel;
        private readonly Label _memoryGenerationLabel;
        private readonly Label _xmpEnabledLabel;
        private readonly Label _memoryVoltageLabel;

        public MemoryMonitor(
            Label memoryModelLabel, Label memoryCapacityLabel, Label memoryDIMMLocationLabel,
            Label memoryFrequencyLabel, Label memoryUsageLabel, Label memoryGenerationLabel,
            Label xmpEnabledLabel, Label memoryVoltageLabel)
        {
            _memoryModelLabel = memoryModelLabel;
            _memoryCapacityLabel = memoryCapacityLabel;
            _memoryDIMMLocationLabel = memoryDIMMLocationLabel;
            _memoryFrequencyLabel = memoryFrequencyLabel;
            _memoryUsageLabel = memoryUsageLabel;
            _memoryGenerationLabel = memoryGenerationLabel;
            _xmpEnabledLabel = xmpEnabledLabel;
            _memoryVoltageLabel = memoryVoltageLabel;
        }

        public void UpdateMemoryInfo()
        {
            UpdateMemoryModel();
            UpdateMemoryCapacity();
            UpdateDIMMLocation();
            UpdateMemoryFrequency();
            UpdateMemoryUsage();
            UpdateMemoryGeneration();
            UpdateXMPStatus();
            UpdateMemoryVoltage();
        }

        private void UpdateMemoryModel()
        {
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT Manufacturer, PartNumber FROM Win32_PhysicalMemory");
                var memoryData = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
                if (memoryData != null)
                {
                    string manufacturer = memoryData["Manufacturer"]?.ToString() ?? "N/A";
                    string partNumber = memoryData["PartNumber"]?.ToString() ?? "N/A";
                    SetLabelText(_memoryModelLabel, $"{manufacturer} {partNumber}");
                }
                else
                {
                    SetLabelText(_memoryModelLabel, "Model information not available.");
                }
            }
            catch (Exception ex)
            {
                SetLabelText(_memoryModelLabel, $"Error: {ex.Message}");
            }
        }

        private void UpdateMemoryCapacity()
        {
            try
            {
                string powerShellCommand = "Get-WmiObject -Class Win32_PhysicalMemory | Measure-Object -Property Capacity -Sum | Select-Object -ExpandProperty Sum";
                string output = ExecutePowerShellCommand(powerShellCommand);
                if (ulong.TryParse(output, out ulong totalBytes))
                {
                    decimal totalGB = totalBytes / (1024 * 1024 * 1024); // Convert bytes to GB
                    SetLabelText(_memoryCapacityLabel, $"{totalGB:F2} GB");
                }
                else
                {
                    SetLabelText(_memoryCapacityLabel, "Unable to parse capacity.");
                }
            }
            catch (Exception ex)
            {
                SetLabelText(_memoryCapacityLabel, $"Error: {ex.Message}");
            }
        }

        private void UpdateDIMMLocation()
        {
            try
            {
                string powerShellCommand = "Get-WmiObject -Class Win32_PhysicalMemory | Select-Object -Property DeviceLocator";
                string output = ExecutePowerShellCommand(powerShellCommand);
                var locations = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(line => line.Trim())
                                      .Where(line => line.StartsWith("C"))
                                      .ToArray();

                if (locations.Any())
                {
                    SetLabelText(_memoryDIMMLocationLabel, string.Join(" | ", locations));
                }
                else
                {
                    SetLabelText(_memoryDIMMLocationLabel, "Location information not available.");
                }
            }
            catch (Exception ex)
            {
                SetLabelText(_memoryDIMMLocationLabel, $"Error: {ex.Message}");
            }
        }

        private void UpdateMemoryFrequency()
        {
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT Speed FROM Win32_PhysicalMemory");
                var memoryData = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
                if (memoryData != null)
                {
                    uint speed = (uint)memoryData["Speed"];
                    SetLabelText(_memoryFrequencyLabel, $"{speed} MHz");
                }
                else
                {
                    SetLabelText(_memoryFrequencyLabel, "Frequency information not available.");
                }
            }
            catch (Exception ex)
            {
                SetLabelText(_memoryFrequencyLabel, $"Error: {ex.Message}");
            }
        }

        private void UpdateMemoryUsage()
        {
            try
            {
                string totalCapacityCommand = "Get-WmiObject -Class Win32_PhysicalMemory | Measure-Object -Property Capacity -Sum | Select-Object -ExpandProperty Sum";
                string totalCapacityOutput = ExecutePowerShellCommand(totalCapacityCommand);
                decimal totalCapacity = Convert.ToDecimal(totalCapacityOutput);

                string freeMemoryCommand = "Get-CimInstance -ClassName Win32_OperatingSystem | Select-Object -ExpandProperty FreePhysicalMemory";
                string freeMemoryOutput = ExecutePowerShellCommand(freeMemoryCommand);
                decimal freeMemory = Convert.ToDecimal(freeMemoryOutput) * 1024; // Convert KB to bytes

                decimal usedMemory = totalCapacity - freeMemory;
                decimal usedMemoryGB = Math.Round(usedMemory / (1024 * 1024 * 1024), 2);
                decimal totalCapacityGB = Math.Round(totalCapacity / (1024 * 1024 * 1024), 2);

                SetLabelText(_memoryUsageLabel, $"{usedMemoryGB} GB / {totalCapacityGB} GB");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        private void UpdateMemoryGeneration()
        {
            try
            {
                string powerShellCommand = "Get-CimInstance -ClassName Win32_PhysicalMemory | Select-Object -Property PartNumber, Speed";
                string output = ExecutePowerShellCommand(powerShellCommand);
                var lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(line => line.Trim())
                                   .ToArray();

                string ddrType = "Unknown";
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2 && int.TryParse(parts[1], out int speed))
                    {
                        ddrType = speed >= 4800 ? "DDR5" : speed >= 2133 ? "DDR4" : "DDR3";
                        SetLabelText(_memoryGenerationLabel, ddrType);
                        return;
                    }
                }

                SetLabelText(_memoryGenerationLabel, "Unknown");
            }
            catch (Exception ex)
            {
                SetLabelText(_memoryGenerationLabel, $"Error: {ex.Message}");
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }

        private void UpdateXMPStatus()
        {
            try
            {
                string powerShellCommand = "Get-CimInstance -ClassName Win32_PhysicalMemory | Select-Object -Property Speed";
                string output = ExecutePowerShellCommand(powerShellCommand);

                var speeds = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(line => line.Trim())
                                    .Where(line => !string.IsNullOrWhiteSpace(line))
                                    .Select(line => int.TryParse(line, out int s) ? (int?)s : null)
                                    .Where(s => s.HasValue)
                                    .Select(s => s.Value)
                                    .ToArray();

                var ddr4StandardSpeeds = new[] { 2666, 2800, 2933, 3200, 3400, 3600, 3733, 3800, 3866, 4000, 4133, 4200 };
                var ddr5StandardSpeeds = new[] { 4800, 5200, 5600, 6000, 6400, 6800, 7200, 7600 };

                bool isXMPEnabled = speeds.Any(s => ddr4StandardSpeeds.Contains(s) || ddr5StandardSpeeds.Contains(s));

                SetLabelText(_xmpEnabledLabel, isXMPEnabled ? "Likely Enabled" : "Likely Disabled");
            }
            catch (Exception ex)
            {
                SetLabelText(_xmpEnabledLabel, $"Error: {ex.Message}");
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }

        private void UpdateMemoryVoltage()
        {
            try
            {
                string powerShellCommand = "Get-CimInstance -ClassName Win32_PhysicalMemory | Select-Object -Property MaxVoltage";
                string output = ExecutePowerShellCommand(powerShellCommand);

                var voltages = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(line => line.Trim())
                                     .Select(line => line.LastIndexOf('1') >= 0 ? (decimal?)Convert.ToDecimal(line) : null)
                                     .Where(v => v.HasValue)
                                     .Select(v => v.Value)
                                     .ToArray();

                if (voltages.Any())
                {
                    SetLabelText(_memoryVoltageLabel, $"{voltages.Max() / 1000:F2} V");
                }
                else
                {
                    SetLabelText(_memoryVoltageLabel, "Voltage information not available.");
                }
            }
            catch (Exception ex)
            {
                SetLabelText(_memoryVoltageLabel, $"Error: {ex.Message}");
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }

        private string ExecutePowerShellCommand(string command)
        {
            try
            {
                using (var process = new Process())
                {
                    process.StartInfo.FileName = "powershell.exe";
                    process.StartInfo.Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{command}\"";
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
