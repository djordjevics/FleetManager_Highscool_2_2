using Repositories.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IFuelLogService
    {
        List<FuelLog> GetAllFuelLog();

        FuelLog GetById(int id);

        FuelLog GetByVehicleID(int id);

        FuelLog Create(FuelLog fuelLog);

        FuelLog Update(FuelLog fuelLog);
     
    }
}
