using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //private const string

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsOfExperience { get; set; }

        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 27, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");

            //TODO: Print the Average of numbers

            double average = numbers.Average();
            Console.WriteLine($"Average of numbers: {average}");

            //TODO: Order numbers in ascending order and print to the console

                //Order numbers in Ascending Order
            var ascendingNumbers = numbers.OrderBy(num => num);
                //Print to Console in Ascending Order
            Console.WriteLine($"Numbers in Ascending Order:");
            foreach (int num in ascendingNumbers)
            {
                Console.WriteLine(num);
            }

            //TODO: Order numbers in descending order and print to the console

            var descendingNumbers = numbers.OrderByDescending(num => num);
            Console.WriteLine($"Numbers in Descending Order:");
            foreach (int num in descendingNumbers)
            {
                Console.WriteLine(num);
            }

            //TODO: Print to the console only the numbers greater than 6

            var greaterThan6 = numbers.Where(num => num > 6);

            Console.WriteLine($"Numbers Greater than 6");
            foreach (int num in greaterThan6)
            {
                Console.WriteLine(num);
            }


            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            var orderedNumbers4 = numbers.OrderBy(num => num);

            Console.WriteLine($"Only 4 Numbers in Ascending Order:");
            int count = 0;
            foreach (int num in orderedNumbers4)
            {
                if (count < 4)
                {
                    Console.WriteLine(num);
                    count++;
                }
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            var newDescendingNumbers = numbers.OrderByDescending(num => num);

            Console.WriteLine($"Descending numbers with my Age:");
            foreach (int num in newDescendingNumbers)
            {
                Console.WriteLine(num);
            }
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            List<Employee> employeeName = new List<Employee>();
            {
                employeeName.Add(new Employee { FirstName = "Bob", LastName = "Ross", Age = 55, YearsOfExperience = 20 });
                employeeName.Add(new Employee { FirstName = "Conor", LastName = "Moore", Age = 45, YearsOfExperience = 10 });
                employeeName.Add(new Employee { FirstName = "Sarah", LastName = "Thomas", Age = 35, YearsOfExperience = 5 });
                employeeName.Add(new Employee { FirstName = "Claire", LastName = "Davis", Age = 25, YearsOfExperience = 2 });
                new Employee { FirstName = "Tom", LastName = "Hanks", Age = 65, YearsOfExperience = 40 };
            };
            Console.WriteLine();
            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var selectedEmployees = employeeName.Where(employee => employee.FirstName.StartsWith("C", StringComparison.OrdinalIgnoreCase) || employee.FirstName.StartsWith("S", StringComparison.OrdinalIgnoreCase)).OrderBy(employee => employee.FirstName);

            Console.WriteLine("List of Employees only if their FirstName starts with a C OR an S and ordered in ascending order by FirstName:");
            foreach (Employee employee in employeeName)
            {
                Console.WriteLine($"First Name: {employee.FirstName}, Last Name: {employee.LastName}, Age: {employee.Age}, Years of Experience: {employee.YearsOfExperience}.");
            }
            Console.WriteLine();
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var selectedEmployeesOver26 = employeeName.Where(employee => employee.Age > 26).OrderBy(employee => employee.Age).ThenBy(employee => employee.FirstName);

            Console.WriteLine("List of Employees over the age 26, ordered by Age first and then by FirstName:");
            foreach (Employee employee in employeeName)
            {
                Console.WriteLine($"Full Name: {employee.FirstName} {employee.LastName}, Age: {employee.Age}.");
            }
            Console.WriteLine();
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            int sumOfExperience = employeeName.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35).Sum(employee => employee.YearsOfExperience);
            Console.WriteLine($"Sum of Years of Experience for employees with YOE less than or equal to 10 AND Age is greater than 35 is:      {sumOfExperience}");
            Console.WriteLine();
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            double averageExperience = employeeName.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35).Average(employee => employee.YearsOfExperience);

            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()

            employeeName = employeeName.Concat(new[] { new Employee { FirstName = "New", LastName = "Employee", Age = 30, YearsOfExperience = 5 } }).ToList();

            Console.WriteLine($"Average Years of Experience for employees with YOE less than or equal to 10 AND Age is greater than 35 is:    {averageExperience}");
           
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
