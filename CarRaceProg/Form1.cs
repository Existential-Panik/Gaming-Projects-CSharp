using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRaceProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gamespeed = 35,x, y, score = 0;
        Random r = new Random();
        void moveRoad(int speed)
        {
            if( pbRoad5.Top >= 1094) { pbRoad5.Top = 0; } else { pbRoad5.Top += speed; }
            if (pbRoad4.Top >= 1094) { pbRoad4.Top = 0; } else { pbRoad4.Top += speed; }
            if (pbRoad3.Top >= 1094) { pbRoad3.Top = 0; } else { pbRoad3.Top += speed; }
            if (pbRoad2.Top >= 1094) { pbRoad2.Top = 0; } else { pbRoad2.Top += speed; }
            if (pbRoad1.Top >= 1094) { pbRoad1.Top = 0; } else { pbRoad1.Top += speed; }
        }
        void moveObst(int speed)
        {
            if (pbObs1.Top >= 1094) { pbObs1.Top = 0; } else { pbObs1.Top += speed; x = r.Next(0, 100); }
            if (pbObs9.Top >= 1094) { pbObs9.Top = 0; } else { pbObs9.Top += speed; }
            if (pbObs8.Top >= 1094) { pbObs8.Top = 0; } else { pbObs8.Top += speed; }
            if (pbObs2.Top >= 1094) { pbObs2.Top = 0; } else { pbObs2.Top += speed; }
            if (pbObs6.Top >= 1094) { pbObs6.Top = 0; } else { pbObs6.Top += speed; }
            if (pbObs4.Top >= 1094) { pbObs4.Top = 0; } else { pbObs4.Top += speed; }
            if (pbObs7.Top >= 1094) { pbObs7.Top = 0; } else { pbObs7.Top += speed; }
            if (pbObs5.Top >= 1094) { pbObs5.Top = 0; } else { pbObs5.Top += speed; }
            if (pbObs3.Top >= 1094) { pbObs3.Top = 0; } else { pbObs3.Top += speed; }
            if (pbObs10.Top >= 1094) { pbObs10.Top = 0; } else { pbObs10.Top += speed; }
        }
        void moveCoins(int speed)
        {
            if (pbCoin1.Top >= 1094) { pbCoin1.Top = 0; } else { pbCoin1.Top += speed; }
            if (pbCoin2.Top >= 1094) { pbCoin2.Top = 0; } else { pbCoin2.Top += speed; }
            if (pbCoin3.Top >= 1094) { pbCoin3.Top = 0; } else { pbCoin3.Top += speed; }
            if (pbCoin4.Top >= 1094) { pbCoin4.Top = 0; } else { pbCoin4.Top += speed; }
            if (pbCoin5.Top >= 1094) { pbCoin5.Top = 0; } else { pbCoin5.Top += speed; }
            if (pbCoin6.Top >= 1094) { pbCoin6.Top = 0; } else { pbCoin6.Top += speed; }
            if (pbCoin7.Top >= 1094) { pbCoin7.Top = 0; } else { pbCoin7.Top += speed; }
            if (pbCoin8.Top >= 1094) { pbCoin8.Top = 0; } else { pbCoin8.Top += speed; }
            if (pbCoin9.Top >= 1094) { pbCoin9.Top = 0; } else { pbCoin9.Top += speed; }
            if (pbCoin10.Top >= 1094) { pbCoin10.Top = 0; } else { pbCoin10.Top += speed; }
            if (pbCoin11.Top >= 1094) { pbCoin11.Top = 0; } else { pbCoin11.Top += speed; }
            if (pbCoin12.Top >= 1094) { pbCoin12.Top = 0; } else { pbCoin12.Top += speed; }
            if (pbCoin13.Top >= 1094) { pbCoin13.Top = 0; } else { pbCoin13.Top += speed; }
            if (pbCoin14.Top >= 1094) { pbCoin14.Top = 0; } else { pbCoin14.Top += speed; }
            if (pbCoin15.Top >= 1094) { pbCoin15.Top = 0; } else { pbCoin15.Top += speed; }
            if (pbCoin16.Top >= 1094) { pbCoin16.Top = 0; } else { pbCoin16.Top += speed; }
            if (pbCoin17.Top >= 1094) { pbCoin17.Top = 0; } else { pbCoin17.Top += speed; }
            if (pbCoin18.Top >= 1094) { pbCoin18.Top = 0; } else { pbCoin18.Top += speed; }
            if (pbCoin19.Top >= 1094) { pbCoin19.Top = 0; } else { pbCoin19.Top += speed; }
        }
        public void gameOver()
        {
            bool gameOver = false;
            if (pbMain.Bounds.IntersectsWith(pbObs1.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs2.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs3.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs4.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs5.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs6.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs7.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs8.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs9.Bounds))
            {
                gameOver = true;
            }
            if (pbMain.Bounds.IntersectsWith(pbObs10.Bounds))
            {
                gameOver = true;
            }
            if(gameOver == true)
            {
                timer1.Stop();
                MessageBox.Show("Game Over!");
                timer1.Enabled = false;
                pbMain.Enabled = false;

            }
        }
        public void scores()
        {
            if(pbMain.Bounds.IntersectsWith(pbCoin1.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin2.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin3.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin4.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin5.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin6.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin7.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin8.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin9.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin10.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin11.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin12.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin13.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin14.Bounds)) { score++; }
            if (pbMain.Bounds.IntersectsWith(pbCoin15.Bounds)) { score++; }
            lblScore.Text = score.ToString();
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                pbMain.Left -= 55;
            }
            if(e.KeyCode == Keys.Right)
            {
                pbMain.Left += 55;
            }
            if(e.KeyCode == Keys.Up)
            {
                pbMain.Top -= 55;
            }
            if (e.KeyCode == Keys.Down)
            {
                pbMain.Top += 55;
            }
        }

        void moveCar(int speed)
        {
            if (pbMain.Top >= 0) { pbMain.Top -= speed; } else { pbMain.Top = 1094; }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveRoad(gamespeed);
            moveObst(gamespeed);
            moveCoins(gamespeed);
            gameOver();
            scores();
        }
    }
}
