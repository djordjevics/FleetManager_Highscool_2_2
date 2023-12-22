using Repositories.Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public class RentService : IRentService
    {
        public Rent Create(Rent r)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rent> GetAllRents()
        {
            return new List<Rent>
            {
                new Rent { Id = 1,
                           DateFrom= DateTime.Now ,
                           DateTo = new DateTime (2023, 12, 30),
                           RentedVehicle = new Vehicle {Registration = "NS123NS" }
                },
                new Rent { Id = 2,
                           DateFrom= DateTime.Now ,
                           DateTo= new DateTime (2024, 2, 23),
                           RentedVehicle = new Vehicle {Registration = "NS234BM" } }
            };
        }

        public Rent GetRent(int id)
        {
            throw new NotImplementedException();
        }

        public Rent GetRentByVehicleId(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Rent Update(Rent r)
        {
            throw new NotImplementedException();
        }
    }
}
