namespace OopPrinciples;

public abstract class Vehicle
{
    public string Brand { get; set; }

    protected Vehicle(string brand)
    {
        Brand = brand;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
    }

    // Every concrete vehicle type must define how it moves.
    public abstract void Move();
}