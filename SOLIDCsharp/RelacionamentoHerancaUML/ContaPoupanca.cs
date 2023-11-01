using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoHerancaUML
{
    internal class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; set; }

        public double CredtoJuros(double valorJuros)
        {
            return Saldo + valorJuros;
        }
    }
}
