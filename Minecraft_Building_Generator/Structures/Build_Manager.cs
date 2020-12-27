/**
  * The build manager will be responsible for handling the buliding 
  */

using Minecraft_Building_Generator.Command_Generator;
using Minecraft_Building_Generator.Grid_Classes;
using Minecraft_Building_Generator.Structures.Infrustructure;
using Minecraft_Building_Generator.Structures.Scenary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Structures
{
    public class Build_Manager
    {

        public int DensityFactor { get; set; } //How dense shall the generated city be?

        private Grid_Container[,] FullGridMap { get; set; }
        private int TotalNumberContainers;

        


        public Build_Manager(Grid_Container[,] map)
        {
            FullGridMap = map;
        }


        //Loops through the grid container/squares and runs build commands
        //This is where types of buildings will need to be identified and 
        public void Process_Containers()
        {
            Random rand = new Random();
            //loop through containers
            for (int i = 0; i < Math.Sqrt(GridMap.number_of_Grid_Containers); i++)
            {
                for (int j = 0; j < Math.Sqrt(GridMap.number_of_Grid_Containers); j++)
                {
                    Grid_Container aContainer = FullGridMap[i, j];
                    Grid_Square[,] squareMap = aContainer.gridSquareMap;

                    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                    {
                        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                        {
                            Grid_Square aSquare = squareMap[m, n];

                            switch(aSquare.zone)
                            {
                                case GridSquare_Zoning.Building:
                                    int randomHeight = rand.Next(20, 40);
                                    while (randomHeight % 4 != 0)//ensures that every building has a rooftop
                                    {
                                        randomHeight = rand.Next(20, 40);
                                    }

                                    GenericBuilding gb = new GenericBuilding(randomHeight, BuildingClass.Commercial);

                                    gb.Building_OutsideWalls(aSquare.startCoordinate);
                                    gb.Building_Floor(aSquare.startCoordinate);
                                    gb.Building_Rooftop(aSquare.startCoordinate);

                                    break;
                                case GridSquare_Zoning.Infrustructure:
                                    Roads road = new Roads();
                                    List<Grid_Square> squares = aSquare.GetAll_Adjacent_Squares();
                                    foreach(Grid_Square _square in squares)
                                    {
                                        if(_square.zone == GridSquare_Zoning.Infrustructure)
                                        {
                                            //If X is greater or less than, direction is North South
                                            if(_square.SquareArrayCoordinate.Item1 > aSquare.SquareArrayCoordinate.Item1 ||
                                               _square.SquareArrayCoordinate.Item1 < aSquare.SquareArrayCoordinate.Item1)
                                            {
                                                road.Build_Road(aSquare.startCoordinate, Direction.South);
                                            }
                                            else if(_square.SquareArrayCoordinate.Item2 > aSquare.SquareArrayCoordinate.Item2 ||
                                                    _square.SquareArrayCoordinate.Item2 < aSquare.SquareArrayCoordinate.Item2)
                                            {
                                                //If Y is greater or less than, direction is East west
                                                road.Build_Road(aSquare.startCoordinate, Direction.East);
                                            }
                                        }
                                    }
                                    
                                    break;

                                case GridSquare_Zoning.Scenery:
                                    Scenery grass = new Scenery();
                                    grass.Build_Scenery(aSquare.startCoordinate);
                                    break;

                                case GridSquare_Zoning.Water:

                                    break;
                            }



                        }
                    }
                }
            }
        }



    }
}
