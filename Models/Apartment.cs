using System;

namespace startimoveis.Models
{
    public class Apartment:Property
    {
        new public int ID { get; set; }
        public decimal MaintenanceFees { get; set; }
    }
}

