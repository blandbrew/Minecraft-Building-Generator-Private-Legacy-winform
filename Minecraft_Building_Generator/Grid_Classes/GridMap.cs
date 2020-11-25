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

            Generate_Adjacent_Containers(this.PrimaryGridMap);

            Generate_Adjacent_Grid_Squares(this.PrimaryGridMap);

            int aaa = 0;

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
                        _tempX = aGridContainer.startCoordinate.x + Shared_Constants.GRID_CONTAINER_SIZE; //adds one on to mark the start point of next grid   

                }

                    _tempX = PrimaryGridMap[i, 0].startCoordinate.x; //Resets the X coord so process can iterate across again. (like a typewriter)
                    _tempZ += Shared_Constants.GRID_CONTAINER_SIZE; //adds 1 to mark the start point of next container

                }

                this.PrimaryGridMap = PrimaryGridMap;

            //} catch(Exception err)
            //{
            //    MessageBox.Show(err.Message, "Grid Map Generator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            //}




        }



        private void Generate_Grid_Squares(Grid_Container[,] PrimaryGridMap)
        {

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

                            _tempX = aSquare.startCoordinate.x + Shared_Constants.GRID_SQUARE_SIZE;

                        }

                        _tempX = aGridSquareMap[m, 0].startCoordinate.x; //Resets the X coord so process can iterate across again. (like a typewriter)
                        _tempZ += Shared_Constants.GRID_SQUARE_SIZE; //adds 1 to mark the start point of next container

                    }

                    //Associates the new GridsquareMap to the container
                    aContainer.gridSquareMap = aGridSquareMap;
                }
            }
        }


        public void Generate_Adjacent_Containers(Grid_Container[,] PrimaryGridMap)
        {
            
            for (int i = 0; i < number_of_Grid_Containers / 2; i++)
            {
                for (int k = 0; k < number_of_Grid_Containers / 2; k++)
                {
                    Grid_Container aContainer = PrimaryGridMap[i, k];


                    //This section is to test for adjacency and then associate the adjacent unit.
                    //Minecraft only has to test 4 directions since we are not considering diagnal adjacency
                    try
                    {

                        //before
                        if (k - 1 >= 0)
                        {
                            aContainer.Add_Adjacent_Container(PrimaryGridMap[i, k - 1]);
                        }
                        //next
                        if (k + 1 < number_of_Grid_Containers / 2)
                        {
                            aContainer.Add_Adjacent_Container(PrimaryGridMap[i, k + 1]);
                        }
                        //above
                        if ((i + 1) > (number_of_Grid_Containers / 2))
                        {
                            aContainer.Add_Adjacent_Container(PrimaryGridMap[i + 1, k]);
                        }
                        //below
                        if ((i - 1) >= 0)
                        {
                            aContainer.Add_Adjacent_Container(PrimaryGridMap[i - 1, k]);
                        }

                    }
                    catch (IndexOutOfRangeException err)
                    {
                        Console.WriteLine(err);
                    }
                }
            }

        }

        public void Generate_Adjacent_Grid_Squares(Grid_Container[,] PrimaryGridMap)
        {

            for (int i = 0; i < number_of_Grid_Containers / 2; i++)
            {
                for (int k = 0; k < number_of_Grid_Containers / 2; k++)
                {
                    Grid_Container aContainer = PrimaryGridMap[i, k];
                    Grid_Square[,] aGridSquareMap = aContainer.gridSquareMap;

                    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                    {
                        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                        {

                            Grid_Square aGridSquare = aGridSquareMap[m, n];
                            try
                            {
                                //before
                                if (n - 1 >= 0)
                                {
                                    aGridSquare.Add_Adjacent_Square(aGridSquareMap[m, n - 1]);
                                }
                                //next
                                if (n + 1 < Shared_Constants.GRID_SQUARE_SIZE)
                                {
                                    aGridSquare.Add_Adjacent_Square(aGridSquareMap[i, n + 1]);
                                }
                                //above
                                if ((m + 1) > (Shared_Constants.GRID_SQUARE_SIZE))
                                {
                                    aGridSquare.Add_Adjacent_Square(aGridSquareMap[i + 1, n]);
                                }
                                //below
                                if ((m - 1) >= 0)
                                {
                                    aGridSquare.Add_Adjacent_Square(aGridSquareMap[i - 1, n]);
                                }

                            }
                            catch (IndexOutOfRangeException err)
                            {
                                Console.WriteLine(err);
                            }

                        }

                    }

                }
            }
        }


        
    }
}
