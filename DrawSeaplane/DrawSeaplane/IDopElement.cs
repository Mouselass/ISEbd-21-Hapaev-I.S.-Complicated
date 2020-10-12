using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seaplane
{
    public interface IDopElement
    {
        int SetNumberOfElements { set; }

        void DrawElement(Graphics g, Color dopColor, float x, float y);
    }
}
