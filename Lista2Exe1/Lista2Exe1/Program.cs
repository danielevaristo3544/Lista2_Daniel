using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Digite o 1º número:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número:");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("O 1º número é maior:");
            }
            else
            {
                Console.WriteLine("O 2º múmero é maior:");
            }

        }
    }
}
