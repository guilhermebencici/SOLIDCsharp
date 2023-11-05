using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }

        public static List<Cliente> GetClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>()
            {
                new Cliente
                {
                   Nome="Guilherme", Pais="Brasil",Email="guilherme@gmail.com"
                },
                new Cliente
                {
                    Nome="Gabi", Pais="Italia",Email="gabi@gmail.com"
                }
            };
            return listaClientes;
        }
    }
}
