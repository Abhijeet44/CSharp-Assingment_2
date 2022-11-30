using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.Assingment_2
{
    class PrintEvenNumbers
    {
        static void Main(string[] args)
        {
            int n = 121;
            int m = 229;

            for(int i=n; i<=m; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
