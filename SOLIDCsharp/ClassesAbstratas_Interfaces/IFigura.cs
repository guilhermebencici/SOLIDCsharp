using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas_Interfaces
{
    internal interface IFigura
    {
        string Nome { get; set; }

        void Desenhar();
        void Identificar();
        void Duplicar();
    }
}
