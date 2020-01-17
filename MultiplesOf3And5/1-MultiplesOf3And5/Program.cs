using System;
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
            int[] numberList = new int[1000];
            int response = 0;
            for(int i = 0; i<1000; i++)
            {
                numberList[i] = i;
            }
            List<int> responseList = numberList.Where(x => x % 3 == 0 || x % 5 == 0).ToList();
            foreach(var number in responseList)
            {
                Console.WriteLine(number);
                response += number;
            }
            Console.WriteLine("Toplam => " + response);
            Console.Read();
        }
    }
}
