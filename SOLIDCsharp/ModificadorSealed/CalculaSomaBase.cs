using System;

namespace ModificadorSealed
{
    internal class CalculaSomaBase
    {

        //MÉTODO SEALED
        protected virtual void MétodoSealed()
        {
            Console.WriteLine("Testando método sealed");
        }
    }
}