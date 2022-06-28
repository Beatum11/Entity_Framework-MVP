using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Models
{
   public class Model
    {
        public List<Customer_Buys> ShowBuys(string clientEmail)
        {
            using (var newContext = new NewContext())
            {

                var clients = newContext.Customers_Buys.Where(c =>
                                                  c.Email == clientEmail);
                return clients.ToList();
            }
        }





    }
}
