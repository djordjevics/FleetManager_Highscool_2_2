using Repositories.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Implementation
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

        public Vehicle GetById(int id) 
        {
            return new Vehicle 
            {
                Id = id, Registration = "dummy" 
            };
        }
    }
}
