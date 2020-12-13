using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minecraft_Building_Generator.UI
{
    class UI_GridPanel
    {
        /**
         * Panel Specific properties
         */
        public Panel gridPanel { get; set; }
        public Font gridPanelFont { get; set; }
        public Pen gridPanelPen { get; set; }
        public SolidBrush gridPanelBrush { get; set; }
        public Graphics gridPanelGraphics { get; set; }



        public UI_Grid_Planning_Container selectedUIRectangle { get; private set; }

        private SolidBrush brush_Initialized = new SolidBrush(Color.White);
        private SolidBrush brush_Selected = new SolidBrush(Color.Red);
        private SolidBrush brush_Infrustructure = new SolidBrush(Color.Black);
        private SolidBrush brush_Building = new SolidBrush(Color.Gray);
        private SolidBrush brush_Scenery = new SolidBrush(Color.Green);
        private SolidBrush brush_Water = new SolidBrush(Color.Blue);
        private SolidBrush brush_None = new SolidBrush(Color.Purple);


        /// <summary>
        /// Creates a new Grid Panel for tracking grid changes
        /// </summary>
        /// <param name="aPanel"></param>
        public UI_GridPanel(Panel aPanel, Graphics gfx)
        {
            gridPanel = aPanel;
            gridPanelFont = new Font("Roboto", 9);
            gridPanelBrush = new SolidBrush(Color.Black);
            gridPanelPen = new Pen(Color.Black);
            gridPanelGraphics = gfx;
        }





        ///// <summary>
        ///// Draws the UI Grid for Containers and Contains All UI_Grid_Containers and associated grid squares
        ///// </summary>
        ///// <param name="sizeOfGrid"></param>
        //public void Draw_UI_Grid(int sizeOfGrid, UI_Grid_Planning_Container[,] UI_Grid_Containers)
        //{


        //    //Grid_production
        //    int separatorValue = 17;
        //    int x = 10;
        //    int y = 10;
        //    int maxX = 1;
        //    int maxY = 1;

        //    //initialize 2d array of grid planner
        //    UI_Grid_Containers = new UI_Grid_Planning_Container[sizeOfGrid, sizeOfGrid];

        //    for (int i = 0; i < sizeOfGrid; i++)
        //    {
        //        gridPanelGraphics.FillRectangle(gridPanelBrush, x, y, 15, 15);

        //        for (int j = 0; j < sizeOfGrid; j++)
        //        {

        //            Rectangle _rect = new Rectangle(x, y, 15, 15);
        //            UI_Grid_Containers[i, j] = new UI_Grid_Planning_Container(_rect);
        //            gridPanelGraphics.FillRectangle(brush_Initialized, _rect);

        //            x += separatorValue;
        //        }
        //        maxX = x;
        //        maxY = y + separatorValue + 10;
        //        x = 10;
        //        y += separatorValue;
        //    }

        //    gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, maxX, 0); //Draws horizontal graph line
        //    gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, 1, maxY); //draws vertical graph line

        //    Point p1 = new Point(maxX + 5, 0);
        //    gridPanelGraphics.DrawString("East", gridPanelFont, gridPanelBrush, p1);

        //    Point p2 = new Point(0, maxY + 5);
        //    gridPanelGraphics.DrawString("South", gridPanelFont, gridPanelBrush, p2);

        //    selectedUIRectangle = UI_Grid_Containers[0, 0];
        //    selectedUIRectangle.selected = true;
        //    gridPanelGraphics.FillRectangle(brush_Selected, selectedUIRectangle.rect);
        //}


        /// <summary>
        /// Creates the Grid Panel layout for Grid Squares
        /// </summary>

        public void Initialize_UI_Grid(int sizeOfGrid, UI_Grid_Planning_Container[,] UI_Grid_Containers)
        {
            //gridPanelGraphics = gfx;

            //Grid_production
            int separatorValue = 17;
            int x = 10;
            int y = 10;
            int maxX = 1;
            int maxY = 1;

            //initialize 2d array of grid planner

            //aContainerOfSquares.UI_Grid_Planning_Squares = new UI_Grid_Planning_Square[Shared_Constants.GRID_SQUARE_SIZE, Shared_Constants.GRID_SQUARE_SIZE];

            for (int i = 0; i < sizeOfGrid; i++)
            {
                for (int j = 0; j < sizeOfGrid; j++)
                {
                    gridPanelGraphics.FillRectangle(gridPanelBrush, x, y, 15, 15);
                    UI_Grid_Planning_Square[,] _uiGridSquares = UI_Grid_Containers[i, j].UI_Grid_Planning_Squares;

                    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
                    {
                        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
                        {
                            Rectangle _rect = new Rectangle(x, y, 15, 15);
                            _uiGridSquares[m, n] = new UI_Grid_Planning_Square(_rect);
                            gridPanelGraphics.FillRectangle(brush_Initialized, _rect);

                            x += separatorValue;
                        }

                        maxX = x;
                        maxY = y + separatorValue + 10;
                        x = 10;
                        y += separatorValue;
                    }

                }

            }

            gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, maxX, 0); //Draws horizontal graph line
            gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, 1, maxY); //draws vertical graph line

            Point p1 = new Point(maxX + 5, 0);
            gridPanelGraphics.DrawString("East", gridPanelFont, gridPanelBrush, p1);

            Point p2 = new Point(0, maxY + 5);
            gridPanelGraphics.DrawString("South", gridPanelFont, gridPanelBrush, p2);

        }



        ///// <summary>
        ///// Intalizes UI Grid Squares
        ///// </summary>
        ///// <param name="UI_Grid_Container"></param>
        ///// <param name="gfx"></param>
        //public void Initialize_UI_Grid(UI_Grid_Planning_Container UI_Grid_Container, Graphics gfx)
        //{
        //    gridPanelGraphics = gfx;
        //    bool squareSelected = false;

        //    //Grid_production
        //    int separatorValue = 17;
        //    int x = 10;
        //    int y = 10;
        //    int maxX = 1;
        //    int maxY = 1;

        //    gridPanelGraphics.FillRectangle(gridPanelBrush, x, y, 15, 15);
        //    UI_Grid_Planning_Square[,] _uiGridSquares = UI_Grid_Container.UI_Grid_Planning_Squares;

        //    for (int m = 0; m < Shared_Constants.GRID_SQUARE_SIZE; m++)
        //    {
        //        for (int n = 0; n < Shared_Constants.GRID_SQUARE_SIZE; n++)
        //        {
        //            if (_uiGridSquares[m, n].Selected)//or may need null test
        //            {
        //                Rectangle _rect = new Rectangle(x, y, 15, 15);
        //                gridPanelGraphics.FillRectangle(brush_Selected, _rect);
        //                squareSelected = true;
        //            }
        //            else
        //            {
        //                Rectangle _rect = new Rectangle(x, y, 15, 15);
        //                _uiGridSquares[m, n] = new UI_Grid_Planning_Square(_rect);
        //                gridPanelGraphics.FillRectangle(brush_Initialized, _rect);
        //            }


        //            x += separatorValue;
        //        }

        //        maxX = x;
        //        maxY = y + separatorValue + 10;
        //        x = 10;
        //        y += separatorValue;
        //    }

        //    gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, maxX, 0); //Draws horizontal graph line
        //    gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, 1, maxY); //draws vertical graph line

        //    Point p1 = new Point(maxX + 5, 0);
        //    gridPanelGraphics.DrawString("East", gridPanelFont, gridPanelBrush, p1);

        //    Point p2 = new Point(0, maxY + 5);
        //    gridPanelGraphics.DrawString("South", gridPanelFont, gridPanelBrush, p2);

        //    if (!squareSelected)
        //    {
        //        _uiGridSquares[0, 0].Selected = true;

        //        gridPanelGraphics.FillRectangle(brush_Selected, selectedUIRectangle.rect);
        //    }

        //}


        public void Fill_Rectangle(GridSquare_Zoning fillType, Rectangle rect)
        {
            switch (fillType)
            {
                case GridSquare_Zoning.Initialized:
                    gridPanelGraphics.FillRectangle(brush_Initialized, rect);
                    break;
                case GridSquare_Zoning.Selected:
                    gridPanelGraphics.FillRectangle(brush_Selected, rect);
                    break;
                case GridSquare_Zoning.Infrustructure:
                    gridPanelGraphics.FillRectangle(brush_Infrustructure, rect);
                    break;
                case GridSquare_Zoning.Building:
                    gridPanelGraphics.FillRectangle(brush_Building, rect);
                    break;
                case GridSquare_Zoning.Scenery:
                    gridPanelGraphics.FillRectangle(brush_Scenery, rect);
                    break;
                case GridSquare_Zoning.Water:
                    gridPanelGraphics.FillRectangle(brush_Water, rect);
                    break;
                case GridSquare_Zoning.None:
                    gridPanelGraphics.FillRectangle(brush_None, rect);
                    break;

            }
        }






        public void UI_Grid_Square_MouseClickEvents(Object sender, MouseEventArgs e, UI_Grid_Planning_Container selectedContainer)
        {


            //UI_Grid_Planning_Container rectangle;
            //for (int i = 0; i < SizeOfGrid; i++)
            //{
            //    for (int j = 0; j < SizeOfGrid; j++)
            //    {
            //        rectangle = gridPlanner_Container[i, j];

            //        if (rectangle.rect.Contains(e.Location))
            //        {
            //            if (rectangle.selected)
            //            {
            //                Console.WriteLine("selected already");
            //                gridPanelGraphics.FillRectangle(brush_Initialized, rectangle.rect);
            //                rectangle.selected = false;
            //            }
            //            else
            //            {
            //                Console.WriteLine("not selected");
            //                gridPanelGraphics.FillRectangle(brush_Selected, rectangle.rect);
            //                rectangle.selected = true;
            //            }

            //        }
            //    }

            //}

        }

    }
}
