using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figuras = new List<Figura>
            {
                new Triangulo(),
                new Circulo()
            };
            foreach(var figura in figuras)
            {
                figura.Desenhar();
            }

            Console.ReadLine();
        }
    }
}
