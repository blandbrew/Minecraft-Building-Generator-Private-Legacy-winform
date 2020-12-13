//This class defines a 13x13 grid square.
//each can have specific properties such ash
//marking adjacent grids, offsets for roads, subterannian features, etc.

using Minecraft_Building_Generator.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Grid_Classes
{
    public class Grid_Square : Grid_Properties, IGrid_Square
    {
        

        //public GridSquare_Zoning zone { get; set; }
        public UI_Grid_Planning_Container ui_rectangle { get; set; }


        /*Variables*/
        /// <summary>
        /// Grid Squares that are adjacent, maximum number of 4.  Excludes Diagnal Squares
        /// </summary>
        public List<Grid_Square> adjacent_Squares { get; set; }

        /// <summary>
        /// Squares that have been marked for adjacent building.
        /// </summary>
        public List<Grid_Square> Joined_Squares { get; set; }

        


        /*Constructor*/
        public Grid_Square(Coordinate startPoint)
        {
            startCoordinate = startPoint;
            adjacent_Squares = new List<Grid_Square>();
        }



        /*Methods*/
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
