using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    class Floaters : IDopElement
    {
        private ElementsEnum floaters;

        public int SetNumberOfElements
        {
            set
            {
                switch (value)
                {
                    case 2:
                        floaters = ElementsEnum.Two;
                        break;
                    case 4:
                        floaters = ElementsEnum.Four;
                        break;
                    case 6:
                        floaters = ElementsEnum.Six;
                        break;
                }
            }
        }

        public void DrawElement(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            if (floaters == ElementsEnum.Two)
            {
                DrawTwoFloaters(g, dopColor, _startPosX, _startPosY);
            }
            else if (floaters == ElementsEnum.Four)
            {
                DrawFourFloaters(g, dopColor, _startPosX, _startPosY);
            }
            else if (floaters == ElementsEnum.Six)
            {
                DrawSixFloaters(g, dopColor, _startPosX, _startPosY);
            }
        }


        private void DrawTwoFloaters(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Brush floater = new SolidBrush(dopColor);

            PointF f1 = new PointF(_startPosX + 30, _startPosY + 40);
            PointF f2 = new PointF(_startPosX + 30, _startPosY + 45);
            PointF f3 = new PointF(_startPosX, _startPosY + 45);
            PointF f4 = new PointF(_startPosX + 10, _startPosY + 55);
            PointF f5 = new PointF(_startPosX + 70, _startPosY + 55);
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

        private void DrawFourFloaters(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Brush floater = new SolidBrush(dopColor);

            DrawTwoFloaters(g, dopColor, _startPosX, _startPosY);

            PointF f1 = new PointF(_startPosX + 30, _startPosY + 50);
            PointF f2 = new PointF(_startPosX + 30, _startPosY + 55);
            PointF f3 = new PointF(_startPosX, _startPosY + 55);
            PointF f4 = new PointF(_startPosX + 10, _startPosY + 65);
            PointF f5 = new PointF(_startPosX + 70, _startPosY + 65);
            PointF f6 = new PointF(_startPosX + 120, _startPosY + 55);
            PointF f7 = new PointF(_startPosX + 70, _startPosY + 55);
            PointF f8 = new PointF(_startPosX + 70, _startPosY + 50);
            PointF f9 = new PointF(_startPosX + 65, _startPosY + 50);
            PointF f10 = new PointF(_startPosX + 65, _startPosY + 55);
            PointF f11 = new PointF(_startPosX + 35, _startPosY + 55);
            PointF f12 = new PointF(_startPosX + 35, _startPosY + 50);
            PointF f13 = new PointF(_startPosX + 30, _startPosY + 50);

            PointF[] floaterP = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13 };
            g.FillPolygon(floater, floaterP);

        }

        private void DrawSixFloaters(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Brush floater = new SolidBrush(dopColor);

            DrawFourFloaters(g, dopColor, _startPosX, _startPosY);

            PointF f1 = new PointF(_startPosX + 30, _startPosY + 60);
            PointF f2 = new PointF(_startPosX + 30, _startPosY + 65);
            PointF f3 = new PointF(_startPosX, _startPosY + 65);
            PointF f4 = new PointF(_startPosX + 10, _startPosY + 75);
            PointF f5 = new PointF(_startPosX + 70, _startPosY + 75);
            PointF f6 = new PointF(_startPosX + 120, _startPosY + 65);
            PointF f7 = new PointF(_startPosX + 70, _startPosY + 65);
            PointF f8 = new PointF(_startPosX + 70, _startPosY + 60);
            PointF f9 = new PointF(_startPosX + 65, _startPosY + 60);
            PointF f10 = new PointF(_startPosX + 65, _startPosY + 65);
            PointF f11 = new PointF(_startPosX + 35, _startPosY + 65);
            PointF f12 = new PointF(_startPosX + 35, _startPosY + 60);
            PointF f13 = new PointF(_startPosX + 30, _startPosY + 60);

            PointF[] floaterP = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13 };
            g.FillPolygon(floater, floaterP);

        }
    }
}