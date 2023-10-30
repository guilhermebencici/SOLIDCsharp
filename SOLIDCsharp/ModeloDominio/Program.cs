using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClienteRico cliente = new ClienteRico("",-1,null);

            Console.WriteLine($"{cliente.Id} {cliente.Nome} {cliente.Endereco}");
            Console.ReadLine();
        }

        private static ClienteAnemico ClienteAnemicoTeste()
        {
            ClienteAnemico cliente = new ClienteAnemico();
            cliente.Id = 10;
            cliente.Nome = "Gui";
            cliente.Endereco = "Rua dos bobo";
            return cliente;
        }
    }
}
