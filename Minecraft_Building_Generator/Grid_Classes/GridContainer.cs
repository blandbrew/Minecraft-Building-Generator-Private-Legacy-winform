/**Grid Container Class
 * 
 * Description:
 * Grid container class is the container of smaller grid squares. 
 * Each grid container is 169x169 blocks
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Grid_Classes
{
    public class Grid_Container : IGrid_Container
    {
        public Coordinate startCoordinate;
        public Coordinate endCoordinate;
        public Coordinate centerblock;

        public int padding;
        public int offset;
        public int margin;

        public Grid_Square[,] gridSquareMap;
        public List<Grid_Container> adjacent_Container_List;

        public Grid_Container(Coordinate startPoint)
        {
            startCoordinate = startPoint;
            adjacent_Container_List = new List<Grid_Container>();
        }

        public void Add_Adjacent_Container(Grid_Container adjacentContainer)
        {
            adjacent_Container_List.Add(adjacentContainer);
        }

        public List<Grid_Container> GetAll_Adjacent_Containers()
        {
            return adjacent_Container_List;
        }

    }
}
