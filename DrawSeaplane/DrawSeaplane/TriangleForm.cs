using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    class TriangleForm : IDopElement
    {
        private ElementsEnum engineForm;

        public int SetNumberOfElements { set => engineForm = (ElementsEnum)value; }

        public Color DopColor { private set; get; }

        public TriangleForm(int digit, Color dopColor)
        {
            SetNumberOfElements = digit;
            DopColor = dopColor;
        }

        public void DrawElement(Graphics g, Color dopColor, float x, float y)
        {
            Brush brush = new SolidBrush(dopColor);
            Pen pen = new Pen(Color.Black);
            
            PointF s1 = new PointF(x + 10, y + 20);
            PointF s2 = new PointF(x + 20, y + 7);
            PointF s3 = new PointF(x + 20, y + 40);
            PointF[] points = { s1, s2, s3 };
            g.FillPolygon(brush, points);
            g.DrawLine(pen, x + 10, y + 7, x + 10, y + 40);           
        }
    }
}
