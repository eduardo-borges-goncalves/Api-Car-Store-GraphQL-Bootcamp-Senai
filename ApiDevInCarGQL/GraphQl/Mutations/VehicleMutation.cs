using ApiDevInCarGQL.Models;
using ApiDevInCarGQL.Repositories;
using ApiDevInCarGQL.Subscriptions;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Subscriptions;

namespace ApiDevInCarGQL.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VehicleMutation
    {
        [Authorize]
        public async Task<Vehicle> venderVeiculo(
            [Service] IVehicleRepository _vehicleRepository,
            [Service] ITopicEventSender eventSender,
            int idVeiculo,
            string cpf, 
            DateTime? date
            )
        {      
            var vehicle = await _vehicleRepository.SellVehicle(idVeiculo, cpf, date);
            await eventSender.SendAsync(vehicle.VehicleType, vehicle).ConfigureAwait(false);
            return vehicle;
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

        [Authorize()]
        public async Task<Vehicle> novoVeiculo(
            [Service] IVehicleRepository _vehicleRepository,
            [Service] ITopicEventSender eventSender,
            Vehicle vehicle)
        {
            var newVehicle = await _vehicleRepository.CreateVehicle(vehicle);
            await eventSender.SendAsync(vehicle.VehicleType, vehicle).ConfigureAwait(true);
            return newVehicle;
        }
    }
}
