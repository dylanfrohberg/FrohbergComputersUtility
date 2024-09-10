namespace FrohbergComputers
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using LibreHardwareMonitor.Hardware;

    public class CPUMonitor
    {
        private readonly Form _form;
        private readonly Label _cpuModelLabel;
        private readonly Label _coreCountLabel;
        private readonly Label _baseClockLabel;
        private readonly Label _cpuTemperatureLabel;
        private readonly Label _cpuUsageLabel;
        private readonly Label _wattageLabel;
        private readonly Label _processCountLabel;
        private readonly Label _cpuVoltageLabel;
        private readonly LibreHardwareMonitor.Hardware.Computer _computer;
        private readonly PerformanceCounter _cpuUsageCounter;

        public CPUMonitor(Form form, Label cpuModel, Label coreCount, Label baseClock, Label cpuTemperature, Label cpuUsage, Label wattage, Label processCount, Label cpuVoltage)
        {
            _form = form;
            _cpuModelLabel = cpuModel;
            _coreCountLabel = coreCount;
            _baseClockLabel = baseClock;
            _cpuTemperatureLabel = cpuTemperature;
            _cpuUsageLabel = cpuUsage;
            _wattageLabel = wattage;
            _processCountLabel = processCount;
            _cpuVoltageLabel = cpuVoltage;

            _computer = new LibreHardwareMonitor.Hardware.Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMotherboardEnabled = true
            };
            _computer.Open();

            _cpuUsageCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        }

        public async Task UpdateCpuDataAsync()
        {
            try
            {
                await Task.Run(() =>
                {
                    UpdateCPUTemperature();
                    UpdateCPUUsage();
                    UpdateProcessCount();
                    UpdateWattage();
                    UpdateCPUVoltage();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating CPU data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateCPUVoltage()
        {
            try
            {
                var cpu = _computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.Cpu);
                if (cpu == null) return;

                cpu.Update();

                var voltageSensors = cpu.Sensors
                    .Where(s => s.SensorType == SensorType.Voltage)
                    .ToList();

                if (!voltageSensors.Any())
                {
                    SetLabelText(_cpuVoltageLabel, "Voltage sensors not available.");
                    return;
                }

                var firstVoltageSensor = voltageSensors.FirstOrDefault();
                if (firstVoltageSensor == null)
                {
                    SetLabelText(_cpuVoltageLabel, "No voltage sensor found.");
                    return;
                }

                var voltage = firstVoltageSensor.Value.GetValueOrDefault();
                SetLabelText(_cpuVoltageLabel, $"{Math.Round(voltage, 2)} V");
            }
            catch (Exception ex)
            {
                SetLabelText(_cpuVoltageLabel, $"Error: {ex.Message}");
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void UpdateCPUTemperature()
        {
            try
            {
                var cpu = _computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.Cpu);
                if (cpu == null) return;

                cpu.Update();

                var temperatureSensors = cpu.Sensors
                    .Where(s => s.SensorType == SensorType.Temperature)
                    .ToList();

                if (!temperatureSensors.Any())
                {
                    SetLabelText(_cpuTemperatureLabel, "Temperature sensors not available.");
                    return;
                }

                var firstTemperatureSensor = temperatureSensors.FirstOrDefault();
                if (firstTemperatureSensor == null)
                {
                    SetLabelText(_cpuTemperatureLabel, "No temperature sensor found.");
                    return;
                }

                var temperature = firstTemperatureSensor.Value.GetValueOrDefault();
                SetLabelText(_cpuTemperatureLabel, $"{temperature}°C");
            }
            catch (Exception ex)
            {
                SetLabelText(_cpuTemperatureLabel, $"Error: {ex.Message}");
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void UpdateCPUUsage()
        {
            try
            {
                if (_cpuUsageCounter == null)
                {
                    SetLabelText(_cpuUsageLabel, "CPU Usage counter not initialized.");
                    return;
                }

                float cpuUsage = _cpuUsageCounter.NextValue();
                Task.Delay(500).Wait(); // Short delay for more stable reading
                cpuUsage = _cpuUsageCounter.NextValue();
                SetLabelText(_cpuUsageLabel, $"{cpuUsage:F1}%");
            }
            catch (Exception ex)
            {
                SetLabelText(_cpuUsageLabel, $"Error: {ex.Message}");
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void UpdateProcessCount()
        {
            try
            {
                int processCount = Process.GetProcesses().Length;
                SetLabelText(_processCountLabel, $"{processCount}");
            }
            catch (Exception ex)
            {
                SetLabelText(_processCountLabel, $"Error: {ex.Message}");
            }
        }

        public void UpdateWattage()
        {
            try
            {
                var cpu = _computer.Hardware.FirstOrDefault(h => h.HardwareType == HardwareType.Cpu);
                if (cpu == null) return;

                cpu.Update();

                var wattageSensors = cpu.Sensors
                    .Where(s => s.SensorType == SensorType.Power)
                    .ToList();

                if (!wattageSensors.Any())
                {
                    SetLabelText(_wattageLabel, "Wattage sensors not available.");
                    return;
                }

                var firstWattageSensor = wattageSensors.FirstOrDefault();
                if (firstWattageSensor == null)
                {
                    SetLabelText(_wattageLabel, "No wattage sensor found.");
                    return;
                }

                var wattage = firstWattageSensor.Value.GetValueOrDefault();
                SetLabelText(_wattageLabel, $"{Math.Round(wattage, 0)} W");
            }
            catch (Exception ex)
            {
                SetLabelText(_wattageLabel, $"Error: {ex.Message}");
                Debug.WriteLine($"Exception: {ex.Message}");
            }
        }

        private void SetLabelText(Label label, string text)
        {
            if (label == null)
            {
                Debug.WriteLine("Label is null. Cannot update text.");
                return;
            }

            if (label.InvokeRequired)
            {
                label.Invoke(new Action(() => label.Text = text));
            }
            else
            {
                label.Text = text;
            }
        }

        public void GetCPUModel()
        {
            try
            {
                string powerShellCommand = "Get-WmiObject -Class Win32_Processor | Select-Object -ExpandProperty Name";
                string output = ExecutePowerShellCommand(powerShellCommand);

                if (!string.IsNullOrEmpty(output))
                {
                    int startIndex = output.IndexOf("i") >= 0 ? output.IndexOf("i") : 0;
                    string modelPart = output.Substring(startIndex).Trim();
                    int atIndex = modelPart.IndexOf("CPU");
                    if (atIndex >= 0)
                    {
                        modelPart = modelPart.Substring(0, atIndex).Trim();
                    }
                    SetLabelText(_cpuModelLabel, modelPart);
                }
                else
                {
                    SetLabelText(_cpuModelLabel, "N/A");
                }
            }
            catch (Exception ex)
            {
                SetLabelText(_cpuModelLabel, $"Error: {ex.Message}");
            }
        }

        public void GetCoreCount()
        {
            try
            {
                string powerShellCommand = "Get-WmiObject -Class Win32_Processor | Select-Object -ExpandProperty NumberOfCores";
                string output = ExecutePowerShellCommand(powerShellCommand);

                if (!string.IsNullOrEmpty(output))
                {
                    if (int.TryParse(output, out int coreCount))
                    {
                        SetLabelText(_coreCountLabel, $"{coreCount} Cores");
                    }
                    else
                    {
                        SetLabelText(_coreCountLabel, "Unable to parse core count.");
                    }
                }
                else
                {
                    SetLabelText(_coreCountLabel, "Core count information not available.");
                }
            }
            catch (Exception ex)
            {
                SetLabelText(_coreCountLabel, $"Error: {ex.Message}");
            }
        }

        public void GetBaseClock()
        {
            try
            {
                string powerShellCommand = "Get-WmiObject -Class Win32_Processor | Select-Object -ExpandProperty MaxClockSpeed";
                string output = ExecutePowerShellCommand(powerShellCommand);

                if (!string.IsNullOrEmpty(output))
                {
                    string numericPart = new string(output.Where(c => char.IsDigit(c)).ToArray());
                    if (decimal.TryParse(numericPart, out decimal clockSpeed))
                    {
                        decimal clockSpeedInGHz = clockSpeed / 1000;
                        SetLabelText(_baseClockLabel, $"{Math.Round(clockSpeedInGHz, 2)} GHz");
                    }
                    else
                    {
                        SetLabelText(_baseClockLabel, "Unable to parse clock speed.");
                    }
                }
                else
                {
                    SetLabelText(_baseClockLabel, "Base clock information not available.");
                }
            }
            catch (Exception ex)
            {
                SetLabelText(_baseClockLabel, $"Error: {ex.Message}");
            }
        }
        //Powershell
        private string ExecutePowerShellCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-Command \"{command}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            using (StreamReader reader = process.StandardOutput)
            {
                return reader.ReadToEnd().Trim();
            }
        }
    }
}
