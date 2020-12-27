using Minecraft_Building_Generator.Command_Generator;
using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Structures
{
    public class GenericBuilding : abstract_Building, IBuilding
    {
        //inherited variables
        //protected int NnumberOfFloors { get; }
        //protected int MaxHeight { get; }
        //protected int MaxWidth { get; set; } = 13;
        //protected int SpaceBetweenFloors { get; set; } = 4;

        string buildingType;
        string color;
        string blockType;
        

        public GenericBuilding(int height, BuildingClass buildingClass)
        {
            Height = height;
        }

        public GenericBuilding()
        {

        }

        public void Building_OutsideWalls(Coordinate startingPoint)
        {

            
            Coordinate endPoint = new Coordinate(startingPoint.x + Width, startingPoint.y + Height, startingPoint.z + Width);

            //adds hollow command
            Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y+Shared_Constants.FLAT_WORLD_STARTING_Y} {startingPoint.z} {endPoint.x} {endPoint.y} {endPoint.z} glass 1 hollow");

            //throw new NotImplementedException();
        }

        public void Building_Floor(Coordinate startingPoint)
        {
            NumberOfFloors = Height / 4; //adds an additional floor onto the building height...may need to reconsider this
            for (int i = 0; i < NumberOfFloors; i++)
            {

                Coordinate endPoint = new Coordinate(startingPoint.x + Width, startingPoint.y, startingPoint.z + Width );
                startingPoint.y += 4;
                endPoint.y += 4;
                Generate_Commands.Add_Command($"fill {startingPoint.x} {startingPoint.y} {startingPoint.z} {endPoint.x} {endPoint.y} {endPoint.z} stone");
                
            }


        }

        public void Building_Lighting()
        {
            throw new NotImplementedException();
        }

        public void Building_Door(string direction)
        {
            throw new NotImplementedException();
        }

        public void Building_Ladder()
        {
            throw new NotImplementedException();
        }

        public void Building_Windows()
        {
            throw new NotImplementedException();
        }

        public void Building_Rooftop(Coordinate startPoint)
        {
            //builds a pyramid top
            //need to create properties definitions for various building structure types, frames, architecture
            Coordinate endPoint = new Coordinate(startPoint.x + Width, Height, startPoint.z + Width);
            for(int i = 0; i < Width/2; i++)
            {
                Generate_Commands.Add_Command($"fill {startPoint.x+i} {Height+i} {startPoint.z+i} {endPoint.x-i} {Height+i} {endPoint.z-i} concrete 9");
            }

            //throw new NotImplementedException();
        }
    }
}
