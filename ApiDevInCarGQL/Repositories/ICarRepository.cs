using ApiDevInCarGQL.Models;

namespace ApiDevInCarGQL.Repositories
{
    public interface ICarRepository
    {
        Task<Vehicle> CreateVehicle(Vehicle car);
        Task<List<Vehicle>> GetAll();
        Task<List<Vehicle>> GetAvailable();
        Task<List<Vehicle>> GetSelled();
        Task<Vehicle> GetExpensiveSelled();
        Task<Vehicle> GetCheapSelled();
        Task<Vehicle> UpdateColor(int chassis, string color);
        Task<Vehicle> UpdateValue(int chassis, double value);
    }
}
