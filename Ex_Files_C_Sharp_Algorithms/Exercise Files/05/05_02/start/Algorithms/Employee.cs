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
        }
    }
}