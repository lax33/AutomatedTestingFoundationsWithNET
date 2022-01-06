using System;
using System.Collections.Generic;
using System.Text;

namespace Flight
{
    class Airplane : IFlyable
    {
        private Coordinate currentPosition;

        public Airplane(Coordinate currentPosition)
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
            double distance = Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                                       Math.Pow(currentPosition.y - newPoint.y, 2) +
                                       Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);

            double speedEnDistance = 200 + distance;
            double speed = (200 + )

            return distance / speed;
        }
    }
}
