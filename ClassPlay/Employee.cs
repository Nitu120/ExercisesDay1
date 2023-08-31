using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlay
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }

        public int YearJoined { get; set; }

        public string JobTitle { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }

        public Employee(string firstName, string lastName, int employeeId,
           int yearJoined, string jobTitle, string department,
           double salary) 
        {
            FirstName = firstName;
            LastName = lastName;   
            EmployeeId = employeeId;   
            YearJoined = yearJoined;
            JobTitle = jobTitle;
            Department = department;
            Salary = salary;
        }
        //constructor overloading-same name diff parameters
        public Employee(string firstName, string lastName, int employeeId
           )
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
           
        }

        public Employee(int employeeId)
        {
            
            EmployeeId = employeeId;
        }

        public Employee Display()
        {
            Console.WriteLine($"Name: {FirstName}, LastName: {LastName},EmployeeId: {EmployeeId} ");
            return this;
          
        }

        public Employee Promote(string jobTitle, double pay)
        {
            Console.WriteLine($"Job Title: {jobTitle}, Salary: {pay} ");
            return this;

        }

        
    }
}
