using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Problem
{
    public interface IMammalProblem
    {
        void Walk();
        void Swim();
        void Fly();
        //Common methods for all mammals
        void Eat();
        void Sleep();
    }
}
