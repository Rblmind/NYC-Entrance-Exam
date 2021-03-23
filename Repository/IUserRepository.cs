using MySQLCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLCRUD.Repository
{
    public interface IUserRepository
    {
        User AddUser(User model);
        User EditUser(User model);
        User DeleteUser(int id);
        IList<User> GetUsers();
    }
}
