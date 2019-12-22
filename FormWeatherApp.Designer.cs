﻿namespace WeatherApp.View
{
    partial class FormWeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeatherApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEnterCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.radioButtonKelvin = new System.Windows.Forms.RadioButton();
            this.btnLocation = new System.Windows.Forms.Button();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.btnToday = new System.Windows.Forms.Button();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.Label();
            this.txtCityDay = new System.Windows.Forms.Label();
            this.txtResult2 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // lblEnterCity
            // 
            this.lblEnterCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEnterCity.AutoEllipsis = true;
            this.lblEnterCity.AutoSize = true;
            this.lblEnterCity.Location = new System.Drawing.Point(8, 13);
            this.lblEnterCity.Name = "lblEnterCity";
            this.lblEnterCity.Size = new System.Drawing.Size(55, 13);
            this.lblEnterCity.TabIndex = 6;
            this.lblEnterCity.Text = "Enter City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            this.label1.Visible = false;
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.AutoEllipsis = true;
            this.btnTomorrow.Location = new System.Drawing.Point(142, 68);
            this.btnTomorrow.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(125, 24);
            this.btnTomorrow.TabIndex = 1;
            this.btnTomorrow.TabStop = false;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.BtnTomorrowWeather_Click);
            // 
            // radioButtonKelvin
            // 
            this.radioButtonKelvin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonKelvin.AutoSize = true;
            this.radioButtonKelvin.Location = new System.Drawing.Point(498, 71);
            this.radioButtonKelvin.Name = "radioButtonKelvin";
            this.radioButtonKelvin.Size = new System.Drawing.Size(78, 17);
            this.radioButtonKelvin.TabIndex = 3;
            this.radioButtonKelvin.Text = "Kelvin        ";
            this.radioButtonKelvin.UseVisualStyleBackColor = true;
            // 
            // btnLocation
            // 
            this.btnLocation.AutoSize = true;
            this.btnLocation.Location = new System.Drawing.Point(115, 8);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(152, 24);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.TabStop = false;
            this.btnLocation.Text = "Determine Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.BtnLocation_Click);
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Checked = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(500, 11);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(76, 17);
            this.radioButtonCelsius.TabIndex = 3;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "Celsius      ";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.AutoEllipsis = true;
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToday.Location = new System.Drawing.Point(8, 68);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(101, 24);
            this.btnToday.TabIndex = 1;
            this.btnToday.TabStop = false;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnTodayWeather_Click);
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(501, 41);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.radioButtonFahrenheit.TabIndex = 3;
            this.radioButtonFahrenheit.Text = "Fahrenheit";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonFahrenheit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnToday, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonCelsius, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLocation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonKelvin, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTomorrow, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEnterCity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCityDay, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtResult2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtRes, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCityName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 567);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(8, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResult.Location = new System.Drawing.Point(115, 125);
            this.txtResult.Name = "txtResult";
            this.tableLayoutPanel1.SetRowSpan(this.txtResult, 2);
            this.txtResult.Size = new System.Drawing.Size(227, 407);
            this.txtResult.TabIndex = 12;
            // 
            // txtCityDay
            // 
            this.txtCityDay.AutoSize = true;
            this.txtCityDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCityDay.Location = new System.Drawing.Point(8, 185);
            this.txtCityDay.Name = "txtCityDay";
            this.txtCityDay.Size = new System.Drawing.Size(101, 347);
            this.txtCityDay.TabIndex = 15;
            // 
            // txtResult2
            // 
            this.txtResult2.AutoSize = true;
            this.txtResult2.Location = new System.Drawing.Point(115, 532);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(0, 13);
            this.txtResult2.TabIndex = 13;
            // 
            // txtRes
            // 
            this.txtRes.AutoSize = true;
            this.txtRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRes.Location = new System.Drawing.Point(348, 125);
            this.txtRes.Name = "txtRes";
            this.tableLayoutPanel1.SetRowSpan(this.txtRes, 2);
            this.txtRes.Size = new System.Drawing.Size(228, 407);
            this.txtRes.TabIndex = 16;
            // 
            // txtCityName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCityName, 2);
            this.txtCityName.Location = new System.Drawing.Point(8, 38);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(259, 20);
            this.txtCityName.TabIndex = 17;
            this.txtCityName.TabStop = false;
            // 
            // FormWeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.Clouds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 630);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FormWeatherApp";
            this.Text = "WeatherApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblEnterCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.RadioButton radioButtonKelvin;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtCityDay;
        private System.Windows.Forms.Label txtResult2;
        private System.Windows.Forms.Label txtRes;
        private System.Windows.Forms.TextBox txtCityName;
    }
}

