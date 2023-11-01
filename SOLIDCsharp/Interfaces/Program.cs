using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GravarXml gravar = new GravarXml();

            gravar.GravarArquivo();
            gravar.Nome();

            // usando interface para referenciar o objeto
            IGravar igravar = new GravarXml();
            igravar.GravarArquivo();
        }
    }
}
