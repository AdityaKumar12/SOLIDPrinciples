using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Problem
{
    public class PenguinProblem : BirdProblem
    {
        // Penguins cannot fly, so overriding the Fly method is not appropriate.
        // This violates the Liskov Substitution Principle.
        public override void Fly()
        {
            Console.WriteLine("Penguins cannot fly.");
        }
    }
}
