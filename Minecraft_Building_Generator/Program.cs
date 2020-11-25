using Minecraft_Building_Generator.Command_Generator;
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

            //Starting coordinates:  143,63,-17
            GridMap aMap = new GridMap(143, 90, -17, 4);

            aMap.GenerateGrids();

            Generate_Commands gc = new Generate_Commands();

            gc.ShortTest(aMap.PrimaryGridMap);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainform());

            
        }
    }
}
