using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assign3
{
    internal class Truck : Vehicle
    {
        public override string Type { get => "TRUCK"; }

        protected double Capacity;
        protected string TruckType;
        protected bool FourWheelDrive;

        public double getCapacity()
        {
            return Capacity;
        }
        public void setCapacity(double value)
        {
            Capacity = value;
        }

        public string getTruckType()
        {
            return TruckType;
        }

        public void setTruckType(string value)
        {
            TruckType = value;
        }

        public bool getFourWheelDrive()
        {
            return FourWheelDrive;
        }

        public void setFourWheelDrive(bool value)
        {
            FourWheelDrive = value;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();

            Console.WriteLine($"Capacity: \"{Capacity}\"");
            Console.WriteLine($"TruckType: \"{TruckType}\"");
            Console.WriteLine($"FourWheelDrive: \"{FourWheelDrive}\"");
        }
    }
}
