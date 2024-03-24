

namespace PROG8051_Assign3
{
    internal class Truck : Vehicle
    {
        public override string Type { get => "TRUCK"; }

        public double Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        public override void DisplayDetails()
        {
            // Inherited method
            base.DisplayDetails();

            Console.WriteLine($"Capacity: \"{Capacity}\"");
            Console.WriteLine($"Truck Type: \"{TruckType}\"");
            Console.WriteLine($"Four Wheel Drive: \"{FourWheelDrive}\"");
        }
    }
}
