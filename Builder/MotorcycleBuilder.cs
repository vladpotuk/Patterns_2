public class MotorcycleBuilder : IVehicleBuilder
{
    private Vehicle _motorcycle = new Vehicle();

    public void SetBrand(string brand)
    {
        _motorcycle.Brand = brand;
    }

    public void SetModel(string model)
    {
        _motorcycle.Model = model;
    }

    public void SetYear(int year)
    {
        _motorcycle.Year = year;
    }

    public void SetColor(string color)
    {
        _motorcycle.Color = color;
    }

    public Vehicle GetVehicle()
    {
        _motorcycle.Type = "Motorcycle";
        return _motorcycle;
    }
}
