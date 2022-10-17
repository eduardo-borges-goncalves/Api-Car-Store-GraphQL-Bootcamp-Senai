using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ApiDevInCarGQL.Models
{
    public abstract class Vehicle
    {
        [Key]
        public int Chassis { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public double Value { get; set; }
        public string Color { get; set; }
        public Boolean Available { get; set; }
        public string Power { get; set; }

        Random randNum = new Random();

        public Vehicle() { }
        public Vehicle(
            DateTime ManufacturingDate,
            string name,
            string licensePlate,
            double value,
            string color, 
            string power
            )
        {
            this.Chassis = randNum.Next();
            this.ManufacturingDate = ManufacturingDate;
            this.Name = name;
            this.LicensePlate = licensePlate;
            this.Value = value;
            this.Color = color;
            this.Available = true;
            this.Power = power;
        }
    }
}
