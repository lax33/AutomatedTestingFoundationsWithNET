namespace ManagesCarPark
{
    public class Engine
    {
        internal int power;
        internal double capacity;
        internal string typeEngin;
        internal long serialNumber;

        public Engine(int power, double capacity, string typeEngin, long serialNumber)
        {
            this.power = power;
            this.capacity = capacity;
            this.typeEngin = typeEngin;
            this.serialNumber = serialNumber;
        }

    }


}
