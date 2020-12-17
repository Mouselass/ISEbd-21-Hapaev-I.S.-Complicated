using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NLog;

namespace Seaplane
{
    public partial class FormAerodrome : Form
    {
        private readonly AerodromeCollection aerodromeCollection;

        private readonly Queue<Vehicle> planeQueue;

        private readonly Logger logger;

        public FormAerodrome()
        {
            InitializeComponent();
            aerodromeCollection = new AerodromeCollection(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            planeQueue = new Queue<Vehicle>();
            logger = LogManager.GetCurrentClassLogger();
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxAerodrome.SelectedIndex;

            listBoxAerodrome.Items.Clear();
            for (int i = 0; i < aerodromeCollection.Keys.Count; i++)
            {
                listBoxAerodrome.Items.Add(aerodromeCollection.Keys[i]);
            }

            if (listBoxAerodrome.Items.Count > 0 && (index == -1 || index >= listBoxAerodrome.Items.Count))
            {
                listBoxAerodrome.SelectedIndex = 0;
            }
            else if (listBoxAerodrome.Items.Count > 0 && index > -1 && index < listBoxAerodrome.Items.Count)
            {
                listBoxAerodrome.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxAerodrome.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()].Draw(gr);
                pictureBoxAerodrome.Image = bmp;

            }
        }

        private void buttonAddAerodrome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название аэродрома", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            aerodromeCollection.AddAerodrome(textBoxNewLevelName.Text);
            ReloadLevels();
            textBoxNewLevelName.Text = "";
        }

        private void buttonDeleteAerodrome_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrome.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэродром { listBoxAerodrome.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Добавили аэродром {textBoxNewLevelName.Text}");
                    aerodromeCollection.DelAerodrome(listBoxAerodrome.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void buttonLandPlane_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrome.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Plane(100, 1000, dialog.Color);
                    if (aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()] + plane)
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

        private void buttonLandWaterplane_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrome.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var plane = new WaterPlane(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        if (aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()] + plane)
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
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrome.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var plane = aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (plane != null)
                    {
                        logger.Info($"Изъят самолет {plane} с места {maskedTextBox.Text}");
                        planeQueue.Enqueue(plane);
                    }
                    Draw();
                }

                catch (PlaneNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Не найдено");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка");
                }
            }
        }

        private void listBoxAerodrome_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на аэродром {listBoxAerodrome.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonCheckPlanes_Click(object sender, EventArgs e)
        {
            if (planeQueue.Count() > 0)
            {
                FormSeaplane form = new FormSeaplane();
                form.SetPlane(planeQueue.Dequeue());
                form.ShowDialog();
            }
            else
            {              
                MessageBox.Show("Не осталось самолетов для просмотра");
            }
        }

        private void buttonAddPlane_Click(object sender, EventArgs e)
        {
            var formPlaneConfig = new FormPlaneConfig();
            formPlaneConfig.AddEvent(AddPlane);
            formPlaneConfig.Show();
        }

        private void AddPlane(Vehicle plane)
        {
            if (plane != null && listBoxAerodrome.SelectedIndex > -1)
            {
                try
                {
                    if ((aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()]) + plane)
                    {
                        Draw();
                        logger.Info($"Добавлен самолет {plane}");
                    }
                    else
                    {
                        MessageBox.Show("Самолет не удалось поставить");
                    }
                }

                catch (AerodromeOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Переполнение");
                }

                catch (AerodromeAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Дублирование");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка");
                }
            }
        }

        private void СохранитьВсеАэродромыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при сохранении");
                }
            }
        }

        private void СохранитьТолькоВыбранныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.SaveData(saveFileDialog.FileName, listBoxAerodrome.SelectedItem.ToString());
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);

                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при сохранении");
                }
            }           
        }

        private void ЗагрузитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }

                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Файл не найден");
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }

                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Обращение к NULL объекту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Обращение к NULL объекту");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при загрузке");
                }
            }
        }

        private void ЗагрузитьТолькоОдинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.LoadOneStage(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }

                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Файл не найден");
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }

                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Обращение к NULL объекту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Обращение к NULL объекту");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при загрузке");
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxAerodrome.SelectedIndex > -1)
            {
                aerodromeCollection[listBoxAerodrome.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
