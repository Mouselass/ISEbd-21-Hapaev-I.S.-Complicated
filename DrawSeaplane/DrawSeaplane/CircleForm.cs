using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    class CircleForm : IDopElement
    {
        private ElementsEnum engineForm;

        public int SetNumberOfElements { set => engineForm = (ElementsEnum)value; }

        public Color DopColor { private set; get; }

        public CircleForm(int digit, Color dopColor)
        {
            SetNumberOfElements = digit;
            DopColor = dopColor;
        }

        public void DrawElement(Graphics g, Color dopColor, float x, float y)
        {
            Brush brush = new SolidBrush(dopColor);
            Pen pen = new Pen(Color.Black);

            g.FillEllipse(brush, x + 10, y + 15, 10, 20);
            g.DrawLine(pen, x + 10, y + 7, x + 10, y + 40);
        }
    }
}
