using Minecraft_Building_Generator.Command_Generator;
using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Structures.Infrustructure
{
    public class Roads
    {
        /**
         * City Generator roads will consume 1 Grid_Square.
         * 
         */
        Coordinate StartPoint;
        int StreetWidth { get; set; } = 8;
        int SidewalkWidth { get; set; } = 2;

        Coordinate CenterlineStart;
        Coordinate CrosswalkStart;

        Direction roadDirection;
        public Roads()
        {

        }

        public void Build_Road(Coordinate startingPoint, Direction direction)
        {
            if( direction == Direction.North || direction == Direction.South)
            {
                Coordinate endPoint = new Coordinate(startingPoint.x + Shared_Constants.GRID_SQUARE_SIZE, startingPoint.y, startingPoint.z + Shared_Constants.GRID_SQUARE_SIZE);
    
                //fills entire square black
                Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y+Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z} {endPoint.x} {endPoint.y+Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z} concrete 15"); //black concrete

                //draws the center yellow line
                Generate_Commands.Add_Command($"fill {startingPoint.x+6} {startingPoint.y+ Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z} {endPoint.x-7} {endPoint.y+Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z} concrete 4"); //yellow concrete

                //draws the two sidewalks
                Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z} {endPoint.x - 12} {endPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z} concrete 8"); //grey concrete
                Generate_Commands.Add_Command($"fill {startingPoint.x + 11} {startingPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z} {endPoint.x} {endPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z} concrete 8");
            } else if(direction == Direction.West || direction == Direction.East)
            {
                Coordinate endPoint = new Coordinate(startingPoint.x + Shared_Constants.GRID_SQUARE_SIZE, startingPoint.y, startingPoint.z + Shared_Constants.GRID_SQUARE_SIZE);

                //fills entire square black
                Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z} {endPoint.x} {endPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z} concrete 15"); //black concrete

                //draws the center yellow line
                Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z + 6} {endPoint.x} {endPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z-7} concrete 4"); //yellow concrete

                //draws the two sidewalks
                Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z} {endPoint.x} {endPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z - 12} concrete 8"); //grey concrete
                Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z + 11} {endPoint.x} {endPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z} concrete 8");
            }

        }
    }
}
