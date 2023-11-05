using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Pedido
    {
        // private ConsoleLogger log = new ConsoleLogger();
        private ILogger logger;
        public Pedido(ILogger _logger)
        {
            logger = _logger;
        }
        public virtual void AdicionarPedido()
        {
            try
            {
                logger.Registrar($"Pedido Incluido em: {DateTime.Now}");
            }
            catch (Exception e)
            {

                logger.Registrar($"{e} - {DateTime.Now}");
            }
        }
    }
}
