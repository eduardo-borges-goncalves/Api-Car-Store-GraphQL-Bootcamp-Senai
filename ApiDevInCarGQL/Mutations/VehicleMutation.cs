using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Repositories;

namespace ApiDevInCarGQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VehicleMutation
    {
        //public Task<List<Vehicle>> venderVeiculo(
        //   [Service] ICarRepository _carRepository,
        //   string tipoVeiculo)
        //{
        //    switch (tipoVeiculo)
        //    {
        //        case ("carro"):
        //            var cars = _carRepository.GetAll();
        //            return cars;

        //    }
        //}

        //public Task<List<Vehicle>> alterarCor(
        //    [Service] ICarRepository _carRepository,
        //    string tipoVeiculo)
        //{
        //    switch (tipoVeiculo)
        //    {
        //        case ("carro"):
        //            var cars = _carRepository.GetAll();
        //            return cars;

        //    }
        //}

        //public Task<List<Vehicle>> alterarValor(
        //    [Service] ICarRepository _carRepository,
        //    string tipoVeiculo)
        //{

        //            var cars = _carRepository.GetAll();
        //            return cars;
        //}

        public Task<Vehicle> novoVeiculo(
            [Service] IVehicleRepository _vehicleRepository,
            Vehicle vehicle)
        {
            var newVehicle = _vehicleRepository.CreateVehicle(vehicle);
            return newVehicle;
        }
    }
}
