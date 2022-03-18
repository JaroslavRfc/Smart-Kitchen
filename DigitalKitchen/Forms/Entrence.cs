using DigitalKitchen.Forms;
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

namespace DigitalKitchen
{
    public partial class Entrence : Form
    {
        MyDbContext myDbContext;

        public Entrence()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            myDbContext = new();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<Models.User> users = myDbContext.Users.ToList();//создание списка пользователя.
            foreach(var user in users)//пробегаемся по пользователям.
            {
                if (EntrenceTextBox.Text == user.Login)
                {
                    AppSettings.LoggedUser = user;//авторизация пользователя.
                    Models.Log log = new();//создаётся лог.
                    log.Text = $"{user.Login} is logged in";//заполнения лога, добавление и сохранение его в базе данных.
                    log.Date = DateTime.Now;
                    log.UserId = user.Id;
                    myDbContext.Logs.Add(log);
                    myDbContext.SaveChanges();
                    Main main = new();
                    main.Show();
                    this.Hide();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
