using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoHerancaUML
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public double Sacar(double valorSaque)
        {
            return Saldo - valorSaque;
        }

        public double Depositar(double valorDeposito)
        {
            return Saldo + valorDeposito;
        }
    }
}
