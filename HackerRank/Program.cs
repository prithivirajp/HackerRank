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
using System.Data;
using HackerRank;
using System.Data.SqlTypes;

class Solution { 

    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice)
    {
        int[] result = new int[alice.Count()];
        for (int i = 0; i <= alice.Count() - 1; i++)
        {
            List<int> a = (from s in scores where s > alice[i] select s).Distinct().ToList();
            result[i] = a.Count + 1;
        }
        return result;
    }
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> a = new List<int>();
        a.AddRange(nums1);
        a.AddRange(nums2);
        //a = a.Distinct().ToList<int>();
        a.Sort();

        if (a.Count % 2 == 0)
        {
            return (double) (a[(a.Count / 2) - 1] + a[a.Count / 2]) / 2;
        }
        else
        {
          return (double)a[(int)Math.Floor((double)a.Count /2)];
        }

        



        return 0.00;

    }
    static void Main(string[] args)
    {
        try
        {

            PayAsia pa = new PayAsia();

            

            pa.CharMatch();

            //string[] copy = new string[] { "1", "2" };

           

            //string[] copyChild = new string[1];
            //var clonevar = copy.Clone();
            //copy.CopyTo(copyChild,0);

            //int a = 11;

            //copy[0] = "hi";

            ////throw new DivideByZeroException();

            //RoughWorks.abc = 9;
            //Derived n1 = new Derived();
            //BaseAbstract n12 = new Derived();

            //n1.AbsMethod();
            //n1.OwnMethod();
            //n1.BaseCommon();

            //n12.AbsMethod();
            //n12.BaseCommon();



            //    int[] result1 = new int[] { 1,1 };
            //    int[] result2 = new int[] { 2};
            //var a = FindMedianSortedArrays(result1, result2);


            // Algo.KnightMove(8, Tuple.Create<int, int>(0, 0));

            //Algo.NQueen(4);

            // string str = "ABABABABABABABABABAB1";
            //  Algo.StrongPasswordChecker(str);


            //Interface t = new Interface();
            //Iconcept t1 = new Interface();
            //t1.d();
            //t1.a();


            //int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            //Array.Sort(nums); // sorts array 
            //Array.Reverse(nums); // sorts array in descending order
            //Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
            //Console.WriteLine(Array.BinarySearch(nums, 8));// binary search 
            //Console.ReadLine();

            //newabstract1 newabs = new normal();

            //newabs.second();
            //newabs.first();

            //normal newnor = new normal();

            //newnor.second();
            //newabs.first();
            //int a;
            //DataTable dt = new DataTable();
            //a = new DataTable().CompDt();



            //int scoresCount = Convert.ToInt32(Console.ReadLine());

            //int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            //;
            //int aliceCount = Convert.ToInt32(Console.ReadLine());

            //int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
            //;
            //int[] result = climbingLeaderboard(scores, alice);

        }
        catch (ArgumentException ex)
        {

        }
        catch (SqlNullValueException ex)
        {

        }
        catch (DivideByZeroException ex)
        {

        }
        finally
        { }
    }
    
    class DataStore<Type1,Type2>
    {
        public Type1 Data { get; set; }
    }

}
