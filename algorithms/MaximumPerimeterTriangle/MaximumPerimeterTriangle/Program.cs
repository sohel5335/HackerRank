using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'maximumPerimeterTriangle' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY sticks as parameter.
     */

    public static void maximumPerimeterTriangle(List<int> sticks)
    {
        List<int> a = new List<int>();
        a = sticks.OrderBy(u=>u).ToList();
        //Array.Sort(sticks);
        int n = sticks.Count();
        int x, y, z;
        for (x = n - 3, y = n - 2, z = n - 1; a[x] + a[y] <= a[z]; x--, y--, z--)
        {
            if (x == 0)
            {
                Console.WriteLine(-1);
                return;
            }
        }
        Console.WriteLine("{0} {1} {2}", a[x], a[y], a[z]);
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

            Result.maximumPerimeterTriangle(sticks);



            //Console.ReadLine();

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
