using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_2
{
    class NumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while(n != 0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("Number of Digits are : " + count);
        }
    }
}
