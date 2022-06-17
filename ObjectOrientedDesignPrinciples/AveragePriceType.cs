using System;
using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class AveragePriceType : ICommand
    {
        private Dictionary<string, int> typeCar_amountCarType;
        private List<double> avarigePricetype;
        private double amountPriceType;


        //public AveragePriceType(List<Car> cars)
        //{
        //    this.cars = cars;
        //}

        public void ExecuteCom(Cars cars)
        {
            int amountCarType = 0; // number of car type
            foreach (var car in cars.ArrayCars)
            {
                string typecar = car.Type; //выбираем текущий тип с которым будем работать

                foreach (var VARIABLE in typeCar_amountCarType) //массив с типами скоторыми уже работали
                {
                    if (typecar != VARIABLE.Key) // cheсk for do we worked with this type?
                    {
                        foreach (var ca in cars.ArrayCars)
                        {
                            if (typecar == ca.Type) // search in 'cars' array and add price
                            {
                                amountCarType++;
                                amountPriceType += ca.Price;
                            }
                        }
                        //amountPriceType /= amountCarType;
                        avarigePricetype.Add(amountPriceType /= amountCarType);
                        typeCar_amountCarType.Add(typecar, amountCarType); // if we do not worked with this type, adding to  'typeCar' array
                        

                        Console.WriteLine($"The average cost of '{typecar}' - {amountPriceType / amountCarType}");
                        amountCarType = 0;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //typeCar.Clear(); //cleaning array for using later
        }

        public void Print()
        {

            Console.WriteLine($"The average cost of '{typeCar_amountCarType.Keys}' - {avarigePricetype[]}");
        }
    }
}