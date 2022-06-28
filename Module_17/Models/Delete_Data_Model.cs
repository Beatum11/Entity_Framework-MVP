using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Models
{
   public class Delete_Data_Model
    {

        public List<Customer> DeleteData(string deleteCustomerId)
        {
            using (var context = new Context())
            {
                int idNumber = int.Parse(deleteCustomerId);

                var cus = context.Customers.Where(c => c.Id == idNumber);

                if (cus.FirstOrDefault() != null)
                    context.Customers.Remove(cus.FirstOrDefault());

                context.SaveChanges();

                return context.Customers.ToList();
            }
        }
    }
}
