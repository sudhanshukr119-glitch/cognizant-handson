using System;
using Exercise4_EmployeeManagement.Models;
using Exercise4_EmployeeManagement.Services;

namespace Exercise4_EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService service = new EmployeeService(10);

            service.AddEmployee(new Employee(101, "John", "Manager", 65000));
            service.AddEmployee(new Employee(102, "Alice", "Developer", 55000));
            service.AddEmployee(new Employee(103, "Bob", "Tester", 45000));
            service.AddEmployee(new Employee(104, "Emma", "Designer", 50000));

            service.DisplayEmployees();

            Console.WriteLine("\nSearching Employee with ID 102");

            Employee employee = service.SearchEmployee(102);

            if (employee != null)
            {
                Console.WriteLine(employee);
            }
            else
            {
                Console.WriteLine("Employee Not Found.");
            }

            Console.WriteLine();

            service.DeleteEmployee(103);

            service.DisplayEmployees();
        }
    }
}