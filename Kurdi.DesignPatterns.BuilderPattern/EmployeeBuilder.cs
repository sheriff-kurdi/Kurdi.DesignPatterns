namespace Kurdi.DesignPatterns.BuilderPattern
{
    public class EmployeeBuilder
    {
        private readonly Employee employee;
        public EmployeeBuilder()
        {
            employee = new Employee();
        }

        public EmployeeBuilder HasFirstName(string firstName)
        {
            employee.FirstName = firstName;
            return this;
        }

        public EmployeeBuilder WithLastName(string lastName)
        {
            employee.LastName = lastName;
            return this;
        }

        public EmployeeBuilder TakeASalaryOf(double salary)
        {
            employee.Salary = salary;
            return this;
        }

        public Employee Build()
        {
            return employee;
        }
    }
}