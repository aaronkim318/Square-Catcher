using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Air_Hockey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer ping = new SoundPlayer(Properties.Resources._528730__alexhanj__ping);
        SoundPlayer winning = new SoundPlayer(Properties.Resources._156420__rauliphone__winning);
        SoundPlayer zoom = new SoundPlayer(Properties.Resources._62139__tkshredder__zoomin);
        

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        Rectangle player1 = new Rectangle(235, 35, 60, 10);
        Rectangle player2 = new Rectangle(235, 465, 60, 10);
        Rectangle ball = new Rectangle(150, 195, 10, 10);
        Rectangle boost = new Rectangle(30, 270, 8, 8);

        int player1Score = 0;
        int player2Score = 0;

        int player1Speed = 6;
        int player2Speed = 6;

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool aDown = false;
        bool dDown = false;
        bool leftDown = false;
        bool rightDown = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //when the keys are clicked make the keys true
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //when the keys are not clicked make the keys false
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();

            int x1 = rand1.Next(0, this.Width - 10);
            int y1 = rand1.Next(0, this.Height - 10);

            int x2 = rand2.Next(0, this.Width - 10);
            int y2 = rand2.Next(0, this.Height - 10);

            //the collison between the ball and the paddle
            if (player1.IntersectsWith(ball))
            {
                ball.X = x1;
                ball.Y = y1;
                player1Score++;
                p1Label.Text = $"{player1Score}";
                ping.Play();
            }
            if (player2.IntersectsWith(ball))
            {
                ball.X = x1;
                ball.Y = y1;
                player2Score++;
                p2Label.Text = $"{player2Score}";
                ping.Play();

            }
            //the collison between player and the boost
            if (player1.IntersectsWith(boost))
            {
                boost.X = x2;
                boost.Y = y2;
                player1Speed += 2;
                zoom.Play();
                
            }
            if (player2.IntersectsWith(boost))
            {
                boost.X = x2;
                boost.Y = y2;
                player2Speed += 2;
                zoom.Play();
            }

            //moves player 1
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }
            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }

            if (dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += player1Speed;
            }

            //move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            if (leftDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }

            if (rightDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }





            //check who wins
            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
                winning.Play();
            }
            else if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
                winning.Play();
            }

            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(blueBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, ball);
            e.Graphics.FillRectangle(yellowBrush, boost);
        }


    }

}
