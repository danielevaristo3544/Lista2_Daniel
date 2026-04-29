using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa de calculo de notas dos alunos e medias

            int p1;
            int p2;
            int m;


            Console.WriteLine(" Programa para cálculo de notas de alunos ");
            Console.Write(" Digite o 1ª nota: ");
            p1 = int.Parse(Console.ReadLine());
            Console.Write(" Digite o 2ª nota: ");
            p2 = int.Parse(Console.ReadLine());

            m = (p1 + (2 * p2)) / 3;

            if (m < 5)
            {
                Console.WriteLine(" O aluno está reprovado com média " + m);
            }
            else
            {
                Console.WriteLine(" O aluno está aprovado com média " + m);
            }

        }
    }
}

