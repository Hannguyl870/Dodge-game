using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodge_game
{
    public partial class Form1 : Form
    {
        int playerscore; 

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool dDown = false;
        bool aDown = false;
        bool leftarrowDown = false;
        bool rightarrowDown = false;

        Rectangle player = new Rectangle(220, 305, 20, 20);
        int playerSpeed = 10;

        List<Rectangle> balls = new List<Rectangle>();
        int ballsize = 10;
        int ballspeed = 8;

        List<Rectangle> obstical = new List<Rectangle>();

        SolidBrush lightblueBrush = new SolidBrush(Color.LightBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush greenBrush = new SolidBrush(Color.LawnGreen);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush purpleBrush = new SolidBrush(Color.MediumPurple);

        Random randgen = new Random();
        int randValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftarrowDown = true;
                    break;
                case Keys.Right:
                    rightarrowDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightarrowDown = false;
                    break;
                case Keys.Left:
                    leftarrowDown = false;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(lightblueBrush, player);
            


            for (int i = 0; i < balls.Count(); i++)
            {
                e.Graphics.FillEllipse(purpleBrush, balls[i]);
            }
        }

        private void Balltimer_Tick(object sender, EventArgs e)
        {
            if (wDown == true && player.Y > 0)
            {
                player.Y -= playerSpeed;
            }

            if (sDown == true && player.Y < this.Height - player.Height)
            {
                player.Y += playerSpeed;
            }

            if (aDown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }

            if (dDown == true && player.X < this.Width - player.Width)
            {
                player.X += playerSpeed;
            }

            if (upArrowDown == true && player.Y > 0)
            {
                player.Y -= playerSpeed;
            }
            if (downArrowDown == true && player.Y < this.Height - player.Height)
            {
                player.Y += playerSpeed;
            }

            if (leftarrowDown == true && player.X > 0)
            {
                player.X -= playerSpeed;
            }

            if (rightarrowDown == true && player.X < this.Width - player.Width)
            {
                player.X += playerSpeed;
            }

            randValue = randgen.Next(1, 11);

            for (int i = 0; i < 5; i++)
            {
                int x = randgen.Next(1,10);
                Rectangle newball = new Rectangle(x, 0, ballsize, ballsize);
                balls.Add(newball);
            }

            for(int i = 0; i < balls.Count(); i++)
            {
                if (balls[i].IntersectsWith(player))
                {
                    playerscore -= 5;
                    balls.RemoveAt(i);
                }
            }
            for (int i = 0; i < obstical.Count(); i++)
            {
                if (obstical[i].IntersectsWith(player))
                {
                    playerscore = 0;
          
                }
            }

            if (playerscore < 0 )
            {
                Winlable.ForeColor = Color.Red;
                Winlable.Text = $" You Lose ";
            }

            
        }
    }
}
