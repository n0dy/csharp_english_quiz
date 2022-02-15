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
    public partial class Help : Form
    {
        public Help(string Help)
        {
            InitializeComponent();
            PomocKviza.Text = Help;
        }

        int posX, posY; bool click;

        private void Help_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                this.Close();
            }
        }

        private void Help_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }

        private void Help_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            posX = e.X;
            posY = e.Y;
        }
    }
}
