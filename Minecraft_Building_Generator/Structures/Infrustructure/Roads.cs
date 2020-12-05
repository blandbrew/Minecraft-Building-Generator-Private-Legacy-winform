﻿using Minecraft_Building_Generator.Grid_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Building_Generator.Structures.Infrustructure
{
    public class Roads
    {
        /**
         * City Generator roads will consume 1 Grid_Square.
         * 
         */
        Coordinate StartPoint;
        int Width { get; set; } = 4;
        int SidewalkWidth { get; set; } = 2;

    }
}