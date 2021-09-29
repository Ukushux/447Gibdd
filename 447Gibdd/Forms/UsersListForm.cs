using _447Gibdd.Classes.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _447Gibdd.Forms
{
    public partial class UsersListForm : Form
    {
        public UsersListForm()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "192.168.201.12",
                Port = 3306,
                UserID = "ISP333_StoliarovID",
                Password = "I%!L96D86",
                Database = "TestGibdd",
                CharacterSet = "utf8"

            };
            Console.WriteLine(builder.ToString());
            UpdateData();
        }
        private void UpdateData()
        {
            dgvUsers.Rows.Clear();
            foreach (User user in EfModel.Init().Users.Where(u=>u.SurName.Contains(tbSearch.Text) ||
            u.SurName.Contains(tbSearch.Text) || u.LastName.Contains(tbSearch.Text) ||
            u.Login.Contains(tbSearch.Text) || u.pass.Contains(tbSearch.Text)))

            {
                int r = dgvUsers.Rows.Add(user.SurName, user.FirstName, user.LastName, user.Login, user.pass);
                dgvUsers.Rows[r].Tag = user;
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                AddUserForm addUser = new AddUserForm(dgvUsers.SelectedRows[0].Tag as User);
                addUser.ShowDialog();
                UpdateData();
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                EfModel.Init().Users.Remove(dgvUsers.SelectedRows[0].Tag as User);
                EfModel.Init().SaveChanges();
                UpdateData();
            }
        }

        private void bt_adduser_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm(new User());
            addUser.ShowDialog();
            UpdateData();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
