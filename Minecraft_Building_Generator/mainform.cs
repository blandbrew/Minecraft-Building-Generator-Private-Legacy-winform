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
        GridMap aMap { get; set; } //Complete layout of the grid
        UI_GridMap UI_Map { get; set; } //complete layout of the UI_Grid

        //UI_Grid_Planning_Container[,] GridPlanner_Map { get; set; } //handles UI grid layout

                /*UI Panels*/
        UI_GridPanel gridcontainerPanel { get; set; }
        UI_GridPanel gridsquarePanel { get; set; }

        private int Grid_Load_Size { get; set; } = 1;
        
        /*Important Variables that track states of the application for comparison*/
        private UI_Grid_Planning_Container selected_container { get; set; }
        private UI_Grid_Planning_Container previouslySelected_container { get; set; }
        private GridSquare_Zoning selected_radioButton_gridzone { get; set; }



        public mainform()
        {

            InitializeComponent();
            UI_Map = new UI_GridMap();
            Initialize_UI_Grid();
            Initialize_CityGenerator_Form();
            
            //Size = new Size(500, 500);
        }

        private void Initialize_UI_Grid()
        {

      
            gridcontainerPanel = new UI_GridPanel(panel_grid_planning, panel_grid_planning.CreateGraphics());
            gridsquarePanel = new UI_GridPanel(panel_grid_square_planning, panel_grid_square_planning.CreateGraphics());

            //Initilizes the containers to 1.
            UI_Map.InitializeUI_Grid_Containers(Grid_Load_Size, gridcontainerPanel);
            UI_Map.InitlializeUI_Grid_Squares(gridsquarePanel);
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
        }


        private void comboBox_how_large_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset grids
            //if(UI_Map.UI_Grid_Container != null)
               

            string selected = comboBox_how_large.SelectedItem.ToString();
            int selectedSize = int.Parse(selected);

            UI_Map.InitializeUI_Grid_Containers((int)Math.Sqrt(selectedSize), gridcontainerPanel);
            UI_Map.InitlializeUI_Grid_Squares(gridsquarePanel);

            int sizeOfBox = 169 * UI_Map.GridSize;
            int TotalSize = sizeOfBox * sizeOfBox;

            dynamic_label_generated_size.Text = $"{sizeOfBox} x {sizeOfBox} = {TotalSize} blocks^2";

            aMap = new GridMap(
                int.Parse(textbox_startcoordinate_x.Text),
                int.Parse(textbox_startcoordinate_y.Text),
                int.Parse(textbox_startcoordinate_z.Text),
                selectedSize);

            aMap.GenerateGrids();
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
            //sets the selected container
            selected_container = UI_Map.Draw_UI_Grid_Containers(gridcontainerPanel);

            //initialization assumes 0,0.  this is okay because loading state method will fill GridPlanner_Map before a grid is painted.
            if(selected_container != null)
            {
                UI_Map.Draw_UI_Grid_Squares(selected_container.UI_Grid_Planning_Squares, gridsquarePanel);
            }
            else
            {
                UI_Map.Draw_UI_Grid_Squares(UI_Map.UI_Grid_Container[0,0].UI_Grid_Planning_Squares, gridsquarePanel);
            }
            
        }
      
        private void panel_grid_square_planning_Paint(object sender, PaintEventArgs e)
        {
            //empty because this is dependant on Container click events
        }




        /**
         * Grid Container Methods
         */


        /// <summary>
        /// Initializes the UI Grid Container section. This is called on every Paint call
        /// </summary>
        /// <param name="sizeOfGrid"></param>
        /// <param name="UI_Grid_Containers"></param>
        //private void Draw_UI_Grid_Containers()
        //{
        //    for (int i = 0; i < UI_Map.GridSize; i++)
        //    {
        //        for (int j = 0; j < UI_Map.GridSize; j++)
        //        { 
        //            gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, UI_Map.UI_Grid_Container[i,j].rect);
        //        }
        //    }

        //    gridcontainerPanel.DrawAxis();
        //    gridcontainerPanel.DrawAxisLabel();

        //    //initializes the first continer to be selected.
        //    UI_Map.UI_Grid_Container[0, 0] = Set_Select_UI_Grid_Planning_Container(UI_Map.UI_Grid_Container[0, 0]);
        //    selected_container = UI_Map.UI_Grid_Container[0, 0];
        //}


        /// <summary>
        /// This method handles what action will be taken when a container is selected
        /// </summary>
        /// <param name="SizeOfGrid"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        //private UI_Grid_Planning_Container Select_Rectangle_Container(Point location)
        //{

        //    UI_Grid_Planning_Container rectangle;
        //    for (int i = 0; i < UI_Map.GridSize; i++)
        //    {
        //        for (int j = 0; j < UI_Map.GridSize; j++)
        //        {
        //            rectangle = UI_Map.UI_Grid_Container[i, j];

        //            if (rectangle.rect.Contains(location))
        //            {
        //                if (previouslySelected == rectangle)
        //                {
        //                    Console.WriteLine("Match");
        //                    Set_Select_UI_Grid_Planning_Container(rectangle);
        //                }
        //                else
        //                {
        //                    rectangle = Set_Select_UI_Grid_Planning_Container(rectangle);
                           
        //                }

        //                return rectangle;
        //            }
        //        }

        //    }
        //    return null;
        //}





        /**
         * Mouse Click Handling Methods
         */

        /// <summary>
        /// Action taken when a Grid_container is clicked
        /// </summary>
        private void panel_grid_planning_MouseClick(Object sender, MouseEventArgs e)
        {

            UI_Grid_Planning_Container aContainer = UI_Map.Select_Rectangle_Container(e.Location, gridcontainerPanel);
            if (aContainer != null)
            {
                dynamic_label_selected_container.Text = "(" + aContainer.ContainerCoordinate.Item1 + "," + aContainer.ContainerCoordinate.Item2 + ")";
                selected_container = aContainer;
                gridsquarePanel.gridPanel.Refresh();
                UI_Map.Load_Grid_Squares(selected_container, gridsquarePanel);
            }

        }


        /**
         * Grid Square Methods
         */


        /// <summary>
        /// Draws Grid squares in the UI Grid Map
        /// </summary>
        //private void Draw_UI_Grid_Squares(UI_Grid_Planning_Square[,] _uiGridSquares)
        //{
        //    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
        //    {
        //        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
        //        {  
        //            gridsquarePanel.Fill_Rectangle(GridSquare_Zoning.Initialized, _uiGridSquares[m,n].rectangle);
        //        }
        //    }



        //    gridsquarePanel.DrawAxis();
        //    gridsquarePanel.DrawAxisLabel();

        //    //UI_Draw_Grid_Support(gridsquarePanel, UI_Map.EastAxisSquare_label.X, UI_Map.SouthAxisSquare_label.Y);
        //    //UI_Draw_Grid_Support("East", gridsquarePanel, UI_Map.EastAxisSquare_label);
        //    //UI_Draw_Grid_Support("South", gridsquarePanel, UI_Map.SouthAxisSquare_label);
            
        //}



        /// <summary>
        /// Action taken when a Grid_Square is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_grid_square_planning_MouseClick(Object sender, MouseEventArgs e)
        {

           UI_Map.Select_Rectangle_Square(sender, e.Location, selected_container, gridsquarePanel, selected_radioButton_gridzone);
            

        }

        ///// <summary>
        ///// This method handles mouseclick functions for individual UI_Grid_squares
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        ///// <param name="_container"></param>
        ///// <returns>A <see cref="UI_Grid_Planning_Container"/> with the selected square in a 2D array of <see cref="UI_Grid_Planning_Square"/></returns>
        //private UI_Grid_Planning_Container Select_Rectangle_Square(Object sender, MouseEventArgs e, UI_Grid_Planning_Container _container)
        //{
        //    //Console.WriteLine(""+_container.ContainerCoordinate.Item1+","+_container.ContainerCoordinate.Item2);
        //    UI_Grid_Planning_Square[,] _gridsquares = _container.UI_Grid_Planning_Squares;

        //    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
        //    {
        //        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
        //        {
        //            UI_Grid_Planning_Square square = _gridsquares[m, n];

        //            if (square.rectangle.Contains(e.Location))
        //            {
        //                //Console.WriteLine("" + square.SquareCoordinate.Item1 + "," + square.SquareCoordinate.Item2);
        //                square = Set_Selected_UI_Grid_Planning_Square(square);


        //                return _container;
        //            }
        //        }

        //    }
        //    return null;
        //}



        /// <summary>
        /// Loads grid_squares 2d array from container, preserving selected squares.
        /// </summary>
        /// <param name="selected_container"></param>
        //private void Load_Grid_Squares(UI_Grid_Planning_Container selected_container)
        //{
        //    UI_Grid_Planning_Square[,] squares = selected_container.UI_Grid_Planning_Squares;

        //    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
        //    {
        //        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
        //        {
        //            if (squares[m, n].Selected)
        //            {
        //                gridsquarePanel.Fill_Rectangle(squares[m, n].zone, squares[m, n].rectangle);
        //            }
        //            else
        //            {
        //                gridsquarePanel.Fill_Rectangle(GridSquare_Zoning.Initialized, squares[m, n].rectangle);
        //            }

        //        }
        //    }

        //    UI_Draw_Grid_Support(gridsquarePanel, UI_Map.EastAxisSquare_label.X, UI_Map.SouthAxisSquare_label.Y);
        //    UI_Draw_Grid_Support("East", gridsquarePanel, UI_Map.EastAxisSquare_label);
        //    UI_Draw_Grid_Support("South", gridsquarePanel, UI_Map.SouthAxisSquare_label);
 
        //}














        /// <summary>
        /// Redraw Grid maps and clears out all of the UI Containers that have selected values.
        /// </summary>
        /// <param name="containerPanel"></param>
        /// <param name="squarePanel"></param>
        private void Redraw_Grid_Map(UI_GridPanel containerPanel, UI_GridPanel squarePanel)
        {

            UI_Map.Reset_Selected();
            squarePanel.gridPanel.Refresh();
            containerPanel.gridPanel.Refresh();
            
            //clear out all contents of the UI GRID CONTAINERS and Associated square containers.

            
        }





        /// <summary>
        /// Handles selecting containers.
        /// </summary>
        /// <param name="selected_container"></param>
        /// <returns></returns>
        //private UI_Grid_Planning_Container Set_Select_UI_Grid_Planning_Container(UI_Grid_Planning_Container selected_container)
        //{
        //    //If true, reset the container.  if False, set to true and mark as selected
        //    if (previouslySelected == null)
        //    {
        //        previouslySelected = selected_container;
        //    }

        //    if (selected_container.selected)
        //    {
        //        selected_container.selected = false;
        //        gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, selected_container.rect);
        //    }
        //    else
        //    {
        //        previouslySelected.selected = false;
        //        gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, previouslySelected.rect);

        //        selected_container.selected = true;
        //        gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Selected, selected_container.rect);
        //        previouslySelected = selected_container;
        //    }

        //    return selected_container;
        //}


        /// <summary>
        /// Handles how to display Grid Panel squares when they are selected
        /// </summary>
        /// <param name="selected_square"></param>
        /// <returns>A selected <see cref="UI_Grid_Planning_Square"/></returns>
        //private UI_Grid_Planning_Square Set_Selected_UI_Grid_Planning_Square(UI_Grid_Planning_Square selected_square)
        //{
        //    if(selected_square.Selected)
        //    {
        //        selected_square.Selected = false;
        //        gridsquarePanel.Fill_Rectangle(GridSquare_Zoning.Initialized, selected_square.rectangle);
        //        selected_square.zone = GridSquare_Zoning.Initialized;
        //    }
        //    else
        //    {
        //        //Radio button determines what color to fill in the square
        //        selected_square.Selected = true;
        //        gridsquarePanel.Fill_Rectangle(selected_radioButton_gridzone, selected_square.rectangle);
        //        selected_square.zone = selected_radioButton_gridzone;
        //    }

        //    return selected_square;
        //}



        /// <summary>
        /// Draws supporting grid outlines
        /// </summary>
        /// <param name="panel"></param>
        //private void UI_Draw_Grid_Support(UI_GridPanel panel, int maxX, int maxY)
        //{
        //    panel.gridPanelGraphics.DrawLine(panel.gridPanelPen, 1, 0, maxX, 0); //Draws horizontal graph line
        //    panel.gridPanelGraphics.DrawLine(panel.gridPanelPen, 1, 0, 1, maxY); //draws vertical graph line
        //}

        /// <summary>
        /// Draws strings in support of grid outlines
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="panel"></param>
        //private void UI_Draw_Grid_Support(string direction, UI_GridPanel panel, Point p1)
        //{
        //    panel.gridPanelGraphics.DrawString(direction, panel.gridPanelFont, panel.gridPanelBrush, p1);
        //}




        /// <summary>
        /// Determines which radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllRadioButtons_CheckedChanged(Object sender, EventArgs e)
        {
            // Check of the raiser of the event is a checked Checkbox.
            // Of course we also need to to cast it first.
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;

                switch (rb.Name)
                {
                    case "radioButton_building":
                        selected_radioButton_gridzone = GridSquare_Zoning.Building;
                        break;
                    case "radioButton_road":
                        selected_radioButton_gridzone = GridSquare_Zoning.Infrustructure;
                        break;
                    case "radioButton_scenery":
                        selected_radioButton_gridzone = GridSquare_Zoning.Scenery;
                        break;
                    case "radioButton_water":
                        selected_radioButton_gridzone = GridSquare_Zoning.Water;
                        break;
                }
            }
        }



    }
}
