using ApiDevInCarGQL.Models;

namespace ApiDevInCarGQL.Seeders
{
    public class MotoSeed
    {
        public static List<Moto> MotoSeeders { get; set; } = new List<Moto>
        {
            new Moto
            (
                ManufacturingDate: DateTime.Now,
                Name: "Twister",
                LicensePlate: "NKI9089",
                Value: 18.000,
                Color: "Azul",
                Wheels: 2,
                Power: "2"
            ),       
            new Moto
            (
                ManufacturingDate: DateTime.Now,
                Name: "CG 150",
                LicensePlate: "FGH9089",
                Value: 19.000,
                Color: "Preto",
                Wheels: 2,
                Power: "1.5"
            ),       
            new Moto
            (
                ManufacturingDate: DateTime.Now,
                Name: "Biz",
                LicensePlate: "ADB8989",
                Value: 14.000,
                Color: "Vermelho",
                Wheels: 2,
                Power: "1.25"
            ),
        };
    }
}
