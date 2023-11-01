using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas_Interfaces
{
    internal class Quadrado : Figura
    {
        public Quadrado(string nome) : base(nome) // herdando a prop Nome da classe abstrata(base)
        {
        }
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando {Nome}...");
            Duplicar(); // herdando o método Duplicar(); da classe abstrata(base)
        }

        public override void Identificar()
        {
            Console.WriteLine($"Sou o: {Nome}");
        }
    }
}
