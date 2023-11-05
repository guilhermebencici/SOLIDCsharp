using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Exemplo
{
    internal class CadastrarCliente : IPersistencia, IMensagemEmail
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Envia Email");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salva Dados");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Valida Dados");
        }
    }
}
