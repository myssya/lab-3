using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class snegBrush : Brush
    {
        PictureBox _pictureBox;
        public snegBrush(Color brushColor, int size, PictureBox pictureBox)
                : base(brushColor, size)
        {
            _pictureBox = pictureBox;
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            int size = Size;

            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                image.SetPixel(x, y0, BrushColor);
            }

            for (int x0 = x - Size; x0 < x + Size; ++x0)
            {
                image.SetPixel(x0, y, BrushColor);
            }
            for (int i = 1; i <= Size; i++)
            {
                image.SetPixel(x - i, y - i, BrushColor);
                image.SetPixel(x + i, y - i, BrushColor);
                image.SetPixel(x - i, y + i, BrushColor);
                image.SetPixel(x + i, y + i, BrushColor);
            }
        }
 
    }
}


