namespace CarSales.ConsoleApp
{
    public interface ISalesReciept
    {
        IVehicle Car { get; set; }
        IPerson Customer { get; set; }
        IPerson SalesMan { get; set; }
        int SalesTotal { get; set; }
    }
}