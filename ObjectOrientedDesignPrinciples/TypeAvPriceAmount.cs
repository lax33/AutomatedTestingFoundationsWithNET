using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class TypeAvPriceAmount
    {
        public string Type;

        public double Amount;

        public double AverigePrice;

        public List<TypeAvPriceAmount> typeCar_amountCarType_averigePrice;

        //protected static List<TypeAvPriceAmount> typeCar_amountCarType_averigePrice; // contains computed values by type
        //private double amountPriceType;

        public void Execute(Cars cars)
        {
            double amountPriceType = 0;

            //TypeAvPriceAmount carFeature = new ();

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

                        TypeAvPriceAmount carFeature = new()
                        {
                            Type = typecar,
                            Amount = amountCarType,
                            AverigePrice = amountPriceType /= amountCarType // type's averige price
                        };
                        typeCar_amountCarType_averigePrice.Add(carFeature);
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