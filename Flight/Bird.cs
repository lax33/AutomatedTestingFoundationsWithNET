using System;

namespace Flight
{
    internal class Bird : IFlyable
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
        /// <returns> Value in kilometers </returns>
        public double FlyTo(Coordinate newPoint)
        {
            return Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                            Math.Pow(currentPosition.y - newPoint.y, 2) +
                            Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);
        }

        /// <summary>
        /// Bird flight time. This is the distanse divided by the speed.
        /// Bird speed may be between 0-20 кm/h. Speed is randomly selected.
        /// </summary>
        /// <param name="newPoint"> New point coordinate </param>
        /// <returns> Value in hours </returns>
        public double GetFlyTime(Coordinate newPoint)
        {
            double distance = Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                                        Math.Pow(currentPosition.y - newPoint.y, 2) +
                                        Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);

            Random rndSpeed = new Random();
            double speed = rndSpeed.Next(0, 20); // speed bird from the range of 0-20 km/h

            return distance / speed;
        }
    }
}