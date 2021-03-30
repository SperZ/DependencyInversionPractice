using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.ConsoleApp
{
    public class VehicleInventory : IVehicleInventory
    {
        public List<IVehicle> Stock { get; set; }

        private readonly List<IVehicle> _stock = new List<IVehicle>();
        public void Add(IVehicle vehicle)
        {
            _stock.Add(vehicle);
        }

        public int Count()
        {
            return _stock.Count();
        }

        public IVehicle FindVehicle(int id)
        {
            foreach(IVehicle vehicle in Stock)
            {
                if(vehicle.ID == id)
                {
                    return vehicle;
                }
            }
            return null;
        }

        public List<IVehicle> GetAll()
        {
            return Stock;
        }

        public void Remove(IVehicle vehicle)
        {
            _stock.Remove(vehicle);
        }
    }
}
