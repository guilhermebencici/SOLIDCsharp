using OCP_ExtensionMethods.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1,"Caneta","Azul", 3.40M, 5.00M,100,true);

            Console.WriteLine($"{p1.Nome} e Lucro = {p1.MargemLucro()}");
        }
    }
}
