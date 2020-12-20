using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private UI_Grid_Planning_Container previouslySelected_container { get; set; }




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




        public void InitializeUI_Grid_Containers(int sizeOfGrid, UI_GridPanel containerPanel)
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

            containerPanel.GraphMax_X = maxX;
            containerPanel.GraphMax_Y = maxY;
            //EastAxisContainer_label = new Point(maxX + 5, 0);
            //SouthAxisContainer_label = new Point(0, maxY + 5);

        }


        /// <summary>
        /// Initializes grid squares
        /// </summary>
        public void InitlializeUI_Grid_Squares(UI_GridPanel squaresPanel)
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
                        squaresPanel.GraphMax_X = maxX;
                        squaresPanel.GraphMax_Y = maxY;

                    }
                    x = 10;
                    y = 10;
                    maxX = 1;
                    maxY = 1;
                }
            }
        }



        public UI_Grid_Planning_Container Select_Rectangle_Container(Point location, UI_GridPanel gridContainerPanel)
        {

            UI_Grid_Planning_Container aContainer;
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    aContainer = UI_Grid_Container[i, j];

                    if (aContainer.rect.Contains(location))
                    {
                        if (previouslySelected_container == aContainer)
                        {
                            Console.WriteLine("Match");
                            Set_Select_UI_Grid_Planning_Container(aContainer, gridContainerPanel);
                        }
                        else
                        {
                            aContainer = Set_Select_UI_Grid_Planning_Container(aContainer, gridContainerPanel);

                        }

                        return aContainer;
                    }
                }

            }
            return null;
        }







        public UI_Grid_Planning_Container Draw_UI_Grid_Containers(UI_GridPanel gridcontainerPanel)
        {
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    gridcontainerPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, UI_Grid_Container[i, j].rect);
                }
            }

            gridcontainerPanel.DrawAxis();
            gridcontainerPanel.DrawAxisLabel();

            //initializes the first continer to be selected.
            UI_Grid_Container[0, 0] = Set_Select_UI_Grid_Planning_Container(UI_Grid_Container[0, 0], gridcontainerPanel);

            return UI_Grid_Container[0, 0];
        }












        private UI_Grid_Planning_Container Set_Select_UI_Grid_Planning_Container(UI_Grid_Planning_Container selected_container, UI_GridPanel clickedPanel)
        {
            //If true, reset the container.  if False, set to true and mark as selected

            if (previouslySelected_container == null)
            {
                previouslySelected_container = selected_container;
            }

            if (selected_container.selected)
            {
                selected_container.selected = false;
                clickedPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, selected_container.rect);
            }
            else
            {
                previouslySelected_container.selected = false;
                clickedPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, previouslySelected_container.rect);

                selected_container.selected = true;
                clickedPanel.Fill_Rectangle(GridSquare_Zoning.Selected, selected_container.rect);
                previouslySelected_container = selected_container;
            }

            return selected_container;
        }



        public void Select_Rectangle_Square(Object sender, Point click_location, UI_Grid_Planning_Container _container, UI_GridPanel clickedPanel, GridSquare_Zoning selected_radioButton_gridzone)
        {
            //Console.WriteLine(""+_container.ContainerCoordinate.Item1+","+_container.ContainerCoordinate.Item2);
            UI_Grid_Planning_Square[,] _gridsquares = _container.UI_Grid_Planning_Squares;

            for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
            {
                for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                {
                    UI_Grid_Planning_Square square = _gridsquares[m, n];

                    if (square.rectangle.Contains(click_location))
                    {
                        //Console.WriteLine("" + square.SquareCoordinate.Item1 + "," + square.SquareCoordinate.Item2);
                        square = Set_Selected_UI_Grid_Planning_Square(square, clickedPanel, selected_radioButton_gridzone);


                        //return _container;
                    }
                }

            }
            //return null;
        }

        private UI_Grid_Planning_Square Set_Selected_UI_Grid_Planning_Square(UI_Grid_Planning_Square selected_square, UI_GridPanel clickedPanel, GridSquare_Zoning selected_radioButton_gridzone)
        {
            if (selected_square.Selected)
            {
                selected_square.Selected = false;
                clickedPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, selected_square.rectangle);
                selected_square.zone = GridSquare_Zoning.Initialized;
            }
            else
            {
                //Radio button determines what color to fill in the square
                selected_square.Selected = true;
                clickedPanel.Fill_Rectangle(selected_radioButton_gridzone, selected_square.rectangle);
                //selected_square.zone = selected_radioButton_gridzone;
            }

            return selected_square;
        }



        public void Draw_UI_Grid_Squares(UI_Grid_Planning_Square[,] _uiGridSquares, UI_GridPanel gridSquarePanel)
        {
            for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
            {
                for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                {
                    gridSquarePanel.Fill_Rectangle(GridSquare_Zoning.Initialized, _uiGridSquares[m, n].rectangle);
                }
            }

            gridSquarePanel.DrawAxis();
            gridSquarePanel.DrawAxisLabel();

        }



        public void Load_Grid_Squares(UI_Grid_Planning_Container selected_container, UI_GridPanel gridSquarePanel)
        {
            UI_Grid_Planning_Square[,] squares = selected_container.UI_Grid_Planning_Squares;

            for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
            {
                for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                {
                    if (squares[m, n].Selected)
                    {
                        gridSquarePanel.Fill_Rectangle(squares[m, n].zone, squares[m, n].rectangle);
                    }
                    else
                    {
                        gridSquarePanel.Fill_Rectangle(GridSquare_Zoning.Initialized, squares[m, n].rectangle);
                    }

                }
            }
            gridSquarePanel.DrawAxis();
            gridSquarePanel.DrawAxisLabel();

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
