using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagesCarPark
{
    internal class InitializationException : Exception
    {
        public InitializationException(string massage) : base (massage) {}
    }
}
