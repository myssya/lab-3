using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class BalonBrush : Brush
    {


        public BalonBrush(Color brushColor, int size)
                   : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            int size = Size;
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int offsetX = random.Next(-size, size);
                int offsetY = random.Next(-size, size);

                int pixelX = x + offsetX;
                int pixelY = y + offsetY;

                if (pixelX >= 0 && pixelX < image.Width && pixelY >= 0 && pixelY < image.Height)
                {
                    image.SetPixel(pixelX, pixelY, BrushColor);
                }
            }
        }
    }
}
