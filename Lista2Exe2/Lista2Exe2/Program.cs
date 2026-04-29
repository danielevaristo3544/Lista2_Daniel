using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;       //  Programa para ler dois números inteiros e dizer qual é o maior ou se são iguais
            int b;

            Console.Write("Digite o 1º número inteiro:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número inteiro:");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Os números são iguais");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("O 1º número é maior.");
                }
                else
                {
                    Console.WriteLine("O 2º número é maior.");
                }
            }
        }
    }
}
