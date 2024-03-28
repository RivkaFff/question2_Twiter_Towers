using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2_Twiter_Towers
{
    abstract internal class Shape
    {
        protected int? width;
        protected int? height;
        public abstract void printSomething();
        public void askSizes()
        {
            height = 0;//initializes it for the while condition
            Console.WriteLine("enter width");
            width = int.Parse(Console.ReadLine());
            do //input until getting a valid height values
            {
                Console.WriteLine("enter height, it have to be bigger than 2 or equal to this");
                height = int.Parse(Console.ReadLine());
            } while (height < 2);
        }
    }
}
