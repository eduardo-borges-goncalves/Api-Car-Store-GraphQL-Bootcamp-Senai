using ApiDevInCarGQL.Models;

namespace ApiDevInCarGQL.Seeders
{
    public class CarSeed
    {
        public static List<Car> CarSeeders { get; set; } = new List<Car>
        {
            new Car
            (
                manufacturingDate: DateTime.Now,
                name: "Punto",
                licensePlate: "NKI9089",
                value: 189.000,
                color: "Azul",
                doors: 4,
                fuel: Fuel.gas,
                power: "260"
            ),
            new Car
            (
                manufacturingDate: DateTime.Now,
                name: "Ferrari",
                licensePlate: "LIO9007",
                value: 289.000,
                color: "Preto",
                doors: 2,
                fuel: Fuel.gas,
                power: "380"
            ),
            new Car
            (
                manufacturingDate: DateTime.Now,
                name: "Mercedez",
                licensePlate: "JUU8989",
                value: 389.000,
                color: "Black",
                doors: 4,
                fuel: Fuel.flex,
                power: "220"
            ), 
        };
    }
}
