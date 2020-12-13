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
        List<UI_Grid_Planning_Container> gridsqarePlanner { get; set; }
        Graphics gridcontainer_planning_graphic { get; set; }
        Graphics gridsquare_planning_graphic { get; set; }

        UI_GridPanel gridcontainerPanel { get; set; }
        UI_GridPanel gridsquarePanel { get; set; }
        UI_Grid_Planning_Container[,] GridPlanner_Map { get; set; }

        private UI_Grid_Planning_Container previouslySelected;
        public mainform()
        {

            InitializeComponent();
            Initialize_CityGenerator_Form();
            
            //Size = new Size(500, 500);
        }

        private void Initialize_CityGenerator_Form()
        {
            gridcontainerPanel = new UI_GridPanel(panel_grid_planning, panel_grid_planning.CreateGraphics());
            gridsquarePanel = new UI_GridPanel(panel_grid_square_planning, panel_grid_square_planning.CreateGraphics());

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



           
        }


        private void comboBox_how_large_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox_how_large.SelectedItem.ToString();
            int selectedSize = int.Parse(selected);

            int sizeOfBox = 169 * GridSize();
            int TotalSize = sizeOfBox * sizeOfBox;

            dynamic_label_generated_size.Text = $"{sizeOfBox} x {sizeOfBox} = {TotalSize} blocks^2";

            aMap = new GridMap(
                int.Parse(textbox_startcoordinate_x.Text),
                int.Parse(textbox_startcoordinate_y.Text),
                int.Parse(textbox_startcoordinate_z.Text),
                selectedSize);

            aMap.GenerateGrids();

            //reset grids
            if(GridPlanner_Map != null)
                Redraw_Grid_Map(gridcontainerPanel, gridsquarePanel);

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
            Draw_UI_Grid_Containers(GridSize());

        }
      
        private void panel_grid_square_planning_Paint(object sender, PaintEventArgs e)
        {
            //empty because this is dependant on click events
        }


        /// <summary>
        /// Initializes the UI Grid Container section. This is called on every Paint call
        /// </summary>
        /// <param name="sizeOfGrid"></param>
        /// <param name="UI_Grid_Containers"></param>
        private void Draw_UI_Grid_Containers(int sizeOfGrid)
        {


            //Grid_production
            int separatorValue = 17;
            int x = 10;
            int y = 10;
            int maxX = 1;
            int maxY = 1;

            //initialize 2d array of grid planner
            GridPlanner_Map = new UI_Grid_Planning_Container[sizeOfGrid, sizeOfGrid];

            for (int i = 0; i < sizeOfGrid; i++)
            {
                for (int j = 0; j < sizeOfGrid; j++)
                {

                    Rectangle _rect = new Rectangle(x, y, 15, 15);
                    GridPlanner_Map[i, j] = new UI_Grid_Planning_Container(_rect);
                    gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, _rect);

                    x += separatorValue;
                }
                maxX = x;
                maxY = y + separatorValue + 10;
                x = 10;
                y += separatorValue;
            }

            
            gridcontainerPanel.gridPanelGraphics.DrawLine(gridcontainerPanel.gridPanelPen, 1, 0, maxX, 0); //Draws horizontal graph line
            gridcontainerPanel.gridPanelGraphics.DrawLine(gridcontainerPanel.gridPanelPen, 1, 0, 1, maxY); //draws vertical graph line

            Point p1 = new Point(maxX + 5, 0);
            gridcontainerPanel.gridPanelGraphics.DrawString("East", gridcontainerPanel.gridPanelFont, gridcontainerPanel.gridPanelBrush, p1);

            Point p2 = new Point(0, maxY + 5);
            gridcontainerPanel.gridPanelGraphics.DrawString("South", gridcontainerPanel.gridPanelFont, gridcontainerPanel.gridPanelBrush, p2);

            //initializes the first continer to be selected.
            GridPlanner_Map[0, 0] = Set_Select_UI_Grid_Planning_Container(GridPlanner_Map[0, 0]);
        }

        private UI_Grid_Planning_Container Set_Select_UI_Grid_Planning_Container(UI_Grid_Planning_Container selected_container)
        {
            //If true, reset the container.  if False, set to true and mark as selected
            if(previouslySelected == null)
            {
                previouslySelected = selected_container;
            }

            if(selected_container.selected)
            {
                selected_container.selected = false;
                gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, selected_container.rect);
            } else
            {
                previouslySelected.selected = false;
                gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, previouslySelected.rect);

                selected_container.selected = true;
                gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Selected, selected_container.rect);
                previouslySelected = selected_container;
            }

            return selected_container;
        }


        private void Draw_UI_Grid_Squares()
        {

        }



        /**
         * Mouse Click Handling Methods
         */
        private void panel_grid_planning_MouseClick(Object sender, MouseEventArgs e)
        {
            //On click event
            //store the value in the UI panel container
            //draw it on the grid
            //return the container
            //gridcontainerPanel.UI_Grid_MouseClickEvents(sender, e);


            UI_Grid_Planning_Container selected_container = Select_Rectangle_Container(GridSize(),e.Location);

            //need to draw ui grid squares on selection, but also on Initialization!

            //gridsquarePanel.Initialize_UI_Grid(selected_container);
        }

        private void panel_grid_square_planning_MouseClick(Object sender, MouseEventArgs e)
        {
            gridsquarePanel.UI_Grid_Square_MouseClickEvents(sender, e, gridcontainerPanel.selectedUIRectangle);

        }



        private UI_Grid_Planning_Container Select_Rectangle_Container(int SizeOfGrid, Point location)
        {
           
            UI_Grid_Planning_Container rectangle;
            for (int i = 0; i < SizeOfGrid; i++)
            {
                for (int j = 0; j < SizeOfGrid; j++)
                {
                    rectangle = GridPlanner_Map[i, j];

                    if (rectangle.rect.Contains(location))
                    {
                        if (previouslySelected == rectangle)
                        {
                            Console.WriteLine("Match");
                            Set_Select_UI_Grid_Planning_Container(rectangle);
     
                        }
                        else
                        {

                            rectangle = Set_Select_UI_Grid_Planning_Container(rectangle);
                            ////set old selected rectange to false and set it to initialized state
                            //selectedUIRectangle.selected = false;
                            //gridPanelGraphics.FillRectangle(brush_Initialized, selectedUIRectangle.rect);

                            //gridPanelGraphics.FillRectangle(brush_Selected, rectangle.rect);
                            //rectangle.selected = true;
                            //selectedUIRectangle = rectangle;
                            ////selectedUIRectangle.i = i;
                            ////selectedUIRectangle.j = j;

                        }

                        return rectangle;
                    }
                }

            }

            return null;

        }







        /// <summary>
        /// Redraw Grid maps and clears out all of the UI Containers that have selected values.
        /// </summary>
        /// <param name="containerPanel"></param>
        /// <param name="squarePanel"></param>
        private void Redraw_Grid_Map(UI_GridPanel containerPanel, UI_GridPanel squarePanel)
        {

            Reset_Selected();
            containerPanel.gridPanel.Refresh();
            squarePanel.gridPanel.Invalidate();
            //clear out all contents of the UI GRID CONTAINERS and Associated square containers.

            
        }

        /// <summary>
        /// This Method is used only during Redrawing when the size of the containers are changed.
        /// </summary>
        private void Reset_Selected()
        {
       
            for (int i = 0; i < GridSize(); i++)
            {
                for (int j = 0; j < GridSize(); j++)
                {

                    UI_Grid_Planning_Container _UI_Container = GridPlanner_Map[i, j];
                    _UI_Container.selected = false; //Resets the selected


                    UI_Grid_Planning_Square[,] _UI_Squares = _UI_Container.UI_Grid_Planning_Squares;
                    for (int k = 0; k < Shared_Constants.GRID_SQUARE_SIZE; k++)
                    {
                        for (int  m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                        {
                            _UI_Squares[k, m].Selected = false; //resets the selected
                        }
                    }
                }
            }
        }



        /// <summary>
        /// Obtains the size of UI_Grid_Containers based on the Combox box selection
        /// </summary>
        /// <returns>Size of Grid</returns>
        private int GridSize()
        {
            string selected = comboBox_how_large.SelectedItem.ToString();
            int selectedSize = int.Parse(selected);
            return (int)Math.Sqrt(selectedSize);
        }
    }
}
