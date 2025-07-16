using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Solution
{
    public class BatSolution : IMammalSolution, IWalkingMammalSolution, IFlyingMammalSolution
    {
        public void Walk()
        {
            Console.WriteLine("Bat can walk.");
        }
        public void Fly()
        {
            Console.WriteLine("Bat can fly.");
        }
        public void Eat()
        {
            Console.WriteLine("Bat can eat.");
        }
        public void Sleep()
        {
            Console.WriteLine("Bat can sleep.");
        }
    }
}
