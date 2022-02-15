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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        int posX, posY; bool click;

        struct Pitanja
        {
            public string Pitanje;
            public int Odgovor;
            public string Odg1;
            public string Odg2;
            public string Odg3;
            public string Odg4;
            public bool Bilo;
        }

        Pitanja[] pitanja;
        int brPitanja, RandomPitanje, ukupnoPitanja, tacnihPitanja, brPitanjaPrikaz;
        int sec = 0; double ProsecnoVreme = 0;
        bool poceokviz = false;
        string ImeKviza, Opis;

        private void Quiz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                if (poceokviz)
                {
                    MessageBox.Show("Quiz in progress!", "Error");
                }
                else
                {
                    Home p1 = new Home();
                    p1.Show();
                    this.Hide();
                }
            }
            if(e.KeyCode == Keys.H)
            {
                Help h = new Help(Opis);
                h.Show();
            }
        }

        private void NadjiPitanje()
        {
            poceokviz = true;
            bool BiloPitanje = false;
            sec = 0;
            if (ukupnoPitanja != brPitanjaPrikaz)
            {
                while (!BiloPitanje)
                {
                    Random r = new Random();
                    RandomPitanje = r.Next(brPitanja);
                    if (pitanja[RandomPitanje].Bilo == false)
                    {
                        lblAnswer.Text = pitanja[RandomPitanje].Pitanje;
                        lblAnswer1.Text = pitanja[RandomPitanje].Odg1;
                        lblAnswer2.Text = pitanja[RandomPitanje].Odg2;
                        lblAnswer3.Text = pitanja[RandomPitanje].Odg3;
                        lblAnswer4.Text = pitanja[RandomPitanje].Odg4;
                        pitanja[RandomPitanje].Bilo = true;
                        ukupnoPitanja++;
                        BiloPitanje = true;
                    }
                }
                lblResultat.Text = string.Format("Total questions {0} ||| Correct questions {1} ", ukupnoPitanja, tacnihPitanja);
                TimerAnswer.Start();
            }
            else
            {
                TimerAnswer.Stop();
                TimerCount.Stop();
                lblInfo.Text = "Finish!";
                lblAnswer.Text = "";
                lblAnswer1.Text = "";
                lblAnswer2.Text = "";
                lblAnswer3.Text = "";
                lblAnswer4.Text = "";
                ProsecnoVreme /= ukupnoPitanja;
                poceokviz = false;
                lblResultat.Text = string.Format("Total questions {0} ||| Correct questions {1}", ukupnoPitanja, tacnihPitanja);
            }
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            bool Ucitano = false;
            if (ofdQuiz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                System.IO.StreamReader(ofdQuiz.FileName);
                Ucitano = true;
                sr.Close();
            }
            if (Ucitano == false)
            {
                Quiz q = new Quiz();
                q.Hide();
            }
            try
            {
                string putanja = ofdQuiz.FileName;
                if(putanja.IndexOf(".txt") < 0)
                {
                    MessageBox.Show("The quiz was not found or incorrect file!", "Error");
                    TimerDown.Start();
                    return;
                }
                StreamReader sr = new StreamReader(ofdQuiz.FileName);
                ImeKviza = sr.ReadLine();
                Opis = sr.ReadLine();
                brPitanja = Convert.ToInt32(sr.ReadLine());
                brPitanjaPrikaz = Convert.ToInt32(sr.ReadLine());
                pitanja = new Pitanja[brPitanja];
                for (int i = 0; i < brPitanja; i++)
                {
                    pitanja[i].Pitanje = sr.ReadLine();
                    pitanja[i].Odgovor = Convert.ToInt32(sr.ReadLine());
                    pitanja[i].Odg1 = sr.ReadLine();
                    pitanja[i].Odg2 = sr.ReadLine();
                    pitanja[i].Odg3 = sr.ReadLine();
                    pitanja[i].Odg4 = sr.ReadLine();
                    pitanja[i].Bilo = false;
                }
            }
            catch
            {
                MessageBox.Show("The quiz was not found or incorrect file!", "Error");
                TimerDown.Start();

            }
            lblName.Text = ImeKviza;
            NadjiPitanje();
            TimerAnswer.Enabled = TimerCount.Enabled = true;
        }

        private void TimerAnswer_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "Time ran out!";
            TimerAnswer.Stop();
            NadjiPitanje();
        }

        private void TimerCount_Tick(object sender, EventArgs e)
        {
            sec++;
            lblInfo.Text = sec.ToString();
        }

        private void TimerDown_Tick(object sender, EventArgs e)
        {
            Home p1 = new Home();
            p1.Show();
            this.Hide();
            TimerDown.Stop();
        }

        private void lblAnswer1_Click(object sender, EventArgs e)
        {
            if (pitanja[RandomPitanje].Odgovor == 1)
            {
                lblInfo.Text = "Correct answer!";
                tacnihPitanja++;
            }
            else { lblInfo.Text = "Incorrect answer!"; }
            TimerAnswer.Stop();
            ProsecnoVreme += sec;
            NadjiPitanje();
        }

        private void lbllAnswer2_Click(object sender, EventArgs e)
        {
            if (pitanja[RandomPitanje].Odgovor == 2)
            {
                lblInfo.Text = "Correct answer!";
                tacnihPitanja++;
            }
            else { lblInfo.Text = "Incorrect answer!"; }
            TimerAnswer.Stop();
            ProsecnoVreme += sec;
            NadjiPitanje();
        }

        private void lbllAnswer3_Click(object sender, EventArgs e)
        {
            if (pitanja[RandomPitanje].Odgovor == 3)
            {
                lblInfo.Text = "Correct answer!";
                tacnihPitanja++;
            }
            else { lblInfo.Text = "Incorrect answer!"; }
            TimerAnswer.Stop();
            ProsecnoVreme += sec;
            NadjiPitanje();
        }

        private void lbllAnswer4_Click(object sender, EventArgs e)
        {
            if (pitanja[RandomPitanje].Odgovor == 4)
            {
                lblInfo.Text = "Correct answer!";
                tacnihPitanja++;
            }
            else { lblInfo.Text = "Incorrect answer!"; }
            TimerAnswer.Stop();
            ProsecnoVreme += sec;
            NadjiPitanje();
        }

        private void lblAnswer1_MouseHover(object sender, EventArgs e)
        {
            lblAnswer1.ForeColor = Color.Red;
        }

        private void lblAnswer1_MouseLeave(object sender, EventArgs e)
        {
            lblAnswer1.ForeColor = Color.White;
        }

        private void lbllAnswer2_MouseHover(object sender, EventArgs e)
        {
            lblAnswer2.ForeColor = Color.Red;
        }

        private void lbllAnswer2_MouseLeave(object sender, EventArgs e)
        {
            lblAnswer2.ForeColor = Color.White;
        }

        private void lbllAnswer3_MouseHover(object sender, EventArgs e)
        {
            lblAnswer3.ForeColor = Color.Red;
        }

        private void lbllAnswer3_MouseLeave(object sender, EventArgs e)
        {
            lblAnswer3.ForeColor = Color.White;
        }

        private void lbllAnswer4_MouseHover(object sender, EventArgs e)
        {
            lblAnswer4.ForeColor = Color.Red;
        }

        private void lbllAnswer4_MouseLeave(object sender, EventArgs e)
        {
            lblAnswer4.ForeColor = Color.White;
        }

        private void Quiz_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                this.SetDesktopLocation(MousePosition.X - posX, MousePosition.Y - posY);
            }
        }

        private void Quiz_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void Quiz_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            posX = e.X;
            posY = e.Y;
        }
    }
}
