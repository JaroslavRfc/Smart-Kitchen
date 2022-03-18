using DigitalKitchen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalKitchen.Forms
{
    public partial class User : Form
    {
        private static User uniqInstance;
        public static User GetInstance()
        {
            if(uniqInstance == null || uniqInstance.IsDisposed)
            {
                uniqInstance = new();
            }
            return uniqInstance;
        }

        MyDbContext myDbContext;

        public User()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            myDbContext = new();
            RefreshData();
        }

        private void RefreshData()
        {
            myDbContext = new();
            UserDataGridView.DataSource = myDbContext.Users.ToList();
        }

        private void UserAddButton_Click(object sender, EventArgs e)//добавление пользователя.
        {
            AddUser addUser = new(OperationType.Add);
            addUser.ShowDialog();
            if (addUser.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void UserEditButton_Click(object sender, EventArgs e)//изменение пользователя.
        {
            var userId = (int)UserDataGridView.SelectedRows[0].Cells[0].Value;
            var user = myDbContext.Users.Where(x => x.Id == userId).FirstOrDefault();
            AddUser addUser = new(OperationType.Edit, user);
            addUser.ShowDialog();
            if (addUser.DialogResult == DialogResult.OK)
            {
                Refresh();
            }
        }

        private void UserDelButton_Click(object sender, EventArgs e)//удаление пользователя.
        {
            var userId = (int)UserDataGridView.SelectedRows[0].Cells[0].Value;
            var user = myDbContext.Users.Where(x => x.Id == userId).FirstOrDefault();
            myDbContext.Users.Remove(user);
            myDbContext.SaveChanges();
            RefreshData();
            MessageBox.Show("User is succesfully deleted.");
        }

        private void UserBackButton_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Hide();
        }
    }
}
