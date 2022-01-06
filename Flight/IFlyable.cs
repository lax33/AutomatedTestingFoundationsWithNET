using System;
using System.Collections.Generic;
using System.Text;

namespace Flight
{
    interface IFlyable
    {
        double FlyTo(Coordinate newPoint);
        double GetFlyTime(Coordinate newPoint);

    }
}
