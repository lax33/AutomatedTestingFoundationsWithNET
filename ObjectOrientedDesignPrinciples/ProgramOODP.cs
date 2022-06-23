namespace ObjectOrientedDesignPrinciples
{
    internal class ProgramOODP
    {
        private static void Main(string[] args)
        {
            Cars cars = Cars.Сreate();

            cars.AddCar(new Car() { Type = "Ford", Amount = 5, Model = "Focus", Price = 21000 });
            cars.AddCar(new Car() { Type = "Ford", Amount = 3, Model = "Mondeo", Price = 25400 });
        }
    }
}