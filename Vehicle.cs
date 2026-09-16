public class Vehicle
{
    public string Brand { get; private set; } = "Unknown";

    public Vehicle(string brand)
    {
        ChangeBrand(brand);
    }

    public bool ChangeBrand(string newBrand)
    {
        if (string.IsNullOrWhiteSpace(newBrand))
        {
            return false;
        }

        Brand = newBrand;
        return true;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
    }
}