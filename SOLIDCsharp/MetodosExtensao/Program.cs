using MetodosExtensao.Utils; // método de extensão funciona apenas com o using!
using System;

namespace MetodosExtensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto1 = "curso";
            var texto2 = "guilherme";

            // UTILIZANDO O MÉTODO DE EXTENSÃO!
            texto1 = texto1.CaixaAltaPrimeiraLetra();
            texto2 = texto2.CaixaAltaPrimeiraLetra();

            Console.WriteLine(texto1);
            Console.WriteLine(texto2);



            Console.Read();
        }
    }
}
