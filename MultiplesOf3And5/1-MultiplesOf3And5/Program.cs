﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_MultiplesOf3And5
{
    #region Multiples of 3 and 5
    /*
     If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
     Find the sum of all the multiples of 3 or 5 below 1000.
    */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            int response = 0;
            for(int i=5; i< 1000; i += 5)
            {
                if (i % 3 != 0)
                    response += i;
            }
            for(int i = 3; i < 1000; i += 3)
            {
                response += i;
            }
            Console.WriteLine(response);
            Console.Read();
        }
    }
}
