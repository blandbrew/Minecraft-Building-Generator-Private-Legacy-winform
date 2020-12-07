using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.UI
{
    public class UI_Grid_Planning_Rectangle
    {
        public int gridLocation_I { get; set; } //location of the grid using 2d array [i, j]
        public int gridLocation_J { get; set; } //location of the grid using 2d array [i, j]
        public int gridLocation_K { get; set; } //location of the grid using 2d array [k, l]
        public int gridLocation_L { get; set; } //location of the grid using 2d array [k, l]
        public Rectangle rect {get; set;}
        public bool selected_container { get; set; } = false;
        public bool selected_square { get; set; } = false;


        /// <summary>
        /// Used to store the rectangle and corresponding grid container
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="rectangle"></param>
        public UI_Grid_Planning_Rectangle(int i, int j, Rectangle rectangle)
        {
            gridLocation_I = i;
            gridLocation_J = j;
            rect = rectangle;

        }

        /// <summary>
        /// Used to store the rectangle and corresponding grid container and grid square
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="k"></param>
        /// <param name="l"></param>
        /// <param name="rectangle"></param>
        public UI_Grid_Planning_Rectangle(int i, int j, int k, int l, Rectangle rectangle)
        {
            gridLocation_I = i;
            gridLocation_J = j;
            gridLocation_K = k;
            gridLocation_L = l;
            rect = rectangle;

        }

    }
}
