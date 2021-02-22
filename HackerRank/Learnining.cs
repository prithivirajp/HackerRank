using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Learnining
    {
    }

    public static class Calculator
    {
        private  int _resultStorage = 0;

        public  string Type = "Arithmetic";

        public  int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public  void Store(int result)
        {
            _resultStorage = result;
        }
    }
}
