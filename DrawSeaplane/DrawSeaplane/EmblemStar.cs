using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    class EmblemStar : IDopElement
    {
        private ElementsEnum emblem;

        public int SetNumberOfElements
        {
            set
            {
                emblem = ElementsEnum.Star;
            }
        }

        public void DrawElement(Graphics g, Color dopColor, float x, float y)
        {
            Brush brush = new SolidBrush(dopColor);

            PointF s1 = new PointF(x + 85, y + 24);
            PointF s2 = new PointF(x + 92, y + 22);
            PointF s3 = new PointF(x + 100, y + 17);
            PointF s4 = new PointF(x + 108, y + 22);
            PointF s5 = new PointF(x + 115, y + 24);
            PointF s6 = new PointF(x + 107, y + 29);
            PointF s7 = new PointF(x + 110, y + 33);
            PointF s8 = new PointF(x + 100, y + 31);
            PointF s9 = new PointF(x + 90, y + 34);
            PointF s10 = new PointF(x + 92, y + 29);

            PointF[] starP = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
            g.FillPolygon(brush, starP);
        }
    }
}
