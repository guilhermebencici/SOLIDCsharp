﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorSealed
{
    sealed class CalculaSoma : CalculaSomaBase
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
}
