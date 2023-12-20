using Repositories.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IVehicleService
    {
        List<Vehicle> GetAllVehicles();
    }
}
