using System;

namespace ManagesCarPark
{
    internal class InitializationException : Exception
    {
        public InitializationException(string massage) : base(massage) { }
    }
}
