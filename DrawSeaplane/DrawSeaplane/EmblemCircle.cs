using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    class EmblemCircle : IDopElement
    {
        private ElementsEnum emblem;

        public int SetNumberOfElements
        {
            set
            {
                emblem = ElementsEnum.Circle;
            }
        }

        public void DrawElement(Graphics g, Color dopColor, float x, float y)
        {
            Brush brush = new SolidBrush(dopColor);

            g.FillEllipse(brush, x + 85, y + 15, 25, 18);
        }
    }
}
