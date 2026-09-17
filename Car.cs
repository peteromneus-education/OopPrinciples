namespace OopPrinciples;

    internal class Car : Vehicle
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
    }

// The runtime selects this override when the actual object is a Car.
        public override void PrintInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }
