using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace English_Quiz
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            tBoxQuizName.Text = appPath;
        }

        int posX, posY; bool click;

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Home p1 = new Home();
            p1.Show();
            this.Hide();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help("1 line - Quiz name\n2 line - Quiz Description\n3 line - Total amount of questions\n4 line - Number of questions that will appear on the quiz\n5 line - Question \n6 line - Correct answer\n7 line - Answer 1 | 8 line - Answer 2\n9 line - Answer 3 | 10 line - Answer 4\nEvery next question must have 6 lines");
            h.Show();
        }

        private void lblSaveFile_Click(object sender, EventArgs e)
        {
            if (tBoxQuizName.Text == "")
            {
                MessageBox.Show("You have to put the name of the file", "Error");
            }
            try
            {
                string Putanja = tBoxQuizName.Text;
                if(Putanja.IndexOf(".txt")<0)
                {
                    Putanja += ".txt";
                }
                StreamWriter sw = new StreamWriter(Putanja);
                for (int i = 0; i < rBoxQuiz.Lines.Length; i++)
                {
                    sw.WriteLine(rBoxQuiz.Lines[i]);
                }
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A mistake was found: \n" + ex, "Error");
            }
        }

        private void lblOpenFile_Click(object sender, EventArgs e)
        {
            if (ofdQuiz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(ofdQuiz.FileName);
                string Putanja = ofdQuiz.FileName;
                if(Putanja.IndexOf(".txt") > 0)
                {
                    while (!sr.EndOfStream)
                    {
                        rBoxQuiz.Text += sr.ReadLine() + "\n";
                    }
                    tBoxQuizName.Text = ofdQuiz.FileName;
                }
                else
                {
                    MessageBox.Show("The quiz was not found or incorrect file!", "Error");
                }
                sr.Close();
            }
        }

        private void lblOpenFile_MouseHover(object sender, EventArgs e)
        {
            lblOpenFile.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void lblOpenFile_MouseLeave(object sender, EventArgs e)
        {
            lblOpenFile.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void lblSaveFile_MouseHover(object sender, EventArgs e)
        {
            lblSaveFile.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void lblSaveFile_MouseLeave(object sender, EventArgs e)
        {
            lblSaveFile.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void lblHelp_MouseHover(object sender, EventArgs e)
        {
            lblHelp.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void lblHelp_MouseLeave(object sender, EventArgs e)
        {
            lblHelp.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void lblLogout_MouseHover(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void AdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }

        private void AdminPanel_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void AdminPanel_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            posX = e.X;
            posY = e.Y;

        }
    }
}
