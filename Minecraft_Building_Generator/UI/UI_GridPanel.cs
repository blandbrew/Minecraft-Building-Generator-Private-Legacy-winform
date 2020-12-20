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

        private SolidBrush brush_Initialized = new SolidBrush(Color.White);
        private SolidBrush brush_Selected = new SolidBrush(Color.Red);
        private SolidBrush brush_Infrustructure = new SolidBrush(Color.Black);
        private SolidBrush brush_Building = new SolidBrush(Color.Gray);
        private SolidBrush brush_Scenery = new SolidBrush(Color.Green);
        private SolidBrush brush_Water = new SolidBrush(Color.Blue);
        private SolidBrush brush_None = new SolidBrush(Color.Purple);

        public int GraphMax_X { get; set; }
        public int GraphMax_Y { get; set; }

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

        public void DrawAxis()
        {
            gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, GraphMax_X, 0); //Draws horizontal graph line
            gridPanelGraphics.DrawLine(gridPanelPen, 1, 0, 1, GraphMax_Y); //draws vertical graph line
        }


        /// <summary>
        /// Draw a string at a specific point
        /// </summary>
        /// <param name="direction"></param>
        public void DrawAxisLabel(string text, Point p1)
        {
            gridPanelGraphics.DrawString(text, gridPanelFont, gridPanelBrush, p1);
          
        }

        /// <summary>
        /// Draws the default axis labels for East and South
        /// </summary>
        public void DrawAxisLabel()
        {
            gridPanelGraphics.DrawString("East", gridPanelFont, gridPanelBrush, new Point(GraphMax_X, 0));
            gridPanelGraphics.DrawString("South", gridPanelFont, gridPanelBrush, new Point(0, GraphMax_Y));
        }









        //public void DrawSomething()
        //{
        //    Fill_Rectangle(GridSquare_Zoning.Initialized, new Rectangle(8,4,30,30));

        //    //gridPanel.Clic
        //        //gridPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(gridPanel_MouseClick);
        //}

        //public void gridPanel_MouseClick(object sender, EventArgs e)
        //{
        //    Console.WriteLine("MOUSE CLICKIN");
        //}






    }
}
