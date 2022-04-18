using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makeagame
{
    public partial class Form1 : Form
    {
        int collumspeed = 8;
        int groundspeed = 2;
        int position = 5;
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restart_btt.Hide();
            Timer.Stop();
            pause_btt.Hide();
            tt_btt.Hide();
            end_pic.Hide();
        }
        private void restartGame()
        {
            Timer.Stop();
            score = 0;
            collumspeed = 8;
            bird.Top = 196;
            collumBottom.Left = 540;
            collumBottom1.Left = 760;
            collumTop.Left = 590;
            collumTop1.Left = 860;
            Timer.Start();
        }
        private void GameTimeEvent(object sender, EventArgs e)
        {
            label1.Hide();
            end_pic.Hide();
            logo_pic.Hide();
            tt_btt.Hide();
            pause_btt.Show();
            bird.Top += position;
            collumBottom.Left -= collumspeed;
            collumTop.Left -= collumspeed;
            collumTop1.Left -= collumspeed;
            collumBottom1.Left -= collumspeed;            
            Ground.Left -= groundspeed;
            
            Score.Text = "Điểm Số: " + score.ToString();
            if (Ground.Left < -80)
            {
                Ground.Left =-30 ;
            }
            if (collumBottom.Left < 0 )
            {
                score++;
                collumBottom.Left = 570;                                                        
            }
            if (collumTop.Left < 10 )
            {
                collumTop.Left = 600;                                       
            }
            if(collumBottom1.Left < 10)
            {
                score++;
                collumBottom1.Left = 650; 
            }
            if(collumTop1.Left < 1)
            {
                collumTop1.Left = 750;
            }          
            
            
            if (bird.Bounds.IntersectsWith(collumBottom.Bounds)|| 
                bird.Bounds.IntersectsWith(collumTop.Bounds)||
                bird.Bounds.IntersectsWith(Ground.Bounds)||
                bird.Bounds.IntersectsWith(collumBottom1.Bounds)||
                bird.Bounds.IntersectsWith(collumTop1.Bounds)
                )
            {
                gameover();
            }
            if(bird.Top < -25)
            {
               gameover();
            }
           
        }

        
        private void gameover()
        {
            Timer.Stop();
            pause_btt.Hide();
            end_pic.Show();
            restart_btt.Show();
            exit_btt.Show();
            menu_btt.Show();
        }  
        
        

        private void pause_btt_MouseDown(object sender, MouseEventArgs e)
        {
            Timer.Stop();
            tt_btt.Show();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            position = -10;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            position = +10;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            position = 10;
        }
        
        


        private void pause_btt_Click(object sender, EventArgs e)
        {          
            Timer.Stop();
            tt_btt.Show();
            exit_btt.Show();           
        }

        private void tt_btt_Click(object sender, EventArgs e)
        {
            exit_btt.Hide();
            Timer.Start();
            tt_btt.Hide();
        }
        private void play_btt_Click(object sender, EventArgs e)
        {
            exit_btt.Hide();
            Timer.Start();
            play_btt.Hide();
            menu_btt.Hide();
        }

        private void restart_btt_Click(object sender, EventArgs e)
        {          
            restartGame();
            restart_btt.Hide();
            exit_btt.Hide();
            menu_btt.Hide();
        }
        private void exit_Click(object sender, EventArgs e)
        {          
            this.Close();
        }
        private void play_btt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                exit_btt.Hide();
                Timer.Start();
                play_btt.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            check1.Hide();
            check2.Hide();
            check3.Hide();
        }

        private void close_btt_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
        private void easy_btt_Click(object sender, EventArgs e)
        {
            collumspeed = 8;
            check1.Show();           
        }
        private void medium_btt_Click(object sender, EventArgs e)
        {
            collumspeed = 12;
            check2.Show();            
        }
        private void hard_btt_Click(object sender, EventArgs e)
        {
            collumspeed = 18;
            check3.Show();            
        }
        private void menu_btt_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }
    }
}
