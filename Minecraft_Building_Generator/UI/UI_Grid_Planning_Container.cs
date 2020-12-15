using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.UI
{
    public class UI_Grid_Planning_Container
    {
        public Rectangle rect { get; set; }

        public bool selected { get; set; } = false;
        public GridSquare_Zoning zone { get; set; }

        public UI_Grid_Planning_Square[,] UI_Grid_Planning_Squares { get; set; }
        public Point UI_Grid_Planning_Square_MaxX { get; set; }
        public Point UI_Grid_Planning_Square_MaxY { get; set; }


        /// <summary>
        /// Used to store the rectangle
        /// </summary>
        /// <param name="rectangle"></param>
        public UI_Grid_Planning_Container(Rectangle rectangle)
        {
            rect = rectangle;
            
        }
        //public UI_Grid_Planning_Rectangle(Rectangle rectangle, GridSquare_Zoning setZone)
        //{
        //    rect = rectangle;
        //    zone = setZone;
        //}



    }
}
