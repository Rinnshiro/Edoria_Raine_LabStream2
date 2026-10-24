using System;

namespace Edoria_Raine_LabStream
{
    public sealed class TextFileReadException : Exception
    {
        public TextFileReadException(string message) : base(message) { }
        public TextFileReadException(string message, Exception innerException) : base(message, innerException) { }
    }
}
