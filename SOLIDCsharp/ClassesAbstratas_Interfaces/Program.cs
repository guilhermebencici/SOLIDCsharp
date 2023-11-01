using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado("Quadrado primeiro");
            q.Desenhar();
            q.Identificar();

            Triangulo t = new Triangulo("Triangulo Primeiro");
            t.Desenhar();
            t.Identificar();
            t.Duplicar();
        }
    }
}
