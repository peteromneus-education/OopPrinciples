namespace OopPrinciples;

public class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
    }
}