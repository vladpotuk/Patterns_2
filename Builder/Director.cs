public class Director
{
    public void Construct(IVehicleBuilder builder, string brand, string model, int year, string color)
    {
        builder.SetBrand(brand);
        builder.SetModel(model);
        builder.SetYear(year);
        builder.SetColor(color);
    }
}
