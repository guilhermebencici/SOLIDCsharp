using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Aderente
{
    internal class RegistraLog : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
