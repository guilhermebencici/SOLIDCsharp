using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesacoplaento
{
    internal class RegistarNoArquivo : IRegistro
    {
        private readonly string _caminhoNomeArquivo;
        public RegistarNoArquivo(string path)
        {
            _caminhoNomeArquivo = path;
        }
        public void RegistrarInfo(string mensagem)
        {
            Log(mensagem);
        }

        private void Log(string mensagem)
        {
            using(var streamWriter = new StreamWriter(_caminhoNomeArquivo, true))
            {
                streamWriter.WriteLine(mensagem);
            }
        }
    }
}
