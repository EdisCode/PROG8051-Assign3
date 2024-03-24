

namespace PROG8051_Assign3
{
    internal class Car : Vehicle
{
    public override string Type { get => "CAR"; }

    public int Seats { get; set; }
    public string EngineType { get; set; }
    public string Transmission { get; set; }
    public bool Convertible { get; set; }

    public override void DisplayDetails()
    {
        // Inherited method
        base.DisplayDetails();

        Console.WriteLine($"Seats: \"{Seats}\"");
        Console.WriteLine($"Engine Type: \"{EngineType}\"");
        Console.WriteLine($"Transmission: \"{Transmission}\"");
        Console.WriteLine($"Convertible: \"{Convertible}\"");
    }
}
}
