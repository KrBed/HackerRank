using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        // link to challenge : https://www.hackerrank.com/challenges/staircase/problem
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int numberOfEmptySpaces = n - i;

                var counter = 1;
                var stair = "";

                while (counter <= n)
                {
                    stair += counter < numberOfEmptySpaces ? " " : "#";
                    counter++;
                }

                Console.WriteLine(stair);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give number of stairs");
            int stairs = Convert.ToInt32(Console.ReadLine());
            staircase(stairs);
            Console.ReadKey();
        }
    }
}
