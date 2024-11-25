using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    public class Taxidriver : Person
    {
        public bool HasDriversLicense { get; set; } = true;
        public decimal AccountBalance { get; set; } = Decimal.Zero;
        public string? LicensePlate { get; set; }
        public bool isActive { get; set; } = true;

        public Taxidriver(string fullName, int age, string licensePlate)
        : base(fullName, age)
        {
            LicensePlate = licensePlate;
        }

        public bool IsDriverAvailable() 
        {
            return isActive && AccountBalance > 0;
        }
    }
}
