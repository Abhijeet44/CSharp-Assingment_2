using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_2
{
    class TableOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                int m = n * i;
                Console.WriteLine(n +  "*" + i + " = " + m);
            }
        }
    }
}
