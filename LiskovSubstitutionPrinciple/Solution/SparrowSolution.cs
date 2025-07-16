using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Solution
{
    public class SparrowSolution : FlyingBirdSolution
    {
        public override void Fly()
        {
            Console.WriteLine("The sparrow is flying gracefully.");
        }
    }
}
