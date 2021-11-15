using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "  Osman";
            customer1.CustomerSurname = "  Beshirov  ";
            customer1.CustomerWealth = 200000;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "  Kanan";
            customer2.CustomerSurname = "  Akhmadzade  ";
            customer2.CustomerWealth = 500000;

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "  Maqqa";
            customer3.CustomerSurname = "  Aliyev  ";
            customer3.CustomerWealth = 4545400000;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerId + customer.CustomerName + customer.CustomerSurname + customer.CustomerWealth);
                //customerManager.addToList(customer);
            }

            
           // customerManager.addToList(customer1);

        }
    }
}
