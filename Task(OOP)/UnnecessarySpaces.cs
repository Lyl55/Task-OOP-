using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP_
{
    public class UnnecessarySpaces
    {
        public static string RemoveExtraSpaces(string input)
        {
            string x = "";
            bool LastCharSpace = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' && LastCharSpace)
                {
                    continue;
                }
                LastCharSpace = input[i] == ' ';
                x += input[i];
            }
            return x;
        }
    }
}
