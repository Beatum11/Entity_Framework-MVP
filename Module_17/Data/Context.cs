using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Module_17
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public Context() : base("DbConnect") { }


    }
}
