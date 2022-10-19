using ApiDevInCarGQL.Models;

namespace ApiDevInCarGQL.Repositories
{
    public interface IVehicleRepository
    {
        Task<Vehicle> CreateVehicle(Vehicle vehicle);
        Task<List<Vehicle>> GetAll(string type);
        Task<List<Vehicle>> GetAvailable(string type);
        Task<List<Vehicle>> GetSelled(string type);
        Task<Vehicle> GetExpensiveSelled(string type);
        Task<Vehicle> GetCheapSelled(string type);
        Task<Vehicle> UpdateColor(int chassis, string color);
        Task<Vehicle> UpdateValue(int chassis, double value);
    }
}
