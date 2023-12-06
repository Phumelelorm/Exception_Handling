using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" enter your first number ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your second ");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("your first divided by your second number = ");
                Console.WriteLine(number1 / number2);
            }
            catch (Exception e)  
            {
                Console.WriteLine(e.Message);
            
            } 
        }
    }
}
