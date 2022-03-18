
namespace DigitalKitchen.Forms
{
    partial class User
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
            this.UserBackButton = new System.Windows.Forms.Button();
            this.UserDelButton = new System.Windows.Forms.Button();
            this.UserEditButton = new System.Windows.Forms.Button();
            this.UserAddButton = new System.Windows.Forms.Button();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserBackButton
            // 
            this.UserBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBackButton.Location = new System.Drawing.Point(12, 402);
            this.UserBackButton.Name = "UserBackButton";
            this.UserBackButton.Size = new System.Drawing.Size(72, 36);
            this.UserBackButton.TabIndex = 11;
            this.UserBackButton.Text = "Back";
            this.UserBackButton.UseVisualStyleBackColor = true;
            this.UserBackButton.Click += new System.EventHandler(this.UserBackButton_Click);
            // 
            // UserDelButton
            // 
            this.UserDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserDelButton.Location = new System.Drawing.Point(12, 148);
            this.UserDelButton.Name = "UserDelButton";
            this.UserDelButton.Size = new System.Drawing.Size(72, 36);
            this.UserDelButton.TabIndex = 10;
            this.UserDelButton.Text = "Delete";
            this.UserDelButton.UseVisualStyleBackColor = true;
            this.UserDelButton.Click += new System.EventHandler(this.UserDelButton_Click);
            // 
            // UserEditButton
            // 
            this.UserEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserEditButton.Location = new System.Drawing.Point(12, 78);
            this.UserEditButton.Name = "UserEditButton";
            this.UserEditButton.Size = new System.Drawing.Size(72, 36);
            this.UserEditButton.TabIndex = 9;
            this.UserEditButton.Text = "Edit";
            this.UserEditButton.UseVisualStyleBackColor = true;
            this.UserEditButton.Click += new System.EventHandler(this.UserEditButton_Click);
            // 
            // UserAddButton
            // 
            this.UserAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserAddButton.Location = new System.Drawing.Point(12, 12);
            this.UserAddButton.Name = "UserAddButton";
            this.UserAddButton.Size = new System.Drawing.Size(72, 36);
            this.UserAddButton.TabIndex = 7;
            this.UserAddButton.Text = "Add";
            this.UserAddButton.UseVisualStyleBackColor = true;
            this.UserAddButton.Click += new System.EventHandler(this.UserAddButton_Click);
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserDataGridView.Location = new System.Drawing.Point(126, 12);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowTemplate.Height = 25;
            this.UserDataGridView.Size = new System.Drawing.Size(343, 426);
            this.UserDataGridView.TabIndex = 6;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.UserBackButton);
            this.Controls.Add(this.UserDelButton);
            this.Controls.Add(this.UserEditButton);
            this.Controls.Add(this.UserAddButton);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserBackButton;
        private System.Windows.Forms.Button UserDelButton;
        private System.Windows.Forms.Button UserEditButton;
        private System.Windows.Forms.Button UserAddButton;
        private System.Windows.Forms.DataGridView UserDataGridView;
    }
}