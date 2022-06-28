using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Module_17
{
   public class NewContext : DbContext
    {
        public DbSet<Customer_Buys> Customers_Buys { get; set; }

        public NewContext() : base("NewDbConnect") { }



    }
}
