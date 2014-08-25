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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.dTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.longitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 160);
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
            this.longitude.Location = new System.Drawing.Point(15, 107);
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
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Set date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Longitude:";
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(15, 36);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(96, 20);
            this.date.TabIndex = 8;
            // 
            // time
            // 
            this.time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(164, 35);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(94, 20);
            this.time.TabIndex = 9;
            // 
            // dTime
            // 
            this.dTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dTime.Location = new System.Drawing.Point(164, 106);
            this.dTime.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.dTime.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
            this.dTime.Name = "dTime";
            this.dTime.Size = new System.Drawing.Size(94, 20);
            this.dTime.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "GMT:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTime);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
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
            ((System.ComponentModel.ISupportInitialize)(this.dTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown longitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.NumericUpDown dTime;
        private System.Windows.Forms.Label label4;
    }
}

