using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaHeranca
{
    class Conta
    {
        public int Numero { get; set; }

        public int Saldo { get; set; }

        //CONSTRUTOR
        public Conta()
        {
            Console.WriteLine("Construtor da clase Conta (BASE)");
        }

        // POR SER PRIVATE, SÓ CONSIGO UTILIZAR DENTRO DA CLASSE
        private void GetSaldo()
        {
            Console.WriteLine($"O Saldo atual é de {Saldo} ");
        }

        // POR SER PROTECTED, CONSIGO UTILIZAR NA FILHA
        protected void GetSaldoPoupanca()
        {
            Console.WriteLine($"O saldo da poupança é de {Saldo}" );
        }

        string nomeConta = "Conta Normal";

        // MÉTODO CRIADO PARA TER SOBRECARGA NA FILHA
        protected virtual void GetNome()
        {
            Console.WriteLine($"Nome do dono da Conta {nomeConta}");
        }
    }

    class ContaPoupanca : Conta
    {
        string nomeConta = "Conta Poupança";
        public int JurosMensais { get; set; }

        // SOBRECARGA DO MÉTODO GETNOME()
        protected override void GetNome()
        {
            Console.WriteLine($"Nome do dono da Conta Poupança! {nomeConta}");
        }


        static void Main(string[] args)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Numero = 100;
            cp.Saldo = 2000;
            cp.GetSaldoPoupanca();
            cp.GetNome();
        }
    }
}
