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
        public Rectangle rect {get; set;}
        public bool selected { get; set; } = false;
        public GridSquare_Zoning zone { get; set; }

        public int i { get; set; }
        public int j { get; set; }

        /// <summary>
        /// Used to store the rectangle
        /// </summary>
        /// <param name="rectangle"></param>
        public UI_Grid_Planning_Rectangle(Rectangle rectangle)
        {
            rect = rectangle;

        }
        public UI_Grid_Planning_Rectangle(Rectangle rectangle, GridSquare_Zoning setZone)
        {
            rect = rectangle;
            zone = setZone;
        }



    }
}
