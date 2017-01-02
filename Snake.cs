using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{    
    public class Snake
    {
        public int SnakeLength { get; set; }
        public int Direction { get; set; }
        public bool IsInMotion { get; set; }


        public int PositionX
            {
            get { return Head.posX; }
            set { Head.posX = value; }
            }
        public int PositionY
        {
            get { return Head.posY; }
            set { Head.posY = value; }
        }

        public List<SnakeSegment> SnakeBody = new List<SnakeSegment>();
        SnakeSegment Head = new SnakeSegment();
        Food Food = new Food();

        public Snake()
        {
            SnakeBody.Add(new SnakeSegment());         
        }

        public void DrawSnake(PaintEventArgs e)
        {                     
            for(int i=0; i<SnakeBody.Count;i++)
            {
                Pen snake = new Pen(Color.DarkGreen, 20);
                Rectangle body = new Rectangle(SnakeBody[i].posX, SnakeBody[i].posY, 1, 1);
                e.Graphics.DrawRectangle(snake, body);
                snake.Dispose();            
            }        
        }
        
        public void MoveSnake()
        {            
            if (Settings.IsOver != true)
            {
                for (int i = SnakeBody.Count - 1; i >= 0; i--)
                {
                    if (i == 0) 
                    {
                        ChangeSnakeDirection(i);                      

                        for (int j = 1; j < SnakeBody.Count; j++)
                        {
                            if (SnakeColidedWithBody(i,j)) Game.EndGame();
                        }
                        
                        if (SnakeColidedWithFood())
                        {
                            AddSegment(1);
                            Food.RandomizeFoodPosition();
                            SetPlayerScore();
                            SetSnakeSpeed();                          
                        }                      
                        if (SnakeColidedWithBorder()) Game.EndGame(); 
                    }
                    else MoveSnakeBody(i);                                          
                } 
            }
        }

        private void MoveSnakeBody(int i)
        {
            SnakeBody[i].posX = SnakeBody[i - 1].posX;
            SnakeBody[i].posY = SnakeBody[i - 1].posY;
        }

        private bool SnakeColidedWithBorder()
        {
            if (SnakeBody[0].posX < 10 || SnakeBody[0].posX > 395 || SnakeBody[0].posY < 10 || SnakeBody[0].posY > 395) return true;
            else return false;
        }

        private void SetSnakeSpeed()
        {
            if (ScoreTresholdReached()) Settings.Speed += 5;
        }

        private bool ScoreTresholdReached()
        {
            if (Settings.Score > Settings.Speed * 100) return true;
            else return false;
        }

        private void SetPlayerScore()
        {
            Settings.Score += 100;
        }

        private bool SnakeColidedWithFood()
        {
            if (SnakeBody[0].posX == Food.FoodPosX && SnakeBody[0].posY == Food.FoodPosY) return true;
            return false;
        }

        private bool SnakeColidedWithBody(int i, int j)
        {
            if (SnakeBody[i].posX == SnakeBody[j].posX &&
                SnakeBody[i].posY == SnakeBody[j].posY) return true;
            else return false;
        }

        private void ChangeSnakeDirection(int i)
        {
            switch (Direction)
            {
                case 1:
                    SnakeBody[i].posY -= 20;
                    break;
                case 2:
                    SnakeBody[i].posY += 20;
                    break;
                case 3:
                    SnakeBody[i].posX -= 20;
                    break;
                case 4:
                    SnakeBody[i].posX += 20;
                    break;
                default:
                    break;
            }
        }

        public void AddSegment(int segmentsToAdd)
        {
            for (int i = 0; i < segmentsToAdd; i++)
            {
                SnakeBody.Add(new SnakeSegment());
            }
        }   
    }
}