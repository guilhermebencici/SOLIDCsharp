using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Guilherme");
            p1.Genero = "Masculino";
            p1.Idade = 19;

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Idade);
        }
    }
}
