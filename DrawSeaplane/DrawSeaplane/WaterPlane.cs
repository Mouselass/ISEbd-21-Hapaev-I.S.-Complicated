using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    public class WaterPlane : Plane
    {

        public Color DopColor { private set; get; }

        public bool Star { private set; get; }

        public bool Wing { private set; get; }

        IDopElement Floaters = new Floaters();

        IDopElement EngineForm = new EngineForm();

        IDopElement Emblem;

        public WaterPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool wing, int floatersCount, int engineform, string emblem) :
            base(maxSpeed, weight, mainColor, 130, 60)
        {
            DopColor = dopColor;
            Wing = wing;
            Floaters.SetNumberOfElements = floatersCount;
            EngineForm.SetNumberOfElements = engineform;
            if (emblem == "Star")
                Emblem = new EmblemStar();
            else if (emblem == "Circle")
                Emblem = new EmblemCircle();
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            
            if (Wing)
            {
                Brush wing = new SolidBrush(DopColor);


                PointF w6 = new PointF(_startPosX + 50, _startPosY + 13);
                PointF w7 = new PointF(_startPosX + 80, _startPosY + 33);
                PointF w8 = new PointF(_startPosX + 87, _startPosY + 28);
                PointF w9 = new PointF(_startPosX + 55, _startPosY + 10);
                PointF w10 = new PointF(_startPosX + 50, _startPosY + 13);

                PointF[] dopWingP = { w6, w7, w8, w9, w10 };
                g.FillPolygon(wing, dopWingP);
            }


            Floaters.DrawElement(g, DopColor, _startPosX, _startPosY);

            EngineForm.DrawElement(g, DopColor, _startPosX, _startPosY);

            Emblem.DrawElement(g, DopColor, _startPosX, _startPosY);
        }
    }
}
