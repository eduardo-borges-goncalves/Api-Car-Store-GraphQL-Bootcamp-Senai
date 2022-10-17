using ApiDevInCarGQL.Models;

namespace ApiDevInCarGQL.Seeders
{
    public class VanSeed
    {
        public static List<Van> VansSeeders { get; set; } = new List<Van>
        {
            new Van
            (
                manufacturingDate: DateTime.Now,
                name: "Amarok",
                licensePlate: "POI9089",
                value: 389.000,
                color: "Azul",
                doors: 4,
                fuel: FuelVan.diesel,
                power: "260",
                bucketCapacity: 400
            ),      
            new Van
            (
                manufacturingDate: DateTime.Now,
                name: "Hylux",
                licensePlate: "NOI9089",
                value: 489.000,
                color: "Branco",
                doors: 4,
                fuel: FuelVan.diesel,
                power: "260",
                bucketCapacity: 400
            ),
            new Van
            (
                manufacturingDate: DateTime.Now,
                name: "S-10",
                licensePlate: "POI9089",
                value: 289.000,
                color: "Vermelho",
                doors: 4,
                fuel: FuelVan.diesel,
                power: "260",
                bucketCapacity: 400
            ),

        };
    }
}
