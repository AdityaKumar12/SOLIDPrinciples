using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Problem
{
    public class AreaProblem
    {
        public void RectangleArea(double Width, double Height)
        {
            double area = Width * Height;
            Console.WriteLine($"Area of Rectangle: {area}");
        }

        public void CircleArea(double Radius)
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Area of Circle: {area}");
        }
    }
}
