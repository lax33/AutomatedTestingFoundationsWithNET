namespace ManagesCarPark
{
    public class Transmission
    {
        public string typeTransmission;
        public string manufacturer;
        public int numberOfGears;

        public Transmission(string typeTransmission, int numberOfGears, string manufacturer)
        {
            this.typeTransmission = typeTransmission;
            this.manufacturer = manufacturer;
            this.numberOfGears = numberOfGears;
        }
    }
}
