namespace Seaplane
{
    partial class FormAerodrome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxAerodrome = new System.Windows.Forms.PictureBox();
            this.buttonLandPlane = new System.Windows.Forms.Button();
            this.buttonLandWaterplane = new System.Windows.Forms.Button();
            this.groupBoxTakePlane = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonComparePlanes = new System.Windows.Forms.Button();
            this.buttonCompareWaterPlanes = new System.Windows.Forms.Button();
            this.maskedTextBoxCompare = new System.Windows.Forms.MaskedTextBox();
            this.labelCompare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
            this.groupBoxTakePlane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAerodrome
            // 
            this.pictureBoxAerodrome.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxAerodrome.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAerodrome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAerodrome.Name = "pictureBoxAerodrome";
            this.pictureBoxAerodrome.Size = new System.Drawing.Size(757, 534);
            this.pictureBoxAerodrome.TabIndex = 0;
            this.pictureBoxAerodrome.TabStop = false;
            // 
            // buttonLandPlane
            // 
            this.buttonLandPlane.Location = new System.Drawing.Point(763, 12);
            this.buttonLandPlane.Name = "buttonLandPlane";
            this.buttonLandPlane.Size = new System.Drawing.Size(134, 35);
            this.buttonLandPlane.TabIndex = 1;
            this.buttonLandPlane.Text = "Посадить самолет";
            this.buttonLandPlane.UseVisualStyleBackColor = true;
            this.buttonLandPlane.Click += new System.EventHandler(this.buttonLandPlane_Click);
            // 
            // buttonLandWaterplane
            // 
            this.buttonLandWaterplane.Location = new System.Drawing.Point(763, 76);
            this.buttonLandWaterplane.Name = "buttonLandWaterplane";
            this.buttonLandWaterplane.Size = new System.Drawing.Size(134, 41);
            this.buttonLandWaterplane.TabIndex = 2;
            this.buttonLandWaterplane.Text = "Посадить гидросамолет";
            this.buttonLandWaterplane.UseVisualStyleBackColor = true;
            this.buttonLandWaterplane.Click += new System.EventHandler(this.buttonLandWaterplane_Click);
            // 
            // groupBoxTakePlane
            // 
            this.groupBoxTakePlane.Controls.Add(this.maskedTextBox);
            this.groupBoxTakePlane.Controls.Add(this.buttonTake);
            this.groupBoxTakePlane.Controls.Add(this.labelPlace);
            this.groupBoxTakePlane.Location = new System.Drawing.Point(763, 144);
            this.groupBoxTakePlane.Name = "groupBoxTakePlane";
            this.groupBoxTakePlane.Size = new System.Drawing.Size(134, 123);
            this.groupBoxTakePlane.TabIndex = 3;
            this.groupBoxTakePlane.TabStop = false;
            this.groupBoxTakePlane.Text = "Забрать самолет";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(58, 51);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(39, 22);
            this.maskedTextBox.TabIndex = 2;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(22, 94);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 1;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 54);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(46, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место :";
            // 
            // buttonComparePlanes
            // 
            this.buttonComparePlanes.Location = new System.Drawing.Point(772, 387);
            this.buttonComparePlanes.Name = "buttonComparePlanes";
            this.buttonComparePlanes.Size = new System.Drawing.Size(125, 64);
            this.buttonComparePlanes.TabIndex = 4;
            this.buttonComparePlanes.Text = "Сравнить количество самолетов с введенным числом";
            this.buttonComparePlanes.UseVisualStyleBackColor = true;
            this.buttonComparePlanes.Click += new System.EventHandler(this.ButtonComparePlanes_Click);
            // 
            // buttonCompareWaterPlanes
            // 
            this.buttonCompareWaterPlanes.Location = new System.Drawing.Point(772, 457);
            this.buttonCompareWaterPlanes.Name = "buttonCompareWaterPlanes";
            this.buttonCompareWaterPlanes.Size = new System.Drawing.Size(125, 65);
            this.buttonCompareWaterPlanes.TabIndex = 5;
            this.buttonCompareWaterPlanes.Text = "Сравнить количество гидросамолетов с введенным числом";
            this.buttonCompareWaterPlanes.UseVisualStyleBackColor = true;
            this.buttonCompareWaterPlanes.Click += new System.EventHandler(this.ButtonCompareWaterPlanes_Click);
            // 
            // maskedTextBoxCompare
            // 
            this.maskedTextBoxCompare.Location = new System.Drawing.Point(864, 344);
            this.maskedTextBoxCompare.Name = "maskedTextBoxCompare";
            this.maskedTextBoxCompare.Size = new System.Drawing.Size(33, 22);
            this.maskedTextBoxCompare.TabIndex = 6;
            // 
            // labelCompare
            // 
            this.labelCompare.Location = new System.Drawing.Point(763, 332);
            this.labelCompare.Name = "labelCompare";
            this.labelCompare.Size = new System.Drawing.Size(100, 34);
            this.labelCompare.TabIndex = 7;
            this.labelCompare.Text = "Введите число для сравнения:";
            // 
            // FormAerodrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 534);
            this.Controls.Add(this.labelCompare);
            this.Controls.Add(this.maskedTextBoxCompare);
            this.Controls.Add(this.buttonCompareWaterPlanes);
            this.Controls.Add(this.buttonComparePlanes);
            this.Controls.Add(this.groupBoxTakePlane);
            this.Controls.Add(this.buttonLandWaterplane);
            this.Controls.Add(this.buttonLandPlane);
            this.Controls.Add(this.pictureBoxAerodrome);
            this.Name = "FormAerodrome";
            this.Text = "Аэродром";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
            this.groupBoxTakePlane.ResumeLayout(false);
            this.groupBoxTakePlane.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrome;
        private System.Windows.Forms.Button buttonLandPlane;
        private System.Windows.Forms.Button buttonLandWaterplane;
        private System.Windows.Forms.GroupBox groupBoxTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonComparePlanes;
        private System.Windows.Forms.Button buttonCompareWaterPlanes;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCompare;
        private System.Windows.Forms.Label labelCompare;
    }
}