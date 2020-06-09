namespace Introduction
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lb_time = new System.Windows.Forms.Label();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.lb_date = new System.Windows.Forms.Label();
            this.cb_showdate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_time.Location = new System.Drawing.Point(21, 24);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(46, 26);
            this.lb_time.TabIndex = 0;
            this.lb_time.Text = "Time";
            this.lb_time.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_timer
            // 
            this.main_timer.Enabled = true;
            this.main_timer.Interval = 1000;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_date.Location = new System.Drawing.Point(21, 69);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(45, 26);
            this.lb_date.TabIndex = 1;
            this.lb_date.Text = "Date";
            this.lb_date.Visible = false;
            // 
            // cb_showdate
            // 
            this.cb_showdate.AutoSize = true;
            this.cb_showdate.Location = new System.Drawing.Point(26, 117);
            this.cb_showdate.Name = "cb_showdate";
            this.cb_showdate.Size = new System.Drawing.Size(77, 17);
            this.cb_showdate.TabIndex = 2;
            this.cb_showdate.Text = "Show date";
            this.cb_showdate.UseVisualStyleBackColor = true;
            this.cb_showdate.CheckedChanged += new System.EventHandler(this.cb_showdate_CheckedChanged);
            this.cb_showdate.MouseLeave += new System.EventHandler(this.cb_showdate_MouseLeave);
            this.cb_showdate.MouseHover += new System.EventHandler(this.cb_showdate_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 166);
            this.Controls.Add(this.cb_showdate);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_time);
            this.Name = "Form1";
            this.Text = "MyWindowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.CheckBox cb_showdate;
    }
}

