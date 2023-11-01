using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override void CalculaArea()
        {
            this.Area = Lado * Lado;
        }

        public override void CalculaPerimeto()
        {
            this.Perimeto = 4 * Lado;
        }
    }
}
