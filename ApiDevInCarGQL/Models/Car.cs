namespace ApiDevInCarGQL.Models{

    public enum Fuel
    {
        flex, 
        gas
    }   

    public class Car : Vehicle
    {
        public int Doors { get; set; }
        public Fuel Fuel { get; set; }

        public Car (
            DateTime manufacturingDate,
            string name,
            string licensePlate,
            double value,
            string color,
            int doors, 
            Fuel fuel,
            string power
            ) : base(manufacturingDate, name, licensePlate, value, color, power)
        {
            Doors = doors; 
            Fuel = fuel; 
        }
    }
}