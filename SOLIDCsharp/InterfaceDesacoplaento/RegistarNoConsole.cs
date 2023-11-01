using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDesacoplaento
{
    internal class RegistrarNoConsole : IRegistro
    {
        public void RegistrarInfo(string mensagem)
        {
            Console.WriteLine($"info: {mensagem}" );
        }
    }
}
