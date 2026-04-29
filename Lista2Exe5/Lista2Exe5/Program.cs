using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa dedicado a calcular a área de um retângulo, onde o usuário irá informar a base e a altura do retângulo.
            // O programa deve exibir a área calculada e, caso a área seja maior ou menor que 100,
            // exibir uma mensagem indicando que o terreno é grande ou pequeno.
            int b;
            int h;
            int a;

            Console.Write(" Digite a base do retãngulo: ");
            b = int.Parse(Console.ReadLine());
            Console.Write(" Digite a altura do retângulo: ");
            h = int.Parse(Console.ReadLine());

            a = b * h;

            Console.WriteLine(" A área do retângulo é  : " + a);

            if (a > 100)
            {
                Console.WriteLine(" O terreno é grande ");
            }
            else
            {
                Console.WriteLine(" O terreno é pequeno ");
            }
        }
    }
}
