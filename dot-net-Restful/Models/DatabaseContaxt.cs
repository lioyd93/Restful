using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace dot_net_Restful.Models
{
    public class DatabaseContaxt: DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        //public DbSet<Movies> Movies { get; set; }
        //public DbSet<Genre> Genre{ get; set; }
        public DbSet<Membershiptype> MembershipType { get; set; }

        public DatabaseContaxt()
          : base("DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContaxt, System.Data.Entity.Migrations.Configuration>("DefaultConnection"));

        }
    }
    
}