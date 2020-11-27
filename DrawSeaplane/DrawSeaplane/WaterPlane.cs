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

        public int Floaters { private set; get; }

        public string FloatersForm { private set; get; }

        IDopElement Floater;

        public void SetDopColor(Color color) 
        {
            DopColor = color;

            if (FloatersForm == "CircleForm")
            {
                Floater = new CircleForm(Floaters, DopColor);
            }
            else if (FloatersForm == "RectangleForm")
            {
                Floater = new RectangleForm(Floaters, DopColor);
            }
            else if (FloatersForm == "TriangleForm")
            {
                Floater = new TriangleForm(Floaters, DopColor);
            }
        }

        public void SetFloater(IDopElement floater)
        {
            Floater = floater;
            FloatersForm = Floater.GetType().Name;
        }

        public void SetNumberOfFloaters(int numberOfFloaters)
        {
            Floaters = numberOfFloaters;
        }

        public WaterPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool wing, bool star, int numberOfFloaters, string floatersForm) :
            base(maxSpeed, weight, mainColor, 130, 60)
        {
            DopColor = dopColor;
            Wing = wing;
            Star = star;
            Floaters = numberOfFloaters;
            FloatersForm = floatersForm;

            if (FloatersForm == "TriangleForm")
            {
                Floater = new TriangleForm(Floaters, DopColor);
            }
            else if (FloatersForm == "RectangleForm")
            {
                Floater = new RectangleForm(Floaters, DopColor);
            }
            else if (FloatersForm == "CircleForm")
            {
                Floater = new CircleForm(Floaters, DopColor);
            }

        }

        public WaterPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool wing, bool star) :
            base(maxSpeed, weight, mainColor, 130, 60)
        {
            DopColor = dopColor;
            Wing = wing;
            Star = star;
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

            if (Star)
            {
                Brush star = new SolidBrush(DopColor);

                PointF s1 = new PointF(_startPosX + 85, _startPosY + 24);
                PointF s2 = new PointF(_startPosX + 92, _startPosY + 22);
                PointF s3 = new PointF(_startPosX + 100, _startPosY + 17);
                PointF s4 = new PointF(_startPosX + 108, _startPosY + 22);
                PointF s5 = new PointF(_startPosX + 115, _startPosY + 24);
                PointF s6 = new PointF(_startPosX + 107, _startPosY + 29);
                PointF s7 = new PointF(_startPosX + 110, _startPosY + 33);
                PointF s8 = new PointF(_startPosX + 100, _startPosY + 31);
                PointF s9 = new PointF(_startPosX + 90, _startPosY + 34);
                PointF s10 = new PointF(_startPosX + 92, _startPosY + 29);

                PointF[] starP = { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
                g.FillPolygon(star, starP);
            }

            if (Floater != null)
            {
                Floater.DrawElement(g, DopColor, _startPosX, _startPosY);
            }
        }
    }
}
