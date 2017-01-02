using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public class Food: Position
    {     
        public static int FoodPosX { get; set; }
        public static int FoodPosY { get; set; }

        public void DrawFood(PaintEventArgs e)
        {
            posX = FoodPosX;
            posY = FoodPosY;                                
            Pen snake = new Pen(Color.Sienna, 20);
            Rectangle body = new Rectangle(posX, posY, 1, 1);
            e.Graphics.DrawRectangle(snake, body);            
        }

        public void RandomizeFoodPosition()
        {
            Random rand = new Random();
            FoodPosX = rand.Next(1, 19)*20;
            FoodPosY = rand.Next(1, 19)*20;
        }
    }
}