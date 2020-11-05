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

        private void ButtonComparePlanes_Click(object sender, EventArgs e)
        {
            if (aerodrome >= Convert.ToInt32(maskedTextBoxCompare.Text))
            {
                MessageBox.Show("Количество самолетов больше или равно введенному числу");
            }
            else
            {
                MessageBox.Show("Количество самолетов меньше, чем введенное число");
            }            
        }
        private void ButtonCompareWaterPlanes_Click(object sender, EventArgs e)
        {
            if (aerodrome <= Convert.ToInt32(maskedTextBoxCompare.Text))
            {
                MessageBox.Show("Количество гидросамолетов больше или равно введенному числу");
            }
            else
            {
                MessageBox.Show("Количество гидросамолетов меньше, чем введенное число");
            }           
        }
    }
}
