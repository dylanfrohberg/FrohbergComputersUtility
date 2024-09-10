namespace FrohbergComputers
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using LibreHardwareMonitor.Hardware;

    public partial class frohbergcomputersForm : Form
    {
        private Timer timer;
        private GPUMonitor gpuMonitor;
        private CPUMonitor cpuMonitor;

        // Declare missing variables
        private Computer computer;
        private PerformanceCounter cpuUsageCounter;

        public frohbergcomputersForm()
        {
            InitializeComponent();
            InitializeHardware();
            InitializePerformanceCounters();

            // Initialize GPUMonitor and CPUMonitor with form and labels
            gpuMonitor = new GPUMonitor(this, GPUMODEL, GPUMEMORY, GPUTEMPERATURE, GPUCLOCKSPEED, GPUPOWER, GPUUSAGE, GPUDRIVERDATE, GPUVOLTAGE);
            cpuMonitor = new CPUMonitor(this, CPUModel, CORECOUNT, BASECLOCK, CPUTEMP, CPUUSAGE, WATTAGE, PROCESSCOUNT, CPUVOLTAGE); // Ensure these labels are correctly assigned

            CPUUSAGE.Text = "Loading...";
            GPUUSAGE.Text = "Loading...";

            timer = new Timer
            {
                Interval = 1000 // Updates every 1 second (1000 milliseconds)
            };
            timer.Tick += Timer_Tick; // Subscribe to the Tick event
            timer.Start(); // Start the timer
        }

        private void InitializeHardware()
        {
            computer = new Computer
            {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMotherboardEnabled = true
            };
            computer.Open();
        }

        private async void InitializePerformanceCounters()
        {
            try
            {
                cpuUsageCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                await Task.Delay(1000); // 1 second delay
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error initializing performance counters: {ex.Message}");
            }
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            // Run the update methods asynchronously to keep UI responsive
            await cpuMonitor.UpdateCpuDataAsync();
            gpuMonitor.UpdateGpuData();

            // Ensure the GPU voltage is updated every tick
            gpuMonitor.UpdateGPUVoltage();
        }
        //Load all methods 
        private void Form1_Load(object sender, EventArgs e)
        {
            cpuMonitor.GetCPUModel();
            cpuMonitor.UpdateProcessCount();
            cpuMonitor.GetBaseClock();
            cpuMonitor.UpdateCPUTemperature();
            cpuMonitor.UpdateCPUUsage();
            cpuMonitor.UpdateWattage();
            cpuMonitor.GetCoreCount();
            cpuMonitor.UpdateCPUVoltage();
        }
    }
}
