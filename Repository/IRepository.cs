using MySQLCRUD.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLCRUD.Repository
{
    public interface IRepository
    {
        DbSet<User> Users { get; set; }
        DbSet<Roles> Roles { get; set; }
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
    }
}
