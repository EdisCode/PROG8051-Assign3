using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assign3
{
    internal class Motorcycle : Vehicle
    {
        public override string Type { get => "MOTORCYCLE"; }

        protected double EngineCapacity;
        protected string FuelType;
        protected bool HasFairing;

        public double getEngineCapacity()
        {
            return EngineCapacity;
        }

        public void setEngineCapacity(double value)
        {
            EngineCapacity = value;
        }

        public string getFuelType()
        {
            return FuelType;
        }

        public void setFuelType(string value)
        {
            FuelType = value;
        }

        public bool getHasFairing()
        {
            return HasFairing;
        }

        public void setHasFairing(bool value)
        {
            HasFairing = value;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();

            Console.WriteLine($"EngineCapacity: {EngineCapacity}");
            Console.WriteLine($"FuelType: {FuelType}");
            Console.WriteLine($"HasFairing: {HasFairing}");
        }
    }
}
