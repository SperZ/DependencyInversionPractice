using System.Collections.Generic;

namespace CarSales.ConsoleApp
{
    public interface IVehicleInventory
    {

        List<IVehicle> Stock { get; set; }

        void Add(IVehicle vehicle);
        int Count();
        List<IVehicle> GetAll();
        void Remove(IVehicle vehicle);

        IVehicle FindVehicle(int id);
    }
}