using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject;
using Entities;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* using (ContextDA db = new ContextDA())
             {
                 CustomerTest c = new CustomerTest(db);
                 c.TestMethod1();
             }*/

            ContextDA contexteDA = new ContextDA();
            contexteDA.Customers.Add(new Customer("TEST"));
        }
    }
}
