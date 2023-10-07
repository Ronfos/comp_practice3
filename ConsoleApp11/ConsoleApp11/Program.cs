using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пять слов:");
            string a1 = Convert.ToString(Console.ReadLine());
            string a2 = Convert.ToString(Console.ReadLine());
            string a3 = Convert.ToString(Console.ReadLine());
            string a4 = Convert.ToString(Console.ReadLine());
            string a5 = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"\n{a1}");
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.ReadKey();
        }
    }
}
