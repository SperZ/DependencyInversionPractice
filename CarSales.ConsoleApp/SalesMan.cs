using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.ConsoleApp
{
    public class SalesMan : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TotalSales { get; set; }
        public int TotalSold { get; set; }
        public decimal TotalMadeOffCommision { get; set; }
        public decimal CommissionPercetage { get; set; }

        public SalesMan() { }
        public SalesMan(int salesId, string firstName, string lastName, decimal totalSales, int totalSold, decimal totalMadeOffCommission, decimal commissionPercentage) 
        {
            ID = salesId;
            FirstName = firstName;
            LastName = lastName;
            TotalSales = totalSales;
            TotalSold = totalSold;
            TotalMadeOffCommision = totalMadeOffCommission;
            CommissionPercetage = commissionPercentage;
        }
    }
}
