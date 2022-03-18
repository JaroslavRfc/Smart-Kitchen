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
    public partial class TechnicalCard : Form
    {
        private static TechnicalCard uniqInstance;
        public static TechnicalCard GetInstance()
        {
            if (uniqInstance == null || uniqInstance.IsDisposed)
            {
                uniqInstance = new();
            }
            return uniqInstance;
        }

        MyDbContext myDbContext;

        public TechnicalCard()
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
            TCdataGridView.DataSource = myDbContext.TechnicalCards.ToList();
        }

        private void TcAddButton_Click(object sender, EventArgs e)//добавление тех карты.
        {
            AddTechnicalCard addTechnicalCard = new(Models.OperationType.Add);
            addTechnicalCard.ShowDialog();
            if (addTechnicalCard.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void TcEditButton_Click(object sender, EventArgs e)///изменение тех карты.
        {
            var technicalCardId = (int)TCdataGridView.SelectedRows[0].Cells[0].Value;
            var technicalCard = myDbContext.TechnicalCards.Where(x => x.Id == technicalCardId).FirstOrDefault();
            AddTechnicalCard addTechnicalCard = new(OperationType.Edit, technicalCard);
            addTechnicalCard.ShowDialog();
            if (addTechnicalCard.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void TcDelButton_Click(object sender, EventArgs e)//удаление тех карты.
        {
            var technicalCardId = (int)TCdataGridView.SelectedRows[0].Cells[0].Value;
            var technicalCard = myDbContext.TechnicalCards.Where(x => x.Id == technicalCardId).FirstOrDefault();
            Models.Log log = new();
            log.Text = $"{technicalCard.Name} is deleted.";
            log.Date = DateTime.Now;
            log.UserId = technicalCard.Id;
            myDbContext.Logs.Add(log);
            myDbContext.TechnicalCards.Remove(technicalCard);
            myDbContext.SaveChanges();
            RefreshData();
            MessageBox.Show("Technical card is succesfully deleted.");
        }

        private void TcBackButton_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Hide();
        }
    }
}
