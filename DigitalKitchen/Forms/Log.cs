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
    public partial class Log : Form
    {
        private static Log uniqInstance;
        public static Log GetInstance()
        {
            if (uniqInstance == null || uniqInstance.IsDisposed)
            {
                uniqInstance = new();
            }
            return uniqInstance;
        }

        MyDbContext myDbContext;

        public Log()
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
            LogDataGridView.DataSource = myDbContext.Logs.ToList();
        }

        private void LogBackButton_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Hide();
        }
    }
}
