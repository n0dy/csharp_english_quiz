using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace English_Quiz
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        int posX, posY; bool click;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.X)
            {
                AdminLogin al = new AdminLogin();
                al.Show();
                this.Hide();
            }
        }

        private void lblExitQuiz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblQuiz_Click(object sender, EventArgs e)
        {
            Quiz q = new Quiz();
            q.Show();
            this.Hide();
        }

        private void lblHelpQuiz_Click(object sender, EventArgs e)
        {
            Help h = new Help("Click the Quiz so you can open the Quiz and play it");
            h.Show();
        }

        private void lblQuiz_MouseLeave(object sender, EventArgs e)
        {
            lblQuiz.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void lblQuiz_MouseHover(object sender, EventArgs e)
        {
            lblQuiz.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void lblHelpQuiz_MouseHover(object sender, EventArgs e)
        {
            lblHelpQuiz.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void lblHelpQuiz_MouseLeave(object sender, EventArgs e)
        {
            lblHelpQuiz.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void lblExitQuiz_MouseLeave(object sender, EventArgs e)
        {
            lblExitQuiz.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void lblExitQuiz_MouseHover(object sender, EventArgs e)
        {
            lblExitQuiz.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            posX = e.X;
            posY = e.Y;
        }

        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }
    }
}
