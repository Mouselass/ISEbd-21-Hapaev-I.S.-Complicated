using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    class RectangleForm : IDopElement
    {
        private ElementsEnum floatersForm;

        public int SetNumberOfElements { set => floatersForm = (ElementsEnum)value; }

        public Color DopColor { private set; get; }

        public RectangleForm(int digit, Color dopColor)
        {
            SetNumberOfElements = digit;
            DopColor = dopColor;
        }

        public void DrawElement(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            switch (floatersForm)
            {
                case ElementsEnum.Two:
                    DrawTwoFloaters(g, _startPosX, _startPosY);
                    break;

                case ElementsEnum.Four:
                    DrawFourFloaters(g, _startPosX, _startPosY);
                    break;

                case ElementsEnum.Six:
                    DrawSixFloaters(g, _startPosX, _startPosY);
                    break;
            }
            
        }

        private void DrawTwoFloaters(Graphics g, float _startPosX, float _startPosY)
        {
            Brush floater = new SolidBrush(DopColor);

            PointF f1 = new PointF(_startPosX + 30, _startPosY + 40);
            PointF f2 = new PointF(_startPosX + 30, _startPosY + 45);
            PointF f3 = new PointF(_startPosX + 10, _startPosY + 45);
            PointF f4 = new PointF(_startPosX + 10, _startPosY + 55);
            PointF f5 = new PointF(_startPosX + 120, _startPosY + 55);
            PointF f6 = new PointF(_startPosX + 120, _startPosY + 45);
            PointF f7 = new PointF(_startPosX + 70, _startPosY + 45);
            PointF f8 = new PointF(_startPosX + 70, _startPosY + 40);
            PointF f9 = new PointF(_startPosX + 65, _startPosY + 40);
            PointF f10 = new PointF(_startPosX + 65, _startPosY + 45);
            PointF f11 = new PointF(_startPosX + 35, _startPosY + 45);
            PointF f12 = new PointF(_startPosX + 35, _startPosY + 40);
            PointF f13 = new PointF(_startPosX + 30, _startPosY + 40);

            PointF[] floaterP = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13 };
            g.FillPolygon(floater, floaterP);
        }

        private void DrawFourFloaters(Graphics g, float _startPosX, float _startPosY)
        {
            DrawTwoFloaters(g, _startPosX, _startPosY);

            Brush floater = new SolidBrush(DopColor);

            PointF f1 = new PointF(_startPosX + 30, _startPosY + 52);
            PointF f2 = new PointF(_startPosX + 30, _startPosY + 57);
            PointF f3 = new PointF(_startPosX + 10, _startPosY + 57);
            PointF f4 = new PointF(_startPosX + 10, _startPosY + 67);
            PointF f5 = new PointF(_startPosX + 120, _startPosY + 67);
            PointF f6 = new PointF(_startPosX + 120, _startPosY + 57);
            PointF f7 = new PointF(_startPosX + 70, _startPosY + 57);
            PointF f8 = new PointF(_startPosX + 70, _startPosY + 52);
            PointF f9 = new PointF(_startPosX + 65, _startPosY + 52);
            PointF f10 = new PointF(_startPosX + 65, _startPosY + 57);
            PointF f11 = new PointF(_startPosX + 35, _startPosY + 57);
            PointF f12 = new PointF(_startPosX + 35, _startPosY + 52);
            PointF f13 = new PointF(_startPosX + 30, _startPosY + 52);

            PointF[] floaterP = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13 };
            g.FillPolygon(floater, floaterP);
        }

        private void DrawSixFloaters(Graphics g, float _startPosX, float _startPosY)
        {
            DrawFourFloaters(g, _startPosX, _startPosY);

            Brush floater = new SolidBrush(DopColor);

            PointF f1 = new PointF(_startPosX + 30, _startPosY + 64);
            PointF f2 = new PointF(_startPosX + 30, _startPosY + 69);
            PointF f3 = new PointF(_startPosX + 10, _startPosY + 69);
            PointF f4 = new PointF(_startPosX + 10, _startPosY + 79);
            PointF f5 = new PointF(_startPosX + 120, _startPosY + 79);
            PointF f6 = new PointF(_startPosX + 120, _startPosY + 69);
            PointF f7 = new PointF(_startPosX + 70, _startPosY + 69);
            PointF f8 = new PointF(_startPosX + 70, _startPosY + 64);
            PointF f9 = new PointF(_startPosX + 65, _startPosY + 64);
            PointF f10 = new PointF(_startPosX + 65, _startPosY + 69);
            PointF f11 = new PointF(_startPosX + 35, _startPosY + 69);
            PointF f12 = new PointF(_startPosX + 35, _startPosY + 64);
            PointF f13 = new PointF(_startPosX + 30, _startPosY + 64);

            PointF[] floaterP = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13 };
            g.FillPolygon(floater, floaterP);
        }
    }
}
