using System;
using System.Collections.Generic;

namespace Langton_s_Ant
{
    public class Ant
    {
        public int globalIndex; //Index, unique to each ant
        public int x; //Position of the ant in the grid
        public int y;
        private (int, int) currentDir; //Current direction of the ant
        private int iCurrentDir;
        private Grid g;
        public static List<(int, int)> dirs = new List<(int, int)>() { (0, -1), (1, 0),  (0, 1), (-1, 0) };
        //public static List<(int, int)> dirs = new List<(int, int)>() { (0, -1), (1, -1), (1, 0), (1, 1), (0, 1), (-1, 1), (-1, 0), (-1, -1) };
        private static Random rnd = new Random();

        public Ant(int x, int y, Grid g, int globalIndex)
        {
            this.x = x;
            this.y = y;
            this.g = g;
            this.globalIndex = globalIndex;
            iCurrentDir = rnd.Next(0, dirs.Count);
            this.currentDir = dirs[iCurrentDir];
            
        }

        public void UpdateAnt()
        {
            if (g.TabBoxes[this.x, this.y] == -1) //If the ant is on a blank tile, turn it to left and sets the tile's color to the ant color
            {
                this.iCurrentDir = (this.iCurrentDir - 1 + dirs.Count) % dirs.Count;
                g.TabBoxes[this.x, this.y] = this.globalIndex;
            }
            else //Else turn it to right and delete the tile's color
            {
                this.iCurrentDir = (this.iCurrentDir + 1 + dirs.Count) % dirs.Count;
                g.TabBoxes[this.x, this.y] = -1;
            }

            this.currentDir = dirs[iCurrentDir];

            //
            this.x = (this.x + currentDir.Item1 + g.nX) % (g.nX);
            this.y = (this.y + currentDir.Item2 + g.nY) % (g.nY);

            

            /*(int, int) newPos = (this.x + currentDir.Item1, this.y + currentDir.Item2);
            if (0<= newPos.Item1 && newPos.Item1 <g.nX && 0 <= newPos.Item2 && newPos.Item2 < g.nY)
            {
                if (g.TabBoxes[newPos.Item1, newPos.Item2])
                {
                    currentDir = (currentDir.Item2, -currentDir.Item1);
                }
                else
                {
                    currentDir = (-currentDir.Item2, currentDir.Item1);
                }
                Console.WriteLine(currentDir);
                this.x = newPos.Item1;
                this.y = newPos.Item2;
            }*/
        }
    }
}