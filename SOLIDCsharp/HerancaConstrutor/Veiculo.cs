using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HerancaConstrutor
{
    internal class Veiculo
    {
        // CAMPO PARA O NOSSO CONSTRUTOR PRIVADO
        private string _numeroChassis;
        public Veiculo(string numeroChassis)
        {
            _numeroChassis = numeroChassis;
            Console.WriteLine($"Inicializando Veículo:  {numeroChassis}");
        }

        // CONSTRUTOR DA CLASSE BASE -> PRIMEIRO A SER EXECUTADO, ENTRETANDO, NÃO HERDADO
        public Veiculo()
        {
            Console.WriteLine("Inicializando a classe VEÍCULO!");
        }

        public virtual void Teste()
        {
            Console.WriteLine("Acessei teste");
        }
    }
}
