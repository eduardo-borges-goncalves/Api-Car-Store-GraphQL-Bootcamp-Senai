﻿using ApiDevInCarGQL.Models;

namespace ApiDevInCarGQL.Seeders
{
    public class VehicleSeed
    {
        public static List<Vehicle> VehicleSeeders { get; set; } = new List<Vehicle>
        {
            new Vehicle
            {
                IdVehicle = 1,
                VehicleType = VehicleType.carro,
                ManufacturingDate = DateTime.Now,
                Name = "Punto",
                LicensePlate = "NKI9089",
                Value = 189.000,
                Color = "Azul",
                Power = "260",
                Doors = 4,
                Fuel = Fuel.gas,
                Available = true
            },               
            new Vehicle
            {
                IdVehicle = 2,
                VehicleType = VehicleType.moto,
                ManufacturingDate = DateTime.Now,
                Name = "twister",
                LicensePlate = "Npl5589",
                Value = 19.000,
                Color = "Vermelha",
                Power = "2",
                Wheels = 2,
                Available = true
            },         
            new Vehicle
            {
                IdVehicle = 3,
                VehicleType = VehicleType.camionete,
                ManufacturingDate = DateTime.Now,
                Name = "Amarok",
                LicensePlate = "MJE9089",
                Value = 400.000,
                Color = "Preto",
                Power = "200",
                Doors = 4,
                Fuel = Fuel.diesel, 
                BucketCapacity = 200, 
                Available = true
            },         
            new Vehicle
            {
                IdVehicle = 4,
                VehicleType = VehicleType.carro,
                ManufacturingDate = DateTime.Now,
                Name = "Lancer",
                LicensePlate = "KKO9089",
                Value = 89.000,
                Color = "Rosa",
                Power = "456",
                Doors = 4,
                Fuel = Fuel.flex,
                Available = true
            },
        };
    }
}
