﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator
{

    //public enum gridsquare_legend { Initialized, Selected, Infrustructure, Building, Scenery, water };
    public enum GridSquare_Zoning { Initialized, Selected, Building, Infrustructure, Scenery, Water, None }
    public enum BuildingClass { Residential, Commercial, Industrial, Utility, Service, None }
    public enum InfrustructureClass { Road, Rail, Subway, bridge, None }
    public enum SceneryClass { Park, Playground, Garden, Other, None }
    public enum WaterClass { pond, lake, coast, waterfall}
    public enum BuildingMaterial { Glass, Wooden, Rock, Concrete, Jewel, Other, None }

    public enum Direction { North, East, South, West }



    public static class Shared_Constants
    {
        
        public const int DEMO_STARTING_X = 143;
        public const int DEMO_STARTING_Y = 75;
        public const int DEMO_STARTING_Z = -17;


        public const int GRID_CONTAINER_SIZE = 169;
        public const int GRID_SQUARE_SIZE = 13;
        
        public const int MAX_FILL = 32768;
        public const int GRID_CONTAINER_CENTER = 85;
        public const int GRID_SQUARE_CENTER = 6;

        public const int UI_GRID_RECTANGLE_SIZE = 13;

        public const int MAX_NUMBER_OF_COMMANDS = 9950;

        public const int FLAT_WORLD_STARTING_Y = 3;


    }
}
