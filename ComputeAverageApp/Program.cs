using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5;
            double roundOff, total, average;
            Console.WriteLine("Enter 5 grades separated by new line: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());   
            num4= Convert.ToInt32(Console.ReadLine());  
            num5 = Convert.ToInt32(Console.ReadLine());
            total = num1 + num2 + num3 + num4 + num5; 
            average = total/ 5;
            roundOff = Math.Round(average);
            Console.WriteLine("The average  is " + average + " round off to " + roundOff);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
