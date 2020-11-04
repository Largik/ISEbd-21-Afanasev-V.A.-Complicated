namespace ship
{
    partial class FormPort
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
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCreateMotorShip = new System.Windows.Forms.Button();
            this.groupBoxTakeShip = new System.Windows.Forms.GroupBox();
            this.buttonTakeFromRemoved = new System.Windows.Forms.Button();
            this.buttonTakeShipFromPort = new System.Windows.Forms.Button();
            this.maskedTextBoxPlaceShip = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelCountPipes = new System.Windows.Forms.Label();
            this.comboBoxPipes = new System.Windows.Forms.ComboBox();
            this.labelCountLine = new System.Windows.Forms.Label();
            this.comboBoxFormCabin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCabin = new System.Windows.Forms.ComboBox();
            this.listBoxPorts = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddPort = new System.Windows.Forms.Button();
            this.buttonDeletePort = new System.Windows.Forms.Button();
            this.labelNamePort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBoxTakeShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPort.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(686, 567);
            this.pictureBoxPort.TabIndex = 1;
            this.pictureBoxPort.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(710, 240);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(151, 24);
            this.buttonCreate.TabIndex = 9;
            this.buttonCreate.Text = "Припарковать корабль";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCreateMotorShip
            // 
            this.buttonCreateMotorShip.Location = new System.Drawing.Point(710, 390);
            this.buttonCreateMotorShip.Name = "buttonCreateMotorShip";
            this.buttonCreateMotorShip.Size = new System.Drawing.Size(151, 23);
            this.buttonCreateMotorShip.TabIndex = 10;
            this.buttonCreateMotorShip.Text = "Припарковать теплоход";
            this.buttonCreateMotorShip.UseVisualStyleBackColor = true;
            this.buttonCreateMotorShip.Click += new System.EventHandler(this.buttonCreateMotorShip_Click);
            // 
            // groupBoxTakeShip
            // 
            this.groupBoxTakeShip.Controls.Add(this.buttonTakeFromRemoved);
            this.groupBoxTakeShip.Controls.Add(this.buttonTakeShipFromPort);
            this.groupBoxTakeShip.Controls.Add(this.maskedTextBoxPlaceShip);
            this.groupBoxTakeShip.Controls.Add(this.labelPlace);
            this.groupBoxTakeShip.Location = new System.Drawing.Point(710, 419);
            this.groupBoxTakeShip.Name = "groupBoxTakeShip";
            this.groupBoxTakeShip.Size = new System.Drawing.Size(151, 136);
            this.groupBoxTakeShip.TabIndex = 11;
            this.groupBoxTakeShip.TabStop = false;
            this.groupBoxTakeShip.Text = "Забрать Судно";
            // 
            // buttonTakeFromRemoved
            // 
            this.buttonTakeFromRemoved.Location = new System.Drawing.Point(9, 91);
            this.buttonTakeFromRemoved.Name = "buttonTakeFromRemoved";
            this.buttonTakeFromRemoved.Size = new System.Drawing.Size(121, 39);
            this.buttonTakeFromRemoved.TabIndex = 11;
            this.buttonTakeFromRemoved.Text = "Взять забранный корабль";
            this.buttonTakeFromRemoved.UseVisualStyleBackColor = true;
            this.buttonTakeFromRemoved.Click += new System.EventHandler(this.buttonTakeFromRemoved_Click);
            // 
            // buttonTakeShipFromPort
            // 
            this.buttonTakeShipFromPort.Location = new System.Drawing.Point(9, 62);
            this.buttonTakeShipFromPort.Name = "buttonTakeShipFromPort";
            this.buttonTakeShipFromPort.Size = new System.Drawing.Size(121, 23);
            this.buttonTakeShipFromPort.TabIndex = 10;
            this.buttonTakeShipFromPort.Text = "Забрать с парковки";
            this.buttonTakeShipFromPort.UseVisualStyleBackColor = true;
            this.buttonTakeShipFromPort.Click += new System.EventHandler(this.buttonTakeShipFromPort_Click_1);
            // 
            // maskedTextBoxPlaceShip
            // 
            this.maskedTextBoxPlaceShip.Location = new System.Drawing.Point(51, 24);
            this.maskedTextBoxPlaceShip.Name = "maskedTextBoxPlaceShip";
            this.maskedTextBoxPlaceShip.Size = new System.Drawing.Size(79, 20);
            this.maskedTextBoxPlaceShip.TabIndex = 10;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 27);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 10;
            this.labelPlace.Text = "Место:";
            // 
            // labelCountPipes
            // 
            this.labelCountPipes.AutoSize = true;
            this.labelCountPipes.Location = new System.Drawing.Point(707, 267);
            this.labelCountPipes.Name = "labelCountPipes";
            this.labelCountPipes.Size = new System.Drawing.Size(91, 13);
            this.labelCountPipes.TabIndex = 12;
            this.labelCountPipes.Text = "Количество труб";
            // 
            // comboBoxPipes
            // 
            this.comboBoxPipes.FormattingEnabled = true;
            this.comboBoxPipes.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxPipes.Location = new System.Drawing.Point(710, 283);
            this.comboBoxPipes.Name = "comboBoxPipes";
            this.comboBoxPipes.Size = new System.Drawing.Size(151, 21);
            this.comboBoxPipes.TabIndex = 13;
            // 
            // labelCountLine
            // 
            this.labelCountLine.AutoSize = true;
            this.labelCountLine.Location = new System.Drawing.Point(707, 307);
            this.labelCountLine.Name = "labelCountLine";
            this.labelCountLine.Size = new System.Drawing.Size(72, 13);
            this.labelCountLine.TabIndex = 14;
            this.labelCountLine.Text = "Форма кают";
            // 
            // comboBoxFormCabin
            // 
            this.comboBoxFormCabin.FormattingEnabled = true;
            this.comboBoxFormCabin.Items.AddRange(new object[] {
            "Круглая",
            "Квадратная"});
            this.comboBoxFormCabin.Location = new System.Drawing.Point(710, 323);
            this.comboBoxFormCabin.Name = "comboBoxFormCabin";
            this.comboBoxFormCabin.Size = new System.Drawing.Size(151, 21);
            this.comboBoxFormCabin.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Количество кают";
            // 
            // comboBoxCabin
            // 
            this.comboBoxCabin.FormattingEnabled = true;
            this.comboBoxCabin.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.comboBoxCabin.Location = new System.Drawing.Point(710, 363);
            this.comboBoxCabin.Name = "comboBoxCabin";
            this.comboBoxCabin.Size = new System.Drawing.Size(151, 21);
            this.comboBoxCabin.TabIndex = 17;
            // 
            // listBoxPorts
            // 
            this.listBoxPorts.FormattingEnabled = true;
            this.listBoxPorts.Location = new System.Drawing.Point(710, 83);
            this.listBoxPorts.Name = "listBoxPorts";
            this.listBoxPorts.Size = new System.Drawing.Size(151, 121);
            this.listBoxPorts.TabIndex = 18;
            this.listBoxPorts.SelectedIndexChanged += new System.EventHandler(this.listBoxPorts_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(710, 26);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(151, 20);
            this.textBoxNewLevelName.TabIndex = 19;
            // 
            // buttonAddPort
            // 
            this.buttonAddPort.Location = new System.Drawing.Point(710, 54);
            this.buttonAddPort.Name = "buttonAddPort";
            this.buttonAddPort.Size = new System.Drawing.Size(151, 23);
            this.buttonAddPort.TabIndex = 20;
            this.buttonAddPort.Text = "Добавить парковку";
            this.buttonAddPort.UseVisualStyleBackColor = true;
            this.buttonAddPort.Click += new System.EventHandler(this.buttonAddPort_Click);
            // 
            // buttonDeletePort
            // 
            this.buttonDeletePort.Location = new System.Drawing.Point(710, 210);
            this.buttonDeletePort.Name = "buttonDeletePort";
            this.buttonDeletePort.Size = new System.Drawing.Size(151, 23);
            this.buttonDeletePort.TabIndex = 21;
            this.buttonDeletePort.Text = "Удалить парковку";
            this.buttonDeletePort.UseVisualStyleBackColor = true;
            this.buttonDeletePort.Click += new System.EventHandler(this.buttonDeletePort_Click);
            // 
            // labelNamePort
            // 
            this.labelNamePort.AutoSize = true;
            this.labelNamePort.Location = new System.Drawing.Point(761, 10);
            this.labelNamePort.Name = "labelNamePort";
            this.labelNamePort.Size = new System.Drawing.Size(40, 13);
            this.labelNamePort.TabIndex = 22;
            this.labelNamePort.Text = "Порты";
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 567);
            this.Controls.Add(this.labelNamePort);
            this.Controls.Add(this.buttonDeletePort);
            this.Controls.Add(this.buttonAddPort);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxPorts);
            this.Controls.Add(this.comboBoxCabin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFormCabin);
            this.Controls.Add(this.labelCountLine);
            this.Controls.Add(this.comboBoxPipes);
            this.Controls.Add(this.labelCountPipes);
            this.Controls.Add(this.groupBoxTakeShip);
            this.Controls.Add(this.buttonCreateMotorShip);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxPort);
            this.Name = "FormPort";
            this.Text = "Порт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBoxTakeShip.ResumeLayout(false);
            this.groupBoxTakeShip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCreateMotorShip;
        private System.Windows.Forms.GroupBox groupBoxTakeShip;
        private System.Windows.Forms.Button buttonTakeShipFromPort;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceShip;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelCountPipes;
        private System.Windows.Forms.ComboBox comboBoxPipes;
        private System.Windows.Forms.Label labelCountLine;
        private System.Windows.Forms.ComboBox comboBoxFormCabin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCabin;
        private System.Windows.Forms.ListBox listBoxPorts;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddPort;
        private System.Windows.Forms.Button buttonDeletePort;
        private System.Windows.Forms.Label labelNamePort;
        private System.Windows.Forms.Button buttonTakeFromRemoved;
    }
}