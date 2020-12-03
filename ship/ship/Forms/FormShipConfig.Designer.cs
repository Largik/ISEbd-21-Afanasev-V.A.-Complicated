namespace ship
{
    partial class FormShipConfig
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
            this.groupBoxTypeShip = new System.Windows.Forms.GroupBox();
            this.labelMotorShip = new System.Windows.Forms.Label();
            this.labelDefaultShip = new System.Windows.Forms.Label();
            this.panelShip = new System.Windows.Forms.Panel();
            this.pictureBoxTypeShip = new System.Windows.Forms.PictureBox();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.countPipe = new System.Windows.Forms.Label();
            this.numericUpDownPipe = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCabin = new System.Windows.Forms.CheckBox();
            this.checkBoxLines = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelColorAqua = new System.Windows.Forms.Panel();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorGrey = new System.Windows.Forms.Panel();
            this.panelColorYellow = new System.Windows.Forms.Panel();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.panelColorGreen = new System.Windows.Forms.Panel();
            this.panelColorRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxPipes = new System.Windows.Forms.GroupBox();
            this.labelTrianglePipe = new System.Windows.Forms.Label();
            this.labelRectanglePipe = new System.Windows.Forms.Label();
            this.labelDefaultPipe = new System.Windows.Forms.Label();
            this.groupBoxTypeShip.SuspendLayout();
            this.panelShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypeShip)).BeginInit();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxPipes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeShip
            // 
            this.groupBoxTypeShip.Controls.Add(this.labelMotorShip);
            this.groupBoxTypeShip.Controls.Add(this.labelDefaultShip);
            this.groupBoxTypeShip.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTypeShip.Name = "groupBoxTypeShip";
            this.groupBoxTypeShip.Size = new System.Drawing.Size(145, 114);
            this.groupBoxTypeShip.TabIndex = 3;
            this.groupBoxTypeShip.TabStop = false;
            this.groupBoxTypeShip.Text = "Тип корабля";
            // 
            // labelMotorShip
            // 
            this.labelMotorShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMotorShip.Location = new System.Drawing.Point(19, 69);
            this.labelMotorShip.Name = "labelMotorShip";
            this.labelMotorShip.Size = new System.Drawing.Size(106, 27);
            this.labelMotorShip.TabIndex = 1;
            this.labelMotorShip.Text = "Теплоход";
            this.labelMotorShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMotorShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMotorShip_MouseDown);
            // 
            // labelDefaultShip
            // 
            this.labelDefaultShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDefaultShip.Location = new System.Drawing.Point(19, 21);
            this.labelDefaultShip.Name = "labelDefaultShip";
            this.labelDefaultShip.Size = new System.Drawing.Size(106, 27);
            this.labelDefaultShip.TabIndex = 0;
            this.labelDefaultShip.Text = "Кобраль";
            this.labelDefaultShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDefaultShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDefaultShip_MouseDown);
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShip.Controls.Add(this.pictureBoxTypeShip);
            this.panelShip.Location = new System.Drawing.Point(163, 12);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(168, 163);
            this.panelShip.TabIndex = 4;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // pictureBoxTypeShip
            // 
            this.pictureBoxTypeShip.Location = new System.Drawing.Point(15, 20);
            this.pictureBoxTypeShip.Name = "pictureBoxTypeShip";
            this.pictureBoxTypeShip.Size = new System.Drawing.Size(138, 125);
            this.pictureBoxTypeShip.TabIndex = 0;
            this.pictureBoxTypeShip.TabStop = false;
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.countPipe);
            this.groupBoxParams.Controls.Add(this.numericUpDownPipe);
            this.groupBoxParams.Controls.Add(this.checkBoxCabin);
            this.groupBoxParams.Controls.Add(this.checkBoxLines);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParams.Controls.Add(this.labelWeight);
            this.groupBoxParams.Controls.Add(this.labelSpeed);
            this.groupBoxParams.Location = new System.Drawing.Point(12, 181);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(319, 133);
            this.groupBoxParams.TabIndex = 5;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // countPipe
            // 
            this.countPipe.AutoSize = true;
            this.countPipe.Location = new System.Drawing.Point(16, 91);
            this.countPipe.Name = "countPipe";
            this.countPipe.Size = new System.Drawing.Size(69, 13);
            this.countPipe.TabIndex = 8;
            this.countPipe.Text = "Кол-во труб:";
            // 
            // numericUpDownPipe
            // 
            this.numericUpDownPipe.Location = new System.Drawing.Point(96, 91);
            this.numericUpDownPipe.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownPipe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPipe.Name = "numericUpDownPipe";
            this.numericUpDownPipe.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownPipe.TabIndex = 7;
            this.numericUpDownPipe.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkBoxCabin
            // 
            this.checkBoxCabin.AutoSize = true;
            this.checkBoxCabin.Location = new System.Drawing.Point(211, 81);
            this.checkBoxCabin.Name = "checkBoxCabin";
            this.checkBoxCabin.Size = new System.Drawing.Size(60, 17);
            this.checkBoxCabin.TabIndex = 6;
            this.checkBoxCabin.Text = "5 кают";
            this.checkBoxCabin.UseVisualStyleBackColor = true;
            // 
            // checkBoxLines
            // 
            this.checkBoxLines.AutoSize = true;
            this.checkBoxLines.Location = new System.Drawing.Point(211, 58);
            this.checkBoxLines.Name = "checkBoxLines";
            this.checkBoxLines.Size = new System.Drawing.Size(58, 17);
            this.checkBoxLines.TabIndex = 5;
            this.checkBoxLines.Text = "Линии";
            this.checkBoxLines.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownWeight.Location = new System.Drawing.Point(96, 64);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(112, 26);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(16, 64);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(74, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес корабля:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(16, 28);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Макс. скорость:";
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelColorAqua);
            this.groupBoxColors.Controls.Add(this.panelColorWhite);
            this.groupBoxColors.Controls.Add(this.panelColorBlue);
            this.groupBoxColors.Controls.Add(this.panelColorGrey);
            this.groupBoxColors.Controls.Add(this.panelColorYellow);
            this.groupBoxColors.Controls.Add(this.panelColorBlack);
            this.groupBoxColors.Controls.Add(this.panelColorGreen);
            this.groupBoxColors.Controls.Add(this.panelColorRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(385, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(231, 163);
            this.groupBoxColors.TabIndex = 6;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelColorAqua
            // 
            this.panelColorAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelColorAqua.Location = new System.Drawing.Point(188, 111);
            this.panelColorAqua.Name = "panelColorAqua";
            this.panelColorAqua.Size = new System.Drawing.Size(37, 35);
            this.panelColorAqua.TabIndex = 4;
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.BackColor = System.Drawing.Color.White;
            this.panelColorWhite.Location = new System.Drawing.Point(134, 111);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(37, 35);
            this.panelColorWhite.TabIndex = 4;
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.BackColor = System.Drawing.Color.Blue;
            this.panelColorBlue.Location = new System.Drawing.Point(76, 111);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(37, 35);
            this.panelColorBlue.TabIndex = 4;
            // 
            // panelColorGrey
            // 
            this.panelColorGrey.BackColor = System.Drawing.Color.Gray;
            this.panelColorGrey.Location = new System.Drawing.Point(18, 111);
            this.panelColorGrey.Name = "panelColorGrey";
            this.panelColorGrey.Size = new System.Drawing.Size(37, 35);
            this.panelColorGrey.TabIndex = 4;
            // 
            // panelColorYellow
            // 
            this.panelColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelColorYellow.Location = new System.Drawing.Point(188, 69);
            this.panelColorYellow.Name = "panelColorYellow";
            this.panelColorYellow.Size = new System.Drawing.Size(37, 35);
            this.panelColorYellow.TabIndex = 4;
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.BackColor = System.Drawing.Color.Black;
            this.panelColorBlack.Location = new System.Drawing.Point(134, 69);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(37, 35);
            this.panelColorBlack.TabIndex = 4;
            // 
            // panelColorGreen
            // 
            this.panelColorGreen.BackColor = System.Drawing.Color.Green;
            this.panelColorGreen.Location = new System.Drawing.Point(76, 69);
            this.panelColorGreen.Name = "panelColorGreen";
            this.panelColorGreen.Size = new System.Drawing.Size(37, 35);
            this.panelColorGreen.TabIndex = 4;
            // 
            // panelColorRed
            // 
            this.panelColorRed.BackColor = System.Drawing.Color.Red;
            this.panelColorRed.Location = new System.Drawing.Point(18, 69);
            this.panelColorRed.Name = "panelColorRed";
            this.panelColorRed.Size = new System.Drawing.Size(37, 35);
            this.panelColorRed.TabIndex = 3;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(119, 21);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(106, 27);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 21);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(107, 27);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(541, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(541, 291);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxPipes
            // 
            this.groupBoxPipes.Controls.Add(this.labelTrianglePipe);
            this.groupBoxPipes.Controls.Add(this.labelRectanglePipe);
            this.groupBoxPipes.Controls.Add(this.labelDefaultPipe);
            this.groupBoxPipes.Location = new System.Drawing.Point(337, 181);
            this.groupBoxPipes.Name = "groupBoxPipes";
            this.groupBoxPipes.Size = new System.Drawing.Size(161, 132);
            this.groupBoxPipes.TabIndex = 9;
            this.groupBoxPipes.TabStop = false;
            this.groupBoxPipes.Text = "Тип труб";
            // 
            // labelTrianglePipe
            // 
            this.labelTrianglePipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrianglePipe.Location = new System.Drawing.Point(18, 86);
            this.labelTrianglePipe.Name = "labelTrianglePipe";
            this.labelTrianglePipe.Size = new System.Drawing.Size(122, 27);
            this.labelTrianglePipe.TabIndex = 4;
            this.labelTrianglePipe.Text = "Треугольные";
            this.labelTrianglePipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTrianglePipe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPipe_MouseDown);
            // 
            // labelRectanglePipe
            // 
            this.labelRectanglePipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRectanglePipe.Location = new System.Drawing.Point(18, 52);
            this.labelRectanglePipe.Name = "labelRectanglePipe";
            this.labelRectanglePipe.Size = new System.Drawing.Size(122, 27);
            this.labelRectanglePipe.TabIndex = 3;
            this.labelRectanglePipe.Text = "Квадратные";
            this.labelRectanglePipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRectanglePipe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPipe_MouseDown);
            // 
            // labelDefaultPipe
            // 
            this.labelDefaultPipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDefaultPipe.Location = new System.Drawing.Point(18, 21);
            this.labelDefaultPipe.Name = "labelDefaultPipe";
            this.labelDefaultPipe.Size = new System.Drawing.Size(122, 27);
            this.labelDefaultPipe.TabIndex = 2;
            this.labelDefaultPipe.Text = "Стандартные";
            this.labelDefaultPipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDefaultPipe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPipe_MouseDown);
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 325);
            this.Controls.Add(this.groupBoxPipes);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBoxTypeShip);
            this.Name = "FormShipConfig";
            this.Text = "Выбор Корабля";
            this.groupBoxTypeShip.ResumeLayout(false);
            this.panelShip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTypeShip)).EndInit();
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxPipes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTypeShip;
        private System.Windows.Forms.Label labelMotorShip;
        private System.Windows.Forms.Label labelDefaultShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.PictureBox pictureBoxTypeShip;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.CheckBox checkBoxCabin;
        private System.Windows.Forms.CheckBox checkBoxLines;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelColorAqua;
        private System.Windows.Forms.Panel panelColorWhite;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.Panel panelColorGrey;
        private System.Windows.Forms.Panel panelColorYellow;
        private System.Windows.Forms.Panel panelColorBlack;
        private System.Windows.Forms.Panel panelColorGreen;
        private System.Windows.Forms.Panel panelColorRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label countPipe;
        private System.Windows.Forms.NumericUpDown numericUpDownPipe;
        private System.Windows.Forms.GroupBox groupBoxPipes;
        private System.Windows.Forms.Label labelTrianglePipe;
        private System.Windows.Forms.Label labelRectanglePipe;
        private System.Windows.Forms.Label labelDefaultPipe;
    }
}