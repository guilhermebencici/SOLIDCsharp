using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesacoplaento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var registraOcorrenciaConsole = new RegistroOcorrencia(new RegistrarNoConsole());

            registraOcorrenciaConsole.Registrar("Registro no Console");


            var registrarOcorrenciaArquivo = new RegistroOcorrencia(new RegistarNoArquivo(@"c:\dados\teste.txt"));
            registrarOcorrenciaArquivo.Registrar("Registro no Arquivo");

            Console.ReadLine();
        }
    }
}
