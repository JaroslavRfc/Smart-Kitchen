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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void MainWhButton_Click(object sender, EventArgs e)
        {
            WareHouse wareHouse = new();
            wareHouse.Show();
            this.Hide();
        }

        private void MainLogButton_Click(object sender, EventArgs e)
        {
            Log log = new();
            log.Show();
            this.Hide();
        }

        private void MainTcButton_Click(object sender, EventArgs e)
        {
            TechnicalCard technicalCard = new();
            technicalCard.Show();
            this.Hide();
        }

        private void MainUsersButton_Click(object sender, EventArgs e)//доступ только для админа
        {
            var userLogged = AppSettings.LoggedUser.IsAdmin;
            if(userLogged == true)
            {
                User user = new();
                user.Show();
                this.Hide();
            }
            else
            {
                MainUsersButton.Enabled = false;
            }
                
        }

        private void MainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainBackButton_Click(object sender, EventArgs e)
        {
            Entrence entrecne = new();
            entrecne.Show();
            this.Hide();
        }
    }
}
