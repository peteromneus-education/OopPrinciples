public class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
    }
}