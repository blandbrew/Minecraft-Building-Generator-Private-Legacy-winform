using Minecraft_Building_Generator.Command_Generator;
using Minecraft_Building_Generator.Constants;
using Minecraft_Building_Generator.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Building_Generator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Guid id = Guid.NewGuid();
            //Console.WriteLine(id.ToString());

            //Blocks b = new Blocks();
            //b.Populate_BlockList();
            //Starting coordinates:  143,63,-17
            //GridMap aMap = new GridMap(0, 60, 0, 4);

            //aMap.GenerateGrids();

            //Generate_Commands gc = new Generate_Commands();
            //Build_Manager bm = new Build_Manager(aMap.PrimaryGridMap);
            //bm.Process_Containers();
            //gc.ShortTest(aMap.PrimaryGridMap);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainform());

            
        }
    }
}
