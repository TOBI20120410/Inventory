﻿using System.Runtime.Serialization;

namespace Inventory
{
    [Serializable]
    internal class NumberFormatException : Exception
    {
        public NumberFormatException()
        {
        }

        public NumberFormatException(string? message) : base(message)
        {
        }

        public NumberFormatException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NumberFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}