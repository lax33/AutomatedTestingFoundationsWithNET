using System;

namespace ObjectOrientedDesignPrinciples
{
    public class CountAll : ICommand
    {
        private int amount;

        public void ExecuteCom(Cars cars)
        {
            amount = cars.ArrayCars.Count;
        }

        public void Print()
        {
            Console.WriteLine($"Total number of cars {amount}");
        }
    }
}