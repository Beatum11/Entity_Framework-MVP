using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
   public class Customer_Buys
    {
        #region Свойства

        public int Id { get; set; }
        public string Email { get; set; }

        public int Item_Id { get; set; }

        public string Item_Name { get; set; }
        #endregion


        #region Конструкторы
        public Customer_Buys(string _email, int _item_id, string _item_name)
        {
            Email = _email;
            Item_Id = _item_id;
            Item_Name = _item_name;
        }

        public Customer_Buys()
        {

        }

        #endregion

    }
}
