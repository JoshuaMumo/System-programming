using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_project
{
    public partial class Process_management_form : Form
    {
        public Process_management_form()
        {
            InitializeComponent();
        }

        private void Kill_process_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    string selectedProcess = listBox1.SelectedItem.ToString();

                    foreach (var process in Process.GetProcessesByName(selectedProcess))
                    {
                        process.Kill();
                    }

                    MessageBox.Show($"Process {selectedProcess} killed successfully.");
                    Find_all_processes_Click(sender, e); // Refresh process list after killing the process
                }
                else
                {
                    MessageBox.Show("Please select a process to kill.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Find_all_processes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Get all processes and add them to the ListBox
            foreach (Process process in Process.GetProcesses())
            {
                listBox1.Items.Add(process.ProcessName);
            }
        }

        private void Start_process_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    string selectedProcess = listBox1.SelectedItem.ToString() + ".exe";
                    Process.Start(selectedProcess);
                    MessageBox.Show($"Process {selectedProcess} started successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a process to start.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}
