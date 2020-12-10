using Minecraft_Building_Generator.Command_Generator;
using Minecraft_Building_Generator.Grid_Classes;
using Minecraft_Building_Generator.Structures;
using Minecraft_Building_Generator.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Building_Generator
{
    public partial class mainform : Form
    {
        GridMap aMap { get; set; }
        //List<UI_Grid_Planning_Rectangle> gridPlanner { get; set; }
        List<UI_Grid_Planning_Rectangle> gridsqarePlanner { get; set; }
        Graphics gridcontainer_planning_graphic { get; set; }
        Graphics gridsquare_planning_graphic { get; set; }

        UI_GridPanel gridcontainerPanel { get; set; }
        UI_GridPanel gridsquarePanel { get; set; }
        public mainform()
        {

            InitializeComponent();
            Initialize_CityGenerator_Form();
            
            //Size = new Size(500, 500);
        }

        private void Initialize_CityGenerator_Form()
        {
            /*Starting coordinates default*/
            textbox_startcoordinate_x.Text = "0";
            textbox_startcoordinate_y.Text = "0";
            textbox_startcoordinate_z.Text = "0";

            /*Set Default size*/
            comboBox_how_large.SelectedIndex = 0;

            //Creates wordwrap for description label
            label_behaviorpack_info.MaximumSize = new Size(500, 0);
            label_behaviorpack_info.AutoSize = true;

            /*Initialize the windows form*/
            textBox_tab_minecraftversion_1.Text = "1";
            textBox_tab_minecraftversion_2.Text = "15";
            textBox_tab_minecraftversion_3.Text = "0";

            /*UUID*/
            textBox_tab_UUID.Text = "abe07dbe - 3461 - 11eb - adc1 - 0242ac120002";

            /*Description*/
            textBox_tab_behaviorpack_description.Text = "A customized city generated";

            /*Version*/
            textBox_behaviorpack_version.Text = "1.0";

            //gridPlanner = new List<UI_Grid_Planning_Rectangle>();


            gridcontainerPanel = new UI_GridPanel(panel_grid_planning);
            gridsquarePanel = new UI_GridPanel(panel_grid_square_planning);
           
        }


        private void comboBox_how_large_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox_how_large.SelectedItem.ToString();
            int selectedSize = int.Parse(selected);
            int sizeOfBox = 169 * (int)(Math.Sqrt(selectedSize));
            int TotalSize = sizeOfBox * sizeOfBox;

            dynamic_label_generated_size.Text = $"{sizeOfBox} x {sizeOfBox} = {TotalSize} blocks^2";

            aMap = new GridMap(
                int.Parse(textbox_startcoordinate_x.Text),
                int.Parse(textbox_startcoordinate_y.Text),
                int.Parse(textbox_startcoordinate_z.Text),
                selectedSize);

            aMap.GenerateGrids();

            panel_grid_planning.Refresh();
            panel_grid_square_planning.Invalidate();


        }


        /**
         * Button handling methods
         */
        private void button_generate_Click(object sender, EventArgs e)
        {
            label_export_complete.Text = "";
            label_export_complete.Refresh();

            Generate_Commands gc = new Generate_Commands();
            Build_Manager bm = new Build_Manager(aMap.PrimaryGridMap);
            bm.Process_Containers();
            string status = gc.ExportCommandstoFiles(aMap.PrimaryGridMap);

            label_export_complete.Text = status;
        }




        
        /**
         * Panel Paint Methods
         */
        private void panel_grid_planning_Paint(object sender, PaintEventArgs e)
        {
            string selected = comboBox_how_large.SelectedItem.ToString();
            int selectedSize = int.Parse(selected);
            gridcontainerPanel.DrawGrid((int)Math.Sqrt(selectedSize), gridcontainerPanel.gridPanel.CreateGraphics());
            
        }
      
        private void panel_grid_square_planning_Paint(object sender, PaintEventArgs e)
        {
            gridsquarePanel.DrawGrid(Shared_Constants.GRID_SQUARE_SIZE, gridsquarePanel.gridPanel.CreateGraphics());
        }


        /**
         * Mouse Click Handling Methods
         */
        private void panel_grid_planning_MouseClick(Object sender, MouseEventArgs e)
        {
            gridcontainerPanel.UI_Grid_MouseClickEvents(sender, e);
        }


        /// <summary>
        /// Draws grid squares based on grid container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void panel_grid_square_planning_Paint(object sender, PaintEventArgs e)
        private void Draw_Grid_Square_Planner()
        {
            SolidBrush aBrush = new SolidBrush(Color.White);
            Pen p = new Pen(Color.Black);
            //Grid_production
            int separatorValue = 17;
            int x = 10;
            int y = 10;
            int maxX = 1;
            int maxY = 1;

            for (int i = 0; i < Shared_Constants.GRID_SQUARE_SIZE; i++)
            {
                gridsquare_planning_graphic.FillRectangle(aBrush, x, y, 15, 15);

                for (int j = 0; j < Shared_Constants.GRID_SQUARE_SIZE; j++)
                {

                    Rectangle _rect = new Rectangle(x, y, 15, 15);
                    gridsqarePlanner.Add(new UI_Grid_Planning_Rectangle( _rect));
                    gridsquare_planning_graphic.FillRectangle(aBrush, _rect);

                    x += separatorValue;
                }
                maxX = x;
                maxY = y + separatorValue + 10;
                x = 10;
                y += separatorValue;
            }

            gridsquare_planning_graphic.DrawLine(p, 1, maxY, maxX, maxY); //Draws horizontal graph line
            gridsquare_planning_graphic.DrawLine(p, 1, 1, 1, maxY); //draws vertical graph line
        }


        private void panel_grid_square_planning_MouseClick(Object sender, MouseEventArgs e)
        {
            gridsquarePanel.UI_Grid_Square_MouseClickEvents(sender, e, gridcontainerPanel.selectedUIRectangle);

            //Console.WriteLine("Mouse Clicked");
            //foreach (UI_Grid_Planning_Rectangle rectangle in gridsqarePlanner)
            //{
            //    if (rectangle.rect.Contains(e.Location) && rectangle.selected == false)
            //    {
            //        SolidBrush sb = new SolidBrush(Color.Red);
            //        gridsquare_planning_graphic.FillRectangle(sb, rectangle.rect);
            //        //Draw_Grid_Square_Planner();
            //        rectangle.selected = true;
            //    }
            //    else if (rectangle.rect.Contains(e.Location) && rectangle.selected == true)
            //    {
            //        SolidBrush sb = new SolidBrush(Color.White);
            //        gridcontainer_planning_graphic.FillRectangle(sb, rectangle.rect);
            //        rectangle.selected = false;
            //        //gridsquare_planning_graphic.Clear(BackColor);
            //    }

            //}
        }
    }
}
