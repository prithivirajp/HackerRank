using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using HackerRank;


namespace HackerRank
{
#region Interface
     class Interface : Iconcept, Iconcept1
    {
        void Iconcept.a()
        {
        }
        void Iconcept1.a()
        {

        }
        public int b()
        {
            return 1;
        }
        public int c()
        {
            return 1;
        }

        public int d()
        {
            return 1;
        }
        public int my()
        {
            return 1;
        }


    }


    interface Iconcept
    {
         void a();

        int b();
        int c();
        int d();



    }
    interface Iconcept1
    {
        void a();

        int b();
        int c();


    }

}
#endregion


#region Abstract
abstract class BaseAbstract
 {

    private int basevar = 0;
    public  virtual  int BaseCommon()
    {

       return  basevar = 100;

    }

    public abstract void AbsMethod();


}

class Derived : BaseAbstract
{



    public  override  void AbsMethod()
    {

    }

    public void OwnMethod()
    {

    }

    public  override int BaseCommon()
    {
       int a =  base.BaseCommon();
        return a;
    }



}
class Derived2 : Derived
{



    public override void AbsMethod()
    {

    }

    public void OwnMethod()
    {

    }

    public override  int BaseCommon()
    {
        int a = base.BaseCommon();
        return a;
    }



}




#endregion

#region static
class NewStatic
{

    public static int b = 5;
    public  int c = 5;

    private static void a() 
{
        b = b++;


    }

}


#endregion

#region ExtentionMethod
public static class exten
{

    public static int CompDt(this DataTable a)

      {
        DataTable dt = new DataTable();
        dt.Columns.Add("1");
        dt.Columns.Add("2");
        dt.Rows.Add( "hi", "hello");
        return 1;

       }
}
#endregion

#region RoughWork
public static class Algo
{
    public static int StrongPasswordChecker(string s)
    {
        int p = 3;
        bool a = true;
        bool A = true;
        bool num = true;

        if (s.Length >= 6 && s.Length <= 20)
        { }
        else if (s.Length < 6)
            return 6 - s.Length;
        else if (s.Length > 20)
            return s.Length - 20;

        for (int i = 0; i <= s.Length - 1; i++)
        {

            if ((int)s[i] >= 97 && (int)s[i] <= 122 && a)
            {
                p -= 1;
                a = false;
            }
            else if ((int)s[i] >= 65 && (int)s[i] <= 90 && A)
            {
                p -= 1;
                A = false;
            }
            else if ((int)s[i] >= 49 && (int)s[i] <= 57 && num)
            {
                p -= 1;
                num = false;
            }

            if (i + 2 <= s.Length && s[i] == s[i + 1] && s[i] == s[i + 2])
            {
                if (a)
                {
                    p -= 1;
                    a = false;
                }
                else if (A)
                {
                    p -= 1;
                    A = false;

                }
                else if (num)
                {
                    p -= 1;
                    num = false;
                }

                p += 1;
                i = i + 2;
            }


        }

        return p;

    }


