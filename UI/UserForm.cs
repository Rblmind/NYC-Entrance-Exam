using MySQLCRUD.Model;
using MySQLCRUD.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLCRUD.UI
{
    public partial class UserForm : Form
    {

        ListViewItem lstItems;
        int userId = 0;

        public UserForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();

            var model = new User();
            model.Firstname = txtFirstname.Text;
            model.Middlenname = txtMiddlename.Text;
            model.Lastname = txtLastname.Text;
            model.Age = int.Parse(txtAge.Text);
            model.Gender = txtGender.Text;

            userRepository.AddUser(model);

            MessageBox.Show("Success");

            GetUserList();
        }

        private void GetUserList()
        {

            listView1.Items.Clear();

            IUserRepository userRepository = new UserRepository();

            var userList = userRepository.GetUsers();

            foreach(var users in userList)
            {
                lstItems = listView1.Items.Add(users.Id.ToString());
                lstItems.SubItems.Add(users.Firstname);
                lstItems.SubItems.Add(users.Middlenname);
                lstItems.SubItems.Add(users.Lastname);
                lstItems.SubItems.Add(users.Age.ToString());
                lstItems.SubItems.Add(users.Gender);

            }

            txtFirstname.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtMiddlename.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtGender.Text = string.Empty;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            GetUserList();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                IUserRepository userRepository = new UserRepository();

                userId = int.Parse(listView1.SelectedItems[0].Text);
                var userList = userRepository.GetUsers().FirstOrDefault(x => x.Id == userId);
                txtFirstname.Text = userList.Firstname;
                txtMiddlename.Text = userList.Middlenname;
                txtLastname.Text = userList.Lastname;
                txtAge.Text = userList.Age.ToString();
                txtGender.Text = userList.Gender;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            var userList = userRepository.GetUsers().FirstOrDefault(x => x.Id == userId);
            userList.Firstname = txtFirstname.Text;
            userList.Middlenname = txtMiddlename.Text;
            userList.Lastname = txtLastname.Text;
            userList.Age = int.Parse(txtAge.Text);
            userList.Gender = txtGender.Text;

            userRepository.EditUser(userList);

            MessageBox.Show("Success");

            GetUserList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            userRepository.DeleteUser(userId);
            MessageBox.Show("Success");

            GetUserList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GetUserList();
        }
    }
}
