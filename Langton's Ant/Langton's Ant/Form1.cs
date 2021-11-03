using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Langton_s_Ant
{
    public partial class Form1 : Form
    {
        private Timer MainTimer;
        private Game game;
        public int nX;
        public int nY;
        public int boxSize;
        public bool isPlaying = true;

        public Form1(int x, int y, int boxSize, int nbAnts)
        {
            this.MainTimer = new Timer();
            this.MainTimer.Interval = (1);
            this.MainTimer.Tick += new EventHandler(MainTimer_Tick);
            this.MainTimer.Start();
            this.nX = x;
            this.nY = y;

            this.boxSize = boxSize;
            this.game = new Game(this.nX, this.nY, boxSize,nbAnts);

            InitializeComponent(this.nX, this.nY, boxSize);
        }


        private void MainTimer_Tick(object sender, EventArgs e)
        {
            /*var frm = this.CanvasBox;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, nX * boxSize, nY * boxSize));
                bmp.Save($@"..\..\..\Screenshots\LangtonAnt_{game.steps}.png");
            }*/
            for (int i = 0; i< game.stepsPerDraw; i++)
            {
                foreach (Ant ant in game.ants)
                {
                    ant.UpdateAnt();
                }
                ++game.steps;
                this.Text = $"Langton's Ants : Step {game.steps}";
            }
            Refresh();
        }
        private void CanvasBox_Paint(object sender, PaintEventArgs e)
        {
            game.PaintGrid(e.Graphics);
        }
        private void Pause(object sender, KeyPressEventArgs e)
        {
            isPlaying = !isPlaying;
            if (isPlaying) { this.MainTimer.Start(); }
            else { this.MainTimer.Stop(); }
        }
        private void ChangeStepsPerDraw(object sender, EventArgs e)
        {
            game.stepsPerDraw = this.StepsPerDrawTrackBar.Value;
            this.StepsPerDrawLab.Text = $"{game.stepsPerDraw} step(s) calculated between 2 canvas updates";
        }
        private void ChangeStepSpeed(object sender, EventArgs e)
        {
            this.MainTimer.Interval =  this.StepSpeedTrackBar.Value;
            this.MainTimer.Start();
            this.StepSpeedLab.Text = $"{this.StepSpeedTrackBar.Value} ms between 2 canvas updates";
        }
    }
}

