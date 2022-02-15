namespace English_Quiz
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.PomocKviza = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PomocKviza
            // 
            this.PomocKviza.BackColor = System.Drawing.Color.Transparent;
            this.PomocKviza.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PomocKviza.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PomocKviza.ForeColor = System.Drawing.Color.Transparent;
            this.PomocKviza.Location = new System.Drawing.Point(25, 129);
            this.PomocKviza.Name = "PomocKviza";
            this.PomocKviza.Size = new System.Drawing.Size(354, 247);
            this.PomocKviza.TabIndex = 4;
            this.PomocKviza.Text = "Help";
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(45, 88);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(310, 29);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = "Press X for exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.PomocKviza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.Text = "Help";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Help_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Help_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Help_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Help_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PomocKviza;
        private System.Windows.Forms.Label lblExit;
    }
}