using System;
using System.Collections.Generic;
using System.Text;

namespace Flight
{
    internal struct Coordinate
    {
        public uint x;
        public uint y;
        public uint z;

        public Coordinate(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
