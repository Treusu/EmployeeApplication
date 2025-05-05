using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(
                ID.Text,
                FName.Text,
                LName.Text,
                Position.Text);

            int row = dataGridEmployee.Rows.Add();
            dataGridEmployee.Rows[row].Cells["colID"].Value = employee.EmployeeID;
            dataGridEmployee.Rows[row].Cells["colFirstName"].Value = employee.FirstName;
            dataGridEmployee.Rows[row].Cells["colLastName"].Value = employee.LastName;
            dataGridEmployee.Rows[row].Cells["colPosition"].Value = employee.Position;

            ID.Clear();
            FName.Clear();
            LName.Clear();
            Position.Clear();
            ID.Focus();
        }
    }
}
