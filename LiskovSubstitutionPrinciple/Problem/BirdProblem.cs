using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Problem
{
    public class BirdProblem
    {
        public virtual void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }
}
