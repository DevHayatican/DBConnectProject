using DBConnectProject.repository;
using DBConnectProject.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.controller
{
    internal class CustomerController
    {
        ICustomerService customerService;

        public CustomerController()
        {
            customerService = new CustomerService(new CustomerRepository());
        }

        public void customerDelete(string id)
        {
            customerService.customerDelete(id);
        }


        public void customerSave(string id, string companyName, string contactName)
        {
            customerService.customerSave(id, companyName, contactName);
        }

        public bool customerUpdate(string id,string contactName)
        {
            return customerService.customerUpdate(id, contactName);
        }

    }
}
