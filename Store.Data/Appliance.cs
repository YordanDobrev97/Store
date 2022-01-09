using System;

namespace Store.Data
{
    public class Appliance : Product
    {
        public string Model { get; set; }

        public DateTime ProductionDate { get; set; }

        public double Weight { get; set; }
    }
}
