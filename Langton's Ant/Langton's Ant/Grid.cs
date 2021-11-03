using System;
using System.Drawing;

namespace Langton_s_Ant
{
	public class Grid
	{
		public int nX { get; private set; } //Number of cells per row
		public int nY { get; private set; } //Number of cells per column
		private int boxSize;
		public int[,] TabBoxes; //2 dimensional array that stores all the boxes : -1 if the tile is blank, any other positive integer if the tile is colored
		public Graphics Canvas;
		public Grid(int nbCellsX, int nbCellsY, int boxSize)
		{
			this.nX = nbCellsX;
			this.nY = nbCellsY;
			this.boxSize = boxSize;
			this.TabBoxes = new int[this.nX, this.nY];
			for (int x = 0; x < this.nX; x++)
            {
				for (int y = 0; y < this.nY; y++)
				{
					TabBoxes[x, y] = -1;
				}

			}

		}
	}
}