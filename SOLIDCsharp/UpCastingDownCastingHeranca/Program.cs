using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastingDownCastingHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UpCasting();

            Circulo circulo = new Circulo();
            Forma f = circulo; // este é o UPCASTING -> implícita

            Circulo c = (Circulo)f; // DownCasting -> explicito

            Console.WriteLine(c == f);
            Console.WriteLine(f == circulo);

            c.Desenhar();
            c.PintarCirculo();

            Console.ReadLine();
        }

        private static void UpCasting()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo; // este é o UPCASTING

            Console.WriteLine(f == circulo);
            f.Desenhar();
        }
    }
}
