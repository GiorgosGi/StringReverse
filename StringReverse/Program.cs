using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Giorgos";
            Console.WriteLine(StringReverse(name));
            Console.WriteLine(StringReverse2(name));
        }

        static string StringReverse(string s)
        {​​
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {​​
                result += s[i];
            }​​
            return (result);
        }​​

        static string StringReverse2(string s)
        {​​
                StringBuilder result = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {​​
                    result.Append(s[i]);
            }​​
                return (result.ToString());
        }​​

    }
}
