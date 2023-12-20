using Repositories.Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public class VehicleService : IVehicleService
    {
        public List<Vehicle> GetAllVehicles()
        {
            return new List<Vehicle>
            {
                new Vehicle { Registration = "NS123NS" },
                new Vehicle { Registration = "NS234BM" }
            };
        }
    }
}
