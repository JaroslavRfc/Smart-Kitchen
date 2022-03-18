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
    public partial class AddProduct : Form
    {
        MyDbContext myDbContext;
        OperationType operationType;
        Product product;

        public AddProduct(OperationType operationType)
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            this.operationType = operationType;
            myDbContext = new();
        }

        public AddProduct(OperationType operationType, Product product)
        {
            InitializeComponent();
            this.operationType = operationType;
            myDbContext = new();
            this.product = product;
            ProductNameTextBox.Text = product.Name;
            ProductCountTextBox.Text = product.Count.ToString();
            ProductPriceTextBox.Text = product.Price.ToString();
        }

        private void ProductOkButton_Click(object sender, EventArgs e)
        {
            if(operationType == OperationType.Add)
            {
                var newProduct = new Product();
                newProduct.Name = ProductNameTextBox.Text;
                newProduct.Count = int.Parse(ProductCountTextBox.Text);
                newProduct.Price = decimal.Parse(ProductPriceTextBox.Text);
                Models.Log log = new();
                log.Text = $"{newProduct.Name} is added.";
                log.Date = DateTime.Now;
                log.UserId = AppSettings.LoggedUser.Id;
                myDbContext.Logs.Add(log);

                myDbContext.Products.Add(newProduct);
                myDbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            else if(operationType == OperationType.Edit)
            {
                var id = product.Id;
                var editProduct = myDbContext.Products.Where(x => x.Id == id).FirstOrDefault();
                editProduct.Name = ProductNameTextBox.Text;
                editProduct.Count = int.Parse(ProductCountTextBox.Text);
                editProduct.Price = decimal.Parse(ProductPriceTextBox.Text);
                Models.Log log = new();
                log.Text = $"{editProduct.Name} is changed.";
                log.Date = DateTime.Now;
                log.UserId = editProduct.Id;
                myDbContext.Logs.Add(log);
                myDbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ProductCancelButton_Click(object sender, EventArgs e)
        {
            WareHouse wareHouse = new();
            wareHouse.Show();
            this.Hide();
        }
    }
}
