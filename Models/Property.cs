using System;

namespace startimoveis.Models
{
    public class Property
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal SuitesNumber{ get; set; }
        public decimal Size { get; set; }
        public int Cep { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int PhoneNumber { get; set; }
        public decimal ParkingSpace { get; set; }
        public bool Leasing  { get; set; }
        public bool Sale { get; set; }
    }
}