using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Entities;

namespace UnitTestProject
{
    /// <summary>
    /// Description résumée pour UnitTest1
    /// </summary>
    [TestClass]
    public class CustomerTest
    {
        public ContextDA db;

        public CustomerTest(ContextDA db)
        {
            this.db = db;
        }

        [TestMethod]
        public void TestMethod1()
        {
           
                // Create and save a new Customer 
                Customer c = new Customer("Toto");
                db.Customers.Add(c);
                db.SaveChanges();

                // Display all Blogs from the database 
                IEnumerable<Customer> query = from customer in db.Customers
                            orderby customer.LastName
                            select customer;

                Console.WriteLine("All customers in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            

        }
    }
}
