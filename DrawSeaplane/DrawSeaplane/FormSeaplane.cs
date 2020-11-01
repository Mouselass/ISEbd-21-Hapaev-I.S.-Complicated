﻿using System;
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
    public partial class FormSeaplane : Form
    {
        private Plane plane;

        public FormSeaplane()
        {
            InitializeComponent();
            comboBoxFloaters.Items.AddRange(new string[] { "2 поплавка", "4 поплавка", "6 поплавков" });
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plane.DrawTransport(gr);
            pictureBoxPlane.Image = bmp;
        }

        private void ButtonCreatePlane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plane = new Plane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray);
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width, pictureBoxPlane.Height);
            Draw();
        }

        private void ButtonCreateWaterPlane_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int floatersForm = (checkBoxTriangle.Checked && !checkBoxRectangle.Checked && !checkBoxCircle.Checked) ? 1 : 
                (!checkBoxTriangle.Checked && checkBoxRectangle.Checked && !checkBoxCircle.Checked) ? 2 :
                (!checkBoxTriangle.Checked && !checkBoxRectangle.Checked && checkBoxCircle.Checked ? 3 : 0);
            int numberOfFloaters = (comboBoxFloaters.SelectedIndex + 1) * 2;
            plane = new WaterPlane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray, Color.Red, true, true, numberOfFloaters, floatersForm);
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width, pictureBoxPlane.Height);
            Draw();            
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    plane.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    plane.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    plane.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    plane.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }       
    }
}
