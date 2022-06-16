using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class CountAll : ICommand
    {
        private int amount;


        //public CountAll(List<Car> cars)
        //{
        //    this.cars = cars;
        //}

        public void ExecuteCom(Cars cars)
        {
            foreach (var car in cars.ArrayCars)
            {
                amount += car.Amount;
            }

            Console.WriteLine($"Total number of cars {amount}");
        }
    }
}