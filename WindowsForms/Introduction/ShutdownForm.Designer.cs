namespace Introduction
{
    partial class ShutdownForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lb_Time = new System.Windows.Forms.Label();
            this.trackBarHours = new System.Windows.Forms.TrackBar();
            this.trackBarMinutes = new System.Windows.Forms.TrackBar();
            this.lb_hours = new System.Windows.Forms.Label();
            this.lb_minute = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lock screen",
            "Log out",
            "Sleep",
            "Shutdown"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(319, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По времени";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "через";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Time.Location = new System.Drawing.Point(261, 39);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(70, 26);
            this.lb_Time.TabIndex = 3;
            this.lb_Time.Text = "label1";
            // 
            // trackBarHours
            // 
            this.trackBarHours.LargeChange = 1;
            this.trackBarHours.Location = new System.Drawing.Point(75, 71);
            this.trackBarHours.Maximum = 24;
            this.trackBarHours.Name = "trackBarHours";
            this.trackBarHours.Size = new System.Drawing.Size(256, 45);
            this.trackBarHours.TabIndex = 5;
            // 
            // trackBarMinutes
            // 
            this.trackBarMinutes.LargeChange = 10;
            this.trackBarMinutes.Location = new System.Drawing.Point(75, 117);
            this.trackBarMinutes.Maximum = 60;
            this.trackBarMinutes.Name = "trackBarMinutes";
            this.trackBarMinutes.Size = new System.Drawing.Size(256, 45);
            this.trackBarMinutes.TabIndex = 5;
            // 
            // lb_hours
            // 
            this.lb_hours.AutoSize = true;
            this.lb_hours.Location = new System.Drawing.Point(12, 71);
            this.lb_hours.Name = "lb_hours";
            this.lb_hours.Size = new System.Drawing.Size(35, 13);
            this.lb_hours.TabIndex = 6;
            this.lb_hours.Text = "Часы";
            // 
            // lb_minute
            // 
            this.lb_minute.AutoSize = true;
            this.lb_minute.Location = new System.Drawing.Point(12, 117);
            this.lb_minute.Name = "lb_minute";
            this.lb_minute.Size = new System.Drawing.Size(46, 13);
            this.lb_minute.TabIndex = 7;
            this.lb_minute.Text = "Минуты";
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(15, 167);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(136, 39);
            this.btn_Apply.TabIndex = 8;
            this.btn_Apply.Text = "Применить";
            this.btn_Apply.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(193, 167);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(138, 39);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // ShutdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 219);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.lb_minute);
            this.Controls.Add(this.lb_hours);
            this.Controls.Add(this.trackBarMinutes);
            this.Controls.Add(this.trackBarHours);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ShutdownForm";
            this.Text = "ShutdownForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.TrackBar trackBarHours;
        private System.Windows.Forms.TrackBar trackBarMinutes;
        private System.Windows.Forms.Label lb_hours;
        private System.Windows.Forms.Label lb_minute;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_cancel;
    }
}