using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{

    //link to challenge: https://www.hackerrank.com/challenges/time-conversion/problem
    class Program
    {

        static string timeConversion(string s)
        {
            if (s.Contains("AM")) return AmConversion(s);
            return PmConversion(s);

        }

        private static string PmConversion(string s)
        {
            var time = s.Remove(8, 2).Split(':');
            if (time[0] != "12") time[0] = Convert.ToString(Convert.ToInt32(time[0]) + 12); 
            
            return String.Join(":", time, 0, time.Length);
        }

        private static string AmConversion(string s)
        {
            if (s == "12:00:00AM") return "00:00:00";

            var time = s.Remove(8, 2).Split(':');
            if (time[0] == "12") time[0] = "00";

            return String.Join(":", time, 0, time.Length);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter date with format: [07:05:45AM]");//07:05:45AM
            string s = Console.ReadLine();
            string result = timeConversion(s);

            Console.WriteLine(result);
        }
    }
}
