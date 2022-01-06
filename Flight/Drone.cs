using System;
using System.Collections.Generic;
using System.Text;

namespace Flight
{
    class Drone : IFlyable
    {
        private Coordinate currentPosition;

        public Drone(Coordinate currentPosition)
        {
            this.currentPosition = currentPosition;
        }

        public double FlyTo(Coordinate newPoint)
        {
            return Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                            Math.Pow(currentPosition.y - newPoint.y, 2) +
                            Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);
        }

        public double GetFlyTime(Coordinate newPoint)
        {
            return Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                            Math.Pow(currentPosition.y - newPoint.y, 2) +
                            Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);
        }
    }
}
