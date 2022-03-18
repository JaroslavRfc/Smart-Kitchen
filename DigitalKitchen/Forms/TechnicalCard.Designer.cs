
namespace DigitalKitchen.Forms
{
    partial class TechnicalCard
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
            this.TcBackButton = new System.Windows.Forms.Button();
            this.TcDelButton = new System.Windows.Forms.Button();
            this.TcEditButton = new System.Windows.Forms.Button();
            this.TcAddButton = new System.Windows.Forms.Button();
            this.TCdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TCdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TcBackButton
            // 
            this.TcBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TcBackButton.Location = new System.Drawing.Point(26, 415);
            this.TcBackButton.Name = "TcBackButton";
            this.TcBackButton.Size = new System.Drawing.Size(75, 23);
            this.TcBackButton.TabIndex = 9;
            this.TcBackButton.Text = "Back";
            this.TcBackButton.UseVisualStyleBackColor = true;
            this.TcBackButton.Click += new System.EventHandler(this.TcBackButton_Click);
            // 
            // TcDelButton
            // 
            this.TcDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TcDelButton.Location = new System.Drawing.Point(26, 135);
            this.TcDelButton.Name = "TcDelButton";
            this.TcDelButton.Size = new System.Drawing.Size(75, 23);
            this.TcDelButton.TabIndex = 8;
            this.TcDelButton.Text = "Delete";
            this.TcDelButton.UseVisualStyleBackColor = true;
            this.TcDelButton.Click += new System.EventHandler(this.TcDelButton_Click);
            // 
            // TcEditButton
            // 
            this.TcEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TcEditButton.Location = new System.Drawing.Point(26, 71);
            this.TcEditButton.Name = "TcEditButton";
            this.TcEditButton.Size = new System.Drawing.Size(75, 23);
            this.TcEditButton.TabIndex = 7;
            this.TcEditButton.Text = "Edit";
            this.TcEditButton.UseVisualStyleBackColor = true;
            this.TcEditButton.Click += new System.EventHandler(this.TcEditButton_Click);
            // 
            // TcAddButton
            // 
            this.TcAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TcAddButton.Location = new System.Drawing.Point(26, 12);
            this.TcAddButton.Name = "TcAddButton";
            this.TcAddButton.Size = new System.Drawing.Size(75, 23);
            this.TcAddButton.TabIndex = 6;
            this.TcAddButton.Text = "Add";
            this.TcAddButton.UseVisualStyleBackColor = true;
            this.TcAddButton.Click += new System.EventHandler(this.TcAddButton_Click);
            // 
            // TCdataGridView
            // 
            this.TCdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TCdataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TCdataGridView.Location = new System.Drawing.Point(123, 12);
            this.TCdataGridView.Name = "TCdataGridView";
            this.TCdataGridView.RowTemplate.Height = 25;
            this.TCdataGridView.Size = new System.Drawing.Size(530, 426);
            this.TCdataGridView.TabIndex = 5;
            // 
            // TechnicalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.TcBackButton);
            this.Controls.Add(this.TcDelButton);
            this.Controls.Add(this.TcEditButton);
            this.Controls.Add(this.TcAddButton);
            this.Controls.Add(this.TCdataGridView);
            this.Name = "TechnicalCard";
            this.Text = "TechnicalCard";
            ((System.ComponentModel.ISupportInitialize)(this.TCdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TcBackButton;
        private System.Windows.Forms.Button TcDelButton;
        private System.Windows.Forms.Button TcEditButton;
        private System.Windows.Forms.Button TcAddButton;
        private System.Windows.Forms.DataGridView TCdataGridView;
    }
}