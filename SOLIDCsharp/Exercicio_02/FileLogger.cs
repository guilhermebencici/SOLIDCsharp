using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"c:\dados\log\LogOcorrencias.txt",mensagem);
        }
    }
}
