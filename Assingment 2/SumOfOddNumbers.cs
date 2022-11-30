using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_2
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

