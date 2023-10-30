using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosSobrecarga
{
    internal class Program
    {
        static public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static public double Somar(double numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static public int Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach(var numero in numeros)
                resultado += numero;
            return resultado;
        }

        static void Main(string[] args)
        {
            var resultado1 = Somar(100, 100);
            var resultado2 = Program.Somar(100, 200, 300);
            var resultado3 = Somar(new int[] { 1, 2, 3 });

            Console.WriteLine($"{resultado1} {resultado2} {resultado3}");
            Console.ReadLine();
        }
    }
}
