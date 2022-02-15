namespace English_Quiz
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.tBoxSifra = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxSifra
            // 
            this.tBoxSifra.BackColor = System.Drawing.Color.White;
            this.tBoxSifra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxSifra.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSifra.Location = new System.Drawing.Point(125, 225);
            this.tBoxSifra.MaxLength = 100;
            this.tBoxSifra.Name = "tBoxSifra";
            this.tBoxSifra.PasswordChar = '*';
            this.tBoxSifra.Size = new System.Drawing.Size(250, 30);
            this.tBoxSifra.TabIndex = 4;
            this.tBoxSifra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxSifra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxSifra_KeyDown);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Transparent;
            this.lblBack.Location = new System.Drawing.Point(125, 280);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(250, 40);
            this.lblBack.TabIndex = 5;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInfo.Location = new System.Drawing.Point(125, 334);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(250, 23);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Quiz.Properties.Resources.EnglishQuizAdminLogin;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.tBoxSifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Quiz";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxSifra_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminLogin_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxSifra;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblInfo;
    }
}