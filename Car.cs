namespace OopPrinciples;

internal class Car : Vehicle
{
    public Car(string brand) : base(brand)
    {
    }

    public override void Move()
    {
        Console.WriteLine("The car drives on the road.");
    }
}
