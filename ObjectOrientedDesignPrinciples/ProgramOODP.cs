using System;
using System.Transactions;

namespace ObjectOrientedDesignPrinciples
{
    internal class ProgramOODP
    {
        private static void Main(string[] args)
        {
            Cars cars = Cars.Сreate();

            cars.AddCar(new Car() { Type = "Ford", Amount = 5, Model = "Focus", Price = 21000 });
            cars.AddCar(new Car() { Type = "Ford", Amount = 3, Model = "Mondeo", Price = 25400 });
            cars.AddCar(new Car(){Type = "Renault", Amount = 4, Model = "Scenic 1", Price = 15000});

            cars.AddCar(new Car(){Type = "Masda", Amount = 7, Model = "F323", Price = 5500});

            while (true)
            {
                Console.Write("Enter the command - ");
                string command = Console.ReadLine();
                Console.WriteLine(command);

                CallСommand callСommand = new CallСommand(command);

                callСommand.Command?.ExecuteCom(cars);

                callСommand.Command?.Print();


                //Console.ReadKey();
            }

           

        }
    }
}