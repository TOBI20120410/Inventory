using System.Runtime.Serialization;

namespace Inventory
{
    [Serializable]
    internal class CurrencyFormatException : Exception
    {
        public CurrencyFormatException()
        {
        }

        public CurrencyFormatException(string? message) : base(message)
        {
        }

        public CurrencyFormatException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CurrencyFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}