using MySQLCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLCRUD.Repository
{
    public class UserRepository : IUserRepository
    {
        IRepository repository = new Repository();

        public User AddUser(User model) {

            try
            {
                this.repository.Users.Add(model);
                this.repository.SaveChanges();
                return model;
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        public User EditUser(User model) {

            try
            {
                var user = this.repository.Users.Find(model.Id);
                user.Firstname = model.Firstname;
                user.Middlenname = model.Middlenname;
                user.Lastname = model.Lastname;
                user.Age = model.Age;
                user.Gender = model.Gender;

                this.repository.SaveChanges();

                return model;
            }
            catch(Exception ex)
            {
                return null;
            }

            
        }
        public User DeleteUser(int id) {

            try
            {
                var user = this.repository.Users.Find(id);
                this.repository.Users.Remove(user);
                this.repository.SaveChanges();
                return user;
            }
            catch(Exception ex)
            {
                return null;
            }
          
        }
        public IList<User> GetUsers() {
            try
            {
                var userList = this.repository.Users.ToList();
                return userList;
            }
            catch(Exception ex)
            {
                return null;
            }
          
        }
    }
}
