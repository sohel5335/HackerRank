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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int f = lcm(a.ToArray());
        int l = gcd(b.ToArray());
        int count = 0;
        for (int i = f, j = 2; i <= l; i = f * j, j++)
        {
            if (l % i == 0) { count++; }
        }
        return count;
    }
    private static int gcd(int a, int b)
    {
        while (b > 0)
        {
            int temp = b;
            b = a % b; // % is remainder
            a = temp;
        }
        return a;
    }   
    private static int lcm(int a, int b)
    {
        return a * (b / gcd(a, b));
    }
    private static int gcd(int[] input)
    {
        int result = input[0];
        for (int i = 1; i < input.Count(); i++)
        {
            result = gcd(result, input[i]);
        }
        return result;
    }

    private static int lcm(int[] input)
    {           
        int result = input[0];
        for (int i = 1; i < input.Count(); i++)
        {
            result = lcm(result, input[i]);
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {


        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);
        //Console.ReadLine();
        //textWriter.Flush();
        //textWriter.Close();
    }
}
