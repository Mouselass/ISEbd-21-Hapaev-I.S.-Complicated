namespace Seaplane
{
    partial class FormSeaplane
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreatePlane = new System.Windows.Forms.Button();
            this.buttonCreateWaterPlane = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxCircle = new System.Windows.Forms.CheckBox();
            this.checkBoxRectangle = new System.Windows.Forms.CheckBox();
            this.checkBoxTriangle = new System.Windows.Forms.CheckBox();
            this.labelForm = new System.Windows.Forms.Label();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreatePlane
            // 
            this.buttonCreatePlane.Location = new System.Drawing.Point(726, 12);
            this.buttonCreatePlane.Name = "buttonCreatePlane";
            this.buttonCreatePlane.Size = new System.Drawing.Size(146, 32);
            this.buttonCreatePlane.TabIndex = 1;
            this.buttonCreatePlane.Text = "Создать самолет";
            this.buttonCreatePlane.UseVisualStyleBackColor = true;
            this.buttonCreatePlane.Click += new System.EventHandler(this.ButtonCreatePlane_Click);
            // 
            // buttonCreateWaterPlane
            // 
            this.buttonCreateWaterPlane.Location = new System.Drawing.Point(9, 111);
            this.buttonCreateWaterPlane.Name = "buttonCreateWaterPlane";
            this.buttonCreateWaterPlane.Size = new System.Drawing.Size(79, 28);
            this.buttonCreateWaterPlane.TabIndex = 7;
            this.buttonCreateWaterPlane.Text = "Создать";
            this.buttonCreateWaterPlane.UseVisualStyleBackColor = true;
            this.buttonCreateWaterPlane.Click += new System.EventHandler(this.ButtonCreateWaterPlane_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.checkBoxCircle);
            this.groupBox.Controls.Add(this.checkBoxRectangle);
            this.groupBox.Controls.Add(this.checkBoxTriangle);
            this.groupBox.Controls.Add(this.labelForm);
            this.groupBox.Controls.Add(this.buttonCreateWaterPlane);
            this.groupBox.Location = new System.Drawing.Point(726, 50);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(146, 158);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Создать гидросамолет";
            // 
            // checkBoxCircle
            // 
            this.checkBoxCircle.AutoSize = true;
            this.checkBoxCircle.Location = new System.Drawing.Point(9, 88);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.Size = new System.Drawing.Size(104, 17);
            this.checkBoxCircle.TabIndex = 11;
            this.checkBoxCircle.Text = "Круглая форма";
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            // 
            // checkBoxRectangle
            // 
            this.checkBoxRectangle.AutoSize = true;
            this.checkBoxRectangle.Location = new System.Drawing.Point(9, 65);
            this.checkBoxRectangle.Name = "checkBoxRectangle";
            this.checkBoxRectangle.Size = new System.Drawing.Size(123, 17);
            this.checkBoxRectangle.TabIndex = 10;
            this.checkBoxRectangle.Text = "Квадратная форма";
            this.checkBoxRectangle.UseVisualStyleBackColor = true;
            // 
            // checkBoxTriangle
            // 
            this.checkBoxTriangle.AutoSize = true;
            this.checkBoxTriangle.Location = new System.Drawing.Point(9, 42);
            this.checkBoxTriangle.Name = "checkBoxTriangle";
            this.checkBoxTriangle.Size = new System.Drawing.Size(128, 17);
            this.checkBoxTriangle.TabIndex = 9;
            this.checkBoxTriangle.Text = "Треугольная форма";
            this.checkBoxTriangle.UseVisualStyleBackColor = true;
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Location = new System.Drawing.Point(6, 26);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(99, 13);
            this.labelForm.TabIndex = 8;
            this.labelForm.Text = "Форма двигателя";
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::Seaplane.Properties.Resources.arrowLeft;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(824, 412);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::Seaplane.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(788, 412);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::Seaplane.Properties.Resources.arrowRight;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(752, 412);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::Seaplane.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(788, 376);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPlane.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxPlane.TabIndex = 0;
            this.pictureBoxPlane.TabStop = false;
            // 
            // FormSeaplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreatePlane);
            this.Controls.Add(this.pictureBoxPlane);
            this.Name = "FormSeaplane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гидросамолет";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Button buttonCreatePlane;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCreateWaterPlane;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.CheckBox checkBoxCircle;
        private System.Windows.Forms.CheckBox checkBoxRectangle;
        private System.Windows.Forms.CheckBox checkBoxTriangle;
    }
}

