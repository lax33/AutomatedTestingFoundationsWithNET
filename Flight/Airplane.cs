using System;

namespace Flight
{
    class Airplane : IFlyable
    {
        private Coordinate currentPosition;

        public Airplane(Coordinate currentPosition)
        {
            this.currentPosition = currentPosition;
        }

        /// <summary>
        /// The distance from the current position to the new point
        /// </summary>
        /// <param name="newPoint"> New point coordinate </param>
        /// <returns> value in kilometers </returns>
        public double FlyTo(Coordinate newPoint)
        {
            return Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                            Math.Pow(currentPosition.y - newPoint.y, 2) +
                            Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);
        }

        /// <summary>
        /// Airplane flight time.
        /// </summary>
        /// <param name="newPoint"> New point coordinate </param>
        /// <returns> value in hours </returns>
        public double GetFlyTime(Coordinate newPoint)
        {
            const int speedStart = 200;
            double distance = Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                                       Math.Pow(currentPosition.y - newPoint.y, 2) +
                                       Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);

            double speedEnd = speedStart + distance;
            double a = (Math.Pow(speedEnd, 2) - Math.Pow(speedStart, 2)) /
                2 * distance; // acceleration

            return (speedEnd - speedStart) / a;
        }
    }
}
