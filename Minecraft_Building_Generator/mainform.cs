using Minecraft_Building_Generator.Command_Generator;
using Minecraft_Building_Generator.Grid_Classes;
using Minecraft_Building_Generator.Structures;
using Minecraft_Building_Generator.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private UI_Grid_Planning_Square mouseDownSquare;
        private UI_Grid_Planning_Square mouseUpSquare;
        private Point selectionStart;
        private Point selectionEnd;
        private Rectangle selection;
        private bool mouseDown;
        private bool mouseClick;


        private GridSquare_Zoning selected_radioButton_gridzone { get; set; } = GridSquare_Zoning.Building;



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


            TransposeUI_to_Grid();

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

            if (mouseDown && Control.ModifierKeys == Keys.Shift)
            {
                using (Pen pen = new Pen(Color.Black, 1F))
                {
                    //DoubleBuffered = true;
                    pen.DashStyle = DashStyle.Dash;
                    gridsquarePanel.gridPanelGraphics.DrawRectangle(pen, selection);

                }
                //Refresh_Grid_SquareMap(gridsquarePanel);
                UI_Map.Load_Grid_Squares(selected_container, gridsquarePanel);
                //gridsquarePanel.gridPanelGraphics.Clear(Color.FromArgb(153, 180, 209));
            }

            
        }


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
                UI_Map.Load_Grid_Squares(aContainer, gridsquarePanel);
            }
        }

        /// <summary>
        /// Action taken when a Grid_Square is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_grid_square_planning_MouseClick(Object sender, MouseEventArgs e)
        {
           // Console.WriteLine("MouseClicked");
           if (!(Control.ModifierKeys == Keys.Shift))
            {
                UI_Map.Select_Rectangle_Square(sender, e.Location, selected_container, gridsquarePanel, selected_radioButton_gridzone);
                mouseDown = false;
            }

            //Bitmap bm = new Bitmap(gridsquarePanel.gridPanel.Width, gridsquarePanel.gridPanel.Height);
            //gridsquarePanel.gridPanel.DrawToBitmap(bm, new Rectangle(0, 0, gridsquarePanel.gridPanel.Width, gridsquarePanel.gridPanel.Height));
       
            ////gridsquarePanel.gridPanel.BackgroundImage = bm;
            //bm.Save(@"D:\gridbackground.bmp");

        }


        private void panel_grid_square_planning_MouseDown(Object sender, MouseEventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift)
            {
                selectionStart = e.Location;

                mouseDownSquare = UI_Map.MouseDownLocation(selectionStart, selected_container);
                mouseDown = true;
            }


            



        }
        private void panel_grid_square_planning_MouseMove(Object sender, MouseEventArgs e)
        {
            
            if (!mouseDown)
            {
                return;
            }

            //Console.WriteLine("MouseMove: " + e.Location);
            selectionEnd = e.Location;
            SetSelectionRect();

            gridsquarePanel.gridPanel.Invalidate();
            //Refresh_Grid_SquareMap(gridsquarePanel);
            //Refresh();
            //UI_Map.Load_Grid_Squares(selected_container, gridsquarePanel);
            //UI_Map.Highlight_Rectangle_Squares(mouseDownSquare, mouseMovePoint, selected_container, gridsquarePanel, selected_radioButton_gridzone);

        }

        private void panel_grid_square_planning_MouseUp(Object sender, MouseEventArgs e)
        {
                mouseUpSquare = UI_Map.MouseDownLocation(selectionEnd, selected_container);
            if (Control.ModifierKeys == Keys.Shift)
            {
                Console.WriteLine("Shft pressed");
                mouseDown = false;
                SetSelectionRect();
                //gridsquarePanel.gridPanel.Refresh();


                List<UI_Grid_Planning_Square> intersected = new List<UI_Grid_Planning_Square>();

                foreach (UI_Grid_Planning_Square r in selected_container.UI_Grid_Planning_Squares)
                {

                    if (selection.IntersectsWith(r.rectangle))
                    {

                        Console.WriteLine(r.SquareCoordinate);
                        intersected.Add(r);
                    }

                }

                foreach (UI_Grid_Planning_Square square in intersected)
                {
                    UI_Map.Select_Rectangle_Square(square, gridsquarePanel, selected_radioButton_gridzone);
                    //gridsquarePanel.Fill_Rectangle(selected_radioButton_gridzone, square.rectangle);
                }
               
            }
            
        }

            

        

        private void SetSelectionRect()
        {
            int x, y;
            int width, height;

            x = selectionStart.X > selectionEnd.X ? selectionEnd.X : selectionStart.X;
            y = selectionStart.Y > selectionEnd.Y ? selectionEnd.Y : selectionStart.Y;

            width = selectionStart.X > selectionEnd.X ? selectionStart.X - selectionEnd.X : selectionEnd.X - selectionStart.X;
            height = selectionStart.Y > selectionEnd.Y ? selectionStart.Y - selectionEnd.Y : selectionEnd.Y - selectionStart.Y;

            selection = new Rectangle(x, y, width, height);
        }







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

        private void Refresh_Grid_SquareMap(UI_GridPanel squarePanel)
        {
            squarePanel.gridPanel.Refresh();
        }





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


        /// <summary>
        /// Transposes UI Grid over to the Grid for processing
        /// </summary>
        private void TransposeUI_to_Grid()
        {
            //GridMap aMap 
            //UI_GridMap UI_Map
            // UI_Map;

            Grid_Container[,] _gridContainers = aMap.PrimaryGridMap;
            for (int i = 0; i < UI_Map.GridSize; i++)
            {
                for (int j = 0; j < UI_Map.GridSize; j++)
                {
                    Grid_Square[,] _gridSquares = _gridContainers[i, j].gridSquareMap;

                    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                    {
                        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                        {
                            Console.WriteLine(UI_Map.UI_Grid_Container[i, j].UI_Grid_Planning_Squares[m, n].zone);
                            aMap.PrimaryGridMap[i,j].gridSquareMap[m, n].zone = UI_Map.UI_Grid_Container[i, j].UI_Grid_Planning_Squares[m, n].zone;

                        }
                    }
                }
            }
        }


    }
}
