using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoHerancaUML
{
    internal class ContaCorrente : Conta
    {
        public double Limite { get; set; }

        public double DescontoJuros(double valorDesconto)
        {
            return Saldo - valorDesconto;
        }
    }
}
