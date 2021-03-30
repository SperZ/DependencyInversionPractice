using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.ConsoleApp
{
    public class CustomerInventory : IPersonInventory
    {
        public List<IPerson> PersonList { get; set; }

        public void Add(IPerson person)
        {
            this.PersonList.Add(person);
        }

        public List<IPerson> GetAll()
        {
            throw new NotImplementedException();
        }

        public IPerson GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPerson person)
        {
            throw new NotImplementedException();
        }
    }
}
