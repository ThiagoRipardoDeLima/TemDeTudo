using System;
using System.Collections.Generic;

namespace RevendaDeCarro.model
{
    class Carro
    {
        public int codigo { get; private set; }
        public string modelo { get; private set; }
        public int ano { get; private set; }
        public double precoBasico { get; private set; }

        public double precoTotal() { return 0.00; }
    }
}
