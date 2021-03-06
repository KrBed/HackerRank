﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    //Link to challenge https://www.hackerrank.com/challenges/kangaroo/problem
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {

            if (x2 >= x1 && v2 > v1) return "NO";

            while (x1 <= x2)
            {
                x1 += v1;
                x2 += v2;
                if (x1 == x2) return "YES";
            }
            return "NO";

        }

        static void Main(string[] args)
        {
            string[] x1V1X2V2 = new string[] { "0", "3", "4", "2" };

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
