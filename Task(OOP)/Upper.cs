using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP_
{
    public class Upper
    {
        public static string FirstLetter(string x)
        {
            x = x.ToLower();
            char[] arr = x.ToCharArray();
            if (arr.Length >= 1)
            {
                if (char.IsLower(arr[0]))
                {
                    arr[0] = char.ToUpper(arr[0]);
                }
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == ' ')
                {
                    if (char.IsLower(arr[i]))
                    {
                        arr[i] = char.ToUpper(arr[i]);
                    }
                }
            }

            return new string(arr);
        }
    }
}
