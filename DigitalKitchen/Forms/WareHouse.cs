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
    public partial class WareHouse : Form
    {

        private static WareHouse uniqInstance;
        public static WareHouse GetInstance()
        {
            if(uniqInstance == null || uniqInstance.IsDisposed)
            {
                uniqInstance = new();
            }
            return uniqInstance;
        }

        MyDbContext myDbContext;

        public WareHouse()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            myDbContext = new();
            RefreshData();
        }

        private void RefreshData()//обноволение базы данных.
        {
            myDbContext = new();
            WHdataGridView.DataSource = myDbContext.Products.ToList();
        }

        private void WhAddButton_Click(object sender, EventArgs e)//добавление прродукта.
        {
            AddProduct addProduct = new(OperationType.Add);
            addProduct.ShowDialog();
            if (addProduct.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void WhEditButton_Click(object sender, EventArgs e)//изменение продукта.
        {
            var productId = (int)WHdataGridView.SelectedRows[0].Cells[0].Value;
            var product = myDbContext.Products.Where(x => x.Id == productId).FirstOrDefault();
            AddProduct addProduct = new(OperationType.Edit, product);
            addProduct.ShowDialog();
            if (addProduct.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void WhPlusButton_Click(object sender, EventArgs e)//увеличение кол-ва продукта.
        {
            var productId = (int)WHdataGridView.SelectedRows[0].Cells[0].Value;
            var product = myDbContext.Products.Where(x => x.Id == productId).FirstOrDefault();
            product.Count++;
            RefreshData();
        }

        private void WhCopyButton_Click(object sender, EventArgs e)//копирование продукта.
        {
            var productId = (int)WHdataGridView.SelectedRows[0].Cells[0].Value;
            var product = myDbContext.Products.Where(x => x.Id == productId).FirstOrDefault();
            AddProduct addProduct = new(OperationType.Add, product);
            addProduct.ShowDialog();
            if (addProduct.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void WhDelButton_Click(object sender, EventArgs e)//удаление продукта.
        {
            var productId = (int)WHdataGridView.SelectedRows[0].Cells[0].Value;
            var product = myDbContext.Products.Where(x => x.Id == productId).FirstOrDefault();
            Models.Log log = new();
            log.Text = $"{product.Name} is deleted.";
            log.Date = DateTime.Now;
            log.UserId = product.Id;
            myDbContext.Logs.Add(log);
            myDbContext.Products.Remove(product);
            myDbContext.SaveChanges();
            RefreshData();
            MessageBox.Show("Product is succesfully deleted.");
        }

        private void WhBackButton_Click(object sender, EventArgs e)
        {
            Main main = new();
            main.Show();
            this.Hide();
        }
    }
}
