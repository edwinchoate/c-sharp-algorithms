using System;
using System.Collections.Generic;

namespace Algorithms {
    class Employee {

        string name;
        int id;
        string department;

        public Employee(string name, int id, string department) {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        static void Main(string[] args) {
            Employee employee = new Employee("Robby", 3827, "Technology");
            Employee employee2 = new Employee("Bobby", 9415, "Marketing");
            Employee employee3 = new Employee("Sally", 2519, "Sales");

            Dictionary<int, Employee> employees = new Dictionary<int, Employee>() 
            {
                {3827, employee},
                {9415, employee2},
                {2519, employee3},
            };

            Employee e;
            if (employees.TryGetValue(3827, out e))
            {
                Console.WriteLine("{0}, Employee #{1}", e.name, e.id);
            }

            HashSet<string> productCodes = new HashSet<string>() {"34F24HJ", "36FD20J", "8D2FN2R"};

            Console.WriteLine(productCodes.Contains("34F24HJ"));
            Console.WriteLine(productCodes.Contains("99FD200"));
        }
    }
}