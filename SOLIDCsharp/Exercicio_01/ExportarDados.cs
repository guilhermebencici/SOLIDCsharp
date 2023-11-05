using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class ExportarDados
    {
        public static string ExportarCSV(List<Cliente> dados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dados)
            {
                sb.AppendFormat($"{item.Nome},{item.Pais},{item.Email}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
