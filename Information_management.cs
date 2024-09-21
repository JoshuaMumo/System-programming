using System;
using System.Management;
using System.Windows.Forms;

namespace Class_project
{
    public partial class Information_management : Form
    {
        public Information_management()
        {
            InitializeComponent();
        }

        // Button to open another form
        private void button1_Click(object sender, EventArgs e)
        {
            System_programming_form form = new System_programming_form();
            form.Show();
        }

        // Button to load system information into the ListView
        private void button2_Click(object sender, EventArgs e)
        {
            InitializeListView();
            LoadSystemInfo();
        }

        // Initialize the ListView with columns
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Clear();
            listView1.Columns.Add("Property", 150); // Column for the property name
            listView1.Columns.Add("Value", 300);    // Column for the property value
        }

        // Load system information into the ListView
        private void LoadSystemInfo()
        {
            // Clear existing items
            listView1.Items.Clear();

            // Get Operating System Information
            AddItemToListView("Operating System", GetOSInformation());

            // Get Processor Information
            AddItemToListView("Processor", GetProcessorInformation());

            // Get RAM Information
            AddItemToListView("Installed RAM", GetRAMInformation());

            // Get System Model Information
            AddItemToListView("System Model", GetSystemModelInformation());

            // Get Disk Information
            AddItemToListView("Disk Capacity", GetDiskInformation());
        }

        // Helper function to add items to the ListView
        private void AddItemToListView(string property, string value)
        {
            ListViewItem item = new ListViewItem(property);
            item.SubItems.Add(value);
            listView1.Items.Add(item);
        }

        // Method to get the Operating System information
        private string GetOSInformation()
        {
            string osInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                osInfo = obj["Caption"] + " - " + obj["Version"];
            }
            return osInfo;
        }

        // Method to get the Processor information
        private string GetProcessorInformation()
        {
            string processorInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                processorInfo = obj["Name"].ToString();
            }
            return processorInfo;
        }

        // Method to get the Installed RAM information
        private string GetRAMInformation()
        {
            string ramInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                double totalMemory = Convert.ToDouble(obj["TotalPhysicalMemory"]) / (1024 * 1024 * 1024); // Convert bytes to GB
                ramInfo = totalMemory.ToString("0.00") + " GB";
            }
            return ramInfo;
        }

        // Method to get the System Model information
        private string GetSystemModelInformation()
        {
            string modelInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                modelInfo = obj["Manufacturer"] + " - " + obj["Model"];
            }
            return modelInfo;
        }

        // Method to get Disk Capacity information
        private string GetDiskInformation()
        {
            string diskInfo = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DriveType=3");
            foreach (ManagementObject obj in searcher.Get())
            {
                double size = Convert.ToDouble(obj["Size"]) / (1024 * 1024 * 1024); // Convert bytes to GB
                diskInfo += obj["Name"] + ": " + size.ToString("0.00") + " GB\n";
            }
            return diskInfo;
        }
    }
}
