using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing; //For the use of the Color Variable

namespace Mouseio
{
    class ChangeColor
    {
         public ChangeColor(Color[] colors)
        {
            change_color_ushort = 0;
            change_color_array = colors;

        }
        public ChangeColor():this( new Color[5] { Color.Red, Color.Black, Color.Blue, Color.Green, Color.Orange })
        {

        }

        public void changeColor()
        {
            change_color_ushort = (ushort)((++change_color_ushort) % change_color_array.Length);
        }

        public Color returnColor()
        {
            return change_color_array[change_color_ushort];
        }


        private ushort change_color_ushort;
        private Color[] change_color_array;
    }
}
