using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Models
{
   public class Create_CustomerTable_Model
    {
        public void CreateCustomerTable()
        {
            using (var context = new Context())
            {
                Customer cust1 = new Customer("Иванов", "Иван", "Иванович", null,
                                                  "iv@ml.ru");
                Customer cust2 = new Customer("Олегов", "Олег", "Олегович", null,
                                              "ol@ml.ru");

                context.Customers.Add(cust1);
                context.Customers.Add(cust2);

                //context.SaveChanges();
            }

        }
    }
}
