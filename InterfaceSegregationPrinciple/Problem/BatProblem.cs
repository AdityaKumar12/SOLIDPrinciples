using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Problem
{
    public class BatProblem : IMammalProblem
    {
        public void Walk()
        {
            Console.WriteLine("Bat can walk.");
        }
        public void Swim()
        {
            Console.WriteLine("Bat cannot swim.");
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
