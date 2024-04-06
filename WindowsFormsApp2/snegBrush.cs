using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class snegBrush : Brush
    {
        public snegBrush(Color brushColor, int size)
                : base(brushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            int size = Size;

            // Рисуем вертикальную линию
            for (int y0 = y - size; y0 <= y + size; y0++)
            {
                image.SetPixel(x, y0, BrushColor);
            }

            // Рисуем горизонтальную линию
            for (int x0 = x - size; x0 <= x + size; x0++)
            {
                image.SetPixel(x0, y, BrushColor);
            }

            // Рисуем диагональные линии
            for (int i = 1; i <= size; i++)
            {
                image.SetPixel(x - i, y - i, BrushColor);
                image.SetPixel(x + i, y - i, BrushColor);
                image.SetPixel(x - i, y + i, BrushColor);
                image.SetPixel(x + i, y + i, BrushColor);
            }

            // Рисуем точку в центре
            image.SetPixel(x, y, BrushColor);
        }
    }
}
    
