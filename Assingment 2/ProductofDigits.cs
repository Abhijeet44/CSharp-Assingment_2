using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_2
{
    class ProductofDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());
            int product = 1;

            while (n != 0)
            {
                product = product * (n % 10);
                n = n / 10; 
            }
            Console.WriteLine("Product : " + product);
        }
    }
}
