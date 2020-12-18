using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Seaplane
{
    public class WaterPlane : Plane, IEquatable<WaterPlane>, IComparable<WaterPlane>, IEnumerable<object>, IEnumerator<object>
    {

        public Color DopColor { private set; get; }

        public bool Star { private set; get; }

        public bool Wing { private set; get; }

        public int Floaters { private set; get; }

        public string FloatersForm { private set; get; }

        IDopElement Floater;

        public new LinkedList<object> objectProperties = new LinkedList<object>();

        private int currentIndex = -1;

        public new object Current => objectProperties.Find(currentIndex);

        object IEnumerator<object>.Current => objectProperties.Find(currentIndex);

        public new void Dispose()
        {
        }

        public new bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < 8);
        }

        public new void Reset()
        {
            currentIndex = -1;
        }


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

            objectProperties.AddLast(DopColor);
            objectProperties.AddLast(Star);
            objectProperties.AddLast(Wing);
            objectProperties.AddLast(Floaters);
            objectProperties.AddLast(FloatersForm);
        }

        public WaterPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool wing, bool star) :
            base(maxSpeed, weight, mainColor, 130, 60)
        {
            DopColor = dopColor;
            Wing = wing;
            Star = star;

            objectProperties.AddLast(DopColor);
            objectProperties.AddLast(Star);
            objectProperties.AddLast(Wing);
        }

        public WaterPlane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Star = Convert.ToBoolean(strs[4]);
                Wing = Convert.ToBoolean(strs[5]);
                Floaters = Convert.ToInt32(strs[6]);
                FloatersForm = strs[7];
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

                objectProperties.AddLast(MaxSpeed);
                objectProperties.AddLast(Weight);
                objectProperties.AddLast(MainColor);
                objectProperties.AddLast(DopColor);
                objectProperties.AddLast(Star);
                objectProperties.AddLast(Wing);
                objectProperties.AddLast(Floaters);
                objectProperties.AddLast(FloatersForm);
            }
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

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Star}{separator}{Wing}{separator}{Floaters}{separator}{FloatersForm}";
        }

        public bool Equals(WaterPlane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Star != other.Star)
            {
                return false;
            }
            if (Wing != other.Wing)
            {
                return false;
            }
            if (Floaters != other.Floaters)
            {
                return false;
            }
            if (FloatersForm != other.FloatersForm)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is WaterPlane planeObj))
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }

        public int CompareTo(WaterPlane w)
        {
            if (MaxSpeed != w.MaxSpeed)
            {
                return MaxSpeed.CompareTo(w.MaxSpeed);
            }
            if (Weight != w.Weight)
            {
                return Weight.CompareTo(w.Weight);
            }
            if (MainColor != w.MainColor)
            {
                return MainColor.Name.CompareTo(w.MainColor.Name);
            }
            if (DopColor != w.DopColor)
            {
                return DopColor.Name.CompareTo(w.DopColor.Name);
            }
            if (Star != w.Star)
            {
                return Star.CompareTo(w.Star);
            }
            if (Wing != w.Wing)
            {
                return Wing.CompareTo(w.Wing);
            }
            if (Floaters != w.Floaters)
            {
                return Floaters.CompareTo(w.Floaters);
            }
            if (FloatersForm != w.FloatersForm)
            {
                return FloatersForm.CompareTo(w.FloatersForm);
            }
            return 0;
        }

        public new IEnumerator<object> GetEnumerator()
        {
            return (IEnumerator<object>)objectProperties;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
