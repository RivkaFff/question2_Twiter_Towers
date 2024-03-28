using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2_Twiter_Towers
{
    internal class Triangle : Shape
    {
        private void printLine(int? numPoint)//prints a line in the triangle.
        {
            for (int i = 0; i < (width - numPoint) / 2; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < numPoint; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        public override void printSomething()
        {
            int choice = 2;
            double size;
            do
            {
                Console.WriteLine("if you want printing of the triangle's perimeter enter 1, if you want printing of the triangle enter 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        if (width % 2 == 0 || width > height * 2)

                            Console.WriteLine("sorry, it impossible to print the triangle");

                        else
                        {
                            printLine(1);
                            int? numRowTypes = (width / 2 - 1);//calcs how many types of lines ther is - ordered by the number of asterisks in every line.
                            int? numRowsOfOneType = (height - 2) / numRowTypes;//calcs how many rows there is from regular type.
                            int? currentNumAsterisksInLine = 3;
                            int? numLeftRows = height - (numRowTypes * numRowsOfOneType + 2);//rows that left after the calculations.
                            for (int i = 0; i < numRowTypes; i++)
                            {
                                for (int j = 0; j < numRowsOfOneType; j++)
                                {
                                    printLine(currentNumAsterisksInLine);
                                }
                                while (currentNumAsterisksInLine == 3 && numLeftRows > 0)
                                {
                                    printLine(3);
                                    numLeftRows--;
                                }
                                currentNumAsterisksInLine += 2;

                            }
                            printLine(width);
                        }
                        break;
                    case 1:
                        size = Math.Sqrt(Math.Pow((double)width / 2, 2) + Math.Pow((double)height, 2));//calcs the size by the Pythagorean theorem
                        Console.WriteLine($"The perimeter is: {(size * 2 + width)}");
                        break;
                    default:
                        Console.WriteLine("Enter your choice again");
                        break;
                }
            } while (!(choice == 1 || choice == 0));

        }
    }
}
