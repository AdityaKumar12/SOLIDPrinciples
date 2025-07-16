using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Problem
{
    public class HumanProblem : IMammalProblem
    {
        // HumanProblem class implements all methods, even if not applicable
        public void Walk()
        {
            Console.WriteLine("Human can walk.");
        }
        public void Swim()
        {
            Console.WriteLine("Human can swim.");
        }
        public void Fly()
        {
            Console.WriteLine("Human cannot fly.");
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
