using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.UI
{
    public class UI_Grid_Planning_Square
    {
        public Rectangle rectangle { get; set; }
        public bool Selected { get; set; }
        public GridSquare_Zoning zone { get; set; }

        public int clicks;

        public UI_Grid_Planning_Square(Rectangle rect)
        {
            rectangle = rect;
        }


    }
}
