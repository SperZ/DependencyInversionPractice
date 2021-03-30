using CarSales.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.UI
{
    public static class Factory
    {
        public static IVehicle CreateVehicle()
        {
            return new Car();
        }

        public static IPerson CreateSalesman()
        {
            return new SalesMan();
        }

        public static IPerson CreateCustomer()
        {
            return new Customer();
        }

        public static IVehicleInventory CreateVehicleInventory()
        {
            return new VehicleInventory();
        }

        public static ISalesReciept CreateSalesReciept()
        {
            return new SalesReciept();
        }

        public static IPersonInventory CreateCustomerInventory()
        {
            return new CustomerInventory();
        }

        public static IPersonInventory CreateEmployeeInventory()
        {
            return new SaleEmployeeInventory();
        }
    }
}
