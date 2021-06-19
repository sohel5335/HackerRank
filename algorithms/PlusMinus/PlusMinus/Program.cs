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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double p=0, m=0, z=0;
        int n = arr.Count;
        foreach (int e in arr)
        {
            if (e>0)
            {
                p++;
            }
            else if (e < 0)
            {
                m++;
            }
            else
            {
                z++;
            }
       

        }
        Console.WriteLine((p/n).ToString("0.#####"));
        Console.WriteLine((m/n).ToString("0.#####"));
        Console.WriteLine((z/n).ToString("0.#####"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
        //Console.ReadLine();
    }
}
