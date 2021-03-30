namespace CarSales.ConsoleApp
{
    public interface ISalesReciept
    {
        IVehicle Car { get; set; }
        Customer Customer { get; set; }
        SalesMan SalesMan { get; set; }
        int SalesTotal { get; set; }
    }
}