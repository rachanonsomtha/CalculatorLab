using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CPE200Lab1

{
    class RPNCalculatorEngine : CalculatorEngine
    {
        public string Process(string str)
        {
            string result = "0";
            Stack sumall = new Stack();
            string[] parts = str.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                if (isNumber(parts[i]))
                {
                    sumall.Push(parts[i]);
                }
                else if (isOperator(parts[i]))
                {
                    string second = sumall.Pop().ToString();
                    string first = sumall.Pop().ToString();
                    result = calculate(parts[i], first, second);
                    sumall.Push(result);
                }
            }
            return sumall.Pop().ToString();
        }


    }
}
