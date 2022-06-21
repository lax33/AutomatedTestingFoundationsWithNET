using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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