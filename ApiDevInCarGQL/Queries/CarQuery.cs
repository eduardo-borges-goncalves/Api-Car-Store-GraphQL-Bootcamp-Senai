using ApiDevInCarGQL.Context;
using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Repositories;

namespace ApiDevInCarGQL.Queries
{

    [ExtendObjectType(OperationTypeNames.Query)]
    public class CarQuery
    {
        public Task<List<Vehicle>> veiculos(
            [Service] IVehicleRepository _vehicleRepository,
            string? tipoVeiculo)
        {
            var vehicles = _vehicleRepository.GetAll(tipoVeiculo);
            return vehicles;
        }

        public Task<List<Vehicle>> disponiveis(
             [Service] IVehicleRepository _vehicleRepository,
            string? tipoVeiculo)
        {
            var vehicles = _vehicleRepository.GetAvailable(tipoVeiculo);
            return vehicles;
        }

        public Task<List<Vehicle>> vendidos(
            [Service] IVehicleRepository _vehicleRepository,
            string? tipoVeiculo)
        {
            var vehicles = _vehicleRepository.GetSelled(tipoVeiculo);
            return vehicles;
        }

        public Task<Vehicle> maiorPreco(
            [Service] IVehicleRepository _vehicleRepository,
            string? tipoVeiculo)
        {
            var vehicle = _vehicleRepository.GetExpensiveSelled(tipoVeiculo);
            return vehicle;
        }

        public Task<Vehicle> menorPreco(
            [Service] IVehicleRepository _vehicleRepository,
            string? tipoVeiculo)
        {
            var vehicle = _vehicleRepository.GetCheapSelled(tipoVeiculo);
            return vehicle;
        }




    }
}
