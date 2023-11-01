using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionamentoHerancaUML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = cp.Depositar(110);
            cp.Saldo = cp.Sacar(10);
            Console.WriteLine($"Poupança: {cp.CredtoJuros(5)}");

            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = cc.Depositar(110);
            cc.Saldo = cc.Sacar(10);
            Console.WriteLine($"Conta Corrente: {cc.DescontoJuros(10)}");



            Console.ReadLine();
            
        }
    }
}
