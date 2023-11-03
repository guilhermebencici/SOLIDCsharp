using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultMemberInterface
{
    internal interface ILogger
    {
        void Info(string message);

        // NOVO MÉTODO .NET 8, PODE-SE TER INTERFACE COM MÉTODOS COM SUAS IMPLEMENTAÇÕES
        void Error(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
