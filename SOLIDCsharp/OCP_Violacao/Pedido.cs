using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Violacao
{
    internal class Pedido
    {
        public virtual double DescontoPedido(double valorFinal)
        {
            return valorFinal;
        }
    }
}
