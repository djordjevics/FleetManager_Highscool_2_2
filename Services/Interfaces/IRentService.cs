using Repositories.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IRentService
    {
        List<Rent> GetAllRents();
    }
}
