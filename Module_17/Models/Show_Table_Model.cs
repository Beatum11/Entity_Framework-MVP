using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Models
{
   public class Show_Table_Model
    {

        public List<Customer> ShowTable()
        {
            using (var context = new Context())
            {
                return context.Customers.ToList();
            }
        }



    }
}
