using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

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

            //TODO: Print the Sum of numbers Done

            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

           int sum = numbers.Sum();

           Console.WriteLine(sum);

           Console.WriteLine("-------------------------------------------------");

            //TODO: Print the Average of numbers Done

            Console.WriteLine($"Average of number is");

            double num = numbers.Average();

            Console.WriteLine(num);

            Console.WriteLine("-------------------------------------------");

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine($"Order Ascending");

            List<int> sortedNumbers = numbers.OrderBy(number => number).ToList();
            foreach (int number in sortedNumbers)
                Console.WriteLine(number);

            //TODO: Order numbers in decsending order adn print to the console

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine($"Order Decseding");

            List<int> sortNumbers = numbers.OrderByDescending(number => number).ToList();
            foreach (int number in sortNumbers)
                Console.WriteLine(number);

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"Numbers Greater Than 6");

            var numGreat = numbers.Where(number => number >= 6).ToList();
            
            foreach(int number in numGreat)
            {
                if(number > 6)
                {
                    Console.WriteLine(number);
                }
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine($"Print only 4 numbers");

            List<int> desNumbers = numbers.OrderByDescending(number => number).ToList();

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;

                Console.WriteLine("Value of i: {0}", i);
            }


            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine($"Change index 4 with my age");

            //numbers[4] = 41;

            numbers[4] = 41;

            var descWithAge = numbers.OrderByDescending(num => num);

            foreach (var number in descWithAge)
            {
           
                Console.WriteLine(number);
            }




            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.

            Console.WriteLine($"------------------------------------------------");

            var filtered = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower()[0] == 's')
                            .OrderBy(person => person.FirstName);

            var otherFiltered = employees.FindAll(name => name.FirstName.ToLower()[0] == 'c' || name.FirstName.ToLower()[0] == 's')
                                .OrderBy(name => name.FirstName);
           
            Console.WriteLine("----");
            foreach (var person in filtered)
            {
                Console.WriteLine(person.FullName);
            }


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine($"------------------------------------------------");

            var twentySix = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);

            Console.WriteLine("------");
            foreach (var item in twentySix)
            {
                Console.WriteLine($"Name: {item.FullName}, Age: {item.Age}");
            }


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35

            Console.WriteLine($"------------------------------------------------");

            var sumAndYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            Console.WriteLine($"Total YOE:{sumAndYOE.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine($"Avg YOE:{sumAndYOE.Average(x => x.YearsOfExperience)}");

            //TODO: Add an employee to the end of the list without using employees.Add()

            Console.WriteLine("-----------------------------------------------------");
            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }


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
