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
    }
}
