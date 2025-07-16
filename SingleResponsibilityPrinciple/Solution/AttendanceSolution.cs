using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Solution
{
    public class AttendanceSolution
    {
        public AttendanceSolution()
        {
            Console.WriteLine("Welcome to attendance solution class!");
        }
        public void PunchInShift(string name, DateTime shiftTime)
        {
            // Logic to punch shift
            Console.WriteLine($"Employee {name} punched in at {shiftTime}.");
        }
        public void PunchOutShift(string name, DateTime shiftTime)
        {
            // Logic to punch out shift

        }
    }
