using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Max_Sum
{

    // link to challenge :https://www.hackerrank.com/challenges/mini-max-sum/problem
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            long sum = 0;
            long max = arr[0];
            long min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine(sum - max + " " + (sum - min));
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            miniMaxSum(arr);
            Console.ReadLine();
        }
    }
}
