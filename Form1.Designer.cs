namespace Class_project
{
    partial class System_programming_form
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
            Process_management = new Button();
            Information_management = new Button();
            File_management = new Button();
            Memory_management = new Button();
            Input_output_subsystem = new Button();
            IPC = new Button();
            SuspendLayout();
            // 
            // Process_management
            // 
            Process_management.Location = new Point(189, 170);
            Process_management.Name = "Process_management";
            Process_management.Size = new Size(151, 78);
            Process_management.TabIndex = 0;
            Process_management.Text = "Process_management";
            Process_management.UseVisualStyleBackColor = true;
            Process_management.Click += button1_Click;
            // 
            // Information_management
            // 
            Information_management.Location = new Point(389, 170);
            Information_management.Name = "Information_management";
            Information_management.Size = new Size(132, 78);
            Information_management.TabIndex = 1;
            Information_management.Text = "Information_management";
            Information_management.UseVisualStyleBackColor = true;
            Information_management.Click += Information_management_Click;
            // 
            // File_management
            // 
            File_management.Location = new Point(574, 170);
            File_management.Name = "File_management";
            File_management.Size = new Size(147, 78);
            File_management.TabIndex = 2;
            File_management.Text = "File_management";
            File_management.UseVisualStyleBackColor = true;
            // 
            // Memory_management
            // 
            Memory_management.Location = new Point(750, 170);
            Memory_management.Name = "Memory_management";
            Memory_management.Size = new Size(163, 78);
            Memory_management.TabIndex = 3;
            Memory_management.Text = "Memory_management";
            Memory_management.UseVisualStyleBackColor = true;
            // 
            // Input_output_subsystem
            // 
            Input_output_subsystem.Location = new Point(189, 298);
            Input_output_subsystem.Name = "Input_output_subsystem";
            Input_output_subsystem.Size = new Size(151, 63);
            Input_output_subsystem.TabIndex = 4;
            Input_output_subsystem.Text = "Input_output_subsystem";
            Input_output_subsystem.UseVisualStyleBackColor = true;
            // 
            // IPC
            // 
            IPC.Location = new Point(389, 298);
            IPC.Name = "IPC";
            IPC.Size = new Size(132, 63);
            IPC.TabIndex = 5;
            IPC.Text = "IPC";
            IPC.UseVisualStyleBackColor = true;
            // 
            // System_programming_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 740);
            Controls.Add(IPC);
            Controls.Add(Input_output_subsystem);
            Controls.Add(Memory_management);
            Controls.Add(File_management);
            Controls.Add(Information_management);
            Controls.Add(Process_management);
            Name = "System_programming_form";
            Text = "System_programming_form";
            ResumeLayout(false);
        }

        #endregion

        private Button Process_management;
        private Button Information_management;
        private Button File_management;
        private Button Memory_management;
        private Button Input_output_subsystem;
        private Button IPC;
    }
}
