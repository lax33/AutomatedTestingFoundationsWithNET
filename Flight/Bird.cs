using System;

namespace Flight
{
    class Bird : IFlyable
    {
        private Coordinate currentPosition;

        public Bird(Coordinate currentPosition)
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
        /// Flight time
        /// </summary>
        /// <param name="newPoint"> New point coordinate </param>
        /// <returns> value in hours </returns>
        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                                        Math.Pow(currentPosition.y - newPoint.y, 2) +
                                        Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);

            Random rndSpeed = new Random();
            double speed = rndSpeed.Next(0, 20); // speed burd from the range of 0-20 km/h

            return distance / speed;
        }
    }
}
