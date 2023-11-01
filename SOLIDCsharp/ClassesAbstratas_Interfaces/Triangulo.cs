using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas_Interfaces
{
    internal class Triangulo : IFigura
    {
        public Triangulo(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public void Desenhar()
        {
            Console.WriteLine($"Desenhando {Nome}...");
        }

        public void Duplicar()
        {
            Console.WriteLine($"Duplicando o: {Nome}");
        }

        public void Identificar()
        {
            Console.WriteLine($"Sou o: {Nome}");
        }
    }
}
