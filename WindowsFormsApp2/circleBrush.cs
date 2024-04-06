using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class CircleBrush : Brush
    {
        public CircleBrush(Color brushColor, int size)
                : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                image.SetPixel(x, y0, BrushColor);
            }

            for (int x0 = x - Size; x0 < x + Size; ++x0)
            {
                image.SetPixel(x0, y, BrushColor);
            }
        }
    }
}
    



