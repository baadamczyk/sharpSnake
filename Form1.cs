using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Food Food = new Food();
        Snake Snake = new Snake();
        int timerCount = 0;

        public int FoodPosX
        {
            get { return Food.posX; }
            set { Food.posX = value; }
        }

        public int FoodPosY
        {
            get { return Food.posY; }
            set { Food.posY = value; }
        }


        public Form1()
        {
            InitializeComponent();
            StartGame();        
        }

        public void StartGame()
        {            
            ChangeSettingsToDefault();
            SetGameTimer();
            SetSnakeStartingPosition();                                                       
            Food.RandomizeFoodPosition();                               
        }

        private void ChangeSettingsToDefault()
        {
            Settings.Score = 0;
            Settings.IsOver = false;
            Settings.Speed = 5;
        }

        private void SetGameTimer()
        {
            timer1.Interval = 1000 / Settings.Speed;
            timer1.Start();
        }

        private void SetSnakeStartingPosition()
        {
            Random rand = new Random();
            Snake.Direction = rand.Next(1, 4);
        }

        public void GameArea_Paint(object sender, PaintEventArgs e)
        {
            DrawSprites(e);
            DisplayScore();                       
        }

        private void DrawSprites(PaintEventArgs e)
        {
            Food.DrawFood(e);
            Snake.DrawSnake(e);
        }

        private void DisplayScore()
        {
            scoreTextbox.Text = Settings.Score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food.RandomizeFoodPosition();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount++;
            Snake.MoveSnake();
            GameArea.Invalidate();                              
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up && Snake.Direction != 2)
            {
                Snake.Direction = 1;
            }
            else if (e.KeyCode == Keys.Down && Snake.Direction != 1)
            {
                Snake.Direction = 2;
            }
            else if (e.KeyCode == Keys.Left && Snake.Direction != 4)
            {
                Snake.Direction = 3;
            }
            else if (e.KeyCode == Keys.Right && Snake.Direction != 3)
            {
                Snake.Direction = 4;
            }
        }     
    }
}


        

