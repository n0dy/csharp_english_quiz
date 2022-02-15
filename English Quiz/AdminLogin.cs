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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        int posX, posY; bool click;

        private void lblBack_Click(object sender, EventArgs e)
        {
            Home p1 = new Home();
            p1.Show();
            this.Hide();
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void tBoxSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Sifra = tBoxSifra.Text;
                if (Sifra == "equiz2018")
                {
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                    this.Hide();
                }
                else
                {
                    lblInfo.Visible = true;
                    lblInfo.Text = "Incorrect password!";
                }
            }
        }

        private void AdminLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }

        private void AdminLogin_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void AdminLogin_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            posX = e.X;
            posY = e.Y;
        }
    }
}
