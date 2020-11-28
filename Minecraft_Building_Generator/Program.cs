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
            GenericBuilding b = new GenericBuilding();

            //Blocks b = new Blocks();
            //b.Populate_BlockList();
            //Starting coordinates:  143,63,-17
            GridMap aMap = new GridMap(143, 90, -17, 4);

            aMap.GenerateGrids();

            Generate_Commands gc = new Generate_Commands();

            gc.ShortTest(aMap.PrimaryGridMap);

            Block a;
            Blocks.blockList.TryGetValue(8, out a);
            Console.WriteLine(a.name);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainform());

            
        }
    }
}
