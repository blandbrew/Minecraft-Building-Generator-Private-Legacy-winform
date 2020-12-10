using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Minecraft_Building_Generator.UI
{
    class UI_GridPanel
    {
        public Panel gridPanel { get; set; }
        public Font gridPanelFont { get; set; }
        public Pen gridPanelPen { get; set; }
        public SolidBrush gridPanelBrush { get; set; }
        public Graphics gridPanelGraphics { get; set; }
        private int SizeOfGrid;
        UI_Grid_Planning_Rectangle[,] gridPlanner { get; set; }
        public UI_Grid_Planning_Rectangle selectedUIRectangle { get; private set; }
        public enum gridsquare_legend { Initialized, Selected, Infrustructure, Building, Scenery, water};
     

        private SolidBrush brush_Initialized = new SolidBrush(Color.White);
        private SolidBrush brush_Selected = new SolidBrush(Color.Red);
        private SolidBrush brush_Infrustructure = new SolidBrush(Color.Black);
        private SolidBrush brush_Building = new SolidBrush(Color.Gray);
        private SolidBrush brush_Scenery = new SolidBrush(Color.Green);
        private SolidBrush brush_Water = new SolidBrush(Color.Blue);
        private SolidBrush brush_None = new SolidBrush(Color.Purple);


        public UI_GridPanel(Panel aPanel)
        {
            gridPanel = aPanel;
            gridPanelFont = new Font("Roboto", 9);
            gridPanelBrush = new SolidBrush(Color.Black);
            gridPanelPen = new Pen(Color.Black);
        }

        public void DrawGrid(int sizeOfGrid, Graphics gfx)
        {
            gridPanelGraphics = gfx;
            //sets the private value for the size of the grid on this panel
            SizeOfGrid = sizeOfGrid;
            Set_UI_Grid_Container(SizeOfGrid);
            Console.WriteLine(gridPanelGraphics);

        }

        public void UI_Grid_MouseClickEvents(Object sender, MouseEventArgs e)
        {
            Select_Rectangle(e);

        }

        /// <summary>
        /// Provides the logic for selecting grid container markers
        /// </summary>
        /// <param name="e"></param>
        /// <returns><see cref="UI_Grid_Planning_Rectangle"/> selected rectangle</returns>
        private UI_Grid_Planning_Rectangle Select_Rectangle(MouseEventArgs e)
        {
            UI_Grid_Planning_Rectangle rectangle;
            for (int i = 0; i < SizeOfGrid; i++)
            {

                for (int j = 0; j < SizeOfGrid; j++)
                {
                    rectangle = gridPlanner[i, j];

                    if (rectangle.rect.Contains(e.Location))
                    {
                        if (selectedUIRectangle == rectangle)
                        {

                            gridPanelGraphics.FillRectangle(brush_Initialized, rectangle.rect);
                            gridPanelGraphics.FillRectangle(brush_Initialized, selectedUIRectangle.rect);
                            if (selectedUIRectangle.selected == false && rectangle.selected == false)
                            {
                                gridPanelGraphics.FillRectangle(brush_Selected, rectangle.rect);
                                rectangle.selected = true;
                                selectedUIRectangle = rectangle;

                                //set properties 
                            }
                            else
                            {
                                selectedUIRectangle.selected = false;
                                rectangle.selected = false;
                                selectedUIRectangle = rectangle;
                            }

                        }
                        else
                        {
                            //set old selected rectange to false and set it to initialized state
                            selectedUIRectangle.selected = false;
                            gridPanelGraphics.FillRectangle(brush_Initialized, selectedUIRectangle.rect);

                            gridPanelGraphics.FillRectangle(brush_Selected, rectangle.rect);
                            rectangle.selected = true;
                            selectedUIRectangle = rectangle;
                            selectedUIRectangle.i = i;
                            selectedUIRectangle.j = j;

                        }

                        return selectedUIRectangle;
                    }
                }

            }

            return null;

                
            

        }

        /// <summary>
        /// Creates the Grid Panel layout
        /// </summary>
        /// <param name="sizeOfGrid"></param>
        private void Set_UI_Grid_Container(int sizeOfGrid)
        {

            //Grid_production
            int separatorValue = 17;
            int x = 10;
            int y = 10;
            int maxX = 1;
            int maxY = 1;

            //initialize 2d array of grid planner
            gridPlanner = new UI_Grid_Planning_Rectangle[sizeOfGrid, sizeOfGrid];

            for (int i = 0; i < sizeOfGrid; i++)
            {
                gridPanelGraphics.FillRectangle(gridPanelBrush, x, y, 15, 15);

                for (int j = 0; j < sizeOfGrid; j++)
                {

                    Rectangle _rect = new Rectangle(x, y, 15, 15);
                    gridPlanner[i, j] = new UI_Grid_Planning_Rectangle(_rect);
                    gridPanelGraphics.FillRectangle(brush_Initialized, _rect);

                    x += separatorValue;
                }
                maxX = x;
                maxY = y + separatorValue + 10;
                x = 10;
                y += separatorValue;
            }

            gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, maxX, 0); //Draws horizontal graph line
            gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, 1, maxY); //draws vertical graph line

            Point p1 = new Point(maxX + 5, 0);
            gridPanelGraphics.DrawString("East", gridPanelFont, gridPanelBrush, p1);

            Point p2 = new Point(0, maxY + 5);
            gridPanelGraphics.DrawString("South", gridPanelFont, gridPanelBrush, p2);

            selectedUIRectangle = gridPlanner[0, 0];
            selectedUIRectangle.selected = true;
            gridPanelGraphics.FillRectangle(brush_Selected, selectedUIRectangle.rect);
        }

        public void UI_Grid_Square_MouseClickEvents(Object sender, MouseEventArgs e, UI_Grid_Planning_Rectangle selectedContainer)
        {
            Console.WriteLine(selectedContainer.i + " , " + selectedContainer.j);

            UI_Grid_Planning_Rectangle rectangle;
            for (int i = 0; i < SizeOfGrid; i++)
            {

                for (int j = 0; j < SizeOfGrid; j++)
                {
                    rectangle = gridPlanner[i, j];

                    if (rectangle.rect.Contains(e.Location))
                    {
                        if (selectedUIRectangle == rectangle)
                        {

                            gridPanelGraphics.FillRectangle(brush_Initialized, rectangle.rect);
                            gridPanelGraphics.FillRectangle(brush_Initialized, selectedUIRectangle.rect);
                            if (selectedUIRectangle.selected == false && rectangle.selected == false)
                            {
                                gridPanelGraphics.FillRectangle(brush_Selected, rectangle.rect);
                                rectangle.selected = true;
                                selectedUIRectangle = rectangle;

                                //set properties 
                            }
                            else
                            {
                                selectedUIRectangle.selected = false;
                                rectangle.selected = false;
                                selectedUIRectangle = rectangle;
                            }

                        }
                        else
                        {
                            //set old selected rectange to false and set it to initialized state
                            selectedUIRectangle.selected = false;
                            gridPanelGraphics.FillRectangle(brush_Initialized, selectedUIRectangle.rect);

                            gridPanelGraphics.FillRectangle(brush_Selected, rectangle.rect);
                            rectangle.selected = true;
                            selectedUIRectangle = rectangle;

                        }

                        
                    }
                }

            }
        
            }

    }
}
