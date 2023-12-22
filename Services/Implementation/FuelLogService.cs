using Repositories.Models;
using System.Collections.Generic;
using System;

namespace Services
{
    public class FuelLogService
    {
        public FuelLog Create(FuelLog fuelLog)
        {
            throw new NotImplementedException();
        }

        public FuelLog GetByVehicleID(int id)
        {
            return new FuelLog
            {
                Id = id
            };
        }

        public FuelLog GetById(int id)
        {
            return new FuelLog
            {
                Id = id
            };
        }

        public FuelLog Update(FuelLog fuelLog)
        {
            return fuelLog;
        }

        public List<FuelLog> GetAllFuelLog()
        {
            return new List<FuelLog>
            {
                new FuelLog {Id = 0, Consumption = 0},
                new FuelLog {Id = 1, Consumption = 1},
                new FuelLog {Id = 2,Consumption = 2}
            };
        }
    }
}
