using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    class EngineForm : IDopElement
    {
        private ElementsEnum engineForm;

        public int SetNumberOfElements
        {
            set
            {
                switch (value)
                {
                    case 1:
                        engineForm = ElementsEnum.Triangle;
                        break;
                    case 2:
                        engineForm = ElementsEnum.Rectangle;
                        break;
                    case 3:
                        engineForm = ElementsEnum.Ellipse;
                        break;
                    default:
                        break;
                }
            }
        }

        public void DrawElement(Graphics g, Color dopColor, float x, float y)
        {
            Brush brush = new SolidBrush(dopColor);
            Pen pen = new Pen(Color.Black);

            if (engineForm == ElementsEnum.Triangle)
            {
                PointF s1 = new PointF(x + 10, y + 20);
                PointF s2 = new PointF(x + 20, y + 7);
                PointF s3 = new PointF(x + 20, y + 40);
                PointF[] points = { s1, s2, s3 };
                g.FillPolygon(brush, points);
                g.DrawLine(pen, x + 10, y + 7, x + 10, y + 40);
            }

            else if (engineForm == ElementsEnum.Rectangle)
            {
                g.FillRectangle(brush, x + 10, y + 15, 10, 20);
                g.DrawLine(pen, x + 10, y + 7, x + 10, y + 40);
            }

            else if (engineForm == ElementsEnum.Ellipse)
            {
                g.FillEllipse(brush, x + 10, y + 15, 10, 20);
                g.DrawLine(pen, x + 10, y + 7, x + 10, y + 40);
            }

        }
    }
}
