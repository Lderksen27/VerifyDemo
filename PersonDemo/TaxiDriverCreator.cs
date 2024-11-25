using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    public class TaxiDriverCreator
    {
        public Taxidriver CreateTaxiDriver(string fullName, int age, string licensePlate )
        {
            return new Taxidriver(fullName, age, licensePlate);
        }
    }
}
