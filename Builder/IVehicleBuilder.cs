public interface IVehicleBuilder
{
    void SetBrand(string brand);
    void SetModel(string model);
    void SetYear(int year);
    void SetColor(string color);
    Vehicle GetVehicle();
}
