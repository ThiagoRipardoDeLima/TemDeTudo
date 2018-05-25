using System;

namespace Cinema
{
    class ModelException : Exception
    {
        public ModelException(string mensagem) : base(mensagem) { }
    }
}
