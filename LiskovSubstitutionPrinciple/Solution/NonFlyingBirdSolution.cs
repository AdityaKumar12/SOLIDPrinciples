using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Solution
{
    public class NonFlyingBirdSolution : BirdSolution
    {
        public override void Move()
        {
            Walk();
        }
        public virtual void Walk()
        {
            Console.WriteLine("The bird is walking.");
        }
    }
}
