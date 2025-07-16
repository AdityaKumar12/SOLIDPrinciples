using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Solution
{
    public class FlyingBirdSolution : BirdSolution
    {
        public override void Move()
        {
            Fly();
        }
        public virtual void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }
}
