using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Models
{
    public class Add_Customer_Model
    {

        public List<Customer> AddCustomer(string surname,
                                          string name,
                                          string fath_name, 
                                          string email)
        {
            using (var context = new Context())
            {
                Customer customer = new Customer(surname, name, fath_name, null, email);

                context.Customers.Add(customer);
                context.SaveChanges();

                return context.Customers.ToList();
            }

        }
    }
}
