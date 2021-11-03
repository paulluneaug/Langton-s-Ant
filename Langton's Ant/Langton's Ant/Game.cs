using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Langton_s_Ant
{
	public class Game
	{
		private int nX; //Number of boxes per row
		private int nY; //Number of boxes per column
		private int boxSize; //Number of pixels of each box
		public Grid grid;
		public List<Ant> ants = new List<Ant>();
		public List<Color> antsColors = new List<Color>() { Color.FromArgb(255, 0, 0), //Color of the first 12 ants
															Color.FromArgb(255, 153, 0),
															Color.FromArgb(153, 204, 0),
															Color.FromArgb(51, 153, 102),
															Color.FromArgb(51, 204, 204),
															Color.FromArgb(51, 102, 255),
															Color.FromArgb(204, 153, 255),
															Color.FromArgb(255, 153, 204),
															Color.FromArgb(150, 150, 150),
															Color.FromArgb(255, 255, 0),
															Color.FromArgb(131, 69, 65)};
		public SolidBrush ColorBrush;
		public int steps = 0;
		public int stepsPerDraw = 1;

		public Game(int nbCellsX, int nbCellsY, int boxSize, int nbAnts)
		{
			this.nX = nbCellsX; 
			this.nY = nbCellsY; 
			this.boxSize = boxSize;

			this.ColorBrush = new SolidBrush(Color.White);

			grid = new Grid(this.nX, this.nY, this.boxSize);
			Random rnd = new Random();

			for (int i = 0; i<nbAnts ; i++)
            {
				ants.Add(new Ant(rnd.Next(10, nX - 10), rnd.Next(10, nY - 10), grid, i));
				if ((i + 1) > antsColors.Count)
                {
					antsColors.Add(Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
                }
            }

		}

		public void PaintGrid(Graphics g)
		{
			g.Clear(Color.Black);
			for (int i = 0; i < nX; i++)
			{
				for (int j = 0; j < nY; j++)
				{
					if (grid.TabBoxes[i, j] != -1)
					{
						this.ColorBrush.Color = antsColors[grid.TabBoxes[i, j]];
						g.FillRectangle(ColorBrush, i * boxSize, j * boxSize, boxSize, boxSize);
						
					}
				}
			}

			//Displays the ants
			this.ColorBrush.Color = Color.FromArgb(255, 255, 255);
			foreach (Ant a in ants)
            {
				g.FillRectangle(ColorBrush, a.x * boxSize, a.y * boxSize, boxSize, boxSize);
			}
		}
	}
}
