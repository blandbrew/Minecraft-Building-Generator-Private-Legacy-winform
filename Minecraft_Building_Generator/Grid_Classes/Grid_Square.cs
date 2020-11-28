        //This class defines a 13x13 grid square.
        //each can have specific properties such ash
        //marking adjacent grids, offsets for roads, subterannian features, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Grid_Classes
{
    public class Grid_Square : Grid_Properties, IGrid_Square
    {
       // public Coordinate startCoordinate;
        //public Coordinate endCoordinate;
        public Coordinate centerblock;

        public int padding;
        public int offset;
        public int margin;
        public bool isValid;

        public List<Grid_Square> adjacent_Squares;

        public Grid_Square(Coordinate startPoint)
        {
            startCoordinate = startPoint;
            adjacent_Squares = new List<Grid_Square>();
        }

        public void Add_Adjacent_Square(Grid_Square adjacentSquare)
        {
            this.adjacent_Squares.Add(adjacentSquare);
            
        }

        public List<Grid_Square> GetAll_Adjacent_Squares()
        {
            return adjacent_Squares;
            throw new NotImplementedException();
        }
    }
}
