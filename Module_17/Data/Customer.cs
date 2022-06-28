using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
   public class Customer
    {
        #region Свойства
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fath_Name { get; set; }
        public string Phone_Number { get; set; }

        public string Email { get; set; }
        #endregion

        #region Кострукторы
        public Customer(string _surname, string _name, 
                        string _fath_name, string _phone_number,
                        string _email)
        {
            Surname = _surname;
            Name = _name;
            Fath_Name = _fath_name;
            Phone_Number = _phone_number;
            Email = _email;
        }

        public Customer()
        {

        }
        #endregion


    }
}
