
namespace DigitalKitchen.Forms
{
    partial class Main
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
            this.MainExitButton = new System.Windows.Forms.Button();
            this.MainUsersButton = new System.Windows.Forms.Button();
            this.MainTcButton = new System.Windows.Forms.Button();
            this.MainLogButton = new System.Windows.Forms.Button();
            this.MainWhButton = new System.Windows.Forms.Button();
            this.MainBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainExitButton
            // 
            this.MainExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainExitButton.Location = new System.Drawing.Point(432, 391);
            this.MainExitButton.Name = "MainExitButton";
            this.MainExitButton.Size = new System.Drawing.Size(108, 47);
            this.MainExitButton.TabIndex = 9;
            this.MainExitButton.Text = "Exit";
            this.MainExitButton.UseVisualStyleBackColor = true;
            this.MainExitButton.Click += new System.EventHandler(this.MainExitButton_Click);
            // 
            // MainUsersButton
            // 
            this.MainUsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainUsersButton.Location = new System.Drawing.Point(443, 25);
            this.MainUsersButton.Name = "MainUsersButton";
            this.MainUsersButton.Size = new System.Drawing.Size(97, 40);
            this.MainUsersButton.TabIndex = 8;
            this.MainUsersButton.Text = "Users";
            this.MainUsersButton.UseVisualStyleBackColor = true;
            this.MainUsersButton.Click += new System.EventHandler(this.MainUsersButton_Click);
            // 
            // MainTcButton
            // 
            this.MainTcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainTcButton.Location = new System.Drawing.Point(309, 25);
            this.MainTcButton.Name = "MainTcButton";
            this.MainTcButton.Size = new System.Drawing.Size(97, 40);
            this.MainTcButton.TabIndex = 7;
            this.MainTcButton.Text = "Technical Card";
            this.MainTcButton.UseVisualStyleBackColor = true;
            this.MainTcButton.Click += new System.EventHandler(this.MainTcButton_Click);
            // 
            // MainLogButton
            // 
            this.MainLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainLogButton.Location = new System.Drawing.Point(164, 25);
            this.MainLogButton.Name = "MainLogButton";
            this.MainLogButton.Size = new System.Drawing.Size(97, 40);
            this.MainLogButton.TabIndex = 6;
            this.MainLogButton.Text = "Log";
            this.MainLogButton.UseVisualStyleBackColor = true;
            this.MainLogButton.Click += new System.EventHandler(this.MainLogButton_Click);
            // 
            // MainWhButton
            // 
            this.MainWhButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainWhButton.Location = new System.Drawing.Point(30, 25);
            this.MainWhButton.Name = "MainWhButton";
            this.MainWhButton.Size = new System.Drawing.Size(97, 40);
            this.MainWhButton.TabIndex = 5;
            this.MainWhButton.Text = "WareHouse";
            this.MainWhButton.UseVisualStyleBackColor = true;
            this.MainWhButton.Click += new System.EventHandler(this.MainWhButton_Click);
            // 
            // MainBackButton
            // 
            this.MainBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainBackButton.Location = new System.Drawing.Point(30, 391);
            this.MainBackButton.Name = "MainBackButton";
            this.MainBackButton.Size = new System.Drawing.Size(108, 47);
            this.MainBackButton.TabIndex = 10;
            this.MainBackButton.Text = "Back";
            this.MainBackButton.UseVisualStyleBackColor = true;
            this.MainBackButton.Click += new System.EventHandler(this.MainBackButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.MainBackButton);
            this.Controls.Add(this.MainExitButton);
            this.Controls.Add(this.MainUsersButton);
            this.Controls.Add(this.MainTcButton);
            this.Controls.Add(this.MainLogButton);
            this.Controls.Add(this.MainWhButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainExitButton;
        private System.Windows.Forms.Button MainUsersButton;
        private System.Windows.Forms.Button MainTcButton;
        private System.Windows.Forms.Button MainLogButton;
        private System.Windows.Forms.Button MainWhButton;
        private System.Windows.Forms.Button MainBackButton;
    }
}