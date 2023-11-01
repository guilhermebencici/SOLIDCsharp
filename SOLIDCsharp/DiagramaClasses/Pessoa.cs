using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClasses
{
    internal class Pessoa
    {
        public Pessoa()
        {}

        public Pessoa(string nome, int idade, string sexo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
        }

        private DateTime dataNascimento = new DateTime(1992, 1, 6);
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public void IdentificarPessoa()
        {
            Console.WriteLine($"{Nome} - {Idade} - {Sexo}");
        }
    }
}
