using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa de calculo de notas dos alunos e recomposição para se chegar a aprovação
            // Se a nota for menor que 5, calcula a nota necessária para chegar a 10,
            // caso contrário, a nota de recomposição é 0

            int p1;
            int p2;

            Console.WriteLine(" Programa para cálculo de recomposição de notas de alunos ");
            Console.Write(" Digite o 1ª nota: ");
            p1 = int.Parse(Console.ReadLine());

            if (p1 < 5)
            {
                p2 = (10 - p1);
                Console.WriteLine(" O aluno estará aprovado na 2ª prova com nota:  " + p2);
            }
            else
            {
                Console.WriteLine(" O aluno não precisa fazer a 2ª prova, pois já está aprovado com nota: " + p1);
            }

        }
    }
}
