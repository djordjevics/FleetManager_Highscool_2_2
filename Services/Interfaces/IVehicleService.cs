using Repositories.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IVehicleService
    {
        List<Vehicle> GetAllVehicles();

        Vehicle GetById(int id);
    }
}
