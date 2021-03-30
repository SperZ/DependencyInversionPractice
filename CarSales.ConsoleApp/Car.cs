using System;

namespace CarSales.ConsoleApp
{
    public enum VehicleType { Car, Truck, SUV, Van }
    public enum FuelType { Gas, Diesel, Electric, Hybrid}
    public class Car : IVehicle
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public bool IsNew { get; set; }
        public string Color { get; set; }
        public int NumberOfKeys { get; set; }
        public int Price { get; set; }
        public VehicleType VehicleType { get; set; }
        public FuelType FuelType { get; set; }

        public Car() { }
        public Car(string make, string model, int mileage, bool isNew, string color, int numberOfKeys, VehicleType vehicleType, FuelType fuelType)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            IsNew = isNew;
            Color = color;
            NumberOfKeys = numberOfKeys;
            VehicleType = vehicleType;
            FuelType = fuelType;
        }
    }
}
