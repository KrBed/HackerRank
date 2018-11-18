using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
   // link to challenge https://www.hackerrank.com/challenges/plus-minus/problem
    class Program
    {

        static void plusMinus(int[] arr)
        {
            decimal positive = 0;
            decimal negative = 0;
            decimal zeros = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) positive++;
                else if (arr[i] < 0) negative++;
                else zeros++;
            }
            Console.WriteLine(Decimal.Round(positive/arr.Length,6));
            Console.WriteLine(Decimal.Round(negative / arr.Length,6));
            Console.WriteLine(Decimal.Round(zeros / arr.Length,6));
        }

        static void Main(string[] args)
        {
            int []array = new int[] { -4, 3, -9, 0, 4, 1 };
            plusMinus(array);
            Console.ReadKey();
        }
    }
}
