using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ST1_2
{
    public partial class Arkanoid : Window
    {
        int blocksLeft = 12, lifes = 3, points = 0, speed = 12, Ballspeed_x = 8, Ballspeed_y = 8;
        bool goLeft, goRight, spacebarLock;
        public DispatcherTimer gametimer = new DispatcherTimer();
        public Arkanoid()
        {
            InitializeComponent();
            MyCanvas.Focus();
            
        gametimer.Tick += GameTimerEvent;
            gametimer.Interval = TimeSpan.FromMilliseconds(20);
            gametimer.Start();
        }
        
        private void GameTimerEvent(object sender, EventArgs e)
        {
 
            if (goLeft==true && Canvas.GetLeft(Pad) > 5 )
            {
                Canvas.SetLeft(Pad, Canvas.GetLeft(Pad) - speed);
            }
            if ((goLeft == true && Canvas.GetLeft(Pad) > 5) && spacebarLock==false)
            {
                Canvas.SetLeft(Ball, Canvas.GetLeft(Ball) - speed);
            }
            if (goRight == true && Canvas.GetLeft(Pad) + (Pad.Width+24) <= Application.Current.MainWindow.Width)
            {
                Canvas.SetLeft(Pad, Canvas.GetLeft(Pad) + speed);
            }
            if (goRight == true && Canvas.GetLeft(Pad) + (Pad.Width + 24) <= Application.Current.MainWindow.Width
                && spacebarLock == false)
                {
                Canvas.SetLeft(Ball, Canvas.GetLeft(Ball) + speed);
            }


            if (spacebarLock)
            {
                Canvas.SetTop(Ball, Canvas.GetTop(Ball) - Ballspeed_y);
                Canvas.SetLeft(Ball, Canvas.GetLeft(Ball) - Ballspeed_x);
            }


            if (Canvas.GetTop(Ball) + (Ball.Height * 2) <= 50)
            { Ballspeed_y = -Ballspeed_y; }

            if (Canvas.GetLeft(Ball) < 5 || Canvas.GetLeft(Ball) + (Ball.Width * 2) > Application.Current.MainWindow.Width)
            { Ballspeed_x = -Ballspeed_x; }

            if (Canvas.GetTop(Ball) + (Ball.Height * 2) >= Application.Current.MainWindow.Height)
            { Ballspeed_y = -Ballspeed_y;
                MessageBox.Show("Utrata piłki, -1 życie");
                lifes--;
                points = points - 10; ;
                Points.Content = "Punkty: " + points;
                Lifes.Content = "życia: " + lifes;
                Canvas.SetTop(Ball, Canvas.GetTop(Pad) - (Pad.Height*2));
                Canvas.SetLeft(Ball, Canvas.GetLeft(Pad) + (0.5*Pad.Width));
                spacebarLock = false;
            }


            if (Canvas.GetTop(Ball) + (Ball.Height) > Canvas.GetTop(Pad)
                  && Canvas.GetLeft(Ball) + (Ball.Width) > Canvas.GetLeft(Pad) - 5
                 && Canvas.GetLeft(Ball) + (Ball.Width) < Canvas.GetLeft(Pad) + (Pad.Width) +(16))
            { Ballspeed_y = -Ballspeed_y; }

            else if (Canvas.GetTop(Ball) + (Ball.Height) > Canvas.GetTop(Pad)
                  && Canvas.GetLeft(Ball) + (Ball.Width) > Canvas.GetLeft(Pad) - (16)
                 && Canvas.GetLeft(Ball) + (Ball.Width) < Canvas.GetLeft(Pad) + (Pad.Width) + (24))
            { Ballspeed_x = -Ballspeed_x; }



            foreach (var block in MyCanvas.Children.OfType<Rectangle>())
            {
                if (block.Name != "Pad" &&
                block.Visibility != System.Windows.Visibility.Hidden &&
                Canvas.GetTop(Ball) + (Ball.Height) > Canvas.GetTop(block) &&
                Canvas.GetTop(Ball) < Canvas.GetTop(block) + (block.Height) &&
                Canvas.GetLeft(Ball) + (Ball.Width) > Canvas.GetLeft(block) &&
                Canvas.GetLeft(Ball) < Canvas.GetLeft(block) + (block.Width)  )
                {
                    Ballspeed_y = -Ballspeed_y;
                    block.Visibility = System.Windows.Visibility.Hidden;
                    points += 10;
                    Points.Content = "Punkty: " + points;
                    blocksLeft--;
                }
                else if (block.Name != "Pad" &&
                block.Visibility != System.Windows.Visibility.Hidden &&
                Canvas.GetTop(Ball) + (Ball.Height) >= Canvas.GetTop(block) &&
                Canvas.GetTop(Ball) + (Ball.Height) < Canvas.GetTop(block) + (block.Height) &&
                Canvas.GetLeft(Ball) + (Ball.Width) > Canvas.GetLeft(block) - 3 &&
                Canvas.GetLeft(Ball) < Canvas.GetLeft(block) + (block.Width) + 3  )
                {
                    Ballspeed_x = -Ballspeed_x;
                    block.Visibility = System.Windows.Visibility.Hidden;
                    points += 10;
                    Points.Content = "Punkty: " + points;
                    blocksLeft--;
                }
                
            }
            Victory();
            Lose();
        }

        private void Lose()
        {
            if (lifes == 0)
            {
                MessageBox.Show("Brak żyć, przegrana! Punkty:"+ points);
                gametimer.Stop();
                this.Close();
            }
        }
        private void Victory()
        {
            int bonusPointsLifes = 10;
            if (blocksLeft == 0)
            {
                bonusPointsLifes *= lifes;
                points += bonusPointsLifes;
                MessageBox.Show("Gratulacje, wygrałeś! Punkty:" + points + " (Dodatkowe punkty za życia: " + bonusPointsLifes +")");
                gametimer.Stop();
                this.Close();
            }
        }

        private void MyCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                goRight = true;
            }
            if (e.Key == Key.Left)
            {
                goLeft = true;
            }
            if (e.Key == Key.Space)
            {
                spacebarLock = true;
            }
        }

        private void MyCanvas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                goRight = false;
            }
            if (e.Key == Key.Left)
            {
                goLeft = false;
            }
        }
    }
}
