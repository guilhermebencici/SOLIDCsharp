using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Violacao
{
    internal class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        public void IncluirPedido()
        {
            try
            {
                // código para incluir pedido
                // após incluir, envia o email
                MailMessage mailMessage = new MailMessage("EMailFrom","EMailTo","EMailSubject", "EMailBody");
                this.EnviaEmailPedido(mailMessage);// método ferindo a SRP, pois deveria ter sua prória classe


            }
            catch (Exception e)
            {
                File.WriteAllText(@"c:\dados\ErrorLog.txt", e.ToString());
            }
        }

        public void DeletaPedido()
        {
            try
            {
                //código para deletar pedido gerado
            }
            catch(Exception e)
            {
                File.WriteAllText(@"c:\dados\ErrorLog.txt", e.ToString());
            }
        }

        // método ferindo a SRP, pois deveria ter sua prória classe
        private void EnviaEmailPedido(MailMessage mailMessage)
        {
            try
            {
                //código para enviar
            }
            catch (Exception e)
            {
                File.WriteAllText(@"c:\dados\ErrorLog.txt", e.ToString());
            }
        }
    }
}
