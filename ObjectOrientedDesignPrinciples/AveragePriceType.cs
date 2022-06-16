using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class AveragePriceType : ICommand
    {
        private List<string> typeCar;
        private double amountPriceType;
        private readonly List<Car> cars;

        public AveragePriceType(List<Car> cars)
        {
            this.cars = cars;
        }

        public void ExecuteCom()
        {
            int amountCarType = 0; // number of car type
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
                                amountPriceType += ca.Price;
                            }
                        }
                        amountPriceType /= amountCarType;
                        Console.WriteLine($"The average cost of '{typecar}' - {amountPriceType / amountCarType}");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            typeCar.Clear(); //cleaning array for using later
        }
    }
}