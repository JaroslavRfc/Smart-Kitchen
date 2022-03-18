
namespace DigitalKitchen.Forms
{
    partial class AddTechnicalCard
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
            this.IsHalfStuffLabel = new System.Windows.Forms.Label();
            this.AddTcCheckBox = new System.Windows.Forms.CheckBox();
            this.AddTcCancelButton = new System.Windows.Forms.Button();
            this.AddTcOkButton = new System.Windows.Forms.Button();
            this.AddTcFinalPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddTcCostPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddTcNameTextBox = new System.Windows.Forms.TextBox();
            this.AddTcFinalPriceLabel = new System.Windows.Forms.Label();
            this.AddTcCostPriceLabel = new System.Windows.Forms.Label();
            this.AddTcNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IsHalfStuffLabel
            // 
            this.IsHalfStuffLabel.AutoSize = true;
            this.IsHalfStuffLabel.Location = new System.Drawing.Point(10, 58);
            this.IsHalfStuffLabel.Name = "IsHalfStuffLabel";
            this.IsHalfStuffLabel.Size = new System.Drawing.Size(65, 15);
            this.IsHalfStuffLabel.TabIndex = 27;
            this.IsHalfStuffLabel.Text = "IsHalfStuff:";
            // 
            // AddTcCheckBox
            // 
            this.AddTcCheckBox.AutoSize = true;
            this.AddTcCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTcCheckBox.Location = new System.Drawing.Point(92, 58);
            this.AddTcCheckBox.Name = "AddTcCheckBox";
            this.AddTcCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AddTcCheckBox.TabIndex = 26;
            this.AddTcCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddTcCancelButton
            // 
            this.AddTcCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTcCancelButton.Location = new System.Drawing.Point(297, 104);
            this.AddTcCancelButton.Name = "AddTcCancelButton";
            this.AddTcCancelButton.Size = new System.Drawing.Size(75, 53);
            this.AddTcCancelButton.TabIndex = 25;
            this.AddTcCancelButton.Text = "Cancel";
            this.AddTcCancelButton.UseVisualStyleBackColor = true;
            this.AddTcCancelButton.Click += new System.EventHandler(this.AddTcCancelButton_Click);
            // 
            // AddTcOkButton
            // 
            this.AddTcOkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTcOkButton.Location = new System.Drawing.Point(297, 38);
            this.AddTcOkButton.Name = "AddTcOkButton";
            this.AddTcOkButton.Size = new System.Drawing.Size(75, 53);
            this.AddTcOkButton.TabIndex = 24;
            this.AddTcOkButton.Text = "Ok";
            this.AddTcOkButton.UseVisualStyleBackColor = true;
            this.AddTcOkButton.Click += new System.EventHandler(this.AddTcOkButton_Click);
            // 
            // AddTcFinalPriceTextBox
            // 
            this.AddTcFinalPriceTextBox.Location = new System.Drawing.Point(92, 134);
            this.AddTcFinalPriceTextBox.Name = "AddTcFinalPriceTextBox";
            this.AddTcFinalPriceTextBox.Size = new System.Drawing.Size(158, 23);
            this.AddTcFinalPriceTextBox.TabIndex = 23;
            // 
            // AddTcCostPriceTextBox
            // 
            this.AddTcCostPriceTextBox.Location = new System.Drawing.Point(92, 86);
            this.AddTcCostPriceTextBox.Name = "AddTcCostPriceTextBox";
            this.AddTcCostPriceTextBox.Size = new System.Drawing.Size(158, 23);
            this.AddTcCostPriceTextBox.TabIndex = 22;
            // 
            // AddTcNameTextBox
            // 
            this.AddTcNameTextBox.Location = new System.Drawing.Point(92, 12);
            this.AddTcNameTextBox.Name = "AddTcNameTextBox";
            this.AddTcNameTextBox.Size = new System.Drawing.Size(158, 23);
            this.AddTcNameTextBox.TabIndex = 21;
            // 
            // AddTcFinalPriceLabel
            // 
            this.AddTcFinalPriceLabel.AutoSize = true;
            this.AddTcFinalPriceLabel.Location = new System.Drawing.Point(9, 142);
            this.AddTcFinalPriceLabel.Name = "AddTcFinalPriceLabel";
            this.AddTcFinalPriceLabel.Size = new System.Drawing.Size(64, 15);
            this.AddTcFinalPriceLabel.TabIndex = 20;
            this.AddTcFinalPriceLabel.Text = "Final Price:";
            // 
            // AddTcCostPriceLabel
            // 
            this.AddTcCostPriceLabel.AutoSize = true;
            this.AddTcCostPriceLabel.Location = new System.Drawing.Point(10, 94);
            this.AddTcCostPriceLabel.Name = "AddTcCostPriceLabel";
            this.AddTcCostPriceLabel.Size = new System.Drawing.Size(63, 15);
            this.AddTcCostPriceLabel.TabIndex = 19;
            this.AddTcCostPriceLabel.Text = "Cost Price:";
            // 
            // AddTcNameLabel
            // 
            this.AddTcNameLabel.AutoSize = true;
            this.AddTcNameLabel.Location = new System.Drawing.Point(31, 20);
            this.AddTcNameLabel.Name = "AddTcNameLabel";
            this.AddTcNameLabel.Size = new System.Drawing.Size(42, 15);
            this.AddTcNameLabel.TabIndex = 18;
            this.AddTcNameLabel.Text = "Name:";
            // 
            // AddTechnicalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 186);
            this.Controls.Add(this.IsHalfStuffLabel);
            this.Controls.Add(this.AddTcCheckBox);
            this.Controls.Add(this.AddTcCancelButton);
            this.Controls.Add(this.AddTcOkButton);
            this.Controls.Add(this.AddTcFinalPriceTextBox);
            this.Controls.Add(this.AddTcCostPriceTextBox);
            this.Controls.Add(this.AddTcNameTextBox);
            this.Controls.Add(this.AddTcFinalPriceLabel);
            this.Controls.Add(this.AddTcCostPriceLabel);
            this.Controls.Add(this.AddTcNameLabel);
            this.Name = "AddTechnicalCard";
            this.Text = "AddTechnicalCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IsHalfStuffLabel;
        private System.Windows.Forms.CheckBox AddTcCheckBox;
        private System.Windows.Forms.Button AddTcCancelButton;
        private System.Windows.Forms.Button AddTcOkButton;
        private System.Windows.Forms.TextBox AddTcFinalPriceTextBox;
        private System.Windows.Forms.TextBox AddTcCostPriceTextBox;
        private System.Windows.Forms.TextBox AddTcNameTextBox;
        private System.Windows.Forms.Label AddTcFinalPriceLabel;
        private System.Windows.Forms.Label AddTcCostPriceLabel;
        private System.Windows.Forms.Label AddTcNameLabel;
    }
}