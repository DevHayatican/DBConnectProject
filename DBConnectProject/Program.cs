using DBConnectProject.controller;
using DBConnectProject.repository;
using DBConnectProject.repository.context;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerController customerController = new CustomerController();

            CustomerRepository repository = new CustomerRepository();

            //customerController.customerSave("ca", "Vektörel", "ali mehmet");

            //bool b = customerController.customerUpdate("ca", "ali koç");

            // customerController.customerDelete("ca");

            //List<Customers> customerList = repository.GetAll();

            //foreach (var item in customerList)
            //{
            //    Console.WriteLine($"ID: {item.CustomerID}, Şirket: {item.CompanyName}, Name: {item.ContactName}");
            //}
             
           
        }
    }
}
