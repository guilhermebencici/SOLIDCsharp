using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class LocalizaCliente
    {
        public static Cliente ProcuraPorPais(string pais)
        {
            var resultado = Cliente.GetClientes().Find(p => p.Pais == pais);
            return resultado;
        }

        public static Cliente ProcuraPorNome(string nome)
        {
            var resultado = Cliente.GetClientes().Find(n => n.Nome == nome);
            return resultado;
        }

        // dentro da localizaCliente, havia o método ExportarDados, o qual estava ferindo o princípio SRP
        // para corrigi-lo, bastou criar outra classe para guardar o método
    }
}
