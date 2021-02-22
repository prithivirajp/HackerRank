using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank
{
    class  PayAsia
    {

        public void NumberTimes()
        {
            int? numFind = null;
            int count = 0;
            int[] arrNumbers;
            Console.WriteLine("Enter the total number and list of number to search");
            arrNumbers = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arrNumbers.Length; i++)
                arrNumbers[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number to find");
            numFind = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                if (numFind != null && numFind == arrNumbers[i])
                    count++;
            }
            Console.WriteLine("{0} Times", count);
            Console.ReadLine();
        }

        public void Numbercompare()
        {

            int[] arrNumbers;
            Console.WriteLine("Enter the total number and list of number to search");
            arrNumbers = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arrNumbers.Length; i++)
                arrNumbers[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The numbers:");
            for (int i = 0; i < arrNumbers.Length - 1; i++)
            {
                if (arrNumbers[i] > arrNumbers[i + 1])
                    Console.WriteLine("{0}", arrNumbers[i]);
            }
            Console.ReadLine();
        }

        public void CharacterTimes()
        {
            int count = 0;
            char ch;
            string[] arrStrings;
            Console.WriteLine("Enter the charcter and count ");
            ch = Convert.ToChar(Console.ReadLine());
            count = Convert.ToInt32(Console.ReadLine());
            arrStrings = new string[count];
            for (int i = 0; i < arrStrings.Length; i++)
                arrStrings[i] = Convert.ToString(Console.ReadLine());

            count = 0;
            for (int i = 0; i < arrStrings.Length; i++)
            {
                if (arrStrings[i].Contains(ch.ToString()))
                {
                    char[] charArray = arrStrings[i].ToCharArray();
                    foreach (char c in charArray)
                    {
                        if (c == ch)
                            count++;
                    }
                }

            }
            Console.WriteLine("{0} Times", count);
            Console.ReadLine();
        }

        public void SuperFactory()
        {
            try
            {
                int numInputRes = 0;
                string[] arrFactory;
                Dictionary<string, string> Factories = new Dictionary<string, string>();
                Factories.Add("F1", "(x^3-4x+17)%1000");
                Factories.Add("F2", "(-2x^2+5x-1)%1000");
                Factories.Add("F3", "(3x^2-7x+3)%1000");

                Console.WriteLine("Enter Input");
                numInputRes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the total factory List and Orders");
                arrFactory = new string[Convert.ToInt32(Console.ReadLine())];
                for (int i = 0; i < arrFactory.Length; i++)
                    arrFactory[i] = Convert.ToString(Console.ReadLine());

                for (int i = 0; i < arrFactory.Length; i++)
                {

                    if (arrFactory[i] != null && (Factories.ContainsKey(arrFactory[i])))
                    {
                        string expression = Factories[arrFactory[i]];
                        expression = expression.Replace("x^2", "*" + Math.Pow(numInputRes, 2).ToString());
                        expression = expression.Replace("x^3", "*" + Math.Pow(numInputRes, 3).ToString());
                        expression = expression.Replace("x", "*" + numInputRes.ToString());
                        expression = expression.Replace("(*", "(");
                        numInputRes = Convert.ToInt32(new DataTable().Compute(expression, null));
                    }

                }
                Console.WriteLine("Result is {0}", numInputRes);
            }

            catch (Exception ex)
            {


            }


        }

        public void DoubleMatrix()
        {
            int N;
            int M;

            Console.WriteLine("Enter the No of rows and columns ");
            N = Convert.ToInt32(Console.ReadLine());
            M = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[N, M * 2];
            Console.WriteLine("Enter the Values");
            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine();
                string[] row = line.Split(' ').ToArray();
                for (int j = 0; j < row.Length; j++)
                {
                    Int32.TryParse(row[j], out matrix[i, j]);
                    Int32.TryParse(row[j], out matrix[i, j + M]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M * 2; j++)
                {
                    Console.Write("{0} \t", matrix[i, j]);
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();

        }

        public void OnlineTest()
        {
            try
            {
                int i = 0;
                int[] myArray = { i, 20, 30, 40 };
                while (true)
                {
                    Hashtable h = new Hashtable();

                    h.Add("1", 2);
                }
                Console.WriteLine(myArray[5]);
                
            }
            catch (IndexOutOfRangeException ex1)
            {
            }
            catch (StackOverflowException ex1)
            {

            }
            catch (Exception ex)
            {

            }


        }

        public void CharMatch()

        {
            try
            {
                Tuple<int, char>[] lettersMap = new Tuple<int, char>[26];
                lettersMap[0] = Tuple.Create(2, 'A');
                lettersMap[1] = Tuple.Create(2, 'B');
                lettersMap[2] = Tuple.Create(2, 'C');
                lettersMap[3] = Tuple.Create(3, 'D');
                lettersMap[4] = Tuple.Create(3, 'E');
                lettersMap[5] = Tuple.Create(3, 'F');
                lettersMap[6] = Tuple.Create(4, 'G');
                lettersMap[7] = Tuple.Create(4, 'H');
                lettersMap[8] = Tuple.Create(4, 'I');
                lettersMap[9] = Tuple.Create(5, 'J');
                lettersMap[10] = Tuple.Create(5, 'K');
                lettersMap[11] = Tuple.Create(5, 'L');
                lettersMap[12] = Tuple.Create(5, 'M');
                lettersMap[13] = Tuple.Create(6, 'N');
                lettersMap[14] = Tuple.Create(6, 'O');
                lettersMap[15] = Tuple.Create(6, 'P');
                lettersMap[16] = Tuple.Create(7, 'Q');
                lettersMap[17] = Tuple.Create(7, 'R');
                lettersMap[18] = Tuple.Create(7, 'S');
                lettersMap[19] = Tuple.Create(8, 'T');
                lettersMap[20] = Tuple.Create(8, 'U');
                lettersMap[21] = Tuple.Create(8, 'V');
                lettersMap[22] = Tuple.Create(8, 'W');
                lettersMap[23] = Tuple.Create(9, 'X');
                lettersMap[24] = Tuple.Create(9, 'Y');
                lettersMap[25] = Tuple.Create(9, 'Z');

                string[] validwords = new string[1];

                string[] validwordsCopy = new string[1];

                for (int i = 0; i < validwords.Length ; i++)
                {
                    validwords[i] = Console.ReadLine();
                }

                
                validwordsCopy = (string[])validwords.Clone();

                String strFind = Console.ReadLine();
                ArrayList result = new ArrayList();


                for (int j = 0; j < validwordsCopy.Length; j++)
                {
                    
                    for (int i = 0; i < validwordsCopy[j].Length; i++)
                    {
                        var value = (from ch in lettersMap
                                     where ch.Item2 == validwordsCopy[j][i]
                                     select ch.Item1).ToList();

                        validwordsCopy[j]=  validwordsCopy[j].Replace(validwordsCopy[j][i], value[0].ToString().ToCharArray()[0]);
                        

                    }
                }

                for (int i = 0; i < validwordsCopy.Length; i++)
                {
                    if (strFind.ToString() == validwordsCopy[i].ToString())
                    {
                        result.Add(validwordsCopy[i].ToString());
                    }

                }

            }
            catch (Exception ex)            
           {
                
            }

        }

    }
 }
  


