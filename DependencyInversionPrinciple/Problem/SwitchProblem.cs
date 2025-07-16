using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Problem
{
    public class SwitchProblem
    {
        private BulbProblem _bulb;
        public SwitchProblem(BulbProblem bulb)
        {
            _bulb = bulb;
        }
        public void TurnOn()
        {
            _bulb.TurnOnBulb();
        }
        public void TurnOff()
        {
            _bulb.TurnOffBulb();
        }
        public void Toggle()
        {
            if (_bulb.IsOn)
            {
                _bulb.TurnOffBulb();
            } 
            else             
            {
                _bulb.TurnOnBulb();
            }
        }
    }
}
