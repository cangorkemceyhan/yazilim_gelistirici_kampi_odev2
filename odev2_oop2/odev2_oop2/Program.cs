using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_oop2
{
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    interface ICostumerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added!");
        }
        public void Update()
        {
            Console.WriteLine("Sql updated!");
        }
        public void Delete()
        {
            Console.WriteLine("Sql deleted!");
        }
    }
    class OracleCustomerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }
        public void Update()
        {
            Console.WriteLine("Oracle updated!");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }
    }
    class CustomerManager
    {
        public void Add(ICostumerDal costumerDal)
        {
            costumerDal.Add();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfaceOrnek();
            //interfaceOrnek1();
            //interfaceOrnek2();
            



            Console.ReadKey();
        }
        private static void interfaceOrnek()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Gorkem",
                LastName = "Ceyhan",
                Adress = "İstanbul"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Can",
                LastName = "Ceyhan",
                Departmant = "Computer Programming"
            };
            manager.Add(customer);
            manager.Add(student);
        }
        private static void interfaceOrnek1()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }
        private static void interfaceOrnek2()
        {
            ICostumerDal[] costumerDals = new ICostumerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };
            foreach (var costumerDal in costumerDals)
            {
                costumerDal.Add();
            }
        }
    }
}