    public static void NQueen(int N)
    {
        if (N > 1)
        {
            int[,] MatQueen = new int[N ,N];

            for (int i = 0; i <= N - 1; i++)
            {
                for (int j = i==0?i+1:0 ; j <= N - 1; j++)
                {
                    if (i - 1 >= 0 && MatQueen[i - 1, j] == 1)
                    {
                        if (j + 2 < N - 1)
                        {
                            MatQueen[i, j + 2] = 1;
                            break;
                        }
                        else
                        {
                            MatQueen[i, 0] = 1;
                            break;
                        }
                    }
                    else if(i - 1 < 0 ){
                        MatQueen[i, 1] = 1;
                        break;

                    }
                   
                }
            }
            for (int i = 0; i <= N-1; i++)
            {
                for (int j = 0; j <= N-1; j++)
                {
                    Console.Write(MatQueen[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("1");
        }
    }

    public static void KnightMove(int N, Tuple<int,int> pos)
    {
        string[,] KnightMove = new string[N, N];
        int row = pos.Item1;
        int col = pos.Item2;
        KnightMove[row, col] = "0";
        int count = 1;
        for (int i = 0; i < N*N -1; i++)
        {
            if ((row + 2 >= 0 && row + 2 < N) && (col + 1 >= 0 && col + 1 < N) && string.IsNullOrEmpty(KnightMove[row + 2, col + 1]))
            {
                KnightMove[row + 2, col + 1] = count.ToString();
                row += 2;
                col += 1;
                count = count + 1;
            }
            else if ((row + 1 >= 0 && row + 1 < N) && (col + 2 >= 0 && col + 2 < N) && string.IsNullOrEmpty(KnightMove[row + 1, col + 2]))
            {
                KnightMove[row + 1, col + 2] = count.ToString();
                row += 1;
                col += 2;
                count = count + 1;
            }
            else if ((row - 1 >= 0 && row - 1 < N) && (col + 2 >= 0 && col + 2 < N) && string.IsNullOrEmpty(KnightMove[row - 1, col + 2]))
            {
                KnightMove[row - 1, col + 2] = count.ToString();
                row -= 1;
                col += 2;
                count = count + 1;

            }
            else if ((row - 2 >= 0 && row - 2 < N) && (col + 1 >= 0 && col + 1 < N) && string.IsNullOrEmpty(KnightMove[row - 2, col + 1]))
            {
                KnightMove[row - 2, col + 1] = count.ToString();
                row -= 2;
                col += 1;
                count = count + 1;

            }
            
            else if ((row - 2 >= 0 && row - 2 < N) && (col - 1 >= 0 && col - 1 < N) && string.IsNullOrEmpty(KnightMove[row - 2, col - 1]))
            {
                KnightMove[row - 2, col - 1] = count.ToString();
                row -= 2;
                col -= 1;
                count = count + 1;

            }

            else if ((row - 1 >= 0 && row - 1 < N) && (col - 2 >= 0 && col - 2 < N) && string.IsNullOrEmpty(KnightMove[row - 1, col - 2]))
            {

                KnightMove[row - 1, col - 2] = count.ToString();
                row -= 1;
                col -= 2;
                count = count + 1;
            }
            else if ((row + 1 >= 0 && row + 1 < N) && (col - 2 >= 0 && col - 2 < N) && string.IsNullOrEmpty(KnightMove[row + 1, col - 2]))
            {
                KnightMove[row + 1, col - 2] = count.ToString();
                row += 1;
                col -= 2;
                count = count + 1;

            }
            else if ((row + 2 >= 0 && row + 2 < N) && (col - 1 >= 0 && col - 1 < N) && string.IsNullOrEmpty(KnightMove[row + 2, col - 1]))
            {

                KnightMove[row + 2, col - 1] = count.ToString();
                row += 2;
                col -= 1;
                count = count + 1;
            }
           
            

        }




        for (int i = 0; i <= N - 1; i++)
        {
            for (int j = 0; j <= N - 1; j++)
            {
                Console.Write((string.IsNullOrEmpty(KnightMove[i, j])? "-" : KnightMove[i, j]) + "\t");
            }
            Console.WriteLine();
        }
    }

}

public static class RoughWorks
{

    public static int abc;
    static RoughWorks()
    {
        Hashtable h = new Hashtable();
        
        Dictionary<string, string> a = new Dictionary<string, string>();
        HashSet<int> h1 = new HashSet<int>();
       
        int n, i, m = 0, flag = 0;
        Console.Write("Enter the Number to check Prime: ");
        n = int.Parse(Console.ReadLine());
        m = n / 2;
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.Write("Number is not Prime.");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("Number is Prime.");

        string num;
        num = "hello How are you How are You";
        //int sam = (int)num;
        StringBuilder sb = new StringBuilder();
        StringBuilder sb1 = new StringBuilder();
        char[] spearator = { ' ' };
        num = num.ToLower();
        string[] arr = num.Split(spearator).ToArray();
        Array.Reverse(arr);
        arr = arr.Distinct().ToArray();

        foreach (string s in arr)
        {
            for (int ii = 0; ii < s.Length; ++ii)
            {
                StringBuilder subString = new StringBuilder(s.Length - ii);
                for (int j = ii; j < s.Length; ++j)
                {
                    subString.Append(s[j]);
                    Console.Write(subString + " ");
                }
            }

            string Palindrome = s.ToString().ToUpper();
            char[] charArray = Palindrome.ToCharArray();
            Array.Reverse(charArray);
            sb.Append(new string(charArray) + " ");
            if (new string(charArray) == Palindrome)
            {
                Console.Write("Palindrome ");
            }
        }




        h.Add(1, 2);
        h.Add(6, 2);

        h1.Add(1);
        h1.Add(2);
        h1.Add(2);
        h1.Add(2); h1.Add(2);
        h1.Add(3);

        ArrayList tt = new ArrayList();
        tt.Add(1);
        tt.Add(2);
        tt.Sort();

        tt.Insert(tt.IndexOf(2), 3);
        tt.Reverse();

        LinkedList<int> k = new LinkedList<int>();
    }
    }
#endregion
