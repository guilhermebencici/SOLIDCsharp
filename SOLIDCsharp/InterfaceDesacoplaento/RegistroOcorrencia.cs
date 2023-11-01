using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesacoplaento
{
    internal class RegistroOcorrencia
    {
        // ACOPLAMENTO FORTE, O QUE É RUIM.

        //public void RegistrarNoConsole(string mensagem)
        //{
        //    Console.WriteLine($"{mensagem} : {DateTime.Now}");
        //}

        //public void RegistrarNoArquivo(string arquivo, string mensagem)
        //{
        //    using (var streamWriter = new StreamWriter(arquivo, true))
        //    {
        //        streamWriter.WriteLine($"{mensagem} : {DateTime.Now}");
        //    }
        //}

        //public void RegistrarJson(string arquiv, string mensagem)
        //{
        //    //implementação
        //}


        // BAIXO ACOPLAMENTO, DEPOIS DA CRIAÇÃO DA INTERFACE

        private readonly IRegistro _registro;
        public RegistroOcorrencia(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistrarInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}
