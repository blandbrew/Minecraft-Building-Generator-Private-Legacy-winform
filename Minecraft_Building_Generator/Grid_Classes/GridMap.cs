/*Minecraft building generator
 * Grid Map Class
 * 11/21/2020
 * 
 * Description: at this time this class obtains initial coordinates and then begins dividing up the areas for building.
 * 
 * 
 * Minecrat Math:
 * 
 * Max number of block to fill = 32768
 * max square grid size = 181
 *  181 * 181 = 32761 < 32768
 *
 *  
 * Largest Perfect dividable square = 13 x 13
 * 13 x 13 = 169
 * 169 x 169 = 28561
 *  
 * 13x13 is preferable for building generation
 * 181x181 is best for terraforming
 * 
 * Note: all of the above math is done assuming the Y value is 1, or depth of fill command is 1
 * All measurments are units squared.  filling a deeper area requires volume and is not calculated at this moment (11/21/2020)
 *  
 *  Individual grid squares of 13 also works well because it divides the grid by a centerline, allowing for more complex buildings
 *  Starting coordinates:  143,63,-17


    Direction:  west and East are on X axis  (-x West ; +X East)
                north and south are on Z axis  (+Z south ; -Z north)
*/



using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Minecraft_Building_Generator
{
    public class GridMap
    {


        public Coordinate startCoordinate;
        public Coordinate endCoordinate;
        public int number_of_Grid_Containers; //size of the grid in 169x169 block chunks


        //This 2D array stores all the Grid Containers
        public Grid_Container[,] PrimaryGridMap { get; set; }
        Grid_Square[,] ContainerMap { get; set; }


        /// <summary>
        /// This constructor takes 4 parameters.  The start location from where the functions will run, and then how big will the generator go.
        /// 
        /// Must be Even and (Max is 4).
        /// 
        /// Each grid is 169x169 blocks
        /// 
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="startZ"></param>
        /// <param name="number_of_Grid_Containers"></param>
        /// 
        public GridMap(int startX, int startY, int startZ, int number_of_Grid_Containers)
        {
            startCoordinate = new Coordinate(startX, startY, startZ);

            if (number_of_Grid_Containers == 1 || number_of_Grid_Containers % 2 == 0)
            {
                this.number_of_Grid_Containers = number_of_Grid_Containers;
            }
            else
            {
                this.number_of_Grid_Containers = 1;
            }

        }

        public void GenerateGrids()
        {
            Generate_Grid_Containers(startCoordinate, number_of_Grid_Containers);


            Generate_Grid_Squares(this.PrimaryGridMap);

            int aaaa = 1;
        }


  



        private void Generate_Grid_Containers(Coordinate startPoint, int number_of_Grid_Containers)
        {
            //PrimaryGridMap = new Grid_Container[,];
            if(number_of_Grid_Containers == 1)
            {
            
                PrimaryGridMap = new Grid_Container[0,0];

                Map_out_GridContainer(startPoint, PrimaryGridMap);

            } else if(number_of_Grid_Containers >3 && number_of_Grid_Containers % 2 == 0)
            {
                
                //If the number of grid containers is larger than 1, must be an even number.
                //to make an even grid map, divide the number of containers by 2 then minus 1 to account of array's starting at 0 and instantiate the 2D array.
                /**Example
                 * 
                 * number of containers: 4
                 * (4/2) - 1 = 1
                 * primaryGridMap[1,1] => now there are 4 accessible containers
                 */


                int _container = (number_of_Grid_Containers / 2);
                PrimaryGridMap = new Grid_Container[_container, _container];

                //Sets the primary grid Map
                Map_out_GridContainer(startPoint, PrimaryGridMap);
            }
            else
            {
                //additionall validation check to ensure container is correct size
                MessageBox.Show("The Number of Containers selected was incorrectly set.  Only container sizes equalling 1 or an even number greater than 2 are allowed", "Number of Containers error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// This method maps out the Grid Containers and stores each in a 2D array.
        /// </summary>
        /// <param name="startPoint"></param>
        /// <returns></returns>
        private void Map_out_GridContainer(Coordinate startPoint, Grid_Container[,] PrimaryGridMap)
        {
            
            int _tempX = startPoint.x;
            int _tempY = startPoint.y;
            int _tempZ = startPoint.z;

            //try
            //{
                //i and k start at 0 so -1 is not needed to account for array
                for (int i = 0; i < number_of_Grid_Containers / 2; i++)
                {
                    for (int k = 0; k < number_of_Grid_Containers / 2; k++)
                    {
                        //Coordinate temp_Coordinate = new Coordinate(_tempX, _tempY, _tempZ);


                        Grid_Container aGridContainer = new Grid_Container(new Coordinate(_tempX, _tempY, _tempZ));

                        aGridContainer.endCoordinate = new Coordinate
                            (
                                aGridContainer.startCoordinate.x + Shared_Constants.GRID_CONTAINER_SIZE,
                                startPoint.y,
                                aGridContainer.startCoordinate.z + Shared_Constants.GRID_CONTAINER_SIZE
                            );
                        aGridContainer.centerblock = new Coordinate
                            (
                                aGridContainer.startCoordinate.x + Shared_Constants.GRID_CONTAINER_CENTER,
                                startPoint.y,
                                aGridContainer.startCoordinate.y + Shared_Constants.GRID_CONTAINER_CENTER
                            );


                        PrimaryGridMap[i, k] = aGridContainer;
                        _tempX += aGridContainer.startCoordinate.x + Shared_Constants.GRID_CONTAINER_SIZE + 1; //adds one on to mark the start point of next grid
                   

                }

                    _tempX = PrimaryGridMap[i, 0].startCoordinate.x + 1; //Resets the X coord so process can iterate across again. (like a typewriter)
                    _tempZ += Shared_Constants.GRID_CONTAINER_SIZE + 1; //adds 1 to mark the start point of next container

                }

                this.PrimaryGridMap = PrimaryGridMap;

            //} catch(Exception err)
            //{
            //    MessageBox.Show(err.Message, "Grid Map Generator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            //}




        }



        private void Generate_Grid_Squares(Grid_Container[,] PrimaryGridMap)
        {

            //Coordinate startPoint = PrimaryGridMap[0, 0].startCoordinate;
            //int _tempX = startPoint.x;
            //int _tempY = startPoint.y;
            //int _tempZ = startPoint.z;
       

            for (int i = 0; i < number_of_Grid_Containers / 2; i++)
            {
                for (int k = 0; k < number_of_Grid_Containers / 2; k++)
                {

                    Coordinate startPoint = PrimaryGridMap[i, k].startCoordinate;
                    int _tempX = startPoint.x;
                    int _tempY = startPoint.y;
                    int _tempZ = startPoint.z;


                    Grid_Square[,] aGridSquareMap = new Grid_Square[Shared_Constants.GRID_SQUARE_SIZE, Shared_Constants.GRID_SQUARE_SIZE];
                    Grid_Container aContainer = PrimaryGridMap[i, k];

                    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                    {
                        for(int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                        {
                            Grid_Square aSquare = new Grid_Square(new Coordinate(_tempX, _tempY, _tempZ));

                            aSquare.endCoordinate = new Coordinate
                                (
                                    aSquare.startCoordinate.x + Shared_Constants.GRID_SQUARE_SIZE,
                                    aSquare.startCoordinate.y,
                                    aSquare.startCoordinate.z + Shared_Constants.GRID_SQUARE_SIZE
                                );
                            aSquare.centerblock = new Coordinate
                                (
                                    aSquare.startCoordinate.x + Shared_Constants.GRID_SQUARE_CENTER,
                                    aSquare.startCoordinate.y,
                                    aSquare.startCoordinate.z + Shared_Constants.GRID_SQUARE_CENTER
                                );

                            aGridSquareMap[m, n] = aSquare;

                            _tempX = aSquare.startCoordinate.x + Shared_Constants.GRID_SQUARE_SIZE + 1;

                        }

                        _tempX = aGridSquareMap[m, 0].startCoordinate.x + 1; //Resets the X coord so process can iterate across again. (like a typewriter)
                        _tempZ += Shared_Constants.GRID_SQUARE_SIZE + 1; //adds 1 to mark the start point of next container

                    }

                    //Associates the new GridsquareMap to the container
                    aContainer.gridSquareMap = aGridSquareMap;
                }
            }
        }

        //private void Map_Out_GridSquare(Grid_Container aContainer)
        //{
        //    Grid_Square[,] aGridSquareMap = new Grid_Square[Shared_Constants.GRID_SQUARE_SIZE - 1, Shared_Constants.GRID_SQUARE_SIZE - 1];

        //    Coordinate startPoint = aContainer.startCoordinate;

        //    Grid_Square aSquare = new Grid_Square()


        //}

        public void Grid_Divide()
        {

            //creates a grid map able to hold equal squares of 13x13
            //transformation_plot = new GridMap[13, 13];

            //EACH Gridmap chunk needs to store a reference to XYZ for start corner.
            //The individual blocks in the chunk can then be caluclated because the size of the chunk is 13.
            //transformation_plot[0, 0] = new GridMap(Shared_Constants.DEMO_STARTING_X, Shared_Constants.DEMO_STARTING_Y, Shared_Constants.DEMO_STARTING_Z, Shared_Constants.GRID_SIZE);

            int _tempX;
            int _tempY;
            int _tempZ;

            //GridMap initialize_grid = new GridMap(Shared_Constants.DEMO_STARTING_X, Shared_Constants.DEMO_STARTING_Y, Shared_Constants.DEMO_STARTING_Z, Shared_Constants.GRID_SIZE);

            //_tempX = initialize_grid.startX;
            //_tempY = initialize_grid.startY;
            // _tempZ = initialize_grid.startZ;

            //generate the grid squares into 169  13x13 grid squares
            for (int i = 0; i < 13; i++)
            {
                for (int k = 0; k < 13; k++)
                {
                    //transformation_plot[i, k] = new GridMap(
                    //    _tempX,
                    //    _tempY,
                    //    _tempZ,
                    //    Shared_Constants.GRID_SIZE);

                    //add 13 on to the next grid
                    //_tempX += 14;


                }
                //_tempX = initialize_grid.startX;
                //_tempZ += 14;
            }
        }
    }
}
