using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um OBJETO da classe PESSOA -> pessoa1 é um objeto do tipo PESSOA
            Pessoa pessoa1 = new Pessoa("Guilherme", 31, "Masculino"); // após ter criado um construtor na classe Pessoa

            Pessoa pessoa2 = new Pessoa();
            // Quando não havia construtor
            pessoa2.nome = "Gabi";
            pessoa2.idade = 26;
            pessoa2.genero = "Feminino";

            pessoa1.Identificar();
            pessoa2.Identificar();

            Console.ReadLine();
        }
    }
}
