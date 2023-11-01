using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLComposicao
{
    internal class Departamento : IDisposable
    {
        private Escola escola;
        private string nome;

        public Departamento(Escola escola, string nome)
        {
            this.escola = escola;
            this.nome = nome;
        }

        public void Dispose()
        {
            //destroi departamento!
        }
    }
}
