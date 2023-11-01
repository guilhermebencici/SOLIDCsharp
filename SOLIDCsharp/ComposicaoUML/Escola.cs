using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLComposicao
{
    internal class Escola : IDisposable
    {
        public string Nome { get; set; }
        private List<Departamento> departamentos = new List<Departamento>();

        public void AddDepartamento(string nome)
        {
            departamentos.Add(new Departamento(this, nome));
        }

        public void Dispose()
        {
            foreach(var departamento in departamentos)
            {
                departamento.Dispose();
            };
        }
    }
}
