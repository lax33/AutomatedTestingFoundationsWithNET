using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class CountTypes : ICommand
    {
        private List<Car> countTypes = new();

        public void ExecuteCom(Cars cars)
        {
            countTypes.Add(cars?.ArrayCars[0]);
            foreach (var car in cars.ArrayCars)
            {
                foreach (var typ in countTypes)
                {
                    if (typ.Type == car.Type) continue;
                    countTypes.Add(typ);
                    break;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"The count of type - {countTypes.Count}");
        }
    }
}