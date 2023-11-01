using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado();
            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe a cor da figura: ");
            q.Cor = Console.ReadLine();

            Console.WriteLine("Informe o lado do quadrado: ");
            q.Lado = Convert.ToInt32(Console.ReadLine());

            q.CalculaPerimeto();
            q.CalculaArea();

            Console.WriteLine($"A área do quadrado é:  { q.Area} m2 ");
            Console.WriteLine($"O Perímetro do quadrado é:  {q.Perimeto} m ");
            Console.WriteLine($"A cor do quadrado é:  {q.Cor}");

            Console.ReadLine();
        }
    }
}
