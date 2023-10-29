namespace _01._Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string employeeName = employeeInfo[0];
                decimal employeeSalary = decimal.Parse(employeeInfo[1]);
                string employeeDepartment = employeeInfo[2];

                Employee employee = new Employee(employeeName, employeeSalary, employeeDepartment);
                employee.Salaries.Add(employeeSalary);
                employees.Add(employee);
            }

            decimal highestAverage = 0;
            string highestDepartment = string.Empty;

            foreach (Employee currentEmployee in employees)
            {
                if (highestAverage < currentEmployee.Salaries.Average())
                {
                    highestAverage = currentEmployee.Salaries.Average();
                    highestDepartment = currentEmployee.Department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestDepartment}");

            foreach (Employee currentEmployee in employees
                    .Where(e => e.Department == highestDepartment)
                    .OrderByDescending(s => s.Salary))
            {
                Console.WriteLine($"{currentEmployee.Name} {currentEmployee.Salary:F2}");
            }
        }
    }

    public class Employee
    {
        private readonly List<decimal> salaries;

        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;

            salaries = new List<decimal>();
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public List<decimal> Salaries
            => this.salaries;
    }
}
