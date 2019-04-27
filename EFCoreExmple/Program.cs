using System;
using System.Collections.Generic;
using DatabaseContext.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Models;

namespace EFCoreExmple
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository repo=new CustomerRepository();
            

            //customer insert
            Customer customerOne=new Customer();
            customerOne.Name = "Mr. One";
            customerOne.Address = "landon";
            customerOne.Country = "south Asia";
            customerOne.Email = "mrone@gmail.com";
            repo.add(customerOne);

            //update Customer Address
            //Customer retriveCustomer = repo.GetById(1007);
            //retriveCustomer.Address = "Bankok";
            //repo.update(retriveCustomer);

            //Delete Operation
            Customer removeCustomer = repo.GetById(2009);
            repo.Remove(removeCustomer);

            //Show All Data in the database
            List<Customer> getByAll = repo.GetByAll();
            foreach (Customer customer in getByAll)
            {
                Console.WriteLine(customer.Id+" "+customer.Name+" "+customer.Address);
            }

            //Customer retriveCustomer = repo.GetById(1007);
            //retriveCustomer.Address = "thailand";
            //bool isSaved = repo.update(retriveCustomer);
            //if (isSaved)
            //{
            //    Console.WriteLine("Saved!");
            //}
            Console.ReadKey();
        }
    }
}
