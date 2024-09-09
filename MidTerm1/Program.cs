using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User inputs each number
            Console.WriteLine("Enter a number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int third = Convert.ToInt32(Console.ReadLine());
            
            //if statement sorts through each, having exceptions for each of the three being greatest
            if (first > second && first > third)
            {
                Console.WriteLine(first + " is the largest number.");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine(second + " is the largest number.");
            }
            else 
            if (third > first && third > second)
            {
                Console.WriteLine(third + " is the largest number.");
            }
            else
            {
                //else handles when two or more identical numbers are entered
                Console.WriteLine("Two or more numbers are the same, and are greater.");
            }
            Console.ReadLine();
        }
    }
}
