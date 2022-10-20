using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Repositories;
using HotChocolate.AspNetCore.Authorization;
using System.Security.Claims;

namespace ApiDevInCarGQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VehicleMutation
    {
        [Authorize]
        public Task<Transaction> venderVeiculo(
            ClaimsPrincipal claimsPrincipal,
            [Service] IVehicleRepository _vehicleRepository,
            int idVeiculo,
            string cpf, 
            DateTime date
            )
        {      
            var transaction = _vehicleRepository.SellVehicle(idVeiculo, cpf, date);
            return transaction;
        }

        public Task<Vehicle> alterarCor(
            [Service] IVehicleRepository _vehicleRepository,
            int idVeiculo, 
            string cor
            )
        {
            var car = _vehicleRepository.UpdateColor(idVeiculo, cor);
            return car;
        }

        public Task<Vehicle> alterarValor(
           [Service] IVehicleRepository _vehicleRepository,
            double valor,
            int idVeiculo
            )
        {
            var car = _vehicleRepository.UpdateValue(idVeiculo, valor);
            return car;
        }

        // proteger
        [Authorize()]
        public Task<Vehicle> novoVeiculo(
            [Service] IVehicleRepository _vehicleRepository,
            Vehicle vehicle)
        {
            var newVehicle = _vehicleRepository.CreateVehicle(vehicle);
            return newVehicle;
        }
    }
}
