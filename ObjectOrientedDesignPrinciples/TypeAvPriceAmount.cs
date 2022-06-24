using System.Collections.Generic;

namespace ObjectOrientedDesignPrinciples
{
    public class TypeAvPriceAmount
    {
        public string Type;

        public double Amount;

        public double AverigePrice;

        public List<TypeAvPriceAmount> typeCar_amountCarType_averigePrice = new ();

        //protected static List<TypeAvPriceAmount> typeCar_amountCarType_averigePrice; // contains computed values by type
        //private double amountPriceType;

        public void Execute(Cars cars)
        {
            double amountPriceType = 0;

            typeCar_amountCarType_averigePrice.Add(new TypeAvPriceAmount(){Type = "", Amount = 0, AverigePrice = 0});

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

                        typeCar_amountCarType_averigePrice.Add(new TypeAvPriceAmount(){Type = typecar, Amount = amountCarType-1, AverigePrice = amountPriceType /= (amountCarType-1) });
                        
                        //typeCar_amountCarType_averigePrice.Add(carFeature);
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