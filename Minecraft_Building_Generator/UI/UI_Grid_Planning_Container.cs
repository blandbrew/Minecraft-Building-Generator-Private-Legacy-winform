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
        public (int, int) ContainerCoordinate { get; private set; }

        public bool selected { get; set; } = false;
        public bool previously_selected { get; set; } = false;
        public GridSquare_Zoning zone { get; set; }

        public UI_Grid_Planning_Square[,] UI_Grid_Planning_Squares { get; set; }

        public List<UI_Grid_Planning_Container> AdjacentContainers { get; set; }

        //public Adjacency_Compass[,] Adjacnecy_Grid

        /// <summary>
        /// Used to store the rectangle
        /// </summary>
        /// <param name="rectangle"></param>
        public UI_Grid_Planning_Container(Rectangle rectangle, (int, int) containerCoord)
        {
            rect = rectangle;
            ContainerCoordinate = containerCoord;
        }

        private void SetAdjacency()
        {

        }



    }
}
