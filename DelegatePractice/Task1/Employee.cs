using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Employee
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }

        public Employee(string name, double salary, string email)
        {
            _id++;
            Id = _id;
            Name = name;
            Salary = salary;
            Email = email;
        }
    }
}
