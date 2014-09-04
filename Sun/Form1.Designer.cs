namespace Sun
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.longitude = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.NumericUpDown();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.minute = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.NumericUpDown();
            this.SunIco = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.longitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // longitude
            // 
            this.longitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.longitude.DecimalPlaces = 4;
            this.longitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.longitude.InterceptArrowKeys = false;
            this.longitude.Location = new System.Drawing.Point(36, 227);
            this.longitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.longitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(96, 20);
            this.longitude.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Set date (dd/mm/yyyy):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set time (hh : mm : ss):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Longitude:";
            // 
            // latitude
            // 
            this.latitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.latitude.DecimalPlaces = 4;
            this.latitude.Location = new System.Drawing.Point(185, 226);
            this.latitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.latitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(95, 20);
            this.latitude.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Latitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = ":";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(36, 153);
            this.day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(36, 20);
            this.day.TabIndex = 18;
            this.day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(78, 153);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(36, 20);
            this.month.TabIndex = 19;
            this.month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(120, 153);
            this.year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(50, 20);
            this.year.TabIndex = 20;
            this.year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(184, 153);
            this.hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(36, 20);
            this.hour.TabIndex = 21;
            // 
            // minute
            // 
            this.minute.Location = new System.Drawing.Point(226, 153);
            this.minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(36, 20);
            this.minute.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = ":";
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(272, 153);
            this.second.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(36, 20);
            this.second.TabIndex = 25;
            // 
            // SunIco
            // 
            this.SunIco.BackColor = System.Drawing.SystemColors.Control;
            this.SunIco.Cursor = System.Windows.Forms.Cursors.Default;
            this.SunIco.Image = global::Sun.Properties.Resources.Solnce;
            this.SunIco.Location = new System.Drawing.Point(589, 247);
            this.SunIco.Name = "SunIco";
            this.SunIco.Size = new System.Drawing.Size(22, 20);
            this.SunIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SunIco.TabIndex = 27;
            this.SunIco.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sun.Properties.Resources.graf;
            this.pictureBox1.Location = new System.Drawing.Point(349, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(837, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "E; 90";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(578, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "S; 180";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(316, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "W; 270";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(586, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "N; 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 515);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SunIco);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SunCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.longitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SunIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown longitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown latitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.NumericUpDown minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown second;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SunIco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

