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
            //for 
            //int i = - Size; i <= Size i++;
            
        }
 
    }
}


