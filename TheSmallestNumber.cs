using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthWork
{
    internal class TheSmallestNumber
    {

        public void SmallestNumber(int first, int second, int third)
        {
            if (first < second && first < third && first != second && first != third)
            {
                Console.WriteLine($"The smallest number is: {first}");
            }
            else if (second < first && second < third && second != first && second != third)
            {
                Console.WriteLine($"The smallest number is: {second}");
            }
            else if (third < first && third < second && third != first && third != second)
            {
                Console.WriteLine($"The smallest number is: {third}");
            }
            else
            {
                Console.WriteLine("The numbers are equals");
            }
        }

    }
}
