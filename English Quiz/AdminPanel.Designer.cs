namespace English_Quiz
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.rBoxQuiz = new System.Windows.Forms.RichTextBox();
            this.tBoxQuizName = new System.Windows.Forms.TextBox();
            this.ofdQuiz = new System.Windows.Forms.OpenFileDialog();
            this.lblOpenFile = new System.Windows.Forms.Label();
            this.lblSaveFile = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rBoxQuiz
            // 
            this.rBoxQuiz.Location = new System.Drawing.Point(165, 126);
            this.rBoxQuiz.Name = "rBoxQuiz";
            this.rBoxQuiz.Size = new System.Drawing.Size(323, 337);
            this.rBoxQuiz.TabIndex = 0;
            this.rBoxQuiz.Text = "";
            // 
            // tBoxQuizName
            // 
            this.tBoxQuizName.BackColor = System.Drawing.Color.White;
            this.tBoxQuizName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxQuizName.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxQuizName.Location = new System.Drawing.Point(12, 470);
            this.tBoxQuizName.MaxLength = 100;
            this.tBoxQuizName.Name = "tBoxQuizName";
            this.tBoxQuizName.Size = new System.Drawing.Size(476, 24);
            this.tBoxQuizName.TabIndex = 7;
            this.tBoxQuizName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOpenFile
            // 
            this.lblOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpenFile.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFile.ForeColor = System.Drawing.Color.Transparent;
            this.lblOpenFile.Location = new System.Drawing.Point(17, 127);
            this.lblOpenFile.Name = "lblOpenFile";
            this.lblOpenFile.Size = new System.Drawing.Size(141, 33);
            this.lblOpenFile.TabIndex = 8;
            this.lblOpenFile.Text = "Open quiz";
            this.lblOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpenFile.Click += new System.EventHandler(this.lblOpenFile_Click);
            this.lblOpenFile.MouseLeave += new System.EventHandler(this.lblOpenFile_MouseLeave);
            this.lblOpenFile.MouseHover += new System.EventHandler(this.lblOpenFile_MouseHover);
            // 
            // lblSaveFile
            // 
            this.lblSaveFile.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaveFile.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveFile.ForeColor = System.Drawing.Color.Transparent;
            this.lblSaveFile.Location = new System.Drawing.Point(17, 167);
            this.lblSaveFile.Name = "lblSaveFile";
            this.lblSaveFile.Size = new System.Drawing.Size(141, 33);
            this.lblSaveFile.TabIndex = 9;
            this.lblSaveFile.Text = "Save quiz";
            this.lblSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaveFile.Click += new System.EventHandler(this.lblSaveFile_Click);
            this.lblSaveFile.MouseLeave += new System.EventHandler(this.lblSaveFile_MouseLeave);
            this.lblSaveFile.MouseHover += new System.EventHandler(this.lblSaveFile_MouseHover);
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.Transparent;
            this.lblHelp.Location = new System.Drawing.Point(17, 207);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(141, 33);
            this.lblHelp.TabIndex = 10;
            this.lblHelp.Text = "Help";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            this.lblHelp.MouseLeave += new System.EventHandler(this.lblHelp_MouseLeave);
            this.lblHelp.MouseHover += new System.EventHandler(this.lblHelp_MouseHover);
            // 
            // lblLogout
            // 
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Transparent;
            this.lblLogout.Location = new System.Drawing.Point(17, 247);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(141, 33);
            this.lblLogout.TabIndex = 11;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            this.lblLogout.MouseHover += new System.EventHandler(this.lblLogout_MouseHover);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Quiz.Properties.Resources.EnglishQuizAdminPanel;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblSaveFile);
            this.Controls.Add(this.lblOpenFile);
            this.Controls.Add(this.tBoxQuizName);
            this.Controls.Add(this.rBoxQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Quiz";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rBoxQuiz;
        private System.Windows.Forms.TextBox tBoxQuizName;
        private System.Windows.Forms.OpenFileDialog ofdQuiz;
        private System.Windows.Forms.Label lblOpenFile;
        private System.Windows.Forms.Label lblSaveFile;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblLogout;
    }
}