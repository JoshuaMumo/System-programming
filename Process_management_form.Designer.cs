namespace Class_project
{
    partial class Process_management_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Find_all_processes = new Button();
            Start_process = new Button();
            listBox1 = new ListBox();
            Kill_process = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Find_all_processes
            // 
            Find_all_processes.Location = new Point(239, 129);
            Find_all_processes.Name = "Find_all_processes";
            Find_all_processes.Size = new Size(164, 52);
            Find_all_processes.TabIndex = 0;
            Find_all_processes.Text = "Find_all_processes";
            Find_all_processes.UseVisualStyleBackColor = true;
            Find_all_processes.Click += Find_all_processes_Click;
            // 
            // Start_process
            // 
            Start_process.Location = new Point(459, 479);
            Start_process.Name = "Start_process";
            Start_process.Size = new Size(149, 52);
            Start_process.TabIndex = 1;
            Start_process.Text = "Start_process";
            Start_process.UseVisualStyleBackColor = true;
            Start_process.Click += Start_process_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(459, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(392, 329);
            listBox1.TabIndex = 2;
            // 
            // Kill_process
            // 
            Kill_process.Location = new Point(702, 479);
            Kill_process.Name = "Kill_process";
            Kill_process.Size = new Size(149, 52);
            Kill_process.TabIndex = 3;
            Kill_process.Text = "Kill_process";
            Kill_process.UseVisualStyleBackColor = true;
            Kill_process.Click += Kill_process_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 24);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Process_management_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 726);
            Controls.Add(button1);
            Controls.Add(Kill_process);
            Controls.Add(listBox1);
            Controls.Add(Start_process);
            Controls.Add(Find_all_processes);
            Name = "Process_management_form";
            Text = "Process_management_form";
            ResumeLayout(false);
        }

        #endregion

        private Button Find_all_processes;
        private Button Start_process;
        private ListBox listBox1;
        private Button Kill_process;
        private Button button1;
    }
}