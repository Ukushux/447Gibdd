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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            User user = EfModel.Init().Users.Where(u => u.Login == tb_login.Text && u.pass == tb_pass.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("eRROR!");
            }
            else
            {
                MessageBox.Show("Успех! " + user.SurName);
                Hide();
                new UsersListForm().ShowDialog();
                Show();
            }
        }
    }
}
