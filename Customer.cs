using System;
using System.Collections.Generic;
namespace CustomerDetail
{
    class Customer 
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
    }
    class TestCustomer
    {
        static void Main(string[] args)
        {
            List<Customer>Customers=new List<Customer>();
            Customer c1=new Customer{CustId=101,Name="Pranav Kumar",City="Chennai",Salary=70000.00};
             Customer c2=new Customer{CustId=102,Name="Prem Kumar",City="Noida",Salary=100000.00};
              Customer c3=new Customer{CustId=103,Name="Mukesh S",City="Hosur",Salary=50000.00};
               Customer c4=new Customer{CustId=104,Name="Krishnan",City="Mumbai",Salary=60000.00};
               Customers.Add(c1);
               Customers.Add(c2);
               Customers.Add(c3);
               Customers.Add(c4);
               foreach(Customer obj in Customers)
               {
                   Console.WriteLine(obj.CustId+" "+ obj.Name+" "+obj.City+" "+obj.Salary);
               }
            Console.ReadLine();
        }
    }
}
