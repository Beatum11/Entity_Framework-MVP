using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Models
{
   public class Change_Data_Model
    {

        public List<Customer> ChangeData(string customerIdText,
                                          string changeSurname,
                                          string changeName,
                                          string changeFath_name,
                                          string changeEmail)
        {
            using (var context = new Context())
            {
                int idNumber = int.Parse(customerIdText);

                var customer = context.Customers.Where(c => c.Id == idNumber);

                customer.FirstOrDefault().Surname = changeSurname;
                customer.FirstOrDefault().Name = changeName;
                customer.FirstOrDefault().Fath_Name = changeFath_name;
                customer.FirstOrDefault().Phone_Number = null;
                customer.FirstOrDefault().Email = changeEmail;

                context.SaveChanges();

                return context.Customers.ToList();
            }
        }




    }
}
