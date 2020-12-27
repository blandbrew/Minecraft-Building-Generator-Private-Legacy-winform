using Minecraft_Building_Generator.Command_Generator;
using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Structures.Scenary
{
    public class Scenery
    {

        Coordinate StartPoint;


        Coordinate CenterlineStart;
        Coordinate CrosswalkStart;


        public Scenery()
        {

        }

        public void Build_Scenery(Coordinate startingPoint)
        {
            Coordinate endPoint = new Coordinate(startingPoint.x + Shared_Constants.GRID_SQUARE_SIZE, startingPoint.y, startingPoint.z + Shared_Constants.GRID_SQUARE_SIZE);

            Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z} {endPoint.x} {endPoint.y + Shared_Constants.FLAT_WORLD_STARTING_Y} {endPoint.z} concrete 13"); //13 is green concrete
            
        }
    }

}
