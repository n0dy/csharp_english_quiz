namespace English_Quiz
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblExitQuiz = new System.Windows.Forms.Label();
            this.lblHelpQuiz = new System.Windows.Forms.Label();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExitQuiz
            // 
            this.lblExitQuiz.BackColor = System.Drawing.Color.Transparent;
            this.lblExitQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExitQuiz.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitQuiz.ForeColor = System.Drawing.Color.Transparent;
            this.lblExitQuiz.Location = new System.Drawing.Point(125, 300);
            this.lblExitQuiz.Name = "lblExitQuiz";
            this.lblExitQuiz.Size = new System.Drawing.Size(250, 40);
            this.lblExitQuiz.TabIndex = 2;
            this.lblExitQuiz.Text = "Quit";
            this.lblExitQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExitQuiz.Click += new System.EventHandler(this.lblExitQuiz_Click);
            this.lblExitQuiz.MouseLeave += new System.EventHandler(this.lblExitQuiz_MouseLeave);
            this.lblExitQuiz.MouseHover += new System.EventHandler(this.lblExitQuiz_MouseHover);
            // 
            // lblHelpQuiz
            // 
            this.lblHelpQuiz.BackColor = System.Drawing.Color.Transparent;
            this.lblHelpQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelpQuiz.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpQuiz.ForeColor = System.Drawing.Color.Transparent;
            this.lblHelpQuiz.Location = new System.Drawing.Point(125, 240);
            this.lblHelpQuiz.Name = "lblHelpQuiz";
            this.lblHelpQuiz.Size = new System.Drawing.Size(250, 40);
            this.lblHelpQuiz.TabIndex = 3;
            this.lblHelpQuiz.Text = "Help";
            this.lblHelpQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelpQuiz.Click += new System.EventHandler(this.lblHelpQuiz_Click);
            this.lblHelpQuiz.MouseLeave += new System.EventHandler(this.lblHelpQuiz_MouseLeave);
            this.lblHelpQuiz.MouseHover += new System.EventHandler(this.lblHelpQuiz_MouseHover);
            // 
            // lblQuiz
            // 
            this.lblQuiz.BackColor = System.Drawing.Color.Transparent;
            this.lblQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuiz.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz.ForeColor = System.Drawing.Color.Transparent;
            this.lblQuiz.Location = new System.Drawing.Point(125, 180);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(250, 40);
            this.lblQuiz.TabIndex = 4;
            this.lblQuiz.Text = "Quiz";
            this.lblQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuiz.Click += new System.EventHandler(this.lblQuiz_Click);
            this.lblQuiz.MouseLeave += new System.EventHandler(this.lblQuiz_MouseLeave);
            this.lblQuiz.MouseHover += new System.EventHandler(this.lblQuiz_MouseHover);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Quiz.Properties.Resources.EnglishQuizHome;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblQuiz);
            this.Controls.Add(this.lblHelpQuiz);
            this.Controls.Add(this.lblExitQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Home_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Home_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Home_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExitQuiz;
        private System.Windows.Forms.Label lblHelpQuiz;
        private System.Windows.Forms.Label lblQuiz;
    }
}

