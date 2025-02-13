using DBConnectProject.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.service
{
    internal class CustomerService : ICustomerService
    {
        CrudRepository<Customers, string> repository;

        public CustomerService(CrudRepository<Customers, string> repository)
        {
            this.repository = repository;
        }

        public void customerDelete(string id)
        {
            Customers c = repository.GetByİd(id);
            if (c != null)
            {
                repository.Remove(c);

            }
        }

        public void customerSave(string id, string companyName, string contactName)
        {
            Customers c = repository.GetByİd(id);

            if (c != null)
            {
                return;
            }
            Customers customer = new Customers();
            customer.CustomerID = id;
            customer.CompanyName = companyName;
            customer.ContactName = contactName;

            repository.Add(customer);

        }

        public bool customerUpdate(string id, string contactName)
        {
            Customers customer = repository.GetByİd(id);

            if (customer != null)
            {
                customer.ContactName = contactName;
                repository.Update(customer, id);
                return true;
            }
            else
            {
                return false;
            }





        }
    }
}
