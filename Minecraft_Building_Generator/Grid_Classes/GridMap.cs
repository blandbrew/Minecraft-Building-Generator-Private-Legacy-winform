using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Minecraft_Building_Generator
{
    public class GridMap
    {


        public Coordinate startCoordinate;
        public int gridSize; //size of the grid in 169x169 block chunks


        GridMap[,] transformation_plot;

        public GridMap(int startX, int startY, int startZ, int gridSize)
        {


        }



        //creates a grid map able to hold equal squares of 13x13
        transformation_plot = new GridMap[13, 13];

            //EACH Gridmap chunk needs to store a reference to XYZ for start corner.
            //The individual blocks in the chunk can then be caluclated because the size of the chunk is 13.
            transformation_plot[0, 0] = new GridMap(Shared_Constants.DEMO_STARTING_X, Shared_Constants.DEMO_STARTING_Y, Shared_Constants.DEMO_STARTING_Z, Shared_Constants.GRID_SIZE);

        int _tempX;
        int _tempY;
        int _tempZ;

        GridMap initialize_grid = new GridMap(Shared_Constants.DEMO_STARTING_X, Shared_Constants.DEMO_STARTING_Y, Shared_Constants.DEMO_STARTING_Z, Shared_Constants.GRID_SIZE);

        _tempX = initialize_grid.startX;
            _tempY = initialize_grid.startY;
            _tempZ = initialize_grid.startZ;

            //generate the grid squares into 169  13x13 grid squares
            for (int i = 0; i< 13; i++)
            {
                for (int k = 0; k< 13; k++)
                {
                    transformation_plot[i, k] = new GridMap(
                        _tempX,
                        _tempY,
                        _tempZ,
                        Shared_Constants.GRID_SIZE);

        //add 13 on to the next grid
        _tempX += 14;
                    

                }
    _tempX = initialize_grid.startX;
                _tempZ += 14;
            }
    }
}
