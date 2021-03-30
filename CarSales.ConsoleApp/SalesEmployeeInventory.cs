using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.ConsoleApp
{
    public class SaleEmployeeInventory : IPersonInventory
    {
        public List<IPerson> PersonList { get; set; }

        public void Add(IPerson person)
        {
            this.PersonList.Add(person);
        }

        public void Remove(IPerson person)
        {
            this.PersonList.Remove(person);
        }

        public List<IPerson> GetAll()
        {

            return PersonList;
        }

        public IPerson GetPerson(int id)
        {
            foreach (SalesMan person in PersonList)
            {
                if (person.ID == id)
                    return person;
            }
            return null;
        }
    }
}
