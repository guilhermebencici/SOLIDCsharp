using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal abstract class Forma
    {
        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimeto { get; set; }

        // MÉTODOS ABSTRATOS NÃO POSSUEM IMPLEMENTAÇÃO E PRECISAM DO "ABSTRACT"
        public abstract void CalculaArea();
        public abstract void CalculaPerimeto();
        public string Descricao()
        {
            return "Sou a classe ABSTRATA FORMA";
        }
    }
}
