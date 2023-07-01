using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthWork
{
    internal class Rectangle
    {

        public double AreaCalculator(double firstSide, double secondSide)
        {
            double result = firstSide * secondSide;
            return result;

        }

        public double PerimeterCalculator(double firstSide, double secondSide)
        {
            
            double result = (firstSide + secondSide) * 2;
            return result;
        }

    }
}
