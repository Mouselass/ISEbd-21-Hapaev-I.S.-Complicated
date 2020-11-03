using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seaplane
{
    public partial class FormAerodrome : Form
    {
        private readonly Aerodrome<Plane, CircleForm> aerodrome;

        public FormAerodrome()
        {
            InitializeComponent();
            aerodrome = new Aerodrome<Plane, CircleForm>(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aerodrome.Draw(gr);
            pictureBoxAerodrome.Image = bmp;
        }

        private void buttonLandPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);
                if (aerodrome + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Недостаточно мест");
                }
            }
        }

        private void buttonLandWaterplane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new WaterPlane(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (aerodrome + plane)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно мест");
                    }
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var plane = aerodrome - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    FormSeaplane form = new FormSeaplane();
                    form.SetPlane(plane);

                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void ButtonSortPlanes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aerodrome._places.Length - 1; i++)
            {
                for (int j = 0; j < aerodrome._places.Length - 1; j++)
                {
                    if (aerodrome >= j)
                    {
                        aerodrome.SwapPlane(j, j + 1);
                    }
                }
            }
            Draw();
        }
        private void ButtonSortWaterPlanes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aerodrome._places.Length - 1; i++)
            {
                for (int j = 0; j < aerodrome._places.Length - 1; j++)
                {
                    if (aerodrome <= j)
                    {
                        aerodrome.SwapPlane(j, j + 1);
                    }
                }
            }
            Draw();
        }
    }
}
