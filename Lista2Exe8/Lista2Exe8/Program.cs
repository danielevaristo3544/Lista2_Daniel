
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Exe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa dedicado a identificar um triângulo retângulo através de 03 entradas

            int a;
            int b;
            int c;


            Console.WriteLine(" Programa para identificar um triângulo retângulo através de suas 03 entradas ");
            Console.Write(" Digite o 1º lado: ");
            a = int.Parse(Console.ReadLine());
            Console.Write(" Digite o 2º lado: ");
            b = int.Parse(Console.ReadLine());
            Console.Write(" Digite o 3º lado: ");
            c = int.Parse(Console.ReadLine());

            if ((a * a) + (b * b) == (c * c) || (a * a) + (c * c) == (b * b) || (b * b) + (c * c) == (a * a))
            {
                Console.WriteLine(" Os lados formam um triângulo retângulo ");
            }
            else
            {
                Console.WriteLine(" Os lados não formam um triângulo retângulo ");
            }
        }
    }
}
