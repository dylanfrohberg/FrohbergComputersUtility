namespace FrohbergComputers
{
    partial class frohbergcomputersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            systemInfo = new TabControl();
            tpSystemInfo = new TabPage();
            gbGPUInfo = new GroupBox();
            GPUVOLTAGE = new Label();
            lblGpuVoltage = new Label();
            GPUPOWER = new Label();
            lblGPUPower = new Label();
            GPUDRIVERDATE = new Label();
            lblGPUDriverDate = new Label();
            GPUUSAGE = new Label();
            lblGPUUsage = new Label();
            GPUTEMPERATURE = new Label();
            lblGPUTemp = new Label();
            GPUCLOCKSPEED = new Label();
            lblClockSpeedGPU = new Label();
            GPUMEMORY = new Label();
            lblGPUMemory = new Label();
            GPUMODEL = new Label();
            lblGPUModel = new Label();
            groupCPU = new GroupBox();
            CPUVOLTAGE = new Label();
            WATTAGE = new Label();
            lblCpuVoltage = new Label();
            lblCPUPower = new Label();
            PROCESSCOUNT = new Label();
            lblProcessCount = new Label();
            CPUUSAGE = new Label();
            lblCPUUsage = new Label();
            CPUTEMP = new Label();
            lblCPUTemperature = new Label();
            BASECLOCK = new Label();
            lblBaseClock = new Label();
            CORECOUNT = new Label();
            lblCores = new Label();
            CPUModel = new Label();
            lblCPUModel = new Label();
            tpOptimize = new TabPage();
            systemInfo.SuspendLayout();
            tpSystemInfo.SuspendLayout();
            gbGPUInfo.SuspendLayout();
            groupCPU.SuspendLayout();
            SuspendLayout();
            // 
            // systemInfo
            // 
            systemInfo.Controls.Add(tpSystemInfo);
            systemInfo.Controls.Add(tpOptimize);
            systemInfo.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            systemInfo.ItemSize = new Size(120, 20);
            systemInfo.Location = new Point(-5, -3);
            systemInfo.Name = "systemInfo";
            systemInfo.SelectedIndex = 0;
            systemInfo.Size = new Size(1481, 831);
            systemInfo.SizeMode = TabSizeMode.Fixed;
            systemInfo.TabIndex = 0;
            // 
            // tpSystemInfo
            // 
            tpSystemInfo.Controls.Add(gbGPUInfo);
            tpSystemInfo.Controls.Add(groupCPU);
            tpSystemInfo.Location = new Point(4, 24);
            tpSystemInfo.Name = "tpSystemInfo";
            tpSystemInfo.Padding = new Padding(3);
            tpSystemInfo.RightToLeft = RightToLeft.No;
            tpSystemInfo.Size = new Size(1473, 803);
            tpSystemInfo.TabIndex = 0;
            tpSystemInfo.Text = " System Information";
            tpSystemInfo.UseVisualStyleBackColor = true;
            // 
            // gbGPUInfo
            // 
            gbGPUInfo.BackColor = Color.Gainsboro;
            gbGPUInfo.BackgroundImageLayout = ImageLayout.None;
            gbGPUInfo.Controls.Add(GPUVOLTAGE);
            gbGPUInfo.Controls.Add(lblGpuVoltage);
            gbGPUInfo.Controls.Add(GPUPOWER);
            gbGPUInfo.Controls.Add(lblGPUPower);
            gbGPUInfo.Controls.Add(GPUDRIVERDATE);
            gbGPUInfo.Controls.Add(lblGPUDriverDate);
            gbGPUInfo.Controls.Add(GPUUSAGE);
            gbGPUInfo.Controls.Add(lblGPUUsage);
            gbGPUInfo.Controls.Add(GPUTEMPERATURE);
            gbGPUInfo.Controls.Add(lblGPUTemp);
            gbGPUInfo.Controls.Add(GPUCLOCKSPEED);
            gbGPUInfo.Controls.Add(lblClockSpeedGPU);
            gbGPUInfo.Controls.Add(GPUMEMORY);
            gbGPUInfo.Controls.Add(lblGPUMemory);
            gbGPUInfo.Controls.Add(GPUMODEL);
            gbGPUInfo.Controls.Add(lblGPUModel);
            gbGPUInfo.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbGPUInfo.Location = new Point(354, 20);
            gbGPUInfo.Name = "gbGPUInfo";
            gbGPUInfo.RightToLeft = RightToLeft.No;
            gbGPUInfo.Size = new Size(306, 269);
            gbGPUInfo.TabIndex = 14;
            gbGPUInfo.TabStop = false;
            gbGPUInfo.Text = "      GPU Information";
            // 
            // GPUVOLTAGE
            // 
            GPUVOLTAGE.AutoSize = true;
            GPUVOLTAGE.Location = new Point(63, 241);
            GPUVOLTAGE.Name = "GPUVOLTAGE";
            GPUVOLTAGE.Size = new Size(0, 17);
            GPUVOLTAGE.TabIndex = 15;
            // 
            // lblGpuVoltage
            // 
            lblGpuVoltage.AutoSize = true;
            lblGpuVoltage.Location = new Point(7, 241);
            lblGpuVoltage.Name = "lblGpuVoltage";
            lblGpuVoltage.Size = new Size(61, 17);
            lblGpuVoltage.TabIndex = 14;
            lblGpuVoltage.Text = "Voltage:";
            // 
            // GPUPOWER
            // 
            GPUPOWER.AutoSize = true;
            GPUPOWER.Location = new Point(147, 212);
            GPUPOWER.Name = "GPUPOWER";
            GPUPOWER.Size = new Size(0, 17);
            GPUPOWER.TabIndex = 13;
            // 
            // lblGPUPower
            // 
            lblGPUPower.AutoSize = true;
            lblGPUPower.Location = new Point(6, 212);
            lblGPUPower.Name = "lblGPUPower";
            lblGPUPower.Size = new Size(141, 17);
            lblGPUPower.TabIndex = 12;
            lblGPUPower.Text = "Power Consumption:";
            // 
            // GPUDRIVERDATE
            // 
            GPUDRIVERDATE.AutoSize = true;
            GPUDRIVERDATE.Location = new Point(95, 183);
            GPUDRIVERDATE.Name = "GPUDRIVERDATE";
            GPUDRIVERDATE.Size = new Size(0, 17);
            GPUDRIVERDATE.TabIndex = 11;
            // 
            // lblGPUDriverDate
            // 
            lblGPUDriverDate.AutoSize = true;
            lblGPUDriverDate.Location = new Point(6, 183);
            lblGPUDriverDate.Name = "lblGPUDriverDate";
            lblGPUDriverDate.Size = new Size(86, 17);
            lblGPUDriverDate.TabIndex = 10;
            lblGPUDriverDate.Text = "Driver Date:";
            // 
            // GPUUSAGE
            // 
            GPUUSAGE.AutoSize = true;
            GPUUSAGE.Location = new Point(58, 152);
            GPUUSAGE.Name = "GPUUSAGE";
            GPUUSAGE.Size = new Size(0, 17);
            GPUUSAGE.TabIndex = 9;
            // 
            // lblGPUUsage
            // 
            lblGPUUsage.AutoSize = true;
            lblGPUUsage.Location = new Point(6, 152);
            lblGPUUsage.Name = "lblGPUUsage";
            lblGPUUsage.Size = new Size(52, 17);
            lblGPUUsage.TabIndex = 8;
            lblGPUUsage.Text = "Usage:";
            // 
            // GPUTEMPERATURE
            // 
            GPUTEMPERATURE.AutoSize = true;
            GPUTEMPERATURE.Location = new Point(95, 90);
            GPUTEMPERATURE.Name = "GPUTEMPERATURE";
            GPUTEMPERATURE.Size = new Size(0, 17);
            GPUTEMPERATURE.TabIndex = 7;
            // 
            // lblGPUTemp
            // 
            lblGPUTemp.AutoSize = true;
            lblGPUTemp.Location = new Point(6, 90);
            lblGPUTemp.Name = "lblGPUTemp";
            lblGPUTemp.Size = new Size(94, 17);
            lblGPUTemp.TabIndex = 6;
            lblGPUTemp.Text = "Temperature:";
            // 
            // GPUCLOCKSPEED
            // 
            GPUCLOCKSPEED.AutoSize = true;
            GPUCLOCKSPEED.Location = new Point(100, 121);
            GPUCLOCKSPEED.Name = "GPUCLOCKSPEED";
            GPUCLOCKSPEED.Size = new Size(0, 17);
            GPUCLOCKSPEED.TabIndex = 5;
            // 
            // lblClockSpeedGPU
            // 
            lblClockSpeedGPU.AutoSize = true;
            lblClockSpeedGPU.Location = new Point(6, 121);
            lblClockSpeedGPU.Name = "lblClockSpeedGPU";
            lblClockSpeedGPU.Size = new Size(92, 17);
            lblClockSpeedGPU.TabIndex = 4;
            lblClockSpeedGPU.Text = "Clock Speed:";
            // 
            // GPUMEMORY
            // 
            GPUMEMORY.AutoSize = true;
            GPUMEMORY.Location = new Point(73, 59);
            GPUMEMORY.Name = "GPUMEMORY";
            GPUMEMORY.Size = new Size(0, 17);
            GPUMEMORY.TabIndex = 3;
            // 
            // lblGPUMemory
            // 
            lblGPUMemory.AutoSize = true;
            lblGPUMemory.Location = new Point(6, 59);
            lblGPUMemory.Name = "lblGPUMemory";
            lblGPUMemory.Size = new Size(62, 17);
            lblGPUMemory.TabIndex = 2;
            lblGPUMemory.Text = "Memory:";
            // 
            // GPUMODEL
            // 
            GPUMODEL.AutoSize = true;
            GPUMODEL.Location = new Point(63, 28);
            GPUMODEL.Name = "GPUMODEL";
            GPUMODEL.Size = new Size(0, 17);
            GPUMODEL.TabIndex = 1;
            // 
            // lblGPUModel
            // 
            lblGPUModel.AutoSize = true;
            lblGPUModel.Location = new Point(6, 28);
            lblGPUModel.Name = "lblGPUModel";
            lblGPUModel.Size = new Size(51, 17);
            lblGPUModel.TabIndex = 0;
            lblGPUModel.Text = "Model:";
            // 
            // groupCPU
            // 
            groupCPU.BackColor = Color.Gainsboro;
            groupCPU.BackgroundImageLayout = ImageLayout.None;
            groupCPU.Controls.Add(CPUVOLTAGE);
            groupCPU.Controls.Add(WATTAGE);
            groupCPU.Controls.Add(lblCpuVoltage);
            groupCPU.Controls.Add(lblCPUPower);
            groupCPU.Controls.Add(PROCESSCOUNT);
            groupCPU.Controls.Add(lblProcessCount);
            groupCPU.Controls.Add(CPUUSAGE);
            groupCPU.Controls.Add(lblCPUUsage);
            groupCPU.Controls.Add(CPUTEMP);
            groupCPU.Controls.Add(lblCPUTemperature);
            groupCPU.Controls.Add(BASECLOCK);
            groupCPU.Controls.Add(lblBaseClock);
            groupCPU.Controls.Add(CORECOUNT);
            groupCPU.Controls.Add(lblCores);
            groupCPU.Controls.Add(CPUModel);
            groupCPU.Controls.Add(lblCPUModel);
            groupCPU.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupCPU.Location = new Point(46, 20);
            groupCPU.Name = "groupCPU";
            groupCPU.RightToLeft = RightToLeft.No;
            groupCPU.Size = new Size(239, 269);
            groupCPU.TabIndex = 0;
            groupCPU.TabStop = false;
            groupCPU.Text = "      CPU Information";
            // 
            // CPUVOLTAGE
            // 
            CPUVOLTAGE.AutoSize = true;
            CPUVOLTAGE.Location = new Point(69, 243);
            CPUVOLTAGE.Name = "CPUVOLTAGE";
            CPUVOLTAGE.Size = new Size(0, 17);
            CPUVOLTAGE.TabIndex = 17;
            // 
            // WATTAGE
            // 
            WATTAGE.AutoSize = true;
            WATTAGE.Location = new Point(147, 212);
            WATTAGE.Name = "WATTAGE";
            WATTAGE.Size = new Size(0, 17);
            WATTAGE.TabIndex = 13;
            // 
            // lblCpuVoltage
            // 
            lblCpuVoltage.AutoSize = true;
            lblCpuVoltage.Location = new Point(8, 243);
            lblCpuVoltage.Name = "lblCpuVoltage";
            lblCpuVoltage.Size = new Size(61, 17);
            lblCpuVoltage.TabIndex = 16;
            lblCpuVoltage.Text = "Voltage:";
            // 
            // lblCPUPower
            // 
            lblCPUPower.AutoSize = true;
            lblCPUPower.Location = new Point(6, 212);
            lblCPUPower.Name = "lblCPUPower";
            lblCPUPower.Size = new Size(141, 17);
            lblCPUPower.TabIndex = 12;
            lblCPUPower.Text = "Power Consumption:";
            // 
            // PROCESSCOUNT
            // 
            PROCESSCOUNT.AutoSize = true;
            PROCESSCOUNT.Location = new Point(90, 183);
            PROCESSCOUNT.Name = "PROCESSCOUNT";
            PROCESSCOUNT.Size = new Size(0, 17);
            PROCESSCOUNT.TabIndex = 11;
            // 
            // lblProcessCount
            // 
            lblProcessCount.AutoSize = true;
            lblProcessCount.Location = new Point(6, 183);
            lblProcessCount.Name = "lblProcessCount";
            lblProcessCount.Size = new Size(78, 17);
            lblProcessCount.TabIndex = 10;
            lblProcessCount.Text = "Processes:";
            // 
            // CPUUSAGE
            // 
            CPUUSAGE.AutoSize = true;
            CPUUSAGE.Location = new Point(61, 152);
            CPUUSAGE.Name = "CPUUSAGE";
            CPUUSAGE.Size = new Size(0, 17);
            CPUUSAGE.TabIndex = 9;
            // 
            // lblCPUUsage
            // 
            lblCPUUsage.AutoSize = true;
            lblCPUUsage.Location = new Point(6, 152);
            lblCPUUsage.Name = "lblCPUUsage";
            lblCPUUsage.Size = new Size(52, 17);
            lblCPUUsage.TabIndex = 8;
            lblCPUUsage.Text = "Usage:";
            // 
            // CPUTEMP
            // 
            CPUTEMP.AutoSize = true;
            CPUTEMP.Location = new Point(106, 121);
            CPUTEMP.Name = "CPUTEMP";
            CPUTEMP.Size = new Size(0, 17);
            CPUTEMP.TabIndex = 7;
            // 
            // lblCPUTemperature
            // 
            lblCPUTemperature.AutoSize = true;
            lblCPUTemperature.Location = new Point(6, 121);
            lblCPUTemperature.Name = "lblCPUTemperature";
            lblCPUTemperature.Size = new Size(94, 17);
            lblCPUTemperature.TabIndex = 6;
            lblCPUTemperature.Text = "Temperature:";
            // 
            // BASECLOCK
            // 
            BASECLOCK.AutoSize = true;
            BASECLOCK.Location = new Point(96, 90);
            BASECLOCK.Name = "BASECLOCK";
            BASECLOCK.Size = new Size(0, 17);
            BASECLOCK.TabIndex = 5;
            // 
            // lblBaseClock
            // 
            lblBaseClock.AutoSize = true;
            lblBaseClock.Location = new Point(6, 90);
            lblBaseClock.Name = "lblBaseClock";
            lblBaseClock.Size = new Size(84, 17);
            lblBaseClock.TabIndex = 4;
            lblBaseClock.Text = "Base Clock:";
            // 
            // CORECOUNT
            // 
            CORECOUNT.AutoSize = true;
            CORECOUNT.Location = new Point(61, 59);
            CORECOUNT.Name = "CORECOUNT";
            CORECOUNT.Size = new Size(0, 17);
            CORECOUNT.TabIndex = 3;
            // 
            // lblCores
            // 
            lblCores.AutoSize = true;
            lblCores.Location = new Point(6, 59);
            lblCores.Name = "lblCores";
            lblCores.Size = new Size(49, 17);
            lblCores.TabIndex = 2;
            lblCores.Text = "Cores:";
            // 
            // CPUModel
            // 
            CPUModel.AutoSize = true;
            CPUModel.Location = new Point(63, 28);
            CPUModel.Name = "CPUModel";
            CPUModel.Size = new Size(0, 17);
            CPUModel.TabIndex = 1;
            // 
            // lblCPUModel
            // 
            lblCPUModel.AutoSize = true;
            lblCPUModel.Location = new Point(6, 28);
            lblCPUModel.Name = "lblCPUModel";
            lblCPUModel.Size = new Size(51, 17);
            lblCPUModel.TabIndex = 0;
            lblCPUModel.Text = "Model:";
            // 
            // tpOptimize
            // 
            tpOptimize.Location = new Point(4, 24);
            tpOptimize.Name = "tpOptimize";
            tpOptimize.Padding = new Padding(3);
            tpOptimize.Size = new Size(1473, 803);
            tpOptimize.TabIndex = 1;
            tpOptimize.Text = "Optimize";
            tpOptimize.UseVisualStyleBackColor = true;
            // 
            // frohbergcomputersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 822);
            Controls.Add(systemInfo);
            Name = "frohbergcomputersForm";
            Text = "Frohberg Computers";
            Load += Form1_Load;
            systemInfo.ResumeLayout(false);
            tpSystemInfo.ResumeLayout(false);
            gbGPUInfo.ResumeLayout(false);
            gbGPUInfo.PerformLayout();
            groupCPU.ResumeLayout(false);
            groupCPU.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl systemInfo;
        private TabPage tpSystemInfo;
        private TabPage tpOptimize;
        private GroupBox groupCPU;
        private Label CPUModel;
        private Label lblCPUModel;
        private Label lblCores;
        private Label CORECOUNT;
        private Label BASECLOCK;
        private Label lblBaseClock;
        private Label CPUTEMP;
        private Label lblCPUTemperature;
        private Label lblCPUUsage;
        private Label CPUUSAGE;
        private Label lblProcessCount;
        private Label PROCESSCOUNT;
        private Label WATTAGE;
        private Label lblCPUPower;
        private GroupBox gbGPUInfo;
        private Label GPUPOWER;
        private Label lblGPUPower;
        private Label GPUDRIVERDATE;
        private Label lblGPUDriverDate;
        private Label GPUUSAGE;
        private Label lblGPUUsage;
        private Label GPUTEMPERATURE;
        private Label lblGPUTemp;
        private Label GPUCLOCKSPEED;
        private Label lblClockSpeedGPU;
        private Label GPUMEMORY;
        private Label lblGPUMemory;
        private Label GPUMODEL;
        private Label lblGPUModel;
        private Label GPUVOLTAGE;
        private Label lblGpuVoltage;
        private Label CPUVOLTAGE;
        private Label lblCpuVoltage;
    }
}
