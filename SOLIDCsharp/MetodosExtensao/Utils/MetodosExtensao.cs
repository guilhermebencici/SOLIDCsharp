using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao.Utils
{
    public static class MetodosExtensao
    {
        public static string CaixaAltaPrimeiraLetra(this string valor)
        {
            if(valor.Length > 0)
            {
                char[] array = valor.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return valor;
        }
    }
}
