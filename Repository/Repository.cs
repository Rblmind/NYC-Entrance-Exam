using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;
using MySQLCRUD.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLCRUD.Repository
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Repository : DbContext,IRepository
    {
        public Repository()
             : base("name=MySQLCRUD")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }

        public override int SaveChanges() { 
            return base.SaveChanges();
        }
    }
}
