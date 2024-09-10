using System.Diagnostics;
using System.Globalization;

public class GPUMonitor
{
    private readonly Form _form;
    private readonly Label _gpuModelLabel;
    private readonly Label _gpuMemoryLabel;
    private readonly Label _gpuTemperatureLabel;
    private readonly Label _gpuClockSpeedLabel;
    private readonly Label _gpuPowerLabel;
    private readonly Label _gpuUsageLabel;
    private readonly Label _gpuDriverDateLabel;
    private readonly Label _gpuVoltageLabel;

    public GPUMonitor(Form form, Label gpuModel, Label gpuMemory, Label gpuTemperature, Label gpuClockSpeed, Label gpuPower, Label gpuUsage, Label gpuDriverDate, Label voltage)
    {
        _form = form;
        _gpuModelLabel = gpuModel;
        _gpuMemoryLabel = gpuMemory;
        _gpuTemperatureLabel = gpuTemperature;
        _gpuClockSpeedLabel = gpuClockSpeed;
        _gpuPowerLabel = gpuPower;
        _gpuUsageLabel = gpuUsage;
        _gpuDriverDateLabel = gpuDriverDate;
        _gpuVoltageLabel = voltage;
    }

    public void UpdateGpuData()
    {
        try
        {
            string gpuModel = ExecuteNvidiaSmiCommand("name");
            string[] gpuMemory = ExecuteNvidiaSmiCommand("memory.total,memory.free,memory.used").Split(',');
            string gpuTemperature = ExecuteNvidiaSmiCommand("temperature.gpu");
            string currentClockSpeed = ExecuteNvidiaSmiCommand("clocks.current.graphics");
            string maxClockSpeed = ExecuteNvidiaSmiCommand("clocks.max.graphics");
            string gpuPower = ExecuteNvidiaSmiCommand("power.draw");
            string gpuDriverDate = GetGpuDriverDate();
            string gpuUsage = ExecuteNvidiaSmiCommand("utilization.gpu");

            SetLabelText(_gpuModelLabel, gpuModel);
            SetLabelText(_gpuMemoryLabel, FormatMemory(gpuMemory));
            SetLabelText(_gpuTemperatureLabel, $"{gpuTemperature}°C");
            SetLabelText(_gpuClockSpeedLabel, FormatClockSpeed(currentClockSpeed, maxClockSpeed));
            SetLabelText(_gpuPowerLabel, FormatPower(gpuPower));
            SetLabelText(_gpuUsageLabel, gpuUsage);
            SetLabelText(_gpuDriverDateLabel, gpuDriverDate);
            UpdateGPUVoltage();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating GPU data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private string ExecuteNvidiaSmiCommand(string query)
    {
        return ExecuteNvidiaSmiQuery($"--query-gpu={query} --format=csv,noheader");
    }

    private string ExecuteNvidiaSmiQuery(string arguments)
    {
        try
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "nvidia-smi";
                process.StartInfo.Arguments = arguments;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd().Trim();
                process.WaitForExit();
                return string.IsNullOrEmpty(output) ? "N/A" : output;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error executing nvidia-smi command: {ex.Message}");
            return "N/A";
        }
    }

    public void UpdateGPUVoltage()
    {
        try
        {
            string voltageOutput = ExecuteNvidiaSmiQuery("-q -d VOLTAGE");
            Debug.WriteLine($"Voltage Output: {voltageOutput}");

            if (string.IsNullOrEmpty(voltageOutput))
            {
                SetLabelText(_gpuVoltageLabel, "N/A");
                return;
            }

            var lines = voltageOutput.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string voltageLine = lines.FirstOrDefault(line => line.Trim().StartsWith("Graphics", StringComparison.OrdinalIgnoreCase));

            if (voltageLine != null)
            {
                string voltageValueString = voltageLine.Split(':').Last().Trim();
                Debug.WriteLine($"Voltage Line: {voltageValueString}");

                if (decimal.TryParse(voltageValueString.Replace("mV", "").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal voltageValue))
                {
                    SetLabelText(_gpuVoltageLabel, $"{Math.Round(voltageValue / 1000.0m, 3)} V");
                }
                else
                {
                    SetLabelText(_gpuVoltageLabel, "Error parsing voltage.");
                }
            }
            else
            {
                SetLabelText(_gpuVoltageLabel, "Voltage line not found.");
            }
        }
        catch (Exception ex)
        {
            SetLabelText(_gpuVoltageLabel, $"Error: {ex.Message}");
            Debug.WriteLine($"Exception: {ex.Message}");
        }
    }
    //Powershell
    private string GetGpuDriverDate()
    {
        try
        {
            string powerShellCommand = "Get-WmiObject -Class Win32_VideoController | Select-Object -ExpandProperty DriverDate";
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"{powerShellCommand}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd().Trim();
            process.WaitForExit();

            Debug.WriteLine($"Raw Driver Date Output: {output}");

            if (!string.IsNullOrEmpty(output))
            {
                string cleanedOutput = output.Split('.')[0];
                const string format = "yyyyMMddHHmmss";
                if (DateTime.TryParseExact(cleanedOutput, format, null, System.Globalization.DateTimeStyles.None, out DateTime driverDate))
                {
                    return driverDate.ToString("MM/dd/yyyy");
                }
                return "Invalid Date Format";
            }
            return "N/A";
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error retrieving GPU driver date: {ex.Message}");
            return $"Error: {ex.Message}";
        }
    }

    private string FormatMemory(string[] gpuMemory)
    {
        if (gpuMemory.Length >= 3 &&
            decimal.TryParse(gpuMemory[0].Replace(" MiB", "").Trim(), out decimal totalMemory) &&
            decimal.TryParse(gpuMemory[2].Replace(" MiB", "").Trim(), out decimal usedMemory))
        {
            return $"{Math.Round(usedMemory, 0)} MB / {Math.Round(totalMemory, 0)} MB";
        }
        return "Error parsing memory values.";
    }

    private string FormatClockSpeed(string currentClockSpeed, string maxClockSpeed)
    {
        if (decimal.TryParse(currentClockSpeed.Replace(" MHz", "").Trim(), out decimal currentClock) &&
            decimal.TryParse(maxClockSpeed.Replace(" MHz", "").Trim(), out decimal maxClock))
        {
            return $"{Math.Round(currentClock, 0)} MHz / {Math.Round(maxClock, 0)} MHz";
        }
        return "Error parsing clock speeds.";
    }

    private string FormatPower(string gpuPower)
    {
        if (decimal.TryParse(gpuPower.Replace(" W", "").Trim(), out decimal power))
        {
            return $"{Math.Round(power, 0)} W";
        }
        return "Error parsing power value.";
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
