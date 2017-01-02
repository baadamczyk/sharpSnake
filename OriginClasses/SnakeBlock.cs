using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                            if (keyPressed == true)break;
                            location.Y -= 5;
                            form.snakeTile1.Location = location;
                            Task.Delay(50).Wait();
                            IfHitBorder(direction);
                        } while (IsInMotion == true);
                        break;
                    case 2:
                        keyPressed = false;
                        do
                        {
                            Application.DoEvents();
                            if (keyPressed == true) break;
                            location.Y += 5;
                            form.snakeTile1.Location = location;
                            Task.Delay(50).Wait();
                            IfHitBorder(direction);
                        } while (IsInMotion == true);
                        break;
                    case 3:
                        keyPressed = false;
                        do
                        {
                            Application.DoEvents();
                            if (keyPressed == true) break;
                            location.X -= 5;
                            form.snakeTile1.Location = location;
                            Task.Delay(50).Wait();
                            IfHitBorder(direction);
                        } while (IsInMotion == true);
                        break;
                    case 4:
                        keyPressed = false;
                        
                        do
                        {
                            Application.DoEvents();
                            if (keyPressed == true) break;
                            location.X += 5;
                            form.snakeTile1.Location = location;
                            Task.Delay(50).Wait();
                            IfHitBorder(direction); 
                        } while (IsInMotion == true);
                        break;
                    default:
                        break;
                }
            } while (IsInMotion == true);

        }
        
        public void InitSnake()
        {
            Random rand = new Random();
            posX = rand.Next(150, 400);
            posY = rand.Next(150, 400);

            direction = rand.Next(1, 4);

            startingPoint.X = posX;
            startingPoint.Y = posY;
            location = startingPoint;
        }

        public bool IfHitBorder(int direction)
        {
            switch(direction)
            {
                case 1:
                    if (location.Y == 20) this.MakeAMove(4);
                    return true;
                case 2:
                    if (location.Y == 490) this.MakeAMove(3);
                    return true;
                case 3:
                    if (location.X == 20) this.MakeAMove(1);
                    return true;
                case 4:
                    if (location.X == 490) this.MakeAMove(2);
                    return true;
                default:
                    break;
            }
            return false;
        }



    }
}
