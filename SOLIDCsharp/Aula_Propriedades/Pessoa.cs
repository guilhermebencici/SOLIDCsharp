using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Propriedades
{
    internal class Pessoa
    {   // CAMPO
        private string nome;
        private string genero;
        private int idade;

        // CONSTRUTOR PARA TERMOS ACESSO A PROPRIEDADE ( ENCAPSULAMENTO )
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        //PROPRIEDADE NOME
        public string Nome { get; }

        //PROPRIEDADE GENERO
        public string Genero
        {
            set
            {
                genero = value;
                Console.WriteLine(genero);
            }
        }

        //PROPRIEDADE IDADE
        public int Idade
        {
            set
            {
                if(value < 18)
                {
                    Console.WriteLine("Idade precisa ser maior que 18");
                }
                else
                {
                    this.idade = value;
                }
            }
            get { return idade; }
        }



    }


}
