using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class krugBrush : Brush
    {


        public krugBrush(Color brushColor, int size)
                   : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            int size = Size;

            for (int y0 = y - size; y0 <= y + size; y0++)
            {
                for (int x0 = x - size; x0 <= x + size; x0++)
                {
                    if (Math.Pow(x0 - x, 2) + Math.Pow(y0 - y, 2) <= Math.Pow(size, 2))
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                }
            }
        }
    }
}
