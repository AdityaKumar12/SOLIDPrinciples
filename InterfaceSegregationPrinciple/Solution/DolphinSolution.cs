using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Solution
{
    public class DolphinSolution : IMammalSolution, ISwimmingMammalSolution
    {
        public void Swim()
        {
            Console.WriteLine("Dolphin can swim.");
        }
        public void Eat()
        {
            Console.WriteLine("Dolphin can eat.");
        }
        public void Sleep()
        {
            Console.WriteLine("Dolphin can sleep.");
        }
    }
}
