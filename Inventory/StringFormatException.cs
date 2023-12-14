using System.Runtime.Serialization;

namespace Inventory
{
    [Serializable]
    internal class StringFormatException : Exception
    {
        public StringFormatException()
        {
        }

        public StringFormatException(string? message) : base(message)
        {
        }

        public StringFormatException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StringFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}