using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Solution
{
    public class PenguinSolution : NonFlyingBirdSolution
    {
        public override void Walk()
        {
            Console.WriteLine("The penguin is waddling on the ice.");
        }
    }
}
