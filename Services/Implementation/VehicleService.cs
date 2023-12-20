using Repositories.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Implementation
{
    public class VehicleService : IVehicleService
    {
        public Vehicle Create(Vehicle v)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

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

        public Vehicle Update(Vehicle v)
        {
            throw new NotImplementedException();
        }


    }
}
