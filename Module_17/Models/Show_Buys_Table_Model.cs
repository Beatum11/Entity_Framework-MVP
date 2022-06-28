using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Models
{
    public class Show_Buys_Table_Model
    {

        public List<Customer_Buys> ShowBuysTable()
        {
            using (var newContext = new NewContext())
            {
                return newContext.Customers_Buys.ToList();
            }
        }


    }
}
