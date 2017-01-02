using System.Windows.Forms;
namespace Snake
{
    partial class Form1 : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameArea = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scoreTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameArea
            // 
            this.GameArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GameArea.Enabled = false;
            this.GameArea.Location = new System.Drawing.Point(12, 21);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(400, 400);
            this.GameArea.TabIndex = 0;
            this.GameArea.TabStop = false;
            this.GameArea.Paint += new System.Windows.Forms.PaintEventHandler(this.GameArea_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scoreTextbox);
            this.groupBox1.Location = new System.Drawing.Point(144, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punkty";
            // 
            // scoreTextbox
            // 
            this.scoreTextbox.Enabled = false;
            this.scoreTextbox.Location = new System.Drawing.Point(6, 19);
            this.scoreTextbox.Name = "scoreTextbox";
            this.scoreTextbox.Size = new System.Drawing.Size(100, 20);
            this.scoreTextbox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GameArea);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SNAKE";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameArea;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox scoreTextbox;
    }
}

