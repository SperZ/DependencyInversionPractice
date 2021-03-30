namespace CarSales.ConsoleApp
{
    public interface IVehicle
    {
        int ID { get; set; }
        string Color { get; set; }
        FuelType FuelType { get; set; }
        bool IsNew { get; set; }
        string Make { get; set; }
        int Mileage { get; set; }
        int Price { get; set; }
        string Model { get; set; }
        int NumberOfKeys { get; set; }
    }
}