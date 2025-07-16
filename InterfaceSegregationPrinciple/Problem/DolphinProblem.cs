using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Problem
{
    public class DolphinProblem : IMammalProblem
    {

        public void Walk()
        {
            Console.WriteLine("Dolphin cannot walk.");
        }
        public void Swim()
        {
            Console.WriteLine("Dolphin can swim.");
        }
        public void Fly()
        {
            Console.WriteLine("Dolphin cannot fly.");
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
