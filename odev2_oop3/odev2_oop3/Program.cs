using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2_oop3
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Can"},
                new Student{FirstName="Gorkem"},
                new Person{FirstName="Ceyhan"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }



            Console.ReadKey();
        }
    }
}
