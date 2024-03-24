
namespace PROG8051_Assign3
{
    // Base class in which other classes will inherit
    abstract class Vehicle
    {
        public abstract string Type { get; }

        public readonly string ProductID;

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        public Vehicle()
        {
            ProductID = (System.Guid.NewGuid()).ToString();
        }

        // Display vehicle details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"\nProduct Type - \"{Type}\"");
            Console.WriteLine($"ProductID: \"{ProductID}\"");
            Console.WriteLine($"Model: \"{Model}\"");
            Console.WriteLine($"Manufacturer: \"{Manufacturer}\"");
            Console.WriteLine($"Year: \"{Year}\"");
            Console.WriteLine($"Rental Price: \"${RentalPrice}\"");
        }
    }
}
