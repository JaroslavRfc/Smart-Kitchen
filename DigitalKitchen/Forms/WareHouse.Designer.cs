
namespace DigitalKitchen.Forms
{
    partial class WareHouse
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
            this.WhDelButton = new System.Windows.Forms.Button();
            this.WhCopyButton = new System.Windows.Forms.Button();
            this.WhPlusButton = new System.Windows.Forms.Button();
            this.WhEditButton = new System.Windows.Forms.Button();
            this.WhAddButton = new System.Windows.Forms.Button();
            this.WHdataGridView = new System.Windows.Forms.DataGridView();
            this.WhBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WHdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WhDelButton
            // 
            this.WhDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhDelButton.Location = new System.Drawing.Point(22, 329);
            this.WhDelButton.Name = "WhDelButton";
            this.WhDelButton.Size = new System.Drawing.Size(75, 30);
            this.WhDelButton.TabIndex = 11;
            this.WhDelButton.Text = "Delete";
            this.WhDelButton.UseVisualStyleBackColor = true;
            this.WhDelButton.Click += new System.EventHandler(this.WhDelButton_Click);
            // 
            // WhCopyButton
            // 
            this.WhCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhCopyButton.Location = new System.Drawing.Point(22, 251);
            this.WhCopyButton.Name = "WhCopyButton";
            this.WhCopyButton.Size = new System.Drawing.Size(75, 30);
            this.WhCopyButton.TabIndex = 10;
            this.WhCopyButton.Text = "Copy";
            this.WhCopyButton.UseVisualStyleBackColor = true;
            this.WhCopyButton.Click += new System.EventHandler(this.WhCopyButton_Click);
            // 
            // WhPlusButton
            // 
            this.WhPlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhPlusButton.Location = new System.Drawing.Point(22, 173);
            this.WhPlusButton.Name = "WhPlusButton";
            this.WhPlusButton.Size = new System.Drawing.Size(75, 30);
            this.WhPlusButton.TabIndex = 9;
            this.WhPlusButton.Text = "Plus";
            this.WhPlusButton.UseVisualStyleBackColor = true;
            this.WhPlusButton.Click += new System.EventHandler(this.WhPlusButton_Click);
            // 
            // WhEditButton
            // 
            this.WhEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhEditButton.Location = new System.Drawing.Point(22, 93);
            this.WhEditButton.Name = "WhEditButton";
            this.WhEditButton.Size = new System.Drawing.Size(75, 30);
            this.WhEditButton.TabIndex = 8;
            this.WhEditButton.Text = "Edit";
            this.WhEditButton.UseVisualStyleBackColor = true;
            this.WhEditButton.Click += new System.EventHandler(this.WhEditButton_Click);
            // 
            // WhAddButton
            // 
            this.WhAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhAddButton.Location = new System.Drawing.Point(22, 12);
            this.WhAddButton.Name = "WhAddButton";
            this.WhAddButton.Size = new System.Drawing.Size(75, 30);
            this.WhAddButton.TabIndex = 7;
            this.WhAddButton.Text = "Add";
            this.WhAddButton.UseVisualStyleBackColor = true;
            this.WhAddButton.Click += new System.EventHandler(this.WhAddButton_Click);
            // 
            // WHdataGridView
            // 
            this.WHdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WHdataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WHdataGridView.Location = new System.Drawing.Point(178, 12);
            this.WHdataGridView.Name = "WHdataGridView";
            this.WHdataGridView.RowTemplate.Height = 25;
            this.WHdataGridView.Size = new System.Drawing.Size(381, 426);
            this.WHdataGridView.TabIndex = 6;
            // 
            // WhBackButton
            // 
            this.WhBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhBackButton.Location = new System.Drawing.Point(22, 408);
            this.WhBackButton.Name = "WhBackButton";
            this.WhBackButton.Size = new System.Drawing.Size(75, 30);
            this.WhBackButton.TabIndex = 12;
            this.WhBackButton.Text = "Back";
            this.WhBackButton.UseVisualStyleBackColor = true;
            this.WhBackButton.Click += new System.EventHandler(this.WhBackButton_Click);
            // 
            // WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.WhBackButton);
            this.Controls.Add(this.WhDelButton);
            this.Controls.Add(this.WhCopyButton);
            this.Controls.Add(this.WhPlusButton);
            this.Controls.Add(this.WhEditButton);
            this.Controls.Add(this.WhAddButton);
            this.Controls.Add(this.WHdataGridView);
            this.Name = "WareHouse";
            this.Text = "WareHouse";
            ((System.ComponentModel.ISupportInitialize)(this.WHdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WhDelButton;
        private System.Windows.Forms.Button WhCopyButton;
        private System.Windows.Forms.Button WhPlusButton;
        private System.Windows.Forms.Button WhEditButton;
        private System.Windows.Forms.Button WhAddButton;
        private System.Windows.Forms.DataGridView WHdataGridView;
        private System.Windows.Forms.Button WhBackButton;
    }
}