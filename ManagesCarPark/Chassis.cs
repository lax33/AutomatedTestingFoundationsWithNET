namespace ManagesCarPark
{
    public class Chassis
    {
        internal int wheelsNumber;
        internal string numberChassis;
        internal double permissibleLoad;

        public Chassis(int wheelsNumber, string numberChassis, double permissibleLoad)
        {
            this.wheelsNumber = wheelsNumber;
            this.numberChassis = numberChassis;
            this.permissibleLoad = permissibleLoad;
        }

    }
}
