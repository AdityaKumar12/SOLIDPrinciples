using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Problem
{
    public class BulbProblem
    {
        public bool IsOn { get; set; }
        public void TurnOnBulb()
        {
            Console.WriteLine("Turn on bulb.");
        }
        public void TurnOffBulb()
        {
            Console.WriteLine("Turn off bulb.");
        }
    }
}
