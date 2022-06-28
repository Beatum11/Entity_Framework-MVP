using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Models
{
   public class Create_BuysTable_Model
    {
        public void CreateBuysTable()
        {
            using (var newContext = new NewContext())
            {
                Customer_Buys cust_buy1 = new Customer_Buys("iv@ml.ru", 44, "Кораблик");
                Customer_Buys cust_buy2 = new Customer_Buys("iv@ml.ru", 32, "Игрушка");
                Customer_Buys cust_buy3 = new Customer_Buys("ol@ml.ru", 7, "Телефон");

                newContext.Customers_Buys.Add(cust_buy1);
                newContext.Customers_Buys.Add(cust_buy2);
                newContext.Customers_Buys.Add(cust_buy3);

                //newContext.SaveChanges();
            }
        }



    }
}
