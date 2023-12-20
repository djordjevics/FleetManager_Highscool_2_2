using Repositories.Models;
using System.Collections.Generic;
using System.Dynamic;

namespace Services.Interfaces
{
    public interface IVehicleService
    {
        List<Vehicle> GetAllVehicles();

        Vehicle GetById(int id);

        Vehicle Create(Vehicle v);

        Vehicle Update(Vehicle v);

        bool Delete(int id);
    }
}
