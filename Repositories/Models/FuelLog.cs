namespace Repositories.Models
{
    public class FuelLog
    {
        public int Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public double Consumption { get; set; }

        public FuelLog() { }

        public FuelLog(int id, Vehicle vehicle, double consumption)
        {
            Id = id;
            Vehicle = vehicle;
            Consumption = consumption;
        }
    }
}