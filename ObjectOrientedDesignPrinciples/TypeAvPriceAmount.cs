using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedDesignPrinciples
{
    public class TypeAvPriceAmount
    {
        public string Type;

        public double Amount;

        public double AverigePrice;

        public List<TypeAvPriceAmount> typeCar_amountCarType_averigePrice; // contains computed values by type
        private double amountPriceType;

        public void Execute(Cars cars)
        {
            foreach (var car in cars.ArrayCars)
            {
                int amountCarType = 0; // number of car type
                string typecar = car.Type; //выбираем текущий тип с которым будем работать

                foreach (var VARIABLE in typeCar_amountCarType_averigePrice) //массив с типами скоторыми уже работали
                {
                    if (typecar != VARIABLE.Type) // cheсk for do we worked with this type?
                    {
                        foreach (var ca in cars.ArrayCars)
                        {
                            if (typecar == ca.Type) // search in 'cars' array and add price
                            {
                                amountCarType++;
                                amountPriceType += ca.Price;
                            }
                        }
                        var carFeature = new TypeAvPriceAmount()
                        {
                            Type = typecar,
                            Amount = amountCarType,
                            AverigePrice = amountPriceType /= amountCarType  // type's averige price
                        };

                        typeCar_amountCarType_averigePrice.Add(carFeature);

                        Console.WriteLine($"The average cost of '{typecar}' - {amountPriceType / amountCarType}");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}