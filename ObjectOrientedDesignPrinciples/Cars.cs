using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class Cars
    {
        private List<Car> cars;

        public List<Car> ArrayCars
        {
            get => cars;
            set
            {
            }
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }
    }
}