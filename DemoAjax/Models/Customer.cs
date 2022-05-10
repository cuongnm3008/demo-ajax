using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAjax.Models
{
    public class Customer
    {

        public Customer()
        {

        }

        public Customer(string name, string address, int age)
        {
            Name = name;
            Address = address;
            Age = age;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }


        public List<Customer> GetCustomers()
        {
            return new List<Customer>{ 
                new Customer("Nguyen Manh Cuong","Bac Ninh",18),
                new Customer("Nguyen Duc Hung","Hai Duong",20),
                new Customer("Nguyen Hai Phuong","Bac Ninh",30),
                new Customer("Nguyen Duc Phap","Hai Phong",22),
                new Customer("Nguyen Dinh Quang","Ha Noi",26),
                new Customer("Tran Quoc Bao","Ha Noi",27),
                new Customer("Nguyen Van Toan","Ha Noi",15),
                new Customer("Nguyen Van Truong","Hai Duong",16),
            };
        }
    }
}
