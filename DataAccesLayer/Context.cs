using EntityLayer.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Context : DbContext
    {
        public Context() : base("name=TeknikServis")
        { 

        }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Car> Cars{ get; set; }
    }
}
