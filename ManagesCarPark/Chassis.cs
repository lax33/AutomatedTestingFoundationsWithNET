namespace ManagesCarPark
{
    public class Chassis
    {
        public int wheelsNumber;
        public string numberChassis;
        public double permissibleLoad;

        public Chassis() { }
        public Chassis(int wheelsNumber, string numberChassis, double permissibleLoad)
        {
            this.wheelsNumber = wheelsNumber;
            this.numberChassis = numberChassis;
            this.permissibleLoad = permissibleLoad;
        }

    }
}
