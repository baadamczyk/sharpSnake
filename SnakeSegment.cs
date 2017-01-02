using System;

namespace Snake
{
    public class SnakeSegment: Position
    {        
        public SnakeSegment()
        {
            SetSnakeStartingPosition();                
        }

        private void SetSnakeStartingPosition()
        {
            Random rand = new Random();
            posX = rand.Next(1, 19) * 20;
            posY = rand.Next(1, 19) * 20;
        }
    }
}
