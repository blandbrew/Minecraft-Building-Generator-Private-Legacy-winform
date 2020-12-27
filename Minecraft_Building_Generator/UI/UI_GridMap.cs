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

        public int GridSize { get; set; }
        public int previousSizeOfGrid { get; set; }

        private UI_Grid_Planning_Container previouslySelected_container { get; set; }
        private UI_Grid_Planning_Container selected_container { get; set; }



        public UI_GridMap()
        {
            
        }




        public UI_Grid_Planning_Container GetContainer((int, int) container_location)
        {
            //application is working but throwing errors, need to test for validity without getting errors.  length maybe?
            if (UI_Grid_Container[container_location.Item1, container_location.Item2] != null)
               return UI_Grid_Container[container_location.Item1, container_location.Item2];
            else
                return null;
 
        }

        public UI_Grid_Planning_Square GetSquareFromContainer((int, int) container_location, (int, int) square_location)
        {
            if (UI_Grid_Container[container_location.Item1, container_location.Item2].UI_Grid_Planning_Squares[square_location.Item1, square_location.Item2] != null)
                return UI_Grid_Container[container_location.Item1, container_location.Item2].UI_Grid_Planning_Squares[square_location.Item1, square_location.Item2];
            else
                return null;
        }

        public void setCointainer((int,int) container_location, UI_Grid_Planning_Container aContainer)
        {
            if(UI_Grid_Container[container_location.Item1, container_location.Item2] != null)
                UI_Grid_Container[container_location.Item1, container_location.Item2] = aContainer;
     
        }





        /****************************************************************************
         * Initialize UI Grid Section
         *****************************************************************************
         *****************************************************************************
         *****************************************************************************/


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

            AdjacenctContainerCalculation();
            AdjacenctSquaresCalculation();
        }


        /*END OF INITILIZATION*/
        //****************************************************************************





        /****************************************************************************
        * ON MOUSE CLICK - Select Handlers
        *****************************************************************************
        *****************************************************************************
        *****************************************************************************/




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



        /// <summary>
        /// Executed when a square is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="click_location"></param>
        /// <param name="_container"></param>
        /// <param name="clickedPanel"></param>
        /// <param name="selected_radioButton_gridzone"></param>
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

                        setCointainer((_container.ContainerCoordinate.Item1, _container.ContainerCoordinate.Item2), _container);
                    }
                }

            }
      
        }

        public void Select_Rectangle_Square(UI_Grid_Planning_Square aSquare, UI_GridPanel clickedPanel, GridSquare_Zoning selected_radioButton_gridzone)
        {
            //Console.WriteLine(""+_container.ContainerCoordinate.Item1+","+_container.ContainerCoordinate.Item2);


            //Console.WriteLine("" + square.SquareCoordinate.Item1 + "," + square.SquareCoordinate.Item2);
            aSquare = Set_Selected_UI_Grid_Planning_Square(aSquare, clickedPanel, selected_radioButton_gridzone);

            //setCointainer((_container.ContainerCoordinate.Item1, _container.ContainerCoordinate.Item2), _container);
                    
                

          

        }





        //////////////////////////////////////DEVELOPMENT////////////////////////////////////////

        public void Highlight_Rectangle_Squares(UI_Grid_Planning_Square mouseDownSquare, Point mouseMove_location, UI_Grid_Planning_Container _container, UI_GridPanel clickedPanel, GridSquare_Zoning selected_radioButton_gridzone)
        {
            HashSet<UI_Grid_Planning_Square> _highlighted = new HashSet<UI_Grid_Planning_Square>();
            //Console.WriteLine(""+_container.ContainerCoordinate.Item1+","+_container.ContainerCoordinate.Item2);
            UI_Grid_Planning_Square[,] _gridsquares = _container.UI_Grid_Planning_Squares;

            for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
            {
                for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                {
                    UI_Grid_Planning_Square mouseMoveSquare = _gridsquares[m, n];

                    if (mouseMoveSquare.rectangle.Contains(mouseMove_location))
                    {

                        ClearMouseMove(_highlighted, clickedPanel);
                        _highlighted = SetOfSquaresSelected(mouseDownSquare, mouseMoveSquare, _gridsquares, clickedPanel, selected_radioButton_gridzone);
                        
                        foreach(UI_Grid_Planning_Square square in _highlighted)
                        {
                            clickedPanel.Fill_Rectangle(selected_radioButton_gridzone, square.rectangle);
                        }
                    }
                }

            }

        }

        public HashSet<UI_Grid_Planning_Square> SetOfSquaresSelected(UI_Grid_Planning_Square mouseDownSquare, UI_Grid_Planning_Square mouseMoveSquare, UI_Grid_Planning_Square[,] _gridsquares, UI_GridPanel clickedPanel, GridSquare_Zoning selected_radioButton_gridzone)
        {
            int downX, downY, moveX, moveY, numRows, numColumns;
            HashSet<UI_Grid_Planning_Square> set = new HashSet<UI_Grid_Planning_Square>();

            downX = mouseDownSquare.SquareCoordinate.Item1;
            downY = mouseDownSquare.SquareCoordinate.Item2;
            moveX = mouseMoveSquare.SquareCoordinate.Item1;
            moveY = mouseMoveSquare.SquareCoordinate.Item2;


           numRows = moveX - downX;
           numColumns = Math.Abs(downY - moveY);

            for (int i = downX; i < numRows; i++)
            {

                for (int j = downY; j < numColumns; j++)
                {
                    set.Add(_gridsquares[i, j]);
                    //clickedPanel.Fill_Rectangle(selected_radioButton_gridzone, _gridsquares[i, j].rectangle);
                }
            }

            return set;
        }

        private void ClearMouseMove(HashSet<UI_Grid_Planning_Square> _highlighted, UI_GridPanel clickedPanel)
        {
            foreach (UI_Grid_Planning_Square square in _highlighted)
            {
                clickedPanel.Fill_Rectangle(GridSquare_Zoning.Initialized, square.rectangle);
            }
        }

        private void PaintMouseMove()
        {

        }


        /// <summary>
        /// Returns the specific Grid square where mouseDown event occurred
        /// </summary>
        /// <param name="mouseDown_location"></param>
        /// <param name="_container"></param>
        /// <returns></returns>
        public UI_Grid_Planning_Square MouseDownLocation(Point mouseDown_location, UI_Grid_Planning_Container _container)
        {
            UI_Grid_Planning_Square[,] _gridsquares = _container.UI_Grid_Planning_Squares;

            for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
            {
                for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                {
                    UI_Grid_Planning_Square square = _gridsquares[m, n];

                    if (square.rectangle.Contains(mouseDown_location))
                    {
                        return square;
                    }
                }

            }
            return null;
        }

        //////////////////////////////////////DEVELOPMENT////////////////////////////////////////




        /*END OF Click Handlers*/
        //****************************************************************************







        /****************************************************************************
        * DRAW METHOD Calls to UI_GridPanel
        *****************************************************************************
        *****************************************************************************
        *****************************************************************************/

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
        /*END OF Draw Methods*/
        //****************************************************************************





        /****************************************************************************
        * Handles Selection settings
        *****************************************************************************
        *****************************************************************************
        *****************************************************************************/


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
                selected_square.zone = selected_radioButton_gridzone;
            }

            return selected_square;
        }


        /*END OF Selection Handlers*/
        //****************************************************************************




        /****************************************************************************
        * Utility Methods
        *****************************************************************************
        *****************************************************************************
        *****************************************************************************/


        /// <summary>
        /// Loads Grid squares when a container square is clicked.
        /// </summary>
        /// <param name="selected_container"></param>
        /// <param name="gridSquarePanel"></param>
        public void Load_Grid_Squares(UI_Grid_Planning_Container selected_container, UI_GridPanel gridSquarePanel)
        {
            UI_Grid_Planning_Square[,] squares = selected_container.UI_Grid_Planning_Squares;

            for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
            {
                for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                {
                    if (squares[m, n].Selected)
                    {
                        Console.WriteLine("SELECTED SQUARES " + squares[m, n].zone.ToString());
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


        /// <summary>
        /// Resets all of the grid containers and grid squares back to initilized and unselected
        /// </summary>
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


        /// <summary>
        /// Calculates the Adjacent Containers and adds them to the list
        /// </summary>
        private void AdjacenctContainerCalculation()
        {
           
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    UI_Grid_Planning_Container aContainer = UI_Grid_Container[i, j];

                    //Console.WriteLine(UI_Grid_Container[i, j+1].ContainerCoordinate);
                    //This section is to test for adjacency and then associate the adjacent unit.
                    //Minecraft only has to test 4 directions since we are not considering diagnal adjacency
                         //before
                        if (j - 1 >= 0 && UI_Grid_Container[i, j - 1] != null)
                        {
                            
                            aContainer.AdjacentContainers.Add(UI_Grid_Container[i, j - 1]);
                        }
                        //next
                        if ((j + 1 < GridSize) && UI_Grid_Container[i, j + 1] != null)
                        {
                        Console.WriteLine("ADDED CONTAINER");
                            aContainer.AdjacentContainers.Add(UI_Grid_Container[i, j + 1]);
                        }
                        //above
                        if ((i + 1 < GridSize) && UI_Grid_Container[i + 1, j] != null)
                        {
                       
                            aContainer.AdjacentContainers.Add(UI_Grid_Container[i + 1, j]);
                        }
                        //below
                        if ((i - 1 >= 0) && UI_Grid_Container[i - 1, j] != null)
                        {
                    
                            aContainer.AdjacentContainers.Add(UI_Grid_Container[i - 1, j]);
                        }

                }
            }
        }

        private void AdjacenctSquaresCalculation()
        {
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    UI_Grid_Planning_Container aContainer = UI_Grid_Container[i, j];
                    UI_Grid_Planning_Square[,] aGridSquareMap = aContainer.UI_Grid_Planning_Squares;


                    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                    {
                        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                        {

                            UI_Grid_Planning_Square aGridSquare = aGridSquareMap[m, n];
                         
                            try
                            {
                                //left
                                if ((n - 1 >= 0) && aGridSquareMap[m, n - 1] != null)
                                {
                                    aGridSquare.AdjacentSquares.Add(aGridSquareMap[m, n - 1]);
                                }
                                //right
                                if ((n + 1 < Shared_Constants.GRID_SQUARE_SIZE) && aGridSquareMap[m, n + 1] != null)
                                {
                                    
                                    aGridSquare.AdjacentSquares.Add(aGridSquareMap[m, n + 1]);
                                }
                                //below
                                if ((m + 1 < Shared_Constants.GRID_SQUARE_SIZE) && aGridSquareMap[m + 1, n] != null)
                                {
                                    aGridSquare.AdjacentSquares.Add(aGridSquareMap[m + 1, n]);
                                }
                                //above
                                if ((m - 1 >= 0) && aGridSquareMap[m - 1, n] != null)
                                {
                                    aGridSquare.AdjacentSquares.Add(aGridSquareMap[m - 1, n]);
                                }

                                (bool, string) edgeResult = EdgeTest(i, j, m, n);

                                if (edgeResult.Item1)
                                    GetAdjacentSquareFromAnotherContainer(aGridSquare, edgeResult.Item2);


                            }
                            catch (IndexOutOfRangeException err)
                            {
                                Console.WriteLine(err);
                            }

                        }

                    }

                }
            }
        
        }

        private (bool, string) EdgeTest(int i, int j, int m, int n)
        {
            //not working because of the limits imposed by i != 0, what happens if i does equal zero....
            if (m == 0 && i-1 >= 0)
                return (true, "north");
            else if (m == 12 && i+1 <= 12)
                return (true, "south");
            else if (n == 0 && j-1 >= 0)
                return (true, "West");
            else if (n == 12 && j <= 12)
                return (true, "East");

            return (false, "none");
        }

        private void GetAdjacentSquareFromAnotherContainer(UI_Grid_Planning_Square current_square, string direction)
        {
            //UI_Grid_Planning_Square adjacentsquare;
            int row;
            int col;
            (int, int) adjSquareCoordinate = current_square.SquareCoordinate;
            

            switch(direction)
            {
                case "north":
                    row = -1;
                    col = 0;
                    adjSquareCoordinate.Item1 = 12;
                    break;
                case "east":
                    row = 0;
                    col = 1;
                    adjSquareCoordinate.Item2 = 0;
                    break;
                case "south":
                    row = 1;
                    col = 0;
                    adjSquareCoordinate.Item1 = 0;
                    break;
                case "west":
                    row = 0;
                    col = -1;
                    adjSquareCoordinate.Item2 = 12;
                    break;
                default:
                    return;
            }

            (int, int) parentContainer = current_square.ParentContainerCoordinate;

            //get a container that is above this container
            UI_Grid_Planning_Container adjContainer = GetContainer((parentContainer.Item1 + row, parentContainer.Item2 + col));
            UI_Grid_Planning_Square adjSquare = adjContainer.UI_Grid_Planning_Squares[adjSquareCoordinate.Item1, adjSquareCoordinate.Item2];

            //current grid square, need to know adjacnet one in another container
            //aGridSquare
            Console.WriteLine("Parent square: " + current_square.SquareCoordinate);
            Console.WriteLine("adjcent square: " + adjSquare.SquareCoordinate);
            current_square.AdjacentSquares.Add(adjSquare);
            adjSquare.AdjacentSquares.Add(current_square);




        }
            

       }
}
