namespace ApiDevInCarGQL.Models
{
    public enum FuelVan
    {
        diesel,
        gas
    }
    public class Van : Vehicle
    {
        public int Doors { get; set; }
        public int BucketCapacity { get; set; }
        public FuelVan Fuel { get; set; }

        public Van (
            DateTime manufacturingDate,
            string name,
            string licensePlate,
            double value,
            int doors,
            int bucketCapacity,
            FuelVan fuel,
            string power, 
            string color
            ) : base(manufacturingDate, name, licensePlate, value, color, power)
        {
            Doors = doors;
            BucketCapacity = bucketCapacity;
            Fuel = fuel;
        }
    }
}
