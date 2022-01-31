using System;

namespace Flight
{
    class Drone : IFlyable
    {
        private Coordinate currentPosition;

        public Drone(Coordinate currentPosition)
        {
            this.currentPosition = currentPosition;
        }

        /// <summary>
        /// The distance from the current position to the new point.
        /// </summary>
        /// <param name="newPoint"></param>
        /// <returns> Value in kilometers </returns>
        public double FlyTo(Coordinate newPoint)
        {
            return Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                            Math.Pow(currentPosition.y - newPoint.y, 2) +
                            Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);
        }

        /// <summary>
        /// Drone flight time.
        /// The drone speed 100 km/h.
        /// The drone hovers in the air every 10 minutes of flight for 1 minute.
        /// </summary>
        /// <param name="newPoint"> New point coordinate </param>
        /// <returns> Value in hours </returns>
        public double GetFlyTime(Coordinate newPoint)
        {
            const int speedDrone = 100;
            double dist10 = speedDrone * 0.166; // the distance flight for 10 minite in hours

            double distance = Math.Pow(Math.Pow(currentPosition.x - newPoint.x, 2) +
                                       Math.Pow(currentPosition.y - newPoint.y, 2) +
                                       Math.Pow(currentPosition.z - newPoint.z, 2), 0.5);

            int timeWait = (int)(Math.Floor(distance / dist10) * 0.016); // waiting time in hours
            double timeFlight = distance / speedDrone;                   // flight time  

            return timeFlight + timeWait;
        }
    }
}
