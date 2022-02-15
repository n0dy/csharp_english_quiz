namespace English_Quiz
{
    partial class Quiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.lblExit = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ofdQuiz = new System.Windows.Forms.OpenFileDialog();
            this.TimerAnswer = new System.Windows.Forms.Timer(this.components);
            this.TimerCount = new System.Windows.Forms.Timer(this.components);
            this.TimerDown = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(99, 157);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(310, 29);
            this.lblExit.TabIndex = 9;
            this.lblExit.Text = "Press X for main menu, H for help";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultat
            // 
            this.lblResultat.BackColor = System.Drawing.Color.Transparent;
            this.lblResultat.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.ForeColor = System.Drawing.Color.White;
            this.lblResultat.Location = new System.Drawing.Point(75, 457);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(351, 35);
            this.lblResultat.TabIndex = 10;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(0, 25);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(500, 30);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerAnswer
            // 
            this.TimerAnswer.Interval = 10000;
            this.TimerAnswer.Tick += new System.EventHandler(this.TimerAnswer_Tick);
            // 
            // TimerCount
            // 
            this.TimerCount.Interval = 1000;
            this.TimerCount.Tick += new System.EventHandler(this.TimerCount_Tick);
            // 
            // TimerDown
            // 
            this.TimerDown.Interval = 1000;
            this.TimerDown.Tick += new System.EventHandler(this.TimerDown_Tick);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(93, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(315, 41);
            this.lblName.TabIndex = 12;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAnswer1.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.ForeColor = System.Drawing.Color.White;
            this.lblAnswer1.Location = new System.Drawing.Point(90, 241);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(321, 40);
            this.lblAnswer1.TabIndex = 13;
            this.lblAnswer1.Text = "label1";
            this.lblAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer1.Click += new System.EventHandler(this.lblAnswer1_Click);
            this.lblAnswer1.MouseLeave += new System.EventHandler(this.lblAnswer1_MouseLeave);
            this.lblAnswer1.MouseHover += new System.EventHandler(this.lblAnswer1_MouseHover);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAnswer2.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.ForeColor = System.Drawing.Color.White;
            this.lblAnswer2.Location = new System.Drawing.Point(90, 291);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(321, 39);
            this.lblAnswer2.TabIndex = 14;
            this.lblAnswer2.Text = "label1";
            this.lblAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer2.Click += new System.EventHandler(this.lbllAnswer2_Click);
            this.lblAnswer2.MouseLeave += new System.EventHandler(this.lbllAnswer2_MouseLeave);
            this.lblAnswer2.MouseHover += new System.EventHandler(this.lbllAnswer2_MouseHover);
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAnswer3.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.ForeColor = System.Drawing.Color.White;
            this.lblAnswer3.Location = new System.Drawing.Point(90, 342);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(321, 39);
            this.lblAnswer3.TabIndex = 15;
            this.lblAnswer3.Text = "label1";
            this.lblAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer3.Click += new System.EventHandler(this.lbllAnswer3_Click);
            this.lblAnswer3.MouseLeave += new System.EventHandler(this.lbllAnswer3_MouseLeave);
            this.lblAnswer3.MouseHover += new System.EventHandler(this.lbllAnswer3_MouseHover);
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAnswer4.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.ForeColor = System.Drawing.Color.White;
            this.lblAnswer4.Location = new System.Drawing.Point(90, 391);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(321, 39);
            this.lblAnswer4.TabIndex = 16;
            this.lblAnswer4.Text = "label1";
            this.lblAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer4.Click += new System.EventHandler(this.lbllAnswer4_Click);
            this.lblAnswer4.MouseLeave += new System.EventHandler(this.lbllAnswer4_MouseLeave);
            this.lblAnswer4.MouseHover += new System.EventHandler(this.lbllAnswer4_MouseHover);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(24, 190);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(453, 41);
            this.lblAnswer.TabIndex = 17;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Quiz.Properties.Resources.EnglishQuizQ2;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Quiz";
            this.Load += new System.EventHandler(this.Quiz_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Quiz_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Quiz_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Quiz_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Quiz_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.OpenFileDialog ofdQuiz;
        private System.Windows.Forms.Timer TimerAnswer;
        private System.Windows.Forms.Timer TimerCount;
        private System.Windows.Forms.Timer TimerDown;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.Label lblAnswer;
    }
}