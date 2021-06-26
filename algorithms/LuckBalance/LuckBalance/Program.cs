using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckBalance
{
    class Result
    {

       

        public static int luckBalance(int k, List<List<int>> contests,int len)
        {
            int importantC=0,MaxLuck=0;
            List<int> tmparr =new List<int> ();
            for (int i=0;i<len;i++)
            {
                MaxLuck += contests[i][0];
                if (contests[i][1] == 1)
                {
                    importantC++;
                    int tmp = contests[i][0];
                    int tmplen = tmparr.Count;
                    for (int j=0;j< tmplen;j++)
                    {
                        if (tmparr[j]>tmp)
                        {
                            int a = tmparr[j];
                            tmparr[j] = tmp;
                            tmp = a;
                        }

                    }
                    tmparr.Add(tmp);
                }
            }

            int lowestWin = importantC - k;

            for (int i=0;i<lowestWin;i++)
            {
                MaxLuck -= (tmparr[i]+ tmparr[i]);
            }


            return MaxLuck;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstMultiInput = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32( firstMultiInput[0]);
            int k = Convert.ToInt32(firstMultiInput[1]);
            List<List<int>> contests = new List<List<int>>();
            for (int i=0;i<n;i++)
            {
                contests.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x=>Convert.ToInt32(x)).ToList());
            }
            int result = Result.luckBalance(k, contests, n);

            Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}
