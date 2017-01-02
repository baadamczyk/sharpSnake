using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        SnakeBlock block1 = new SnakeBlock();

        public Form1()
        {            
            InitializeComponent();                   
            block1.InitSnake();          
            SnakeBlock.form = this;
            Focus();
                  
        }

               

        
        public void Form1_KeyDown(object sender, KeyEventArgs e) //zmiana kierunku
        {
            if(e.KeyCode == Keys.Up)
            {
                block1.keyPressed = true;
                block1.IsInMotion = false;
                block1.MakeAMove(1);
            }
            else if (e.KeyCode == Keys.Down)
            {
                block1.keyPressed = true;
                block1.IsInMotion = false;
                block1.MakeAMove(2);
            }
            else if (e.KeyCode == Keys.Left)
            {
                block1.keyPressed = true;
                block1.IsInMotion = false;
                block1.MakeAMove(3);
            }
            else if(e.KeyCode == Keys.Right)
            {
                block1.keyPressed = true;
                block1.IsInMotion = false;
                block1.MakeAMove(4);
            }
        }

        
    }
}

        

