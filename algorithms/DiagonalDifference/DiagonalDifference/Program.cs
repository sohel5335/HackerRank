using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
         
            int n = arr[0].Count-1;
            int a = 0;
            int b = 0;
            for (int i=0;i<=n;i++)
            {
                 a+= arr[i][i];
                b += arr[i][n - i];
            }
             
            return Math.Abs( a-b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n =Convert.ToInt32( Console.ReadLine());
            List<List<int>> arr = new List<List<int>>();

            for (int i =0;i<n;i++)
            {
                arr.Add( Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList());
            }
            int result = Result.diagonalDifference(arr);


            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
