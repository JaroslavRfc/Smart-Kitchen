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
    public partial class AddTechnicalCard : Form
    {
        MyDbContext myDbContext;
        OperationType operationType;
        Models.TechnicalCard technicalCard; 

        public AddTechnicalCard(OperationType operationType)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            this.operationType = operationType;
            myDbContext = new();
        }
        
        public AddTechnicalCard(OperationType operationType, Models.TechnicalCard technicalCard)
        {
            InitializeComponent();
            this.operationType = operationType;
            myDbContext = new();
            this.technicalCard = technicalCard;
            AddTcNameTextBox.Text = technicalCard.Name;
            AddTcCheckBox.Checked = technicalCard.IsHalfStuff;
            AddTcCostPriceTextBox.Text = technicalCard.CostPrice.ToString();
            AddTcFinalPriceTextBox.Text = technicalCard.FinalPrice.ToString();
        }

        private void AddTcOkButton_Click(object sender, EventArgs e)
        {
            if(operationType == OperationType.Add)
            {
                var newTechnicalCard = new Models.TechnicalCard();
                newTechnicalCard.Name = AddTcNameTextBox.Text;
                newTechnicalCard.IsHalfStuff = AddTcCheckBox.Checked;
                newTechnicalCard.CostPrice = decimal.Parse(AddTcCostPriceTextBox.Text);
                newTechnicalCard.FinalPrice = decimal.Parse(AddTcFinalPriceTextBox.Text);
                Models.Log log = new();
                log.Text = $"{newTechnicalCard.Name} is added.";
                log.Date = DateTime.Now;
                log.UserId = AppSettings.LoggedUser.Id;
                myDbContext.Logs.Add(log);

                myDbContext.TechnicalCards.Add(newTechnicalCard);
                myDbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            else if(operationType == OperationType.Edit)
            {
                var id = technicalCard.Id;
                var editTechnicalCard = myDbContext.TechnicalCards.Where(x => x.Id == id).FirstOrDefault();
                editTechnicalCard.Name = AddTcNameTextBox.Text;
                editTechnicalCard.IsHalfStuff = AddTcCheckBox.Checked;
                editTechnicalCard.CostPrice = decimal.Parse(AddTcCostPriceTextBox.Text);
                editTechnicalCard.FinalPrice = decimal.Parse(AddTcFinalPriceTextBox.Text);
                Models.Log log = new();
                log.Text = $"{editTechnicalCard.Name} is deleted.";
                log.Date = DateTime.Now;
                log.UserId = editTechnicalCard.Id;
                myDbContext.Logs.Add(log);
                myDbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void AddTcCancelButton_Click(object sender, EventArgs e)
        {
            TechnicalCard technicalCard = new();
            technicalCard.Show();
            this.Hide();
        }
    }
}
