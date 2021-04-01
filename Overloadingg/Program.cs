using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadingg
{
  
        public class Numbers
        {

            public int FindMinimum(int number1, int number2)
            {
                return Math.Min(number1, number2);
            }

            public int FindMinimum(int number1, int number2, float number3)
            {
                int IntNumber3 = (int)number3;
                return Math.Min(number1, Math.Min(number2, IntNumber3));
            }

            public int FindMaximum(int number1, int number2)
            {
                return Math.Max(number1, number2);
            }

            public int FindMaximum(int number1, int number2, float number3)
            {
                int IntNumber3 = (int)number3;
                return Math.Max(number1, Math.Max(number2, IntNumber3));
            }
            
        }
      
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("minimum #1:  {0}", number.FindMinimum(3, 1));
            Console.WriteLine("minimum #2:  {0}", number.FindMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("maximum #1:  {0}", number.FindMaximum(3, 1));
            Console.WriteLine("maximum #1:  {0}", number.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
