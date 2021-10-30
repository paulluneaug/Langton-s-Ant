using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Langton_s_Ant
{
    public partial class Form1 : Form
    {
        private Timer MainTimer;
        private Game game;

        public Form1(int x, int y, int nbAnts)
        {
            this.MainTimer = new Timer();
            this.MainTimer.Interval = (5);
            this.MainTimer.Tick += new EventHandler(MainTimer_Tick);
            this.MainTimer.Start();

            int boxSize = 5;
            this.game = new Game(x, y, boxSize,nbAnts);

            InitializeComponent(x,y, boxSize);
        }


        private void MainTimer_Tick(object sender, EventArgs e)
        {
            foreach (Ant ant in game.ants)
            {
                ant.UpdateAnt();
            }
            ++game.steps;
            this.Text = $"Langton's Ants : Step {game.steps}";
            Refresh();
            this.StepsLab.Refresh();
        }
        private void CanvasBox_Paint(object sender, PaintEventArgs e)
        {
            game.PaintGrid(e.Graphics);
        }
    }
}

