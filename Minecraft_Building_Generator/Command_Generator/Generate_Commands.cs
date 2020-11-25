using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Command_Generator
{
    public class Generate_Commands
    {

        //List of commands to be exported to the mcfunction file
        static List<string> generatedFunctionLines = new List<string>();



        /// <summary>
        /// Adds a command to the list
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static int Add_Command(string command)
        {
            generatedFunctionLines.Add(command);

            return generatedFunctionLines.Count;
        }





        private void ExportFunctionLines()
        {
            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "cityGenerator.mcfunction")))
            {
                foreach (string line in generatedFunctionLines)
                    outputFile.WriteLine(line);
            }
        }

        public void ShortTest(Grid_Container[,] map)
        {
            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "cityGenerator.mcfunction")))
            {

                for (int i = 0; i < map.Length / 2; i++)
                {
                    for (int j = 0; j < map.Length / 2; j++)
                    {

                        Grid_Container aContainer = map[i, j];

                        outputFile.WriteLine(
                            "fill " + aContainer.startCoordinate.x + 
                            " " + aContainer.startCoordinate.y + 
                            " " + aContainer.startCoordinate.z + 
                            " " + aContainer.endCoordinate.x + 
                            " " + aContainer.endCoordinate.y + 
                            " " + aContainer.endCoordinate.z + 
                            " stone");
                    }
                }
            }
        }


        /**
         * This is a functional test to demonstrate that the squares are all individually generated procedurally and they can such be recalled.
         */
        public void ExportTESTING(Grid_Container[,] map)
        {
            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "cityGenerator.mcfunction")))
            {
                outputFile.WriteLine("teleport @s 143 115 -17");
                for (int i = 0; i < map.Length/2; i++)
                {
                    for (int j = 0; j < map.Length/2; j++)
                    {
                        Grid_Container aContainer = map[i, j];

                        Grid_Square[,] squareMap = aContainer.gridSquareMap;

                        for (int k = 0; k < 13; k++)
                        {
                            for (int m = 0; m < 13; m++)
                            {

                                int _tempX = squareMap[k, m].startCoordinate.x;
                                int _tempY = squareMap[k, m].startCoordinate.y+1;
                                int _tempZ = squareMap[k, m].startCoordinate.z;

                                int _tempXPrime = _tempX + 13;

                                int _tempZPrime = _tempZ + 13;

                                outputFile.WriteLine("fill " + _tempX + " " + _tempY + " " + _tempZ + " " + _tempXPrime + " " + _tempY + " " + _tempZPrime + " stone");


                            }
                        }
                    }
                }
            }
        }
    }
}
