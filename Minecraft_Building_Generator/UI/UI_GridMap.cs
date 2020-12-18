using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.UI
{
    class UI_GridMap
    {

        public UI_Grid_Planning_Container[,] UI_Grid_Container { get; set; }
        public Point EastAxisContainer_label { get; private set; }
        public Point SouthAxisContainer_label { get; private set; }
        public Point EastAxisSquare_label { get; private set; }
        public Point SouthAxisSquare_label { get; private set; }

        public int GridSize { get; set; }
        public int previousSizeOfGrid { get; set; }





        public UI_GridMap()
        {
            
        }




        public UI_Grid_Planning_Container GetContainer((int, int) container_location)
        {
            return UI_Grid_Container[container_location.Item1, container_location.Item2];
        }

        public UI_Grid_Planning_Square GetSquareFromContainer((int, int) container_location, (int, int) square_location)
        {
            return UI_Grid_Container[container_location.Item1, container_location.Item2].UI_Grid_Planning_Squares[square_location.Item1, square_location.Item2];
        }




        public void InitializeUI_Grid_Containers(int sizeOfGrid)
        {
            Console.WriteLine("initilize container");
            GridSize = sizeOfGrid;

            //Grid_production
            int separatorValue = 17;
            int x = 10;
            int y = 10;
            int maxX = 1;
            int maxY = 1;

            //initialize 2d array of grid planner
            UI_Grid_Container = new UI_Grid_Planning_Container[sizeOfGrid, sizeOfGrid];

            for (int i = 0; i < sizeOfGrid; i++)
            {
                for (int j = 0; j < sizeOfGrid; j++)
                {

                    Rectangle _rect = new Rectangle(x, y, Shared_Constants.UI_GRID_RECTANGLE_SIZE, Shared_Constants.UI_GRID_RECTANGLE_SIZE);
                    UI_Grid_Container[i, j] = new UI_Grid_Planning_Container(_rect, (i, j));
                    //gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, _rect);

                    x += separatorValue;
                }
                maxX = x;
                maxY = y + separatorValue + 10;
                x = 10;
                y += separatorValue;
            }



            //UI_Draw_Grid_Support(gridcontainerPanel, UI_Container_draw_Direction_Max_X, UI_Container_draw_Direction_Max_Y);

            EastAxisContainer_label = new Point(maxX + 5, 0);
            SouthAxisContainer_label = new Point(0, maxY + 5);


            //UI_Draw_Grid_Support("East", gridcontainerPanel, p1);

            //UI_Draw_Grid_Support("East", gridcontainerPanel, p1);

            //UI_Draw_Grid_Support("South", gridcontainerPanel, p2);

            //initializes the first continer to be selected.
            



            //selected_container = UI_Map.UI_Grid_Container[0, 0];


        }

        public void InitlializeUI_Grid_Squares()
        {
            UI_Grid_Planning_Container selected_container;
            Console.WriteLine("initilize squares");
            //Grid_production
            int separatorValue = 17;
            int x = 10;
            int y = 10;
            int maxX = 1;
            int maxY = 1;

            //initialize 2d array of grid planner

            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    selected_container = UI_Grid_Container[i, j];

                    UI_Grid_Planning_Square[,] _uiGridSquares = new UI_Grid_Planning_Square[Shared_Constants.GRID_SQUARE_SIZE, Shared_Constants.GRID_SQUARE_SIZE];

                    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                    {
                        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                        {
                            Rectangle _rect = new Rectangle(x, y, Shared_Constants.UI_GRID_RECTANGLE_SIZE, Shared_Constants.UI_GRID_RECTANGLE_SIZE);
                            _uiGridSquares[m, n] = new UI_Grid_Planning_Square(_rect, (i, j), (m, n));
                            //if (i == 0 && j == 0)
                            //    gridsquarePanel.Fill_Rectangle(GridSquare_Zoning.Initialized, _rect);

                            x += separatorValue;
                        }

                        maxX = x;
                        maxY = y + separatorValue + 10;
                        x = 10;
                        y += separatorValue;
                    }
                    selected_container.UI_Grid_Planning_Squares = _uiGridSquares;

                    if (i == 0 && j == 0)
                    {
                        EastAxisSquare_label = new Point(maxX + 5, 0);
                        SouthAxisSquare_label = new Point(0, maxY + 5);
                    }
                    x = 10;
                    y = 10;
                    maxX = 1;
                    maxY = 1;
                }
            }
        }


        public void Reset_Selected()
        {
           
            for (int i = 0; i < previousSizeOfGrid; i++)
            {
                for (int j = 0; j < previousSizeOfGrid; j++)
                {

                    UI_Grid_Planning_Container _UI_Container = UI_Grid_Container[i, j];
                    _UI_Container.selected = false; //Resets the selected


                    UI_Grid_Planning_Square[,] _UI_Squares = _UI_Container.UI_Grid_Planning_Squares;
                    for (int k = 0; k < Shared_Constants.GRID_SQUARE_SIZE; k++)
                    {
                        for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                        {
                            _UI_Squares[k, m].Selected = false; //resets the selected
                        }
                    }
                }
            }
        }

        
    }
}
