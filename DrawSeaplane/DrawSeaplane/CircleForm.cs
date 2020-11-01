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
        private ElementsEnum floatersForm;

        public int SetNumberOfElements { set => floatersForm = (ElementsEnum)value; }

        public Color DopColor { private set; get; }

        public CircleForm(int digit, Color dopColor)
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

            g.FillRectangle(floater, _startPosX + 30, _startPosY + 40, 5, 10);
            g.FillRectangle(floater, _startPosX + 65, _startPosY + 40, 5, 10);
            g.FillEllipse(floater, _startPosX + 10, _startPosY + 45, 110, 15);
        }

        private void DrawFourFloaters(Graphics g, float _startPosX, float _startPosY)
        {
            DrawTwoFloaters(g, _startPosX, _startPosY);

            Brush floater = new SolidBrush(DopColor);

            g.FillRectangle(floater, _startPosX + 30, _startPosY + 40, 5, 10);
            g.FillRectangle(floater, _startPosX + 65, _startPosY + 40, 5, 10);
            g.FillEllipse(floater, _startPosX + 10, _startPosY + 55, 110, 15);
        }

        private void DrawSixFloaters(Graphics g, float _startPosX, float _startPosY)
        {
            DrawFourFloaters(g, _startPosX, _startPosY);

            Brush floater = new SolidBrush(DopColor);

            g.FillRectangle(floater, _startPosX + 30, _startPosY + 40, 5, 10);
            g.FillRectangle(floater, _startPosX + 65, _startPosY + 40, 5, 10);
            g.FillEllipse(floater, _startPosX + 10, _startPosY + 65, 110, 15);
        }
    }
}
