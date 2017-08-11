using System;

namespace startimoveis.Models
{
    public class House:Property
    {
        new public int ID { get; set; }
        public string Characteristic { get; set; }
    }
}

