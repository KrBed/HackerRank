using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_and__Orange
{
    class Program
    {
        //link to chellange https://www.hackerrank.com/challenges/apple-and-orange/problem

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            Console.WriteLine(countNumberOfFruits(s, t, a, apples));
            Console.WriteLine(countNumberOfFruits(s, t, b, oranges));
        }

        static int countNumberOfFruits(int s, int t, int treePosition, int[] fruits)
        {
            int counter = 0;
            foreach (var fruit in fruits)
            {
                int distance = fruit + treePosition;
                if (distance <= t && distance >= s) counter++;
            }

            return counter;
        }

        static void Main(string[] args)
        {
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            int[] apples = new int[] { -2, 2, 1 };
            int[] oranges = new int[] { 5, -6 };
            countApplesAndOranges(s, t, a, b, apples, oranges);
            Console.ReadKey();
        }
    }
}
