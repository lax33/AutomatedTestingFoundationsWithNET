using System;

namespace Flight
{
    internal class Airplane : IFlyable
    {
        private readonly Coordinate currentPosition;

        public Airplane(Coordinate currentPosition)
        {
            this.currentPosition = currentPosition;
        }

        /// <summary>
        /// The distance from the current position to the new point
        /// </summary>
        /// <param name="newPoint"> New point coordinate </param>
        /// <returns> Value in kilometers </returns>
        public double FlyTo(Coordinate newPoint)
        {
            return Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                            Math.Pow(currentPosition.y - newPoint.y, 2) +
                            Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);
        }

        /// <summary>
        /// Airplane flight time.
        /// The start speed is 200 km/h and it increases every 10 km by 10 km/h.
        /// </summary>
        /// <param name="newPoint"> New point coordinate </param>
        /// <returns> Value in hours </returns>
        public double GetFlyTime(Coordinate newPoint)
        {
            const int speedStart = 200;
            double acceleration = (Math.Pow(210, 2) - Math.Pow(200, 2)) / 2 * 10;

            double distance = Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                                       Math.Pow(currentPosition.y - newPoint.y, 2) +
                                       Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);

            double speedEnd = Math.Pow(2 * distance * acceleration + speedStart * speedStart, 0.5);

            return (speedEnd - speedStart) / acceleration;
        }
    }
}