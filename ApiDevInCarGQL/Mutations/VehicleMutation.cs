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
        public async Task<int> venderVeiculo(
            [Service] IVehicleRepository _vehicleRepository,
            [Service] ITopicEventSender eventSender,
            int idVeiculo,
            string cpf, 
            DateTime? date
            )
        {      
            var vehicle = _vehicleRepository.SellVehicle(idVeiculo, cpf, date);
            await eventSender.SendAsync(nameof(VehicleSubscription.VeiculoVendido), vehicle).ConfigureAwait(false);
            return idVeiculo;
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
        public async Task<int> novoVeiculo(
            [Service] IVehicleRepository _vehicleRepository,
            [Service] ITopicEventSender eventSender,
            Vehicle vehicle)
        {
            var newVehicle = _vehicleRepository.CreateVehicle(vehicle);
            await eventSender.SendAsync(nameof(VehicleSubscription.VeiculoAdicionado), newVehicle).ConfigureAwait(true);
            return newVehicle.Id;
        }
    }
}
