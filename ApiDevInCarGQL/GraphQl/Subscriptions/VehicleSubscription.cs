using ApiDevInCarGQL.Models;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Types;

namespace ApiDevInCarGQL.Subscriptions
{
    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class VehicleSubscription
    {
        [Subscribe]
        public Vehicle VeiculoVendido([Topic] VehicleType type, [EventMessage] Vehicle message) => message;

        [Subscribe]
        public Vehicle VeiculoAdicionado([Topic] VehicleType type, [EventMessage] Vehicle message) => message;
  
    }
}
