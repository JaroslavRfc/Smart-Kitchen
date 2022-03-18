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
    public partial class AddUser : Form
    {
        MyDbContext myDbContext;
        OperationType operationType;
        Models.User user;

        public AddUser(OperationType operationType)
        { 
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            this.operationType = operationType;
            myDbContext = new();
        }

        public AddUser(OperationType operationType, Models.User user)
        {
            InitializeComponent();
            this.operationType = operationType;
            myDbContext = new();
            this.user = user;
            AddUserTextBox.Text = user.Login;
            AddAdminCheckBox.Checked = user.IsAdmin;
        }

        private void AddUserOkButton_Click(object sender, EventArgs e)
        {
            if (operationType == OperationType.Add)
            {
                var newUser = new Models.User();
                newUser.Login = AddUserTextBox.Text;
                newUser.IsAdmin = AddAdminCheckBox.Checked;

                myDbContext.Users.Add(newUser);
                myDbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            else if(operationType == OperationType.Edit)
            {
                var id = user.Id;
                var editUser = myDbContext.Users.Where(x => x.Id == id).FirstOrDefault();
                editUser.Login = AddUserTextBox.Text;
                editUser.IsAdmin = AddAdminCheckBox.Checked;
                myDbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddUserCancelButton_Click(object sender, EventArgs e)
        {
            User user = new();
            user.Show();
            this.Hide();
        }
    }
}
