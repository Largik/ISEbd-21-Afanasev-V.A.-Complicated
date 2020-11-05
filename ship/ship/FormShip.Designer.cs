namespace ship
{
    partial class FormShip
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
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.comboBoxPipes = new System.Windows.Forms.ComboBox();
            this.buttonCreateMotorShip = new System.Windows.Forms.Button();
            this.labelCountPipes = new System.Windows.Forms.Label();
            this.comboBoxFormPipes = new System.Windows.Forms.ComboBox();
            this.labelCountFormPipes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShip.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxShip.TabIndex = 0;
            this.pictureBoxShip.TabStop = false;
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::ship.Properties.Resources.iconfinder_icon_arrow_right_a_211619;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(823, 419);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::ship.Properties.Resources.iconfinder_icon_arrow_down_a_211613;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(787, 419);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::ship.Properties.Resources.iconfinder_icon_arrow_left_a_211616;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(750, 419);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::ship.Properties.Resources.iconfinder_arrow_full_up_103296;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(787, 383);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // comboBoxPipes
            // 
            this.comboBoxPipes.FormattingEnabled = true;
            this.comboBoxPipes.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxPipes.Location = new System.Drawing.Point(761, 95);
            this.comboBoxPipes.Name = "comboBoxPipes";
            this.comboBoxPipes.Size = new System.Drawing.Size(88, 21);
            this.comboBoxPipes.TabIndex = 6;
            // 
            // buttonCreateMotorShip
            // 
            this.buttonCreateMotorShip.Location = new System.Drawing.Point(761, 162);
            this.buttonCreateMotorShip.Name = "buttonCreateMotorShip";
            this.buttonCreateMotorShip.Size = new System.Drawing.Size(88, 36);
            this.buttonCreateMotorShip.TabIndex = 7;
            this.buttonCreateMotorShip.Text = "Создать теплоход";
            this.buttonCreateMotorShip.UseVisualStyleBackColor = true;
            this.buttonCreateMotorShip.Click += new System.EventHandler(this.buttonCreateMotorShip_Click);
            // 
            // labelCountPipes
            // 
            this.labelCountPipes.AutoSize = true;
            this.labelCountPipes.Location = new System.Drawing.Point(758, 79);
            this.labelCountPipes.Name = "labelCountPipes";
            this.labelCountPipes.Size = new System.Drawing.Size(91, 13);
            this.labelCountPipes.TabIndex = 8;
            this.labelCountPipes.Text = "Количество труб";
            // 
            // comboBoxFormPipes
            // 
            this.comboBoxFormPipes.FormattingEnabled = true;
            this.comboBoxFormPipes.Items.AddRange(new object[] {
            "Обычная",
            "Квадратная",
            "Треугольная"});
            this.comboBoxFormPipes.Location = new System.Drawing.Point(761, 135);
            this.comboBoxFormPipes.Name = "comboBoxFormPipes";
            this.comboBoxFormPipes.Size = new System.Drawing.Size(88, 21);
            this.comboBoxFormPipes.TabIndex = 9;
            // 
            // labelCountFormPipes
            // 
            this.labelCountFormPipes.AutoSize = true;
            this.labelCountFormPipes.Location = new System.Drawing.Point(747, 119);
            this.labelCountFormPipes.Name = "labelCountFormPipes";
            this.labelCountFormPipes.Size = new System.Drawing.Size(118, 13);
            this.labelCountFormPipes.TabIndex = 11;
            this.labelCountFormPipes.Text = "Выберите форму труб";
            // 
            // FormShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.labelCountFormPipes);
            this.Controls.Add(this.comboBoxFormPipes);
            this.Controls.Add(this.labelCountPipes);
            this.Controls.Add(this.buttonCreateMotorShip);
            this.Controls.Add(this.comboBoxPipes);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.pictureBoxShip);
            this.Name = "FormShip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShip;
        protected System.Windows.Forms.Button buttonUp;
        protected System.Windows.Forms.Button buttonRight;
        protected System.Windows.Forms.Button buttonDown;
        protected System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.ComboBox comboBoxPipes;
        private System.Windows.Forms.Button buttonCreateMotorShip;
        private System.Windows.Forms.Label labelCountPipes;
        private System.Windows.Forms.ComboBox comboBoxFormPipes;
        private System.Windows.Forms.Label labelCountFormPipes;
    }
}

