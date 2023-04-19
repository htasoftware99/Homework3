using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer is added: " + customer.Name);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is deleted: " + customer.Name);
        }

        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("The number of customers: ", customers.Length);
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id: " + customer.Id);
                Console.WriteLine("Name: " + customer.Name);
                Console.WriteLine("Surname: " + customer.Surname);
                Console.WriteLine("City: " + customer.City);
            }
        }
    }
}
