using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedDesignPrinciples
{
    public class CountTypes : ICommand
    {
        private int amount;
        private readonly List<Car> cars;

        public CountTypes(List<Car> cars)
        {
            this.cars = cars;
        }
        public void ExecuteCom()
        {
            foreach (var car in cars)
            {
                
            }
        }
    }
}