using System;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Linq;

namespace GetBios
{
    public partial class Upgrade : Form
    {
        //Ahmad Abu Saloum
        public static string _lblBiosSerial;
        public static string _lblBiosVersion;
        public static string _lblBiosDate;
        public static string _lblMAC;
        public static string _lblValUUID;
        public static string _lblValCPUId;
        public static string _lblCPUNameVal;
        public static string _lblcomputerName;
        public static string _lblPublicIPAddressVal;
        public static string _lblLocalIPAddressVal;
        public static string _lblOperatingSystemVal;
        public static string _lblRAMVal;
        public static string _lblGPUVal;

        public Upgrade()
        {
            //Ahmad Abu Saloum
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (_lblBiosSerial == null && _lblBiosVersion == null && _lblBiosDate == null && _lblMAC == null && _lblValUUID == null
                && _lblValCPUId == null && _lblCPUNameVal == null && _lblcomputerName == null && _lblPublicIPAddressVal == null
                && _lblLocalIPAddressVal == null && _lblOperatingSystemVal == null && _lblRAMVal == null && _lblGPUVal == null)
            {


                GetInformation();

                if (_lblRAMVal == null)
                {
                    GetOperatingSystemRAM();
                }

                if (_lblGPUVal == null)
                {
                    GetGPU();
                }

                if (_lblPublicIPAddressVal == null)
                {
                    _lblPublicIPAddressVal = GetIPAddress();
                }

                if (_lblLocalIPAddressVal == null)
                {
                    _lblLocalIPAddressVal = GetLocalIPAddress();
                }

                if (_lblOperatingSystemVal == null)
                {
                    _lblOperatingSystemVal = GetOperatingSystem();
                }

                lblBiosSerial.Text = _lblBiosSerial;
                lblBiosVersion.Text = _lblBiosVersion;
                lblBiosDate.Text = _lblBiosDate;
                lblMAC.Text = _lblMAC;
                lblcomputerName.Text = _lblcomputerName;
                lblValUUID.Text = _lblValUUID;
                lblValCPUId.Text = _lblValCPUId;
                lblCPUNameVal.Text = _lblCPUNameVal;
                lblPublicIPAddressVal.Text = _lblPublicIPAddressVal;
                lblLocalIPAddressVal.Text = _lblLocalIPAddressVal;
                lblOperatingSystemVal.Text = _lblOperatingSystemVal;
                lblRAMVal.Text = _lblRAMVal;
                lblGPUVal.Text = _lblGPUVal;
            }
            else
            {
                string message = "All information has been filled";
                string title = "Get Data";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void GetInformation()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS");
                ManagementObjectSearcher Searcher = new ManagementObjectSearcher("SELECT UUID FROM Win32_ComputerSystemProduct");
                ManagementClass mc2 = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();
                ManagementObjectCollection moc2 = mc2.GetInstances();
                ManagementObjectCollection collection = mSearcher.Get();

                if (_lblBiosSerial == null || _lblBiosVersion == null)
                {
                    foreach (ManagementObject obj in collection)
                    {
                        _lblBiosSerial = obj["SerialNumber"].ToString();
                        _lblBiosVersion = obj["SMBIOSBIOSVersion"].ToString();
                        DateTime dt = ManagementDateTimeConverter.ToDateTime(obj["ReleaseDate"].ToString());
                        _lblBiosDate = dt.ToString("dd-MMM-yyyy");
                        obj.Dispose();
                    }
                }

                if (_lblMAC == null)
                {
                    foreach (ManagementObject mo in moc)
                    {
                        if (lblMAC.Text == "- MAC -")
                        {
                            if ((bool)mo["IPEnabled"] == true)
                                _lblMAC = mo["MacAddress"].ToString();
                        }
                        mo.Dispose();
                    }
                }

                if (_lblcomputerName == null)
                {
                    _lblcomputerName = Environment.MachineName.ToString();
                }

                if (_lblValUUID == null)
                {
                    foreach (ManagementObject WmiObject in Searcher.Get())
                    {
                        _lblValUUID = WmiObject["UUID"].ToString();
                        WmiObject.Dispose();
                    }
                }

                if (_lblValCPUId == null || _lblCPUNameVal == null)
                {
                    foreach (ManagementObject mo in moc2)
                    {
                        if (lblValCPUId.Text == "- CPUID -")
                        {
                            _lblValCPUId = mo.Properties["processorID"].Value.ToString();
                            _lblCPUNameVal = mo["Name"].ToString();
                            mo.Dispose();
                            break;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }

        }

        static string GetIPAddress()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }

        public static string GetLocalIPAddress()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
                return localIP;
            }
        }

        public static string GetOperatingSystem()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();
            return name != null ? name.ToString() : "Unknown";
        }

        public void GetOperatingSystemRAM()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                var TotalRamVal = result["TotalVisibleMemorySize"].ToString();
                if (TotalRamVal.Count() > 7)
                {
                    _lblRAMVal = TotalRamVal[0].ToString() + TotalRamVal[1].ToString() + " GB";
                }
                else
                {
                    _lblRAMVal = TotalRamVal[0].ToString() + " GB";
                }
                result.Dispose();
            }
        }

        public void GetGPU()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    _lblGPUVal = obj["Name"].ToString();
                    obj.Dispose();
                }
            }
        }

        private void LinklblAA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/anonymous.albaq3awy");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Ahmad.AbuSaloum");
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            string targetFolder = Application.StartupPath + @"\My Info.txt";
            TextWriter txt = new StreamWriter(targetFolder);
            txt.WriteLine("---------- Written by : Ahmad Abu Saloum ----------");
            txt.WriteLine();
            txt.WriteLine(lblBiosVersion1.Text + " " + lblBiosVersion.Text);
            txt.WriteLine(lblBiosSerialNumber.Text + " " + lblBiosSerial.Text);
            txt.WriteLine(lblBiosLastUpdate.Text + " " + lblBiosDate.Text);
            txt.WriteLine(lblMACAddress.Text + " " + lblMAC.Text);
            txt.WriteLine(lblMachineName.Text + " " + lblcomputerName.Text);
            txt.WriteLine(lblUUID.Text + " " + lblValUUID.Text);
            txt.WriteLine(lblCPUID.Text + " " + lblValCPUId.Text);
            txt.WriteLine(lblPublicIPAddress.Text + " " + lblPublicIPAddressVal.Text);
            txt.WriteLine(lblLocalIPAddress.Text + " " + lblLocalIPAddressVal.Text);
            txt.WriteLine(lblOperatingSystem.Text + " " + lblOperatingSystemVal.Text);
            txt.WriteLine(lblCPUName.Text + " " + lblCPUNameVal.Text);
            txt.WriteLine(lblRAM.Text + " " + lblRAMVal.Text);
            txt.WriteLine(lblGPU.Text + " " + lblGPUVal.Text);
            txt.WriteLine();
            txt.WriteLine("My Page : https://www.facebook.com/anonymous.albaq3awy");
            txt.WriteLine("My Facebook : https://www.facebook.com/Ahmad.AbuSaloum");
            txt.WriteLine("My Linkedin : https://www.linkedin.com/in/ahmadabusaloum");
            txt.Close();
            this.Cursor = System.Windows.Forms.Cursors.Default;
            MessageBox.Show("The file has been saved successfully ^_^", "Saved Succesfully");
        }
    }
}
