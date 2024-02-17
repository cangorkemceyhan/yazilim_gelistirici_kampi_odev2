using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_oop1
{
    class CustomerManager
    {
        public void Add() { Console.WriteLine("Customer add!"); }
        public void Update() { Console.WriteLine("Customer updated!"); }
    }
    class ProductManager
    {
        public void Add() { Console.WriteLine("Product added!"); }
        public void Update() { Console.WriteLine("Product updated!"); }
    }
    class Customer
    {
        public int Id { get; set; }
        private string _firstName;
        public string FirstName { get { return "Mr. " + _firstName; } set { _firstName = value; } }
        public string LastName { get; set; }
        public string City { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager= new ProductManager();
            productManager.Add();
            productManager.Update();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";
            customer.FirstName = "Gorkem";
            customer.LastName = "Ceyhan";
            Customer customer1 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Can",
                LastName = "Ceyhan"
            };
            Console.WriteLine(customer1.FirstName);

            Console.ReadKey();
        }
    }
}
