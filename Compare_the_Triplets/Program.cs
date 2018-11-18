using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long result = 0;
            foreach (var item in ar) result = result + item;

            return result;
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var aliceScore = (a[0] > b[0] ? 1 : 0) + (a[1] > b[1] ? 1 : 0) + (a[2] > b[2] ? 1 : 0);
            var bobScore = (b[0] > a[0] ? 1 : 0) + (b[1] > a[1] ? 1 : 0) + (b[2] > a[2] ? 1 : 0);
            return new List<int> { aliceScore, bobScore };
        }
        static void Main(string[] args)
        {
            var aliceList = new List<int>() { 5, 6, 7 };
            var bobList = new List<int>() { 3, 6, 10 };
           var result = compareTriplets(aliceList, bobList);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }
    }
}
