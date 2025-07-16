using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Solution
{
    public class BulbSolution : ISwitchableSolution
    {
        public bool IsOn { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Turn on bulb.");
            IsOn = true;
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off bulb.");
            IsOn = false;
        }
    }
}
