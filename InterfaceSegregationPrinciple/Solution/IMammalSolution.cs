using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Solution
{
    public interface IMammalSolution
    {
        //Common methods for all mammals
        void Eat();
        void Sleep();
    }
}
