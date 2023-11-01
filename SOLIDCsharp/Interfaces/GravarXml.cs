using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class GravarXml :ArquivoBase, IGravar // Herança precisa vir antes da Interface!
    {
        public void GravarArquivo()
        {
            throw new NotImplementedException();
        }
        public override void Nome()
        {
            Console.WriteLine("Sobrescrevendo o métdo da Classe base");
        }
    }
}
