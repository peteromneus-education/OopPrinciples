Vehicle firstVehicle = new Vehicle("Toyota");
firstVehicle.PrintInfo();

bool changeSucceeded = firstVehicle.ChangeBrand(" ");

Console.WriteLine(changeSucceeded);
firstVehicle.PrintInfo();

changeSucceeded = firstVehicle.ChangeBrand("Volvo");

Console.WriteLine(changeSucceeded);
firstVehicle.PrintInfo();