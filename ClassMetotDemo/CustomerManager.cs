using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void addToList(Customer musteri)
        {
            Console.WriteLine(musteri.CustomerName + musteri.CustomerSurname + "adli muşterinin serveti: " + musteri.CustomerWealth  ); 
        }
    }
}
