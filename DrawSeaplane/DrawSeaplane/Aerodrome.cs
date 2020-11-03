using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    public class Aerodrome<T, P> where T : class, ITransport where P : class, IDopElement
    {
        public readonly T[] _places;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 250;

        private readonly int _placeSizeHeight = 80;

        public Aerodrome(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Aerodrome<T, P> a, T plane)
        {
            for (int i = 0; i < a._places.Length; i++)
            {
                if (a._places[i] == null)
                {
                    plane.SetPosition(10 + a._placeSizeWidth * (int)(i / (int)(a.pictureHeight / a._placeSizeHeight)), 10 + a._placeSizeHeight * (int)(i % (int)(a.pictureHeight / a._placeSizeHeight)), a.pictureWidth, a.pictureHeight);
                    a._places[i] = plane;
                    return true;
                }
            }
            return false;
        }

        public static T operator -(Aerodrome<T, P> a, int index)
        {
            if ((index < a._places.Length) && (index >= 0))
            {
                T plane = a._places[index];
                a._places[index] = null;
                return plane;
            }
            return null;
        }

        public static bool operator >=(Aerodrome<T, P> a, int index)
        {
            if (index > -1 && index < a._places.Length - 1)
            {
                if (a._places[index] is WaterPlane && a._places[index + 1] is Plane)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator <=(Aerodrome<T, P> a, int index)
        {
            if (index > -1 && index < a._places.Length - 1)
            {
                if (a._places[index] is Plane && a._places[index + 1] is WaterPlane)
                {
                    return true;
                }
            }
            return false;
        }

        public void SwapPlane(int firstIndex, int secondIndex)
        {
            if ((firstIndex >= 0 && firstIndex < _places.Length) && (secondIndex >= 0 && secondIndex < _places.Length))
            {
                var temp = _places[firstIndex];
                _places[firstIndex] = _places[secondIndex];
                _places[secondIndex] = temp;
                _places[firstIndex].SetPosition(10 + _placeSizeWidth * (int)(firstIndex / (int)(pictureHeight / _placeSizeHeight)),
                        10 + _placeSizeHeight * (int)(firstIndex % (int)(pictureHeight / _placeSizeHeight)), pictureWidth, pictureHeight);
                _places[secondIndex].SetPosition(10 + _placeSizeWidth * (int)(secondIndex / (int)(pictureHeight / _placeSizeHeight)),
                        10 + _placeSizeHeight * (int)(secondIndex % (int)(pictureHeight / _placeSizeHeight)), pictureWidth, pictureHeight);
            }
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }

                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}