using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205_ch3
{
    class Program
    {
        enum WeekOfTheDay {Sunday, Monday = 7, Tuesday, Wednesday, Thursday = 50, Friday, Saturday };// define
        //an enumeration

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;

            DisplayFiveTime("MSSA");  //method call
            DisplayFiveTime("Lacey"); // 
            DisplaySum(6, 11);
            SolveQuadraticEquation(1, -3, 2); /// x^2-3x+2 = 0

            Console.WriteLine("Today is : " + MSSAweekOfTheDay.Thursday);
        }

        static void DisplaySum(int a, int b)
        {
            Console.WriteLine($"{a}+{b} = {a+b}");
        
        }
        static void SolveQuadraticEquation(double a, double b, double c)
        {
            double squareRootPart = Math.Sqrt(b * b - 4 * a * c);

            Console.WriteLine(((-1)*b + Math.Sqrt(b*b-4*a*c)) /(2*a));
            Console.Write(",");
            Console.WriteLine(((+1) * b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));

        }

        static void DisplayFiveTime(string str= "Pizza")
        {
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine(str);


         
        }


    }
}
