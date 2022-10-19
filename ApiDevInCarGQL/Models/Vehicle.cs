using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ApiDevInCarGQL.Models
{
    public enum Fuel
    {
        flex,
        gas, 
        diesel
    }
    public enum VehicleType
    {
        camionete, 
        carro, 
        moto
    }

    public class Vehicle
    {
        public int? Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public int Chassis { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public double Value { get; set; }
        public string Color { get; set; }
        public bool Available { get; set; }
        public string Power { get; set; }

        ///////
        public int? Doors { get; set; }
        public Fuel? Fuel { get; set; }
        public int? Wheels { get; set; }
        public int? BucketCapacity { get; set; }


        Random randNum = new Random();

        public Vehicle() { }

        //public Vehicle(
        //    int id, 
        //    VehicleType vehicleType,
        //    DateTime manufacturingDate,
        //    string name, 
        //    string licensePlate,
        //    double value, 
        //    string color,
        //    string power, 
        //    int doors, 
        //    Fuel fuel
        //    ) : this(id, vehicleType, manufacturingDate, name, licensePlate, value, color, power)
        //{
        //    Doors = doors;
        //    Fuel = fuel;
        //}       
        //public Vehicle(
        //    int id, 
        //    VehicleType vehicleType,
        //    DateTime manufacturingDate,
        //    string name, 
        //    string licensePlate,
        //    double value, 
        //    string color,
        //    string power, 
        //    int? wheels 
        //    ) : this(id, vehicleType, manufacturingDate, name, licensePlate, value, color, power)
        //{
        //    Wheels = wheels;
        //}    
        //public Vehicle(
        //    int id, 
        //    VehicleType vehicleType,
        //    DateTime manufacturingDate,
        //    string name, 
        //    string licensePlate,
        //    double value, 
        //    string color,
        //    string power, 
        //    Fuel? fuel, 
        //    int bucketCapacity
        //    ) : this(id, vehicleType, manufacturingDate, name, licensePlate, value, color, power)
        //{
        //    Fuel = fuel;
        //    BucketCapacity = bucketCapacity;
        //}

        //public Vehicle(
        //    int id,
        //    VehicleType vehicleType,
        //    DateTime ManufacturingDate,
        //    string name,
        //    string licensePlate,
        //    double value,
        //    string color,
        //    string power
        //    )
        //{
        //    Id = id;
        //    VehicleType = vehicleType;
        //    this.Chassis = randNum.Next();
        //    this.ManufacturingDate = ManufacturingDate;
        //    this.Name = name;
        //    this.LicensePlate = licensePlate;
        //    this.Value = value;
        //    this.Color = color;
        //    this.Available = true;
        //    this.Power = power;
        //}

        public Vehicle(
            VehicleType vehicleType,
            DateTime manufacturingDate,
            string name,
            string licensePlate,
            double value,
            string color,
            string power,
            Fuel fuel,
            int bucketCapacity,
            int wheels,
            int doors
        )
        {
            VehicleType = vehicleType;
            this.Chassis = randNum.Next();
            this.ManufacturingDate = manufacturingDate;
            this.Name = name;
            this.LicensePlate = licensePlate;
            this.Value = value;
            this.Color = color;
            this.Available = true;
            this.Power = power;
            Fuel = fuel;
            Doors = doors;
            BucketCapacity = bucketCapacity;
            Wheels = wheels;

        }
    }
}
