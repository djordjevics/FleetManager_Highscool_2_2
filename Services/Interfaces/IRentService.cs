using Repositories.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IRentService
    {
        List<Rent> GetAllRents();

        Rent GetRent(int id);

        Rent GetRentByVehicleId(int vehicleId);

        Rent Create(Rent r);

        Rent Update(Rent r);

        bool Delete(int id);

    }
}
