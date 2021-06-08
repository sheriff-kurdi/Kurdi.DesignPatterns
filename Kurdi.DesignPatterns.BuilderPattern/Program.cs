using System;

namespace Kurdi.DesignPatterns.BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new EmployeeBuilder()
            .HasFirstName("Sheriff")
            .WithLastName("Kurdi")
            .TakeASalaryOf(12000)
            .Build();

            Console.WriteLine($"Name: {emp.LastName} {emp.LastName} & Salary: {emp.Salary}");
        }
    }
}
