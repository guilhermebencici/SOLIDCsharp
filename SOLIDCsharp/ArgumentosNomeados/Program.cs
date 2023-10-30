using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentosNomeados
{
    internal class Program
    {
        static void Enviar(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"{destino} - {titulo} - {assunto}");
        }
        static void Main(string[] args)
        {
            Enviar(destino: "guibencici@gmail.com", assunto: "Testando função enviar", titulo: "teste top");
            Console.ReadLine();
        }
    }
}
