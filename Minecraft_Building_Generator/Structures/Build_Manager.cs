using Minecraft_Building_Generator.Command_Generator;
using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Structures
{
    public class Build_Manager
    {
        /**
         * The build manager will be responsible for handling the buliding 
         */

        private Grid_Container[,] FullGridMap { get; set; }
        private int TotalNumberContainers;

        public Build_Manager(Grid_Container[,] map)
        {
            FullGridMap = map;
        }


        //Loops through the grid container/squares and runs build commands
        public void Process_Containers()
        {
            //loop through containers
            for (int i = 0; i < GridMap.number_of_Grid_Containers / 2; i++)
            {
                for (int j = 0; j < GridMap.number_of_Grid_Containers / 2; j++)
                {
                    Grid_Container aContainer = FullGridMap[i, j];
                    Grid_Square[,] squareMap = aContainer.gridSquareMap;

                    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                    {
                        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                        {
                            Grid_Square aSquare = squareMap[m, n];

                            GenericBuilding gb = new GenericBuilding(150, BuildingClass.Commercial);

                            gb.Building_OutsideWalls(aSquare.startCoordinate);
                            gb.Building_Floor(aSquare.startCoordinate);

                        }
                    }
                }
            }
        }



    }
}
