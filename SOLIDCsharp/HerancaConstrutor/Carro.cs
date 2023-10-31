using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaConstrutor
{
    internal class Carro : Veiculo // CLASSE DERIVADA DA CLASSE BASE VEICULO
    {
        public Carro(string numeroChassis) : base(numeroChassis)
        {
            //inicializar outros campos da classe carro!
            Console.WriteLine($"Inicializando Carro:  {numeroChassis}");
        }
        //CONSTRUTOR PRÓPRIO DA CLASSE DERIVDA
        public Carro()
        {
            Console.WriteLine("Inicializando a classe CARRO");
        }

        public override void Teste()
        {
            base.Teste();
            Console.WriteLine("Sobrescrevendo o método TESTE da BASE");
        }
    }
}
