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
            networkGroupBox = new GroupBox();
            DHCP = new Label();
            lblDHCP = new Label();
            DNS = new Label();
            label2 = new Label();
            DEFAULTGATEWAY = new Label();
            lblDefaultGateway = new Label();
            IPADDRESS = new Label();
            lblIPAddress = new Label();
            SUBNETMASK = new Label();
            lblSubnetMask = new Label();
            MACADDRESS = new Label();
            lblMACAddress = new Label();
            NETWORKADAPTER = new Label();
            lblNetworkAdapter = new Label();
            MotherboardGroupBox = new GroupBox();
            SECUREBOOT = new Label();
            lblSecureBoot = new Label();
            BIOS = new Label();
            lblBIOS = new Label();
            MOTHERBOARD = new Label();
            lblMotherboard = new Label();
            VERSION = new Label();
            lblVersion = new Label();
            MOTHERBOARDMANUFACTURER = new Label();
            lblMotherboardManufacturer = new Label();
            SYSTEMMANUFACTURER = new Label();
            lblSystemManufacturer = new Label();
            groupBox1 = new GroupBox();
            MEMORYVOLTAGE = new Label();
            lblMemoryVoltage = new Label();
            XMPENABLED = new Label();
            lblXMPEnabled = new Label();
            MEMORYGENERATION = new Label();
            lblMemoryGeneration = new Label();
            MEMORYUSAGE = new Label();
            lblMemoryUsage = new Label();
            DIMMLOCATION = new Label();
            lblMemoryTemperature = new Label();
            MEMORYFREQUENCY = new Label();
            lblMemoryFrequency = new Label();
            MEMORYCAPACITY = new Label();
            lblCapacity = new Label();
            MEMORYMODEL = new Label();
            lblMemoryModel = new Label();
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
            SENT = new Label();
            label3 = new Label();
            RECEIVED = new Label();
            label5 = new Label();
            systemInfo.SuspendLayout();
            tpSystemInfo.SuspendLayout();
            networkGroupBox.SuspendLayout();
            MotherboardGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
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
            tpSystemInfo.Controls.Add(networkGroupBox);
            tpSystemInfo.Controls.Add(MotherboardGroupBox);
            tpSystemInfo.Controls.Add(groupBox1);
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
            // networkGroupBox
            // 
            networkGroupBox.BackColor = Color.LightCoral;
            networkGroupBox.BackgroundImageLayout = ImageLayout.None;
            networkGroupBox.Controls.Add(RECEIVED);
            networkGroupBox.Controls.Add(label5);
            networkGroupBox.Controls.Add(SENT);
            networkGroupBox.Controls.Add(label3);
            networkGroupBox.Controls.Add(DHCP);
            networkGroupBox.Controls.Add(lblDHCP);
            networkGroupBox.Controls.Add(DNS);
            networkGroupBox.Controls.Add(label2);
            networkGroupBox.Controls.Add(DEFAULTGATEWAY);
            networkGroupBox.Controls.Add(lblDefaultGateway);
            networkGroupBox.Controls.Add(IPADDRESS);
            networkGroupBox.Controls.Add(lblIPAddress);
            networkGroupBox.Controls.Add(SUBNETMASK);
            networkGroupBox.Controls.Add(lblSubnetMask);
            networkGroupBox.Controls.Add(MACADDRESS);
            networkGroupBox.Controls.Add(lblMACAddress);
            networkGroupBox.Controls.Add(NETWORKADAPTER);
            networkGroupBox.Controls.Add(lblNetworkAdapter);
            networkGroupBox.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            networkGroupBox.Location = new Point(586, 305);
            networkGroupBox.Name = "networkGroupBox";
            networkGroupBox.RightToLeft = RightToLeft.No;
            networkGroupBox.Size = new Size(363, 308);
            networkGroupBox.TabIndex = 18;
            networkGroupBox.TabStop = false;
            networkGroupBox.Text = "                         Network Information";
            // 
            // DHCP
            // 
            DHCP.AutoSize = true;
            DHCP.Location = new Point(63, 207);
            DHCP.Name = "DHCP";
            DHCP.Size = new Size(0, 17);
            DHCP.TabIndex = 17;
            // 
            // lblDHCP
            // 
            lblDHCP.AutoSize = true;
            lblDHCP.Location = new Point(6, 207);
            lblDHCP.Name = "lblDHCP";
            lblDHCP.Size = new Size(49, 17);
            lblDHCP.TabIndex = 16;
            lblDHCP.Text = "DHCP:";
            // 
            // DNS
            // 
            DNS.AutoSize = true;
            DNS.Location = new Point(103, 180);
            DNS.Name = "DNS";
            DNS.Size = new Size(0, 17);
            DNS.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 180);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 12;
            label2.Text = "DNS Server(s):";
            // 
            // DEFAULTGATEWAY
            // 
            DEFAULTGATEWAY.AutoSize = true;
            DEFAULTGATEWAY.Location = new Point(126, 152);
            DEFAULTGATEWAY.Name = "DEFAULTGATEWAY";
            DEFAULTGATEWAY.Size = new Size(0, 17);
            DEFAULTGATEWAY.TabIndex = 9;
            // 
            // lblDefaultGateway
            // 
            lblDefaultGateway.AutoSize = true;
            lblDefaultGateway.Location = new Point(6, 152);
            lblDefaultGateway.Name = "lblDefaultGateway";
            lblDefaultGateway.Size = new Size(118, 17);
            lblDefaultGateway.TabIndex = 8;
            lblDefaultGateway.Text = "Default Gateway:";
            // 
            // IPADDRESS
            // 
            IPADDRESS.AutoSize = true;
            IPADDRESS.Location = new Point(87, 90);
            IPADDRESS.Name = "IPADDRESS";
            IPADDRESS.Size = new Size(0, 17);
            IPADDRESS.TabIndex = 7;
            // 
            // lblIPAddress
            // 
            lblIPAddress.AutoSize = true;
            lblIPAddress.Location = new Point(6, 90);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(81, 17);
            lblIPAddress.TabIndex = 6;
            lblIPAddress.Text = "IP Address:";
            // 
            // SUBNETMASK
            // 
            SUBNETMASK.AutoSize = true;
            SUBNETMASK.Location = new Point(103, 121);
            SUBNETMASK.Name = "SUBNETMASK";
            SUBNETMASK.Size = new Size(0, 17);
            SUBNETMASK.TabIndex = 5;
            // 
            // lblSubnetMask
            // 
            lblSubnetMask.AutoSize = true;
            lblSubnetMask.Location = new Point(6, 121);
            lblSubnetMask.Name = "lblSubnetMask";
            lblSubnetMask.Size = new Size(95, 17);
            lblSubnetMask.TabIndex = 4;
            lblSubnetMask.Text = "Subnet Mask:";
            // 
            // MACADDRESS
            // 
            MACADDRESS.AutoSize = true;
            MACADDRESS.Location = new Point(103, 60);
            MACADDRESS.Name = "MACADDRESS";
            MACADDRESS.Size = new Size(0, 17);
            MACADDRESS.TabIndex = 3;
            // 
            // lblMACAddress
            // 
            lblMACAddress.AutoSize = true;
            lblMACAddress.Location = new Point(6, 60);
            lblMACAddress.Name = "lblMACAddress";
            lblMACAddress.Size = new Size(97, 17);
            lblMACAddress.TabIndex = 2;
            lblMACAddress.Text = "MAC Address:";
            // 
            // NETWORKADAPTER
            // 
            NETWORKADAPTER.AutoSize = true;
            NETWORKADAPTER.Location = new Point(126, 29);
            NETWORKADAPTER.Name = "NETWORKADAPTER";
            NETWORKADAPTER.Size = new Size(0, 17);
            NETWORKADAPTER.TabIndex = 1;
            // 
            // lblNetworkAdapter
            // 
            lblNetworkAdapter.AutoSize = true;
            lblNetworkAdapter.Location = new Point(6, 29);
            lblNetworkAdapter.Name = "lblNetworkAdapter";
            lblNetworkAdapter.Size = new Size(120, 17);
            lblNetworkAdapter.TabIndex = 0;
            lblNetworkAdapter.Text = "Network Adapter:";
            // 
            // MotherboardGroupBox
            // 
            MotherboardGroupBox.BackColor = Color.LightCoral;
            MotherboardGroupBox.BackgroundImageLayout = ImageLayout.None;
            MotherboardGroupBox.Controls.Add(SECUREBOOT);
            MotherboardGroupBox.Controls.Add(lblSecureBoot);
            MotherboardGroupBox.Controls.Add(BIOS);
            MotherboardGroupBox.Controls.Add(lblBIOS);
            MotherboardGroupBox.Controls.Add(MOTHERBOARD);
            MotherboardGroupBox.Controls.Add(lblMotherboard);
            MotherboardGroupBox.Controls.Add(VERSION);
            MotherboardGroupBox.Controls.Add(lblVersion);
            MotherboardGroupBox.Controls.Add(MOTHERBOARDMANUFACTURER);
            MotherboardGroupBox.Controls.Add(lblMotherboardManufacturer);
            MotherboardGroupBox.Controls.Add(SYSTEMMANUFACTURER);
            MotherboardGroupBox.Controls.Add(lblSystemManufacturer);
            MotherboardGroupBox.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MotherboardGroupBox.Location = new Point(46, 305);
            MotherboardGroupBox.Name = "MotherboardGroupBox";
            MotherboardGroupBox.RightToLeft = RightToLeft.No;
            MotherboardGroupBox.Size = new Size(479, 213);
            MotherboardGroupBox.TabIndex = 17;
            MotherboardGroupBox.TabStop = false;
            MotherboardGroupBox.Text = "                                      Motherboard Information";
            // 
            // SECUREBOOT
            // 
            SECUREBOOT.AutoSize = true;
            SECUREBOOT.Location = new Point(96, 180);
            SECUREBOOT.Name = "SECUREBOOT";
            SECUREBOOT.Size = new Size(0, 17);
            SECUREBOOT.TabIndex = 13;
            // 
            // lblSecureBoot
            // 
            lblSecureBoot.AutoSize = true;
            lblSecureBoot.Location = new Point(6, 180);
            lblSecureBoot.Name = "lblSecureBoot";
            lblSecureBoot.Size = new Size(90, 17);
            lblSecureBoot.TabIndex = 12;
            lblSecureBoot.Text = "Secure Boot:";
            // 
            // BIOS
            // 
            BIOS.AutoSize = true;
            BIOS.Location = new Point(52, 152);
            BIOS.Name = "BIOS";
            BIOS.Size = new Size(0, 17);
            BIOS.TabIndex = 9;
            // 
            // lblBIOS
            // 
            lblBIOS.AutoSize = true;
            lblBIOS.Location = new Point(6, 152);
            lblBIOS.Name = "lblBIOS";
            lblBIOS.Size = new Size(42, 17);
            lblBIOS.TabIndex = 8;
            lblBIOS.Text = "BIOS:";
            // 
            // MOTHERBOARD
            // 
            MOTHERBOARD.AutoSize = true;
            MOTHERBOARD.Location = new Point(100, 90);
            MOTHERBOARD.Name = "MOTHERBOARD";
            MOTHERBOARD.Size = new Size(0, 17);
            MOTHERBOARD.TabIndex = 7;
            // 
            // lblMotherboard
            // 
            lblMotherboard.AutoSize = true;
            lblMotherboard.Location = new Point(6, 90);
            lblMotherboard.Name = "lblMotherboard";
            lblMotherboard.Size = new Size(94, 17);
            lblMotherboard.TabIndex = 6;
            lblMotherboard.Text = "Motherboard:";
            // 
            // VERSION
            // 
            VERSION.AutoSize = true;
            VERSION.Location = new Point(67, 121);
            VERSION.Name = "VERSION";
            VERSION.Size = new Size(0, 17);
            VERSION.TabIndex = 5;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(6, 121);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(60, 17);
            lblVersion.TabIndex = 4;
            lblVersion.Text = "Version:";
            // 
            // MOTHERBOARDMANUFACTURER
            // 
            MOTHERBOARDMANUFACTURER.AutoSize = true;
            MOTHERBOARDMANUFACTURER.Location = new Point(187, 60);
            MOTHERBOARDMANUFACTURER.Name = "MOTHERBOARDMANUFACTURER";
            MOTHERBOARDMANUFACTURER.Size = new Size(0, 17);
            MOTHERBOARDMANUFACTURER.TabIndex = 3;
            // 
            // lblMotherboardManufacturer
            // 
            lblMotherboardManufacturer.AutoSize = true;
            lblMotherboardManufacturer.Location = new Point(6, 60);
            lblMotherboardManufacturer.Name = "lblMotherboardManufacturer";
            lblMotherboardManufacturer.Size = new Size(184, 17);
            lblMotherboardManufacturer.TabIndex = 2;
            lblMotherboardManufacturer.Text = "Motherboard Manufacturer:";
            // 
            // SYSTEMMANUFACTURER
            // 
            SYSTEMMANUFACTURER.AutoSize = true;
            SYSTEMMANUFACTURER.Location = new Point(154, 29);
            SYSTEMMANUFACTURER.Name = "SYSTEMMANUFACTURER";
            SYSTEMMANUFACTURER.Size = new Size(0, 17);
            SYSTEMMANUFACTURER.TabIndex = 1;
            // 
            // lblSystemManufacturer
            // 
            lblSystemManufacturer.AutoSize = true;
            lblSystemManufacturer.Location = new Point(6, 29);
            lblSystemManufacturer.Name = "lblSystemManufacturer";
            lblSystemManufacturer.Size = new Size(148, 17);
            lblSystemManufacturer.TabIndex = 0;
            lblSystemManufacturer.Text = "System Manufacturer:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCoral;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(MEMORYVOLTAGE);
            groupBox1.Controls.Add(lblMemoryVoltage);
            groupBox1.Controls.Add(XMPENABLED);
            groupBox1.Controls.Add(lblXMPEnabled);
            groupBox1.Controls.Add(MEMORYGENERATION);
            groupBox1.Controls.Add(lblMemoryGeneration);
            groupBox1.Controls.Add(MEMORYUSAGE);
            groupBox1.Controls.Add(lblMemoryUsage);
            groupBox1.Controls.Add(DIMMLOCATION);
            groupBox1.Controls.Add(lblMemoryTemperature);
            groupBox1.Controls.Add(MEMORYFREQUENCY);
            groupBox1.Controls.Add(lblMemoryFrequency);
            groupBox1.Controls.Add(MEMORYCAPACITY);
            groupBox1.Controls.Add(lblCapacity);
            groupBox1.Controls.Add(MEMORYMODEL);
            groupBox1.Controls.Add(lblMemoryModel);
            groupBox1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(712, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(479, 269);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "                                        Memory Information";
            // 
            // MEMORYVOLTAGE
            // 
            MEMORYVOLTAGE.AutoSize = true;
            MEMORYVOLTAGE.Location = new Point(63, 241);
            MEMORYVOLTAGE.Name = "MEMORYVOLTAGE";
            MEMORYVOLTAGE.Size = new Size(0, 17);
            MEMORYVOLTAGE.TabIndex = 15;
            // 
            // lblMemoryVoltage
            // 
            lblMemoryVoltage.AutoSize = true;
            lblMemoryVoltage.Location = new Point(6, 241);
            lblMemoryVoltage.Name = "lblMemoryVoltage";
            lblMemoryVoltage.Size = new Size(61, 17);
            lblMemoryVoltage.TabIndex = 14;
            lblMemoryVoltage.Text = "Voltage:";
            // 
            // XMPENABLED
            // 
            XMPENABLED.AutoSize = true;
            XMPENABLED.Location = new Point(52, 212);
            XMPENABLED.Name = "XMPENABLED";
            XMPENABLED.Size = new Size(0, 17);
            XMPENABLED.TabIndex = 13;
            // 
            // lblXMPEnabled
            // 
            lblXMPEnabled.AutoSize = true;
            lblXMPEnabled.Location = new Point(6, 212);
            lblXMPEnabled.Name = "lblXMPEnabled";
            lblXMPEnabled.Size = new Size(40, 17);
            lblXMPEnabled.TabIndex = 12;
            lblXMPEnabled.Text = "XMP:";
            // 
            // MEMORYGENERATION
            // 
            MEMORYGENERATION.AutoSize = true;
            MEMORYGENERATION.Location = new Point(95, 183);
            MEMORYGENERATION.Name = "MEMORYGENERATION";
            MEMORYGENERATION.Size = new Size(0, 17);
            MEMORYGENERATION.TabIndex = 11;
            // 
            // lblMemoryGeneration
            // 
            lblMemoryGeneration.AutoSize = true;
            lblMemoryGeneration.Location = new Point(6, 183);
            lblMemoryGeneration.Name = "lblMemoryGeneration";
            lblMemoryGeneration.Size = new Size(83, 17);
            lblMemoryGeneration.TabIndex = 10;
            lblMemoryGeneration.Text = "Generation:";
            // 
            // MEMORYUSAGE
            // 
            MEMORYUSAGE.AutoSize = true;
            MEMORYUSAGE.Location = new Point(58, 152);
            MEMORYUSAGE.Name = "MEMORYUSAGE";
            MEMORYUSAGE.Size = new Size(0, 17);
            MEMORYUSAGE.TabIndex = 9;
            // 
            // lblMemoryUsage
            // 
            lblMemoryUsage.AutoSize = true;
            lblMemoryUsage.Location = new Point(7, 152);
            lblMemoryUsage.Name = "lblMemoryUsage";
            lblMemoryUsage.Size = new Size(52, 17);
            lblMemoryUsage.TabIndex = 8;
            lblMemoryUsage.Text = "Usage:";
            // 
            // DIMMLOCATION
            // 
            DIMMLOCATION.AutoSize = true;
            DIMMLOCATION.Location = new Point(115, 90);
            DIMMLOCATION.Name = "DIMMLOCATION";
            DIMMLOCATION.Size = new Size(0, 17);
            DIMMLOCATION.TabIndex = 7;
            // 
            // lblMemoryTemperature
            // 
            lblMemoryTemperature.AutoSize = true;
            lblMemoryTemperature.Location = new Point(7, 90);
            lblMemoryTemperature.Name = "lblMemoryTemperature";
            lblMemoryTemperature.Size = new Size(107, 17);
            lblMemoryTemperature.TabIndex = 6;
            lblMemoryTemperature.Text = "DIMM Location:";
            // 
            // MEMORYFREQUENCY
            // 
            MEMORYFREQUENCY.AutoSize = true;
            MEMORYFREQUENCY.Location = new Point(85, 121);
            MEMORYFREQUENCY.Name = "MEMORYFREQUENCY";
            MEMORYFREQUENCY.Size = new Size(0, 17);
            MEMORYFREQUENCY.TabIndex = 5;
            // 
            // lblMemoryFrequency
            // 
            lblMemoryFrequency.AutoSize = true;
            lblMemoryFrequency.Location = new Point(6, 121);
            lblMemoryFrequency.Name = "lblMemoryFrequency";
            lblMemoryFrequency.Size = new Size(78, 17);
            lblMemoryFrequency.TabIndex = 4;
            lblMemoryFrequency.Text = "Frequency:";
            // 
            // MEMORYCAPACITY
            // 
            MEMORYCAPACITY.AutoSize = true;
            MEMORYCAPACITY.Location = new Point(67, 59);
            MEMORYCAPACITY.Name = "MEMORYCAPACITY";
            MEMORYCAPACITY.Size = new Size(0, 17);
            MEMORYCAPACITY.TabIndex = 3;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(6, 59);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(67, 17);
            lblCapacity.TabIndex = 2;
            lblCapacity.Text = "Capacity:";
            // 
            // MEMORYMODEL
            // 
            MEMORYMODEL.AutoSize = true;
            MEMORYMODEL.Location = new Point(64, 28);
            MEMORYMODEL.Name = "MEMORYMODEL";
            MEMORYMODEL.Size = new Size(0, 17);
            MEMORYMODEL.TabIndex = 1;
            // 
            // lblMemoryModel
            // 
            lblMemoryModel.AutoSize = true;
            lblMemoryModel.Location = new Point(7, 28);
            lblMemoryModel.Name = "lblMemoryModel";
            lblMemoryModel.Size = new Size(51, 17);
            lblMemoryModel.TabIndex = 0;
            lblMemoryModel.Text = "Model:";
            // 
            // gbGPUInfo
            // 
            gbGPUInfo.BackColor = Color.LightCoral;
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
            gbGPUInfo.Text = "                    GPU Information";
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
            groupCPU.BackColor = Color.LightCoral;
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
            groupCPU.Text = "             CPU Information";
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
            // SENT
            // 
            SENT.AutoSize = true;
            SENT.Location = new Point(47, 237);
            SENT.Name = "SENT";
            SENT.Size = new Size(0, 17);
            SENT.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 237);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 18;
            label3.Text = "Sent:";
            // 
            // RECEIVED
            // 
            RECEIVED.AutoSize = true;
            RECEIVED.Location = new Point(77, 270);
            RECEIVED.Name = "RECEIVED";
            RECEIVED.Size = new Size(0, 17);
            RECEIVED.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 270);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 20;
            label5.Text = "Recieved:";
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
            networkGroupBox.ResumeLayout(false);
            networkGroupBox.PerformLayout();
            MotherboardGroupBox.ResumeLayout(false);
            MotherboardGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label MEMORYVOLTAGE;
        private Label lblMemoryVoltage;
        private Label XMPENABLED;
        private Label lblXMPEnabled;
        private Label MEMORYGENERATION;
        private Label lblMemoryGeneration;
        private Label MEMORYUSAGE;
        private Label lblMemoryUsage;
        private Label DIMMLOCATION;
        private Label lblMemoryTemperature;
        private Label MEMORYFREQUENCY;
        private Label lblMemoryFrequency;
        private Label MEMORYCAPACITY;
        private Label lblCapacity;
        private Label MEMORYMODEL;
        private Label lblMemoryModel;
        private GroupBox MotherboardGroupBox;
        private Label SECUREBOOT;
        private Label lblSecureBoot;
        private Label BIOS;
        private Label lblBIOS;
        private Label MOTHERBOARD;
        private Label lblMotherboard;
        private Label VERSION;
        private Label lblVersion;
        private Label MOTHERBOARDMANUFACTURER;
        private Label lblMotherboardManufacturer;
        private Label SYSTEMMANUFACTURER;
        private Label lblSystemManufacturer;
        private GroupBox networkGroupBox;
        private Label DNS;
        private Label label2;
        private Label DEFAULTGATEWAY;
        private Label lblDefaultGateway;
        private Label IPADDRESS;
        private Label lblIPAddress;
        private Label SUBNETMASK;
        private Label lblSubnetMask;
        private Label MACADDRESS;
        private Label lblMACAddress;
        private Label NETWORKADAPTER;
        private Label lblNetworkAdapter;
        private Label DHCP;
        private Label lblDHCP;
        private Label RECEIVED;
        private Label label5;
        private Label SENT;
        private Label label3;
    }
}
