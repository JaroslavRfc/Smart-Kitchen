
namespace DigitalKitchen
{
    partial class Entrence
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.EntrenceTextBox = new System.Windows.Forms.TextBox();
            this.EntrenceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(339, 68);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 47);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.Location = new System.Drawing.Point(339, 12);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(103, 47);
            this.EnterButton.TabIndex = 10;
            this.EnterButton.Text = "Log in";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // EntrenceTextBox
            // 
            this.EntrenceTextBox.Location = new System.Drawing.Point(77, 60);
            this.EntrenceTextBox.Name = "EntrenceTextBox";
            this.EntrenceTextBox.Size = new System.Drawing.Size(231, 23);
            this.EntrenceTextBox.TabIndex = 9;
            // 
            // EntrenceLabel
            // 
            this.EntrenceLabel.AutoSize = true;
            this.EntrenceLabel.Location = new System.Drawing.Point(3, 68);
            this.EntrenceLabel.Name = "EntrenceLabel";
            this.EntrenceLabel.Size = new System.Drawing.Size(68, 15);
            this.EntrenceLabel.TabIndex = 8;
            this.EntrenceLabel.Text = "User Name:";
            // 
            // Entrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 136);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EntrenceTextBox);
            this.Controls.Add(this.EntrenceLabel);
            this.Name = "Entrence";
            this.Text = "Entrence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox EntrenceTextBox;
        private System.Windows.Forms.Label EntrenceLabel;
    }
}

