using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assign3
{
    internal class Car : Vehicle
{
    public override string Type { get => "CAR"; }

    protected int Seats;
    protected string EngineType;
    protected string Transmission;
    protected bool Convertible;

    public Car() { }

    public int getSeats()
    {
        return Seats;
    }

    public void setSeats(int value)
    {
        Seats = value;
    }

    public string getEngineType()
    {
        return EngineType;
    }

    public void setEngineType(string value)
    {
        EngineType = value;
    }

    public string getTransmission()
    {
        return Transmission;
    }

    public void setTransmission(string value)
    {
        Transmission = value;
    }

    public bool getConvertible()
    {
        return Convertible;
    }

    public void setConvertible(bool value)
    {
        Convertible = value;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();

        Console.WriteLine($"Seats: \"{Seats}\"");
        Console.WriteLine($"EngineType: \"{EngineType}\"");
        Console.WriteLine($"Transmission: \"{Transmission}\"");
        Console.WriteLine($"Convertible: \"{Convertible}\"");
    }
}
}
