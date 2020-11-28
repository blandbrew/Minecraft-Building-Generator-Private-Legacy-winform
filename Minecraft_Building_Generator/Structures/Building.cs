using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Structures
{
    public abstract class Building
    {
        Coordinate startCoordinate; //starting coordinate in a 13x13 grid

        //Building Description
        public int numberOfFloors { get; set; }
        public int maxHeight { get; set; }
        public int maxWidth { get; set; }
        public int spaceBetweenFloors { get; set; }




        //Subterranian Features
        //bool isUnderground;
        //int maxDepth;

        //BuildingProperties
        //block type
        //block color
        //door
        //windows
        //roof





    }
}
