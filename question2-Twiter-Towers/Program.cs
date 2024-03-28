
using System;
using System.Collections;
using System.Drawing;
using System.Linq.Expressions;

namespace question2_Twiter_Towers
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            int choice;
            do//remains in the menu until getting an input of 3
            {
                Console.WriteLine("main menu: for rectangle enter 1, for triangle enter 2, if you want to exit from the menu enter 3");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        shape = new Rectangle();
                        shape.askSizes();
                        shape.printSomething();
                        break;
                    case 2:
                        shape = new Triangle();
                        shape.askSizes();
                        shape.printSomething();
                        break;
                    case 3:
                        Console.WriteLine("Exsiting");
                        break;
                    default:
                        Console.WriteLine("wrong choice, returns to the main menue...");
                        break;
                }
            }
            while (choice != 3);
        }

    }
}