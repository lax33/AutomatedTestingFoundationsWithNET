namespace ManagesCarPark
{
    public class Engine
    {
        public int power;
        public double capacity;
        public string typeEngin;
        public long serialNumber;

        public Engine() { }
        public Engine(int power, double capacity, string typeEngin, long serialNumber)
        {
            this.power = power;
            this.capacity = capacity;
            this.typeEngin = typeEngin;
            this.serialNumber = serialNumber;
        }
    }
}
