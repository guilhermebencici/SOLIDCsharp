using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Aderente
{
    internal class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger infoLogger;
        private EnviarEmail enviarEmail;

        public Pedido()
        {
            enviarEmail = new EnviarEmail();
            infoLogger = new RegistraLog();
        }
        public void IncluirPedido()
        {
            try
            {
                infoLogger.Info("Incluindo um pedido");
                enviarEmail.EMailFrom = "email.teste@gmail.com";
                enviarEmail.EMailTo = "teste.email@gmail.com";
                enviarEmail.EMailSubject = "SRP";
                enviarEmail.EMailBody = "Um";
                enviarEmail.Enviar();
            }
            catch (Exception e)
            {
                infoLogger.Info("Erro ao enviar email : " + e.Message);
            }
        }

        public void DeletaPedido()
        {
            try
            {
                // código pra deletar pedido
                infoLogger.Info("Pedido deletado em : " + DateTime.Now);

            }
            catch (Exception e)
            {
                infoLogger.Info("Erro ao deletar pedido : " + e.Message);
            }
        }
    }
}
