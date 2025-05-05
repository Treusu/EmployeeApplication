namespace EmployeeApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmEmployeeDatabase());
        }
    }
}

namespace EmployeeNamespace
{
    public class Employee
    {
        private string employeeID;
        private string firstName;
        private string lastName;
        private string position;

        public Employee() { }
        public Employee(string id) => this.employeeID = id;
        public Employee(string id, string fName, string lName, string pos)
        {
            this.employeeID = id;
            this.firstName = fName;
            this.lastName = lName;
            this.position = pos;
        }
        public string EmployeeID
        {
            get => employeeID;
            set => employeeID = value;
        }
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public string Position
        {
            get => position;
            set => position = value;
        }
    }
}