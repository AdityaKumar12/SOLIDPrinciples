using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Problem
{
    public class EmployeeProblem
    {
        public EmployeeProblem()
        {
            Console.WriteLine("Welcome to employee problen class!");
        }

        public void AddEmployee(string name, string email)
        {
            // Logic to add employee
            Console.WriteLine($"Employee {name} with email {email} added.");
        }
        public void RetrieveEmployee(string name)
        {
            // Logic to retrieve employee
            Console.WriteLine($"Employee {name} retrieved.");
        }
        public void UpdateEmployee(string email, string newName)
        {
            // Logic to send email
            Console.WriteLine($"Employee name updated to {newName} with email id = {email}.");
        } 
        public void DeleteEmployee(string name) {
            // Logic to delete employee
            Console.WriteLine($"Employee {name} deleted.");
        }

        public void PunchInShift(string name, DateTime shiftTime)
        {
            // Logic to punch shift
            Console.WriteLine($"Employee {name} punched in at {shiftTime}.");
        }
        public void PunchOutShift(string name, DateTime shiftTime)
        {
            // Logic to punch out shift
            Console.WriteLine($"Employee {name} punched out at {shiftTime}.");
        }
    }
}
