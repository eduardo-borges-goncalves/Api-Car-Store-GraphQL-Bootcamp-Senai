using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDevInCarGQL.Models
{
    public class Moto : Vehicle
    {
        public int Wheels { get; set; }

        public Moto():base() { }
        public Moto(
            DateTime ManufacturingDate,
            string Name,
            string LicensePlate,
            double Value,
            string Color,
            int Wheels,
            string Power
            ) : base(ManufacturingDate, Name, LicensePlate, Value, Color, Power)
        {
            this.Wheels = Wheels;
        }
    }
}