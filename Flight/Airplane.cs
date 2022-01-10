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
        /// The start speed is 200 km/h and it increases every 10 km by 10 km/h
        /// The maximum speed 800 km/h 
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

            if (speedEnd > 800)
            {
                speedEnd = 800;
                double a = (Math.Pow(800, 2) - Math.Pow(speedStart, 2)) /
                    2 * distance; // acceleration ?

                return (800 - speedStart) / a + (distance - 80) / 800 ;
            }
            else
            {
                double a = (Math.Pow(speedEnd, 2) - Math.Pow(speedStart, 2)) /
                    2 * distance; // acceleration ?

                return (speedEnd - speedStart) / a;
            }
        }
    }
}
