
namespace DigitalKitchen.Forms
{
    partial class Log
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
            this.LogDataGridView = new System.Windows.Forms.DataGridView();
            this.LogBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogDataGridView
            // 
            this.LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogDataGridView.Location = new System.Drawing.Point(12, 12);
            this.LogDataGridView.Name = "LogDataGridView";
            this.LogDataGridView.RowTemplate.Height = 25;
            this.LogDataGridView.Size = new System.Drawing.Size(776, 403);
            this.LogDataGridView.TabIndex = 1;
            // 
            // LogBackButton
            // 
            this.LogBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBackButton.Location = new System.Drawing.Point(12, 421);
            this.LogBackButton.Name = "LogBackButton";
            this.LogBackButton.Size = new System.Drawing.Size(75, 23);
            this.LogBackButton.TabIndex = 2;
            this.LogBackButton.Text = "Back";
            this.LogBackButton.UseVisualStyleBackColor = true;
            this.LogBackButton.Click += new System.EventHandler(this.LogBackButton_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogBackButton);
            this.Controls.Add(this.LogDataGridView);
            this.Name = "Log";
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LogDataGridView;
        private System.Windows.Forms.Button LogBackButton;
    }
}