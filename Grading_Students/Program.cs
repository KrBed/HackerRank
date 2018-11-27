using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    // link to challege https://www.hackerrank.com/challenges/grading/problem
    class Program
    {

        static int[] gradingStudents(int[] grades)
        {
            int[] finalGrades = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38) finalGrades[i] = grades[i];
                else
                {
                    var difference = 5 - (grades[i] % 5);
                    if (difference < 3) finalGrades[i] = grades[i] + difference;
                    else finalGrades[i] = grades[i];
                }
            }

            return finalGrades;
        }
        static void Main(string[] args)
        {
            int[] grades = new int[] { 73, 67, 38, 33 };
            int[] result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadKey();
        }
    }
}
