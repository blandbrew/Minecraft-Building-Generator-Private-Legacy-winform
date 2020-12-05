using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator
{

    public enum BuildingClass { Residential, Commercial, Industrial, Other, None }
    public enum BuildingMaterial { Glass, Wooden, Rock, Concrete, Jewel, Other, None }

    

    public static class Shared_Constants
    {
        
        public const int DEMO_STARTING_X = 143;
        public const int DEMO_STARTING_Y = 75;
        public const int DEMO_STARTING_Z = -17;


        public const int GRID_CONTAINER_SIZE = 169;
        public const int GRID_SQUARE_SIZE = 13;
        public const int MAX_FILL = 32768;
        public const int GRID_CONTAINER_CENTER = 85;
        public const int GRID_SQUARE_CENTER = 7;

        public const int MAX_NUMBER_OF_COMMANDS = 9950;
        
    }
}
