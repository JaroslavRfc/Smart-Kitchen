
namespace DigitalKitchen.Forms
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductCancelButton = new System.Windows.Forms.Button();
            this.ProductOkButton = new System.Windows.Forms.Button();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductCountTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductCountLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductCancelButton
            // 
            this.ProductCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductCancelButton.Location = new System.Drawing.Point(291, 86);
            this.ProductCancelButton.Name = "ProductCancelButton";
            this.ProductCancelButton.Size = new System.Drawing.Size(75, 53);
            this.ProductCancelButton.TabIndex = 15;
            this.ProductCancelButton.Text = "Cancel";
            this.ProductCancelButton.UseVisualStyleBackColor = true;
            this.ProductCancelButton.Click += new System.EventHandler(this.ProductCancelButton_Click);
            // 
            // ProductOkButton
            // 
            this.ProductOkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductOkButton.Location = new System.Drawing.Point(291, 21);
            this.ProductOkButton.Name = "ProductOkButton";
            this.ProductOkButton.Size = new System.Drawing.Size(75, 53);
            this.ProductOkButton.TabIndex = 14;
            this.ProductOkButton.Text = "Ok";
            this.ProductOkButton.UseVisualStyleBackColor = true;
            this.ProductOkButton.Click += new System.EventHandler(this.ProductOkButton_Click);
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(76, 116);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(158, 23);
            this.ProductPriceTextBox.TabIndex = 13;
            // 
            // ProductCountTextBox
            // 
            this.ProductCountTextBox.Location = new System.Drawing.Point(76, 68);
            this.ProductCountTextBox.Name = "ProductCountTextBox";
            this.ProductCountTextBox.Size = new System.Drawing.Size(158, 23);
            this.ProductCountTextBox.TabIndex = 12;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(76, 21);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(158, 23);
            this.ProductNameTextBox.TabIndex = 11;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(19, 124);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(36, 15);
            this.ProductPriceLabel.TabIndex = 10;
            this.ProductPriceLabel.Text = "Price:";
            // 
            // ProductCountLabel
            // 
            this.ProductCountLabel.AutoSize = true;
            this.ProductCountLabel.Location = new System.Drawing.Point(12, 76);
            this.ProductCountLabel.Name = "ProductCountLabel";
            this.ProductCountLabel.Size = new System.Drawing.Size(43, 15);
            this.ProductCountLabel.TabIndex = 9;
            this.ProductCountLabel.Text = "Count:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(13, 29);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(42, 15);
            this.ProductNameLabel.TabIndex = 8;
            this.ProductNameLabel.Text = "Name:";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 157);
            this.Controls.Add(this.ProductCancelButton);
            this.Controls.Add(this.ProductOkButton);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductCountTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductCountLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProductCancelButton;
        private System.Windows.Forms.Button ProductOkButton;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.TextBox ProductCountTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label ProductCountLabel;
        private System.Windows.Forms.Label ProductNameLabel;
    }
}