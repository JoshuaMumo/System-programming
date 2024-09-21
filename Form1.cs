namespace Class_project
{
    public partial class System_programming_form : Form
    {
        public System_programming_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process_management_form form = new Process_management_form();
            form.Show();
        }
    }
}
