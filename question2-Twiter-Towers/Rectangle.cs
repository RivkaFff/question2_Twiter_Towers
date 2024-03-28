using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2_Twiter_Towers
{
    internal class Rectangle : Shape
    {
        public override void printSomething()
        {
            if (height == width || Math.Abs(Convert.ToDecimal(height - width)) > 5)
            {
                Console.WriteLine($"The area is: {height * width}");
            }
            else
            {
                Console.WriteLine($"The perimeter is: {height * 2 + width * 2}");
            }

        }
    }
}
