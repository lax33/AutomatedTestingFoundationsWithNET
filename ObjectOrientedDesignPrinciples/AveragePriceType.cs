using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class AveragePriceType : ICommand
    {
        private List<string> typeCar;
        private double averagePriceType;
        private readonly List<Car> cars;

        public AveragePriceType(List<Car> cars)
        {
            this.cars = cars;
        }

        public void ExecuteCom()
        {
            int amountCarType = 0;
            foreach (var car in cars)
            {
                string typecar = car.Type; //выбираем текущий тип с которым будем работать 

                foreach (var VARIABLE in typeCar) //массив с типами скоторыми уже работали 
                {
                    if (typecar != VARIABLE) // cheсk for do we working with this type?  
                    {
                        typeCar.Add(car.Type); // if we do not worked with this type, adding to  'typeCar' array

                        foreach (var ca in cars)
                        {
                            if (typecar == ca.Type) // search in 'cars' array and add price
                            {
                                amountCarType++;
                                averagePriceType += ca.Price;

                            }

                        }
                        averagePriceType /= cars.Count;
                        Console.WriteLine($"The average cost of '{typecar}' - {averagePriceType}");
                    }
                }

            }
            typeCar.Clear(); //cleaning array for using later
        }
    }
}