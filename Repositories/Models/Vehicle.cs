using System;

namespace Repositories.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Registration {  get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public DateTime ProductionYear { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        
    }
}
