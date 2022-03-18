using System;
using Abstract_class__Interface__Polimorphism.Models;
namespace Abstract_class__Interface__Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[0]-Stop the prorgam\n[1]-Calc square area\n[2]-Calc rectangular are");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        double side = 0;
                        SideValue(ref side);
                        Square square1 = new Square(side);
                        Console.WriteLine($"Square area is:{(square1.CalcArea())}");

                        break;
                    case 2:
                        Console.Clear();
                        double width = 0;
                        double length = 0;
                        RectangularValue(ref width, ref length);
                        Rectangular Rectangular1 = new Rectangular(width,length);
                        Console.WriteLine($"Rectangular are is:{Rectangular1.CalcArea()}");
                        break;
                    default:
                        // code block
                        break;
                }
            } while (key !=0);
        }
        static void SideValue(ref double side)
        {
            Console.WriteLine("Enter Side");
            side = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (side > 0) break;
                else if(side==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Side cannot 0");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter true information:");
                    side = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Side can not be neagtive.!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter true information:");
                    side = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void RectangularValue(ref double width, ref double length)
        {
            Console.WriteLine("Enter width");
            width = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (width > 0) break;
                else if (width == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("width cannot 0");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter true information:");
                    width = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("width can not be neagtive.!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter true information:");
                    width = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (length > 0) break;
                else if(length == 0)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("width cannot 0");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter true information:");
                    length = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("length can not be neagtive.!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter true information:");
                    length = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
