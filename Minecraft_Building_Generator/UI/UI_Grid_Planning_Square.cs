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
        public (int, int) ParentContainerCoordinate { get; private set; }
        public (int, int) SquareCoordinate { get; private set; }

        public Rectangle rectangle { get; set; }
        public bool Selected { get; set; }
        public GridSquare_Zoning zone { get; set; }

        public List<UI_Grid_Planning_Square> AdjacentSquares { get; set; }
        
        public int clicks;

        public UI_Grid_Planning_Square(Rectangle rect, (int, int) ContainerCoord, (int, int) SquareCoord)
        {
            rectangle = rect;
            ParentContainerCoordinate = ContainerCoord;
            SquareCoordinate = SquareCoord;
            AdjacentSquares = new List<UI_Grid_Planning_Square>();
            
        }


    }
}
