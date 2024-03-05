using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();

        IVehicleBuilder carBuilder = new CarBuilder();
        director.Construct(carBuilder, "Toyota", "Camry", 2023, "Black");
        Vehicle car = carBuilder.GetVehicle();

        IVehicleBuilder motorcycleBuilder = new MotorcycleBuilder();
        director.Construct(motorcycleBuilder, "Honda", "CBR", 1000, "Red");
        Vehicle motorcycle = motorcycleBuilder.GetVehicle();

        Console.WriteLine(car.Move());
        Console.WriteLine(car.GetDetails());

        Console.WriteLine(motorcycle.Move());
        Console.WriteLine(motorcycle.GetDetails());
    }
}
