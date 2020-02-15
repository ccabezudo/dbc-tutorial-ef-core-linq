using DBC.Training.EF.Core.Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBC.Training.EF.Core.Linq
{
    public class DataRepository
    {
        public List<Customer> customers { get; set; }
        public List<Product> products { get; set; }
        public List<Invoice> invoices { get; set; }

        public void Init()
        {
            InitCustomer();
            InitProduct();
        }

        public void InitCustomer()
        {
            customers = new List<Customer>();
            customers.Add(new Customer()
            {
                Id = 1,
                Email = "jj2@live.com",
                Name = "Jose Jose",
                Phone = "787-558-8872",
                ZipCode = "00956"
            });

            customers.Add(new Customer()
            {
                Id = 2,
                Email = "jenifer.l@live.com",
                Name = "Jen Leftwich",
                Phone = "899-872-6844",
                ZipCode = "77458"
            });
            customers.Add(new Customer()
            {
                Id = 3,
                Email = "john@live.com",
                Name = "John NoLastname",
                Phone = "998-458-8872",
                ZipCode = "88775"
            });
            customers.Add(new Customer()
            {
                Id = 4,
                Email = "tony@yahoo.com",
                Name = "Tony Molina",
                Phone = "787-551-1258",
                ZipCode = "00956"
            });
        }
        public void InitProduct()
        {
            products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Apple",
                Price = 0.89
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Bannan",
                Price = 0.07
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Pineapple",
                Price = 2.58
            });
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public List<Customer> GetCustomerByZipCode(string zipCode)
        {
            var result = customers
                .Where(costumer => costumer.ZipCode == zipCode)
                .ToList();
            return result;
        }

        public List<Customer> GetCustomerByAreaCode(string areaCode)
        {
            var result = customers
                .Where(costumer => costumer.Phone.StartsWith(areaCode))
                .ToList();
            return result;
        }
    }
}
