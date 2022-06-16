using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class CountAll : ICommand
    {
        private int amount;
        private readonly List<Car> cars;


        public CountAll(List<Car> cars)
        {
            this.cars = cars;
        }

        public void ExecuteCom()
        {
            foreach (var car in cars)
            {
                amount += car.Amount;
            }

            Console.WriteLine($"Total number of cars {amount}");
        }
    }
}