using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseContext.DbContext;
using Microsoft.EntityFrameworkCore;
using Models;
using Remotion.Linq.Utilities;

namespace EFCoreExmple
{
    class CustomerRepository
    {
        CustomerDbContext db =new CustomerDbContext();

        public Customer GetById(int id)
        {
            Customer customer = db.Customers.Find(id);
            return customer;
        }

        public bool add(Customer customer)
        {
            db.Customers.Add(customer);
            return db.SaveChanges()>0;
        }

        public bool update(Customer customer)
        {
            db.Entry(customer).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Customer customer)
        {
            db.Customers.Remove(customer);
            return db.SaveChanges() > 0;
        }
        public List<Customer> GetByAll()
        {
            return db.Customers.ToList();
        }

        public List<Customer> GetByCountry(string country)
        {
            List<Customer>customers=db.Customers.Where(c=>c.Country==country).ToList();
            return customers;
        }
    }
}
