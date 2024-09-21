namespace Class_project
{
    partial class Information_management
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
            button1 = new Button();
            listView1 = new ListView();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(363, 117);
            listView1.Name = "listView1";
            listView1.Size = new Size(609, 417);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(130, 117);
            button2.Name = "button2";
            button2.Size = new Size(172, 94);
            button2.TabIndex = 2;
            button2.Text = "show_system_info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Information_management
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 656);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "Information_management";
            Text = "Information_management";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView listView1;
        private Button button2;
    }
}