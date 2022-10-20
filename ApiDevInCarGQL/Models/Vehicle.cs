using HotChocolate.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        public int? IdVehicle { get; set; }
        public VehicleType VehicleType { get; set; }
        [Authorize]
        public int Chassis { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string Name { get; set; }
        [Authorize]
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

        [Column("IdTransaction")]
        [ForeignKey("Transaction")]
        public int? IdTransaction { get; set; }


        Random randNum = new Random();

        public Vehicle() { }

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
            int doors, 
            int id
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
            IdVehicle = id;
        }
    }
}
