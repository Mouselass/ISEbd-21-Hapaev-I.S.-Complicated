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
            this.groupBoxTakePlane = new System.Windows.Forms.GroupBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.labelAerodrome = new System.Windows.Forms.Label();
            this.buttonAddAerodrome = new System.Windows.Forms.Button();
            this.listBoxAerodrome = new System.Windows.Forms.ListBox();
            this.buttonDeleteAerodrome = new System.Windows.Forms.Button();
            this.buttonCheckPlanes = new System.Windows.Forms.Button();
            this.pictureBoxAerodrome = new System.Windows.Forms.PictureBox();
            this.buttonAddPlane = new System.Windows.Forms.Button();
            this.groupBoxTakePlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTakePlane
            // 
            this.groupBoxTakePlane.Controls.Add(this.maskedTextBox);
            this.groupBoxTakePlane.Controls.Add(this.buttonTake);
            this.groupBoxTakePlane.Controls.Add(this.labelPlace);
            this.groupBoxTakePlane.Location = new System.Drawing.Point(764, 344);
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
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(764, 27);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(133, 22);
            this.textBoxNewLevelName.TabIndex = 4;
            // 
            // labelAerodrome
            // 
            this.labelAerodrome.AutoSize = true;
            this.labelAerodrome.Location = new System.Drawing.Point(791, 9);
            this.labelAerodrome.Name = "labelAerodrome";
            this.labelAerodrome.Size = new System.Drawing.Size(72, 13);
            this.labelAerodrome.TabIndex = 5;
            this.labelAerodrome.Text = "Аэродромы:";
            // 
            // buttonAddAerodrome
            // 
            this.buttonAddAerodrome.Location = new System.Drawing.Point(764, 54);
            this.buttonAddAerodrome.Name = "buttonAddAerodrome";
            this.buttonAddAerodrome.Size = new System.Drawing.Size(133, 23);
            this.buttonAddAerodrome.TabIndex = 6;
            this.buttonAddAerodrome.Text = "Добавить аэродром";
            this.buttonAddAerodrome.UseVisualStyleBackColor = true;
            this.buttonAddAerodrome.Click += new System.EventHandler(this.buttonAddAerodrome_Click);
            // 
            // listBoxAerodrome
            // 
            this.listBoxAerodrome.FormattingEnabled = true;
            this.listBoxAerodrome.Location = new System.Drawing.Point(764, 84);
            this.listBoxAerodrome.Name = "listBoxAerodrome";
            this.listBoxAerodrome.Size = new System.Drawing.Size(133, 95);
            this.listBoxAerodrome.TabIndex = 7;
            this.listBoxAerodrome.Click += new System.EventHandler(this.listBoxAerodrome_SelectedIndexChanged);
            // 
            // buttonDeleteAerodrome
            // 
            this.buttonDeleteAerodrome.Location = new System.Drawing.Point(764, 186);
            this.buttonDeleteAerodrome.Name = "buttonDeleteAerodrome";
            this.buttonDeleteAerodrome.Size = new System.Drawing.Size(133, 23);
            this.buttonDeleteAerodrome.TabIndex = 8;
            this.buttonDeleteAerodrome.Text = "Удалить аэродром";
            this.buttonDeleteAerodrome.UseVisualStyleBackColor = true;
            this.buttonDeleteAerodrome.Click += new System.EventHandler(this.buttonDeleteAerodrome_Click);
            // 
            // buttonCheckPlanes
            // 
            this.buttonCheckPlanes.Location = new System.Drawing.Point(764, 484);
            this.buttonCheckPlanes.Name = "buttonCheckPlanes";
            this.buttonCheckPlanes.Size = new System.Drawing.Size(134, 39);
            this.buttonCheckPlanes.TabIndex = 9;
            this.buttonCheckPlanes.Text = "Просмотреть забранные самолеты";
            this.buttonCheckPlanes.UseVisualStyleBackColor = true;
            this.buttonCheckPlanes.Click += new System.EventHandler(this.buttonCheckPlanes_Click);
            // 
            // pictureBoxAerodrome
            // 
            this.pictureBoxAerodrome.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxAerodrome.Location = new System.Drawing.Point(1, 9);
            this.pictureBoxAerodrome.Name = "pictureBoxAerodrome";
            this.pictureBoxAerodrome.Size = new System.Drawing.Size(757, 495);
            this.pictureBoxAerodrome.TabIndex = 0;
            this.pictureBoxAerodrome.TabStop = false;
            this.pictureBoxAerodrome.Click += new System.EventHandler(this.buttonAddPlane_Click);
            // 
            // buttonAddPlane
            // 
            this.buttonAddPlane.Location = new System.Drawing.Point(773, 279);
            this.buttonAddPlane.Name = "buttonAddPlane";
            this.buttonAddPlane.Size = new System.Drawing.Size(124, 44);
            this.buttonAddPlane.TabIndex = 10;
            this.buttonAddPlane.Text = "Добавить самолет";
            this.buttonAddPlane.UseVisualStyleBackColor = true;
            this.buttonAddPlane.Click += new System.EventHandler(this.buttonAddPlane_Click);
            // 
            // FormAerodrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 534);
            this.Controls.Add(this.buttonAddPlane);
            this.Controls.Add(this.buttonCheckPlanes);
            this.Controls.Add(this.buttonDeleteAerodrome);
            this.Controls.Add(this.listBoxAerodrome);
            this.Controls.Add(this.buttonAddAerodrome);
            this.Controls.Add(this.labelAerodrome);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.groupBoxTakePlane);
            this.Controls.Add(this.pictureBoxAerodrome);
            this.Name = "FormAerodrome";
            this.Text = "Аэродром";
            this.groupBoxTakePlane.ResumeLayout(false);
            this.groupBoxTakePlane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelAerodrome;
        private System.Windows.Forms.Button buttonAddAerodrome;
        private System.Windows.Forms.Button buttonDeleteAerodrome;
        private System.Windows.Forms.ListBox listBoxAerodrome;
        private System.Windows.Forms.Button buttonCheckPlanes;
        private System.Windows.Forms.PictureBox pictureBoxAerodrome;
        private System.Windows.Forms.Button buttonAddPlane;
    }
}