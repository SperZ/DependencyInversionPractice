using System.Collections.Generic;

namespace CarSales.ConsoleApp
{
    public interface IPersonInventory
    {
        List<IPerson> PersonList { get; set; }

        void Add(IPerson person);
        List<IPerson> GetAll();
        IPerson GetPerson(int id);
        void Remove(IPerson person);
    }
}