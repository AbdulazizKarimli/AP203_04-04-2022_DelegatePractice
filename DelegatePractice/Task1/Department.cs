using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Department
    {
        private List<Employee> employees;

        public Department()
        {
            employees = new List<Employee>();
        }

        private bool IsExistsEmployee(Predicate<Employee> predicate)
        {
            var result = employees.Find(predicate);
            if(result == null)
                return false;

            return true;
        }
        public void AddEmployee(Employee employee)
        {
            if (IsExistsEmployee(e => e.Email == employee.Email))
                throw new EmployeeAlreadyExistsException("xeta!!!");

            employees.Add(employee);
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeesCopy = new List<Employee>();
            employeesCopy.AddRange(employees);
            return employeesCopy;
        }
        public List<Employee> FilterEmployeesBySalary(int minSalary, int maxSalary)
        {
            var filteredEmployees = employees.FindAll(e => e.Salary >= minSalary && e.Salary <= maxSalary);
            if (filteredEmployees.Count == 0)
                throw new NotFoundException("xeta");

            return filteredEmployees;
        }
        public Employee GetEmployeeById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            return employees.Find(e => e.Id == id);
        }
        public void DeleteEmployeeById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmez");

            Employee employee = employees.Find(e => e.Id == id);
            if (employee == null)
                throw new NotFoundException("xeta");

            employees.Remove(employee);
        }
        public void EditEmployeeEmail(int? id, string email)
        {
            if (id == null || string.IsNullOrWhiteSpace(email))
                throw new NullReferenceException("id ve ya email null ola bilmez");

            Employee employee = employees.Find(e => e.Id == id);
            if (employee == null)
                throw new NotFoundException("xeta");

            employee.Email = email;
        }
    }
}
