using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoSobrecarga
{
    internal class Calcular
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        // POLIMORFISMO - SOBRECARGA DO MESMO MÉTODO (PARAMETROS DIFERENTES)
        public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }
    }
}
