
namespace DigitalKitchen.Forms
{
    partial class AddUser
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
            this.AddUserCancelButton = new System.Windows.Forms.Button();
            this.AddUserOkButton = new System.Windows.Forms.Button();
            this.AddAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.AddAdminLabel = new System.Windows.Forms.Label();
            this.AddUserTextBox = new System.Windows.Forms.TextBox();
            this.AddUserNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddUserCancelButton
            // 
            this.AddUserCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserCancelButton.Location = new System.Drawing.Point(252, 73);
            this.AddUserCancelButton.Name = "AddUserCancelButton";
            this.AddUserCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserCancelButton.TabIndex = 11;
            this.AddUserCancelButton.Text = "Cancel";
            this.AddUserCancelButton.UseVisualStyleBackColor = true;
            this.AddUserCancelButton.Click += new System.EventHandler(this.AddUserCancelButton_Click);
            // 
            // AddUserOkButton
            // 
            this.AddUserOkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUserOkButton.Location = new System.Drawing.Point(252, 22);
            this.AddUserOkButton.Name = "AddUserOkButton";
            this.AddUserOkButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserOkButton.TabIndex = 10;
            this.AddUserOkButton.Text = "Ok";
            this.AddUserOkButton.UseVisualStyleBackColor = true;
            this.AddUserOkButton.Click += new System.EventHandler(this.AddUserOkButton_Click);
            // 
            // AddAdminCheckBox
            // 
            this.AddAdminCheckBox.AutoSize = true;
            this.AddAdminCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAdminCheckBox.Location = new System.Drawing.Point(75, 78);
            this.AddAdminCheckBox.Name = "AddAdminCheckBox";
            this.AddAdminCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AddAdminCheckBox.TabIndex = 9;
            this.AddAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddAdminLabel
            // 
            this.AddAdminLabel.AutoSize = true;
            this.AddAdminLabel.Location = new System.Drawing.Point(8, 82);
            this.AddAdminLabel.Name = "AddAdminLabel";
            this.AddAdminLabel.Size = new System.Drawing.Size(46, 15);
            this.AddAdminLabel.TabIndex = 8;
            this.AddAdminLabel.Text = "Admin:";
            // 
            // AddUserTextBox
            // 
            this.AddUserTextBox.Location = new System.Drawing.Point(75, 22);
            this.AddUserTextBox.Name = "AddUserTextBox";
            this.AddUserTextBox.Size = new System.Drawing.Size(145, 23);
            this.AddUserTextBox.TabIndex = 7;
            // 
            // AddUserNameLabel
            // 
            this.AddUserNameLabel.AutoSize = true;
            this.AddUserNameLabel.Location = new System.Drawing.Point(12, 30);
            this.AddUserNameLabel.Name = "AddUserNameLabel";
            this.AddUserNameLabel.Size = new System.Drawing.Size(42, 15);
            this.AddUserNameLabel.TabIndex = 6;
            this.AddUserNameLabel.Text = "Name:";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 116);
            this.Controls.Add(this.AddUserCancelButton);
            this.Controls.Add(this.AddUserOkButton);
            this.Controls.Add(this.AddAdminCheckBox);
            this.Controls.Add(this.AddAdminLabel);
            this.Controls.Add(this.AddUserTextBox);
            this.Controls.Add(this.AddUserNameLabel);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserCancelButton;
        private System.Windows.Forms.Button AddUserOkButton;
        private System.Windows.Forms.CheckBox AddAdminCheckBox;
        private System.Windows.Forms.Label AddAdminLabel;
        private System.Windows.Forms.TextBox AddUserTextBox;
        private System.Windows.Forms.Label AddUserNameLabel;
    }
}