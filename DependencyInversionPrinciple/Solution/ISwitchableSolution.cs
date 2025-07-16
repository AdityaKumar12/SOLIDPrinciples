using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Solution
{
    public interface ISwitchableSolution
    {
        bool IsOn { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
