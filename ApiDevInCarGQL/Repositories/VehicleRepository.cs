using ApiDevInCarGQL.Context;
using ApiDevInCarGQL.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDevInCarGQL.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private DevInCarContext _context;
        public VehicleRepository(DevInCarContext context)
        {
            _context = context;
        }

        public async Task<Vehicle> CreateVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }

        public async Task<List<Vehicle>> GetAll(string type)
        {
            switch (type)
            {
                case ("carro"):
                    var cars = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.carro).ToListAsync();
                    return cars;
                case ("moto"):
                    var motos = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.moto).ToListAsync();
                    return motos;
                case ("camionete"):
                    var vans = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.camionete).ToListAsync();
                    return vans;
                default:
                    var vehicles = await _context.Vehicles.ToListAsync();
                    return vehicles;
            }
        }

        public async Task<List<Vehicle>> GetAvailable(string type)
        {
            switch (type)
            {
                case ("carro"):
                    var cars = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.carro && x.Available)
                        .ToListAsync();
                    return cars;
                case ("moto"):
                    var motos = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.moto && x.Available)
                        .ToListAsync();
                    return motos;
                case ("camionete"):
                    var vans = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.camionete && x.Available)
                        .ToListAsync();
                    return vans;
                default:
                    var vehicles = await _context.Vehicles.Where(x => x.Available).ToListAsync();
                    return vehicles;
            }
        }

        public async Task<Vehicle> GetCheapSelled(string type)
        {
            switch (type)
            {
                case ("carro"):
                    var car = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.carro)
                        .OrderBy(x => x.Value)
                        .FirstOrDefaultAsync();
                    return car;
                case ("moto"):
                    var moto = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.moto)
                        .OrderBy(x => x.Value)
                        .FirstOrDefaultAsync();
                    return moto;
                case ("camionete"):
                    var van = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.camionete)
                        .OrderBy(x => x.Value)
                        .FirstOrDefaultAsync();
                    return van;
                default:
                    var vehicle = await _context.Vehicles
                        .OrderBy(x => x.Value)
                        .FirstOrDefaultAsync();
                    return vehicle;
            }
        }

        public async Task<Vehicle> GetExpensiveSelled(string type)
        {
            switch (type)
            {
                case ("carro"):
                    var car = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.carro)
                        .OrderByDescending(x => x.Value)
                        .FirstOrDefaultAsync();
                    return car;
                case ("moto"):
                    var moto = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.moto)
                        .OrderByDescending(x => x.Value)
                        .FirstOrDefaultAsync();
                    return moto;
                case ("camionete"):
                    var van = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.camionete)
                        .OrderByDescending(x => x.Value)
                        .FirstOrDefaultAsync();
                    return van;
                default:
                    var vehicle = await _context.Vehicles
                        .OrderByDescending(x => x.Value)
                        .FirstOrDefaultAsync();
                    return vehicle;
            }
        }

        public async Task<List<Vehicle>> GetSelled(string type)
        {
            switch (type)
            {
                case ("carro"):
                    var cars = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.carro && !x.Available)
                        .ToListAsync();
                    return cars;
                case ("moto"):
                    var motos = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.moto && !x.Available)
                        .ToListAsync();
                    return motos;
                case ("camionete"):
                    var vans = await _context.Vehicles.Where(x => x.VehicleType == VehicleType.camionete && !x.Available)
                        .ToListAsync();
                    return vans;
                default:
                    var vehicles = await _context.Vehicles.Where(x => x.Available).ToListAsync();
                    return vehicles;
            }
        }

        public async Task<Vehicle> UpdateColor(int idVehicle, string color)
        {
            var updatedVehicle = await _context.Vehicles.Where(x => x.IdVehicle == idVehicle).FirstOrDefaultAsync();
            updatedVehicle.Color = color;
            _context.Entry(updatedVehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return updatedVehicle;
        }

        public async Task<Vehicle> UpdateValue(int idVehicle, double value)
        {
            var updatedVehicle = await _context.Vehicles.Where(x => x.IdVehicle == idVehicle).FirstOrDefaultAsync();
            updatedVehicle.Value = value;
            _context.Entry(updatedVehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return updatedVehicle;
        }

        public async Task<Transaction> SellVehicle(int idVehicle, string cpf, DateTime date)
        {
            var transaction = new Transaction(cpf, idVehicle, date);
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            var selledVehicle = await _context.Vehicles.Where(x => x.IdVehicle == idVehicle).FirstOrDefaultAsync();
            selledVehicle.Available = false;

            var transactionInDB = await _context.Transactions.Where(x => x.IdVehicle == idVehicle).FirstOrDefaultAsync();
            selledVehicle.IdTransaction = transactionInDB.IdTransaction;

            _context.Entry(selledVehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return transaction;
        }
    }
}
