using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class Cars
    {
        private List<Car> lCars;

        public List<Car> ArrayCars
        {
            get => lCars;
        }

        private static Cars cars;

        private Cars()
        { }

        public static Cars Сreate()
        {
            if (cars == null)
                cars = new Cars();
            return cars;
        }

        public void AddCar(Car car)
        {
            lCars.Add(car);
        }
    }
}