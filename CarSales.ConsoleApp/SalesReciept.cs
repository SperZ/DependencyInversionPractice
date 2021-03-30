using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.ConsoleApp
{
    public class SalesReciept : ISalesReciept
    {
        public IPerson SalesMan { get; set; }
        public IPerson Customer { get; set; }
        public IVehicle Car { get; set; }
        public int SalesTotal { get; set; }

        public SalesReciept() { }
        public SalesReciept(SalesMan salesMan, Customer customer, IVehicle car, int salesTotal)
        {
            SalesMan = salesMan;
            Customer = customer;
            Car = car;
            SalesTotal = salesTotal;

            salesMan.TotalSales += salesTotal;
            salesMan.TotalSold++;
            salesMan.TotalMadeOffCommision += (salesTotal * salesMan.CommissionPercetage);
        }

    }
}
