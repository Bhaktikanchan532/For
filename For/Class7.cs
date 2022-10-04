using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Class7
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Number");
            int num = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            while(num!=1)
            {
                factorial = factorial * num;
                num = num - 1;
            }
            Console.WriteLine($"Factorial is {factorial}");
        }
    }
}
