namespace GetBios
{
    partial class Upgrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //Ahmad Abu Saloum
        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upgrade));
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblBiosVersion1 = new System.Windows.Forms.Label();
            this.lblBiosLastUpdate = new System.Windows.Forms.Label();
            this.lblBiosSerialNumber = new System.Windows.Forms.Label();
            this.lblBiosVersion = new System.Windows.Forms.Label();
            this.lblBiosSerial = new System.Windows.Forms.Label();
            this.lblBiosDate = new System.Windows.Forms.Label();
            this.lblMACAddress = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblcomputerName = new System.Windows.Forms.Label();
            this.lblUUID = new System.Windows.Forms.Label();
            this.lblValUUID = new System.Windows.Forms.Label();
            this.lblCPUID = new System.Windows.Forms.Label();
            this.lblValCPUId = new System.Windows.Forms.Label();
            this.lblPublicIPAddress = new System.Windows.Forms.Label();
            this.lblLocalIPAddress = new System.Windows.Forms.Label();
            this.lblPublicIPAddressVal = new System.Windows.Forms.Label();
            this.lblLocalIPAddressVal = new System.Windows.Forms.Label();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.lblOperatingSystemVal = new System.Windows.Forms.Label();
            this.lblCPUName = new System.Windows.Forms.Label();
            this.lblCPUNameVal = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblRAMVal = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblGPUVal = new System.Windows.Forms.Label();
            this.LinklblAA = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(114, 468);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(603, 44);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Show Device Info";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lblBiosVersion1
            // 
            this.lblBiosVersion1.AutoSize = true;
            this.lblBiosVersion1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosVersion1.Location = new System.Drawing.Point(68, 19);
            this.lblBiosVersion1.Name = "lblBiosVersion1";
            this.lblBiosVersion1.Size = new System.Drawing.Size(120, 19);
            this.lblBiosVersion1.TabIndex = 1;
            this.lblBiosVersion1.Text = "Bios Version :";
            // 
            // lblBiosLastUpdate
            // 
            this.lblBiosLastUpdate.AutoSize = true;
            this.lblBiosLastUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosLastUpdate.Location = new System.Drawing.Point(31, 93);
            this.lblBiosLastUpdate.Name = "lblBiosLastUpdate";
            this.lblBiosLastUpdate.Size = new System.Drawing.Size(157, 19);
            this.lblBiosLastUpdate.TabIndex = 2;
            this.lblBiosLastUpdate.Text = "Bios Last Update :";
            // 
            // lblBiosSerialNumber
            // 
            this.lblBiosSerialNumber.AutoSize = true;
            this.lblBiosSerialNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosSerialNumber.Location = new System.Drawing.Point(13, 53);
            this.lblBiosSerialNumber.Name = "lblBiosSerialNumber";
            this.lblBiosSerialNumber.Size = new System.Drawing.Size(175, 19);
            this.lblBiosSerialNumber.TabIndex = 3;
            this.lblBiosSerialNumber.Text = "Bios Serial Number :";
            // 
            // lblBiosVersion
            // 
            this.lblBiosVersion.AutoSize = true;
            this.lblBiosVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosVersion.ForeColor = System.Drawing.Color.Maroon;
            this.lblBiosVersion.Location = new System.Drawing.Point(194, 16);
            this.lblBiosVersion.Name = "lblBiosVersion";
            this.lblBiosVersion.Size = new System.Drawing.Size(138, 24);
            this.lblBiosVersion.TabIndex = 4;
            this.lblBiosVersion.Text = "- Bios Version -";
            // 
            // lblBiosSerial
            // 
            this.lblBiosSerial.AutoSize = true;
            this.lblBiosSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosSerial.ForeColor = System.Drawing.Color.Maroon;
            this.lblBiosSerial.Location = new System.Drawing.Point(194, 53);
            this.lblBiosSerial.Name = "lblBiosSerial";
            this.lblBiosSerial.Size = new System.Drawing.Size(120, 24);
            this.lblBiosSerial.TabIndex = 5;
            this.lblBiosSerial.Text = "- Bios Serial -";
            // 
            // lblBiosDate
            // 
            this.lblBiosDate.AutoSize = true;
            this.lblBiosDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiosDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblBiosDate.Location = new System.Drawing.Point(194, 93);
            this.lblBiosDate.Name = "lblBiosDate";
            this.lblBiosDate.Size = new System.Drawing.Size(111, 24);
            this.lblBiosDate.TabIndex = 6;
            this.lblBiosDate.Text = "- Bios Date -";
            // 
            // lblMACAddress
            // 
            this.lblMACAddress.AutoSize = true;
            this.lblMACAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMACAddress.Location = new System.Drawing.Point(61, 129);
            this.lblMACAddress.Name = "lblMACAddress";
            this.lblMACAddress.Size = new System.Drawing.Size(127, 19);
            this.lblMACAddress.TabIndex = 2;
            this.lblMACAddress.Text = "MAC Address :";
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.ForeColor = System.Drawing.Color.Maroon;
            this.lblMAC.Location = new System.Drawing.Point(194, 129);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(74, 24);
            this.lblMAC.TabIndex = 6;
            this.lblMAC.Text = "- MAC -";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.Location = new System.Drawing.Point(49, 163);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(139, 19);
            this.lblMachineName.TabIndex = 2;
            this.lblMachineName.Text = "Machine Name :";
            // 
            // lblcomputerName
            // 
            this.lblcomputerName.AutoSize = true;
            this.lblcomputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomputerName.ForeColor = System.Drawing.Color.Maroon;
            this.lblcomputerName.Location = new System.Drawing.Point(194, 163);
            this.lblcomputerName.Name = "lblcomputerName";
            this.lblcomputerName.Size = new System.Drawing.Size(161, 24);
            this.lblcomputerName.TabIndex = 6;
            this.lblcomputerName.Text = "- Machine Name -";
            // 
            // lblUUID
            // 
            this.lblUUID.AutoSize = true;
            this.lblUUID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUUID.Location = new System.Drawing.Point(125, 202);
            this.lblUUID.Name = "lblUUID";
            this.lblUUID.Size = new System.Drawing.Size(63, 19);
            this.lblUUID.TabIndex = 2;
            this.lblUUID.Text = "UUID :";
            // 
            // lblValUUID
            // 
            this.lblValUUID.AutoSize = true;
            this.lblValUUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValUUID.ForeColor = System.Drawing.Color.Maroon;
            this.lblValUUID.Location = new System.Drawing.Point(194, 199);
            this.lblValUUID.Name = "lblValUUID";
            this.lblValUUID.Size = new System.Drawing.Size(75, 24);
            this.lblValUUID.TabIndex = 6;
            this.lblValUUID.Text = "- UUID -";
            // 
            // lblCPUID
            // 
            this.lblCPUID.AutoSize = true;
            this.lblCPUID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUID.Location = new System.Drawing.Point(110, 233);
            this.lblCPUID.Name = "lblCPUID";
            this.lblCPUID.Size = new System.Drawing.Size(78, 19);
            this.lblCPUID.TabIndex = 2;
            this.lblCPUID.Text = "CPU ID :";
            // 
            // lblValCPUId
            // 
            this.lblValCPUId.AutoSize = true;
            this.lblValCPUId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValCPUId.ForeColor = System.Drawing.Color.Maroon;
            this.lblValCPUId.Location = new System.Drawing.Point(194, 233);
            this.lblValCPUId.Name = "lblValCPUId";
            this.lblValCPUId.Size = new System.Drawing.Size(87, 24);
            this.lblValCPUId.TabIndex = 6;
            this.lblValCPUId.Text = "- CPUID -";
            // 
            // lblPublicIPAddress
            // 
            this.lblPublicIPAddress.AutoSize = true;
            this.lblPublicIPAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicIPAddress.Location = new System.Drawing.Point(26, 267);
            this.lblPublicIPAddress.Name = "lblPublicIPAddress";
            this.lblPublicIPAddress.Size = new System.Drawing.Size(162, 19);
            this.lblPublicIPAddress.TabIndex = 2;
            this.lblPublicIPAddress.Text = "Public IP Address :";
            // 
            // lblLocalIPAddress
            // 
            this.lblLocalIPAddress.AutoSize = true;
            this.lblLocalIPAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalIPAddress.Location = new System.Drawing.Point(33, 301);
            this.lblLocalIPAddress.Name = "lblLocalIPAddress";
            this.lblLocalIPAddress.Size = new System.Drawing.Size(155, 19);
            this.lblLocalIPAddress.TabIndex = 2;
            this.lblLocalIPAddress.Text = "Local IP Address :";
            // 
            // lblPublicIPAddressVal
            // 
            this.lblPublicIPAddressVal.AutoSize = true;
            this.lblPublicIPAddressVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicIPAddressVal.ForeColor = System.Drawing.Color.Maroon;
            this.lblPublicIPAddressVal.Location = new System.Drawing.Point(194, 264);
            this.lblPublicIPAddressVal.Name = "lblPublicIPAddressVal";
            this.lblPublicIPAddressVal.Size = new System.Drawing.Size(180, 24);
            this.lblPublicIPAddressVal.TabIndex = 6;
            this.lblPublicIPAddressVal.Text = "- Public IP Address -";
            // 
            // lblLocalIPAddressVal
            // 
            this.lblLocalIPAddressVal.AutoSize = true;
            this.lblLocalIPAddressVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalIPAddressVal.ForeColor = System.Drawing.Color.Maroon;
            this.lblLocalIPAddressVal.Location = new System.Drawing.Point(194, 298);
            this.lblLocalIPAddressVal.Name = "lblLocalIPAddressVal";
            this.lblLocalIPAddressVal.Size = new System.Drawing.Size(173, 24);
            this.lblLocalIPAddressVal.TabIndex = 6;
            this.lblLocalIPAddressVal.Text = "- Local IP Address -";
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingSystem.Location = new System.Drawing.Point(23, 334);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(165, 19);
            this.lblOperatingSystem.TabIndex = 2;
            this.lblOperatingSystem.Text = "Operating System :";
            // 
            // lblOperatingSystemVal
            // 
            this.lblOperatingSystemVal.AutoSize = true;
            this.lblOperatingSystemVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingSystemVal.ForeColor = System.Drawing.Color.Maroon;
            this.lblOperatingSystemVal.Location = new System.Drawing.Point(194, 331);
            this.lblOperatingSystemVal.Name = "lblOperatingSystemVal";
            this.lblOperatingSystemVal.Size = new System.Drawing.Size(181, 24);
            this.lblOperatingSystemVal.TabIndex = 6;
            this.lblOperatingSystemVal.Text = "- Operating System -";
            // 
            // lblCPUName
            // 
            this.lblCPUName.AutoSize = true;
            this.lblCPUName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUName.Location = new System.Drawing.Point(134, 369);
            this.lblCPUName.Name = "lblCPUName";
            this.lblCPUName.Size = new System.Drawing.Size(54, 19);
            this.lblCPUName.TabIndex = 2;
            this.lblCPUName.Text = "CPU :";
            // 
            // lblCPUNameVal
            // 
            this.lblCPUNameVal.AutoSize = true;
            this.lblCPUNameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUNameVal.ForeColor = System.Drawing.Color.Maroon;
            this.lblCPUNameVal.Location = new System.Drawing.Point(194, 366);
            this.lblCPUNameVal.Name = "lblCPUNameVal";
            this.lblCPUNameVal.Size = new System.Drawing.Size(75, 24);
            this.lblCPUNameVal.TabIndex = 6;
            this.lblCPUNameVal.Text = "- CPU  -";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(130, 400);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(58, 19);
            this.lblRAM.TabIndex = 2;
            this.lblRAM.Text = "RAM :";
            // 
            // lblRAMVal
            // 
            this.lblRAMVal.AutoSize = true;
            this.lblRAMVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMVal.ForeColor = System.Drawing.Color.Maroon;
            this.lblRAMVal.Location = new System.Drawing.Point(194, 397);
            this.lblRAMVal.Name = "lblRAMVal";
            this.lblRAMVal.Size = new System.Drawing.Size(79, 24);
            this.lblRAMVal.TabIndex = 6;
            this.lblRAMVal.Text = "- RAM  -";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.Location = new System.Drawing.Point(133, 432);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(55, 19);
            this.lblGPU.TabIndex = 2;
            this.lblGPU.Text = "GPU :";
            // 
            // lblGPUVal
            // 
            this.lblGPUVal.AutoSize = true;
            this.lblGPUVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUVal.ForeColor = System.Drawing.Color.Maroon;
            this.lblGPUVal.Location = new System.Drawing.Point(194, 429);
            this.lblGPUVal.Name = "lblGPUVal";
            this.lblGPUVal.Size = new System.Drawing.Size(76, 24);
            this.lblGPUVal.TabIndex = 6;
            this.lblGPUVal.Text = "- GPU  -";
            // 
            // LinklblAA
            // 
            this.LinklblAA.AutoSize = true;
            this.LinklblAA.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinklblAA.Location = new System.Drawing.Point(16, 515);
            this.LinklblAA.Name = "LinklblAA";
            this.LinklblAA.Size = new System.Drawing.Size(455, 24);
            this.LinklblAA.TabIndex = 7;
            this.LinklblAA.TabStop = true;
            this.LinklblAA.Text = "www.facebook.com/anonymous.albaq3awy";
            this.LinklblAA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklblAA_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(503, 515);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(208, 24);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ahmad Abu Saloum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.Location = new System.Drawing.Point(9, 468);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(99, 44);
            this.btnSaveData.TabIndex = 0;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // Upgrade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(729, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LinklblAA);
            this.Controls.Add(this.lblGPUVal);
            this.Controls.Add(this.lblRAMVal);
            this.Controls.Add(this.lblCPUNameVal);
            this.Controls.Add(this.lblOperatingSystemVal);
            this.Controls.Add(this.lblLocalIPAddressVal);
            this.Controls.Add(this.lblValCPUId);
            this.Controls.Add(this.lblPublicIPAddressVal);
            this.Controls.Add(this.lblValUUID);
            this.Controls.Add(this.lblcomputerName);
            this.Controls.Add(this.lblMAC);
            this.Controls.Add(this.lblBiosDate);
            this.Controls.Add(this.lblBiosSerial);
            this.Controls.Add(this.lblBiosVersion);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPUName);
            this.Controls.Add(this.lblOperatingSystem);
            this.Controls.Add(this.lblLocalIPAddress);
            this.Controls.Add(this.lblCPUID);
            this.Controls.Add(this.lblBiosSerialNumber);
            this.Controls.Add(this.lblPublicIPAddress);
            this.Controls.Add(this.lblUUID);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.lblMACAddress);
            this.Controls.Add(this.lblBiosLastUpdate);
            this.Controls.Add(this.lblBiosVersion1);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnGetData);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Upgrade";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تطوير - Upgrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label lblBiosVersion1;
        private System.Windows.Forms.Label lblBiosLastUpdate;
        private System.Windows.Forms.Label lblBiosSerialNumber;
        private System.Windows.Forms.Label lblBiosVersion;
        private System.Windows.Forms.Label lblBiosSerial;
        private System.Windows.Forms.Label lblBiosDate;
        private System.Windows.Forms.Label lblMACAddress;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblcomputerName;
        private System.Windows.Forms.Label lblUUID;
        private System.Windows.Forms.Label lblValUUID;
        private System.Windows.Forms.Label lblCPUID;
        private System.Windows.Forms.Label lblValCPUId;
        private System.Windows.Forms.Label lblPublicIPAddress;
        private System.Windows.Forms.Label lblLocalIPAddress;
        private System.Windows.Forms.Label lblPublicIPAddressVal;
        private System.Windows.Forms.Label lblLocalIPAddressVal;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.Label lblOperatingSystemVal;
        private System.Windows.Forms.Label lblCPUName;
        private System.Windows.Forms.Label lblCPUNameVal;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblRAMVal;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblGPUVal;
        private System.Windows.Forms.LinkLabel LinklblAA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSaveData;
    }
}

