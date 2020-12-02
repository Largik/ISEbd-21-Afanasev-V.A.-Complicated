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
            this.groupBoxTakeShip = new System.Windows.Forms.GroupBox();
            this.buttonTakeFromRemoved = new System.Windows.Forms.Button();
            this.buttonTakeShipFromPort = new System.Windows.Forms.Button();
            this.maskedTextBoxPlaceShip = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxPorts = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddPort = new System.Windows.Forms.Button();
            this.buttonDeletePort = new System.Windows.Forms.Button();
            this.labelNamePort = new System.Windows.Forms.Label();
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBoxTakeShip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPort.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(686, 543);
            this.pictureBoxPort.TabIndex = 1;
            this.pictureBoxPort.TabStop = false;
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
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(710, 355);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(151, 58);
            this.buttonSetShip.TabIndex = 23;
            this.buttonSetShip.Text = "Добавить корабль\r\n";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(873, 24);
            this.menuStrip.TabIndex = 24;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 567);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.labelNamePort);
            this.Controls.Add(this.buttonDeletePort);
            this.Controls.Add(this.buttonAddPort);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxPorts);
            this.Controls.Add(this.groupBoxTakeShip);
            this.Controls.Add(this.pictureBoxPort);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormPort";
            this.Text = "Порт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBoxTakeShip.ResumeLayout(false);
            this.groupBoxTakeShip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.GroupBox groupBoxTakeShip;
        private System.Windows.Forms.Button buttonTakeShipFromPort;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceShip;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxPorts;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddPort;
        private System.Windows.Forms.Button buttonDeletePort;
        private System.Windows.Forms.Label labelNamePort;
        private System.Windows.Forms.Button buttonTakeFromRemoved;
        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}