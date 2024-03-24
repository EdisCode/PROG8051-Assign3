

namespace PROG8051_Assign3
{
    internal class Motorcycle : Vehicle
    {
        public override string Type { get => "MOTORCYCLE"; }

        public double EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        public override void DisplayDetails()
        {
            // Inherited method
            base.DisplayDetails();

            Console.WriteLine($"Engine Capacity: \"{EngineCapacity}\"");
            Console.WriteLine($"Fuel Type: \"{FuelType}\"");
            Console.WriteLine($"Has Fairing: \"{HasFairing}\"");
        }
    }
}
