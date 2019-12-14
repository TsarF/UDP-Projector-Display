using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDPProjectorDisplay
{
    class DisplayComponent
    {
        public string Name = "";
        public int X, Y = 0;
        public int size = 0;
        public string contents = "";
        public string ColorHEX = "FFFFFF";
        public Color MainColor = Color.FromArgb(255, 255, 255);
    }
}