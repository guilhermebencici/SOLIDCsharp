using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorSealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculaSoma soma = new CalculaSoma();
            var resultado = soma.Somar(10, 30);

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
