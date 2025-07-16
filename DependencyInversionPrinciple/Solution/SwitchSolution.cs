using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Solution
{
    public class SwitchSolution
    {
        private ISwitchableSolution _switchable;
        public SwitchSolution(ISwitchableSolution switchable)
        {
            _switchable = switchable;
        }
        public void Toggle()
        {
            if (_switchable.IsOn)
            {
                _switchable.TurnOff();
            }
            else
            {
                _switchable.TurnOn();
            }
        }
    }
}
