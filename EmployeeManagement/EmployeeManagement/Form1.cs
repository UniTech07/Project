namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee EmployeeInfo = new Employee();

            EmployeeInfo.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeInfo EmployeeInfo = new EmployeeInfo();

            EmployeeInfo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
