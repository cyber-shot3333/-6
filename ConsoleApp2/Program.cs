using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static bool IsPolyndrome(string input)
        {
            string tmp = input.Replace(" ", "");
            return tmp == Reverse(tmp);
        }

        static string Reverse(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
                sb.Append(input[i]);
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPolyndrome("а роза упала на лапу азора") ? "yes" : "no");
            Console.ReadLine();
        }
    }
}

