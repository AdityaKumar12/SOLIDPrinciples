using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Solution
{
    public class HumanSolution : IMammalSolution, IWalkingMammalSolution, ISwimmingMammalSolution
    {
        public void Walk()
        {
            Console.WriteLine("Human can walk.");
        }

        public void Swim()
        {
            Console.WriteLine("Human can swim.");
        }
        public void Eat()
        {
            Console.WriteLine("Human can eat.");
        }

        public void Sleep()
        {
            Console.WriteLine("Human can sleep.");
        }
    }
}
