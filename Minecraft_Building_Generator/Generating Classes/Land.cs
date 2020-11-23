/*Minecraft building generator
 * Land Class
 * 11/21/2020
 * 
 * Description: The Land Class will be responsible for creating functions and commands to form the land
 */



using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Minecraft_Building_Generator
{

    public class Land
    {

        //2D array to stor grid map classes
        GridMap[,] transformation_plot;

        public Coordinate startCoordinate;
        public int gridSize; //size of the grid in 169x169 block chunks


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
        /// <param name="gridSize"></param>
        /// 
        public Land(int startX, int startY, int startZ, int gridSize)
        {

           
        }

        //USED IN CASE OF large volumes of land need to be modified
        //public Land(int startX, int startY, int startZ, int gridSize, bool terraforming)
        //{
        //    //terraform();
        //}

        //public void Terraform()
        //{

        //}

       

        //public void Land_Divide()
        //{
        //    //string a = Minecraft_Building_Generator.

        //    //creates a grid map able to hold equal squares of 13x13
        //    //transformation_plot = new GridMap[13, 13];

        //    //EACH Gridmap chunk needs to store a reference to XYZ for start corner.
        //    //The individual blocks in the chunk can then be caluclated because the size of the chunk is 13.
        //    transformation_plot[0, 0] = new GridMap(Shared_Constants.DEMO_STARTING_X, Shared_Constants.DEMO_STARTING_Y, Shared_Constants.DEMO_STARTING_Z, Shared_Constants.GRID_SIZE);

        //    int _tempX;
        //    int _tempY;
        //    int _tempZ;

        //    GridMap initialize_grid = new GridMap(Shared_Constants.DEMO_STARTING_X, Shared_Constants.DEMO_STARTING_Y, Shared_Constants.DEMO_STARTING_Z, Shared_Constants.GRID_SIZE);

        //    _tempX = initialize_grid.startX;
        //    _tempY = initialize_grid.startY;
        //    _tempZ = initialize_grid.startZ;

        //    //generate the grid squares into 169  13x13 grid squares
        //    for (int i = 0; i < 13; i++)
        //    {
        //        for (int k = 0; k < 13; k++)
        //        {
        //            transformation_plot[i, k] = new GridMap(
        //                _tempX,
        //                _tempY,
        //                _tempZ, 
        //                Shared_Constants.GRID_SIZE);

        //            //add 13 on to the next grid
        //            _tempX += 14;
                    

        //        }
        //        _tempX = initialize_grid.startX;
        //        _tempZ += 14;
        //    }


        //    WriteCoordsToFile(transformation_plot);
        //}


        //public void WriteCoordsToFile(GridMap[,] plot)
        //{
        //    string docPath =
        //  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    // Write the string array to a new file named "WriteLines.txt".
        //    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "demo.mcfunction")))
        //    {

        //        for (int i = 0; i < 13; i++)
        //        {
        //            for (int k = 0; k < 13; k++)
        //            {

        //                int _tempX = plot[i, k].startX;
        //                int _tempY = plot[i, k].startY;
        //                int _tempZ = plot[i, k].startZ;

        //                int _tempXPrime = _tempX + 13;
                       
        //                int _tempZPrime = _tempZ + 13;

        //                outputFile.WriteLine("fill " + _tempX + " " + _tempY + " " + _tempZ + " " + _tempXPrime + " " + _tempY + " " + _tempZPrime + " stone");


        //            }


        //        }



        //    }



       // }
    }
}
