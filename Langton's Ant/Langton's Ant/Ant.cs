using System;
using System.Collections.Generic;

namespace Langton_s_Ant
{
    public class Ant
    {
        public int globalIndex;
        public int x;
        public int y;
        private (int, int) currentDir;
        private Grid g;
        public static List<(int, int)> dirs = new List<(int, int)>() { (0, 1), (1, 0), (0, -1), (-1, 0) };
        private static Random rnd = new Random();

        public Ant(int x, int y, Grid g, int globalIndex)
        {
            this.x = x;
            this.y = y;
            this.g = g;
            this.globalIndex = globalIndex;
            Console.WriteLine(rnd.Next(0, dirs.Count));
            this.currentDir = dirs[rnd.Next(0, dirs.Count)];
            Console.WriteLine(this.currentDir);
            
        }

        public void UpdateAnt()
        {
            try
            {
                if (g.TabBoxes[this.x, this.y] == -1)
                {
                    currentDir = (currentDir.Item2, -currentDir.Item1);
                    g.TabBoxes[this.x, this.y] = this.globalIndex;
                }
                else
                {
                    currentDir = (-currentDir.Item2, currentDir.Item1);
                    g.TabBoxes[this.x, this.y] = -1;
                }


                this.x = (this.x + currentDir.Item1 + g.nX) % (g.nX);
                this.y = (this.y + currentDir.Item2 + g.nY) % (g.nY);

            }
            catch { Console.WriteLine("Error"); }

            

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