using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            s = s.Replace(" ", string.Empty);
            char[] n = s.ToCharArray();
            Array.Reverse(n);
            string revS = new String(n);
            if (s == revS)
            {
                Console.WriteLine("Текущая строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Текущая строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
