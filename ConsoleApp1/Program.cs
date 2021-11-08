using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string S = Console.ReadLine();
            S = S.Replace(" ", string.Empty);

            char[] ar = S.ToCharArray();
            Array.Reverse(ar);
            string revS = new String(ar);

            if (S == revS)
            {
                Console.WriteLine("Данное предложение не является перевртышем");
            }
            else
            {
                Console.WriteLine("Данное предложение является перевртышем");
            }

            Console.ReadKey();
        }
    }
}
