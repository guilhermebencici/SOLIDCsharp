using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloAnemico
{
    internal class Item
    {
        // PARA ENRIQUECER O DOMÍNIO, É CRIADO O CONSTRUTOR COM VALIDAÇÃO
        public Item(int itemId, int pedidoId, string itemNome, decimal itemPreco)
        {
            if(pedidoId <= 0)
            {
                throw new ArgumentException("O código do pedido deve ser informado com o valor " + "maior que zero");
            }

            if(itemId <= 0)
            {
                throw new ArgumentException("O código do item deve ser informado com o valor " + "maior que zero");
            }

            this.ItemId = itemId;
            this.PedidoId = pedidoId;
            this.ItemNome = ItemNome;
            this.ItemPreco = itemPreco;
        }

        // Definir as propriedades setter como private e adicionar lógica de validação
        public int ItemId { get;  private set; }

        private string _itemNome;
        public string ItemNome {
            get => this._itemNome;
            private set
            {
                this._itemNome = (value.Length > 100) ? throw new ArgumentOutOfRangeException(nameof(ItemNome), 
                    " O nome não pode exceder 100 caracteres") : value;
            }
        }

        private decimal _itemPreco;
        public decimal ItemPreco
        {
            get => this._itemPreco;
            private set
            {
                this._itemPreco = (value <= 0) ? throw new ArgumentOutOfRangeException(nameof(ItemPreco),
                    " O preço deve ser maior que zero!") : value;
            }
        }
        public int PedidoId { get; private set; }
    }
}
