using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    public class SnakeBlock: PictureBox
    {       
        public static int posX { get; set; }
        public static int posY { get; set; }
        public static int direction { get; set; } //1 == góra, 2 == dół, 3 == lewo, 4 == prawo;
        public bool IsInMotion { get; set; }
        public static Point location = new Point(posX,posY);
        public static Point startingPoint = new Point(posX, posY);
        public static Form1 form;
        public bool keyPressed;

        public void MakeAMove(int direction)
        {
            IsInMotion = true;
            do
            {
                switch(direction)
                {
                    case 1:
                        keyPressed = false;
                        do
                        {                            
                            Application.DoEvents();
                            if (keyPressed)break;
                            MoveUp();
                            IfHitBorder(direction);
                        } while (IsInMotion);
                        break;
                    case 2:
                        keyPressed = false;
                        do
                        {                            
                            Application.DoEvents();
                            if (keyPressed) break;
                            MoveDown();
                            IfHitBorder(direction);

                        } while (IsInMotion);
                        break;
                    case 3:
                        keyPressed = false;
                        do
                        {                            
                            Application.DoEvents();
                            if (keyPressed) break;
                            MoveLeft();
                            IfHitBorder(direction);

                        } while (IsInMotion);
                        break;
                    case 4:
                        keyPressed = false;
                        
                        do
                        {                            
                            Application.DoEvents();
                            if (keyPressed) break;
                            MoveRight();
                            IfHitBorder(direction);

                        } while (IsInMotion);
                        break;
                    default:
                        break;
                }
            } while (IsInMotion);

        }

        private void MoveUp()
        {
            location.Y -= 5;
            Task.Delay(50).Wait();            
        }

        private void MoveDown()
        {
            location.Y += 5;
            Task.Delay(50).Wait();
        }

        private void MoveLeft()
        {
            location.X -= 5;
            Task.Delay(50).Wait();
        }

        private void MoveRight()
        {
            location.X += 5;
            Task.Delay(50).Wait();
        }

        public void InitSnake()
        {
            RandomizeSnakePosition();
            RandomizeSnakeDirection();
            SetSnakeStartingPosition();
        }

        private void RandomizeSnakePosition()
        {
            Random rand = new Random();
            posX = rand.Next(150, 400);
            posY = rand.Next(150, 400);            
        }

        private void RandomizeSnakeDirection()
        {
            Random rand = new Random();
            direction = rand.Next(1, 4);
        }

        private void SetSnakeStartingPosition()
        {      
            startingPoint.X = posX;
            startingPoint.Y = posY;
            location = startingPoint;
        }

        public bool IfHitBorder(int direction)
        {
            switch(direction)
            {
                case 1:
                    if (location.Y == 20) MakeAMove(4);
                    return true;
                case 2:
                    if (location.Y == 490) MakeAMove(3);
                    return true;
                case 3:
                    if (location.X == 20) MakeAMove(1);
                    return true;
                case 4:
                    if (location.X == 490) MakeAMove(2);
                    return true;
                default:
                    break;
            }
            return false;
        }



    }
}
