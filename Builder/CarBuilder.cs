public class CarBuilder : IVehicleBuilder
{
    private Vehicle _car = new Vehicle();

    public void SetBrand(string brand)
    {
        _car.Brand = brand;
    }

    public void SetModel(string model)
    {
        _car.Model = model;
    }

    public void SetYear(int year)
    {
        _car.Year = year;
    }

    public void SetColor(string color)
    {
        _car.Color = color;
    }

    public Vehicle GetVehicle()
    {
        _car.Type = "Car";
        return _car;
    }
}
