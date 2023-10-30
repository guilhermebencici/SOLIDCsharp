using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MÉTODOS ESTATICOS, POR ISSO, NÃO HÁ NECESSIDADE DE INSTANCIAR OBJETO
            Console.WriteLine("Método Estático não precisa de um objeto instanciado!");
            Console.WriteLine("Soma = " + Calculadora.Somar(8,2));
            Console.WriteLine("Subtração = " + Calculadora.Subtrair(8, 2));

            // QUANDO O MÉTODO NAO É ESTATICO, É PRECISO INSTANCIA-LO PARA PODER USAR
            Calculadora x = new Calculadora();
            Console.WriteLine("Multiplicação = " + x.Multiplicar(2,5));

            Console.ReadLine();
        }
    }
}
