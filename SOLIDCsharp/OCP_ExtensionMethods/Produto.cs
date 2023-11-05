using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_ExtensionMethods
{
    public class Produto
    {
        public int ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        private decimal _custo = 0;

        public decimal Custo
        {
            get => _custo;

            private set
            {
                if (value > 0)
                    _custo = value;
            }
        }
        public decimal _Venda = 1;

        public decimal Venda
        {
            get => _Venda;
            private set
            {
                if(value > 0)
                    _Venda = value;
            }
        }

        public int Estoque { get; private set; }
        public bool Ativo { get; private set; }

        public Produto(int id, string nome, string descricao, decimal custo, decimal venda, int estoque, bool ativo)
        {
            ProdutoId = id;
            Nome = nome;
            Descricao = descricao;
            Custo = custo;
            Venda = venda;
            Estoque = estoque;
            Ativo = ativo;
        }
    }
}
