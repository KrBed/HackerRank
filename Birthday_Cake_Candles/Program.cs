using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    // link to challenge :https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            List<int> arMax = new List<int>();
            int max = ar.Max();
            foreach (var candle in ar)
            {
                if (candle == max) arMax.Add(candle);
            }
            return arMax.Count;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("How old is your nicest");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Preparing candles");
            var candles = new int[years];
            for (int i = 0; i < candles.Length; i++)
            {
                var candle = rand.Next(1, years);
                candles[i] = candle;
                Console.Write(candle + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of the longest candles");

            Console.WriteLine(birthdayCakeCandles(candles));
            Console.ReadKey();

        }
    }
}
