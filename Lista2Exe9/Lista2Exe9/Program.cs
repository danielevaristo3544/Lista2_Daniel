using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Exe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa dedicado a calcular a relação peso e altura de uma pessoa e exibir uma mensagem da situação

            int s;
            int p;
            int a;
            int r;

            Console.WriteLine(" Programa para calcular a relação peso e altura de uma pessoa ");
            Console.Write(" Digite o seu sexo: 1 para masculino e 2 para feminino ");
            s = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso em Kg: ");
            p = int.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura em cm: ");
            a = int.Parse(Console.ReadLine());

            double a1 = (a / 100.0);
            r = (int)(p / (a1 * a1));


            if (s == 1)
            {
                if (r < 20)
                {
                    Console.WriteLine(" Abaixo do peso ");
                }
                else
                {
                    if (r >= 20 && r <= 25)
                    {
                        Console.WriteLine(" O peso é ideal ");
                    }
                    else
                    {
                        Console.WriteLine(" Acima do peso ");
                    }

                }
            }
            else
            {
                if (r < 19)
                {
                    Console.WriteLine(" Abaixo do peso ");
                }
                else
                {
                    if (r >= 19 && r <= 24)
                    {
                        Console.WriteLine(" O peso é ideal ");
                    }
                    else
                    {
                        Console.WriteLine(" Acima do peso ");
                    }
                }
            }
        }
    }
}


