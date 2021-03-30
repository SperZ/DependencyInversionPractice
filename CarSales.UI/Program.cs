using CarSales.ConsoleApp;
using System;

namespace CarSales.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car dodge =(Car)Factory.CreateVehicle();
            dodge.ID = 1;
            dodge.Make = "Dodge";
            dodge.Model = "Charger";
            dodge.Color = "Blue";
            dodge.Mileage = 10089;
            dodge.IsNew = true;
            dodge.NumberOfKeys = 2;
            dodge.Price = 21000;
            dodge.VehicleType = VehicleType.Car;
            dodge.FuelType = FuelType.Gas;
            Console.WriteLine(dodge.Model);

            IVehicleInventory vehicleInventory = Factory.CreateVehicleInventory();
            
            vehicleInventory.Add(dodge);
            vehicleInventory.Add(dodge);
            Console.WriteLine(vehicleInventory.Count());
            vehicleInventory.Remove(dodge);
            Console.WriteLine(vehicleInventory.Count());

            SalesMan salesMan = (SalesMan)Factory.CreateSalesman();
            salesMan.ID = 1;
            salesMan.FirstName = "Steve";
            salesMan.LastName = "Bonner";
            salesMan.CommissionPercetage = .06m;

            Customer customer = (Customer)Factory.CreateCustomer();
            customer.ID = 1;
            customer.FirstName = "John";
            customer.LastName = "Jovi";
            customer.EmailAddress = "jjovi@iu.net";
            customer.Address = "3232 CrestWood Dr.";

            ISalesReciept salesReciept = Factory.CreateSalesReciept();
            salesReciept.Car = dodge;
            salesReciept.SalesMan = salesMan;
            salesReciept.Customer = customer;
            salesReciept.SalesTotal = 2100;

            Console.WriteLine(salesReciept.Car.Mileage);
            Console.WriteLine(salesReciept.SalesMan.FirstName);
            Console.WriteLine(salesReciept.Customer.LastName);
            SaleCalculations(salesReciept);
            Console.WriteLine(salesMan.TotalMadeOffCommision);
            
            
        }

        public static void SaleCalculations(ISalesReciept reciept)
        {
            reciept.SalesMan.TotalSold++;
            reciept.SalesMan.TotalSales += reciept.Car.Price;
            reciept.SalesMan.TotalMadeOffCommision += reciept.Car.Price * reciept.SalesMan.CommissionPercetage;
   
        }
    }
}
