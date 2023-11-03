using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calc = new Calcular();

            Console.WriteLine(calc.Somar(2,3));
            Console.WriteLine(calc.Somar(2, 3,5));

            Console.ReadLine();
        }
    }
}
