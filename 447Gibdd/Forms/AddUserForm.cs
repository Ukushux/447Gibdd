using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _447Gibdd.Classes;
using _447Gibdd.Classes.Entities;

namespace _447Gibdd.Forms
{
    public partial class AddUserForm : Form
    {
        User EditedUser;
        public AddUserForm(User user)
        {
            EditedUser = user;
            InitializeComponent();

        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            EditedUser.SurName = tb_surname.Text;
            EditedUser.FirstName = tb_firstname.Text;
            EditedUser.LastName = tb_lastname.Text;
            EditedUser.Login = tb_login.Text;
            EditedUser.pass = tb_password.Text;

            if (EditedUser.Id == 0)
            {
                EfModel.Init().Users.Add(EditedUser);
            }
            EfModel.Init().SaveChanges();
            Close();
        }

        private void clear_text_Click(object sender, EventArgs e)
        {
            tb_surname.Clear();
            tb_firstname.Clear();
            tb_lastname.Clear();
            tb_login.Clear();
            tb_password.Clear();
        }
    }
}
