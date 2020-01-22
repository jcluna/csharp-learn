using System;
using System.Runtime.Serialization;

namespace nomina
{
    [Serializable]
    public class CalculadoraException : Exception
    {
        public CalculadoraException()
        {
        }

        public CalculadoraException(string message) : base(message)
        {
        }

        public CalculadoraException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CalculadoraException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
