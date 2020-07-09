namespace Shutdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cb_Action = new System.Windows.Forms.ComboBox();
            this.rb_acurred_time = new System.Windows.Forms.RadioButton();
            this.rb_in = new System.Windows.Forms.RadioButton();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_Hourse = new System.Windows.Forms.Label();
            this.lb_Minutes = new System.Windows.Forms.Label();
            this.tb_Hourse = new System.Windows.Forms.TrackBar();
            this.tb_Minutes = new System.Windows.Forms.TrackBar();
            this.btn_Set = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.systemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.sysTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Minutes)).BeginInit();
            this.sysTrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Action
            // 
            this.cb_Action.FormattingEnabled = true;
            this.cb_Action.Items.AddRange(new object[] {
            "Lock screen",
            "Log off",
            "Hibernate",
            "Shutdown"});
            this.cb_Action.Location = new System.Drawing.Point(12, 12);
            this.cb_Action.Name = "cb_Action";
            this.cb_Action.Size = new System.Drawing.Size(393, 21);
            this.cb_Action.TabIndex = 0;
            this.cb_Action.SelectedIndexChanged += new System.EventHandler(this.cb_Action_SelectedIndexChanged);
            // 
            // rb_acurred_time
            // 
            this.rb_acurred_time.AutoSize = true;
            this.rb_acurred_time.Checked = true;
            this.rb_acurred_time.Location = new System.Drawing.Point(12, 39);
            this.rb_acurred_time.Name = "rb_acurred_time";
            this.rb_acurred_time.Size = new System.Drawing.Size(32, 17);
            this.rb_acurred_time.TabIndex = 1;
            this.rb_acurred_time.TabStop = true;
            this.rb_acurred_time.Text = "В";
            this.rb_acurred_time.UseVisualStyleBackColor = true;
            // 
            // rb_in
            // 
            this.rb_in.AutoSize = true;
            this.rb_in.Location = new System.Drawing.Point(103, 39);
            this.rb_in.Name = "rb_in";
            this.rb_in.Size = new System.Drawing.Size(57, 17);
            this.rb_in.TabIndex = 2;
            this.rb_in.Text = "Через";
            this.rb_in.UseVisualStyleBackColor = true;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Time.Location = new System.Drawing.Point(252, 41);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(66, 26);
            this.lb_Time.TabIndex = 3;
            this.lb_Time.Text = "00:00";
            this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Hourse
            // 
            this.lb_Hourse.AutoSize = true;
            this.lb_Hourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Hourse.Location = new System.Drawing.Point(12, 93);
            this.lb_Hourse.Name = "lb_Hourse";
            this.lb_Hourse.Size = new System.Drawing.Size(49, 20);
            this.lb_Hourse.TabIndex = 4;
            this.lb_Hourse.Text = "Часы";
            // 
            // lb_Minutes
            // 
            this.lb_Minutes.AutoSize = true;
            this.lb_Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Minutes.Location = new System.Drawing.Point(12, 159);
            this.lb_Minutes.Name = "lb_Minutes";
            this.lb_Minutes.Size = new System.Drawing.Size(67, 20);
            this.lb_Minutes.TabIndex = 5;
            this.lb_Minutes.Text = "Минуты";
            this.lb_Minutes.Click += new System.EventHandler(this.lb_Minutes_Click);
            // 
            // tb_Hourse
            // 
            this.tb_Hourse.Location = new System.Drawing.Point(103, 93);
            this.tb_Hourse.Maximum = 23;
            this.tb_Hourse.Name = "tb_Hourse";
            this.tb_Hourse.Size = new System.Drawing.Size(302, 45);
            this.tb_Hourse.TabIndex = 6;
            this.tb_Hourse.ValueChanged += new System.EventHandler(this.tb_Hourse_ValueChanged);
            // 
            // tb_Minutes
            // 
            this.tb_Minutes.LargeChange = 10;
            this.tb_Minutes.Location = new System.Drawing.Point(103, 158);
            this.tb_Minutes.Maximum = 59;
            this.tb_Minutes.Name = "tb_Minutes";
            this.tb_Minutes.Size = new System.Drawing.Size(302, 45);
            this.tb_Minutes.TabIndex = 7;
            this.tb_Minutes.ValueChanged += new System.EventHandler(this.tb_Minutes_ValueChanged);
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(257, 229);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Set.TabIndex = 8;
            this.btn_Set.Text = "Задать";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(342, 229);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // systemTray
            // 
            this.systemTray.ContextMenuStrip = this.sysTrayContextMenu;
            this.systemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTray.Icon")));
            this.systemTray.Text = "notifyIcon1";
            this.systemTray.DoubleClick += new System.EventHandler(this.systemTray_DoubleClick);
            // 
            // sysTrayContextMenu
            // 
            this.sysTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.sysTrayContextMenu.Name = "sysTrayContextMenu";
            this.sysTrayContextMenu.Size = new System.Drawing.Size(105, 48);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.systemTray_DoubleClick);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 264);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.tb_Minutes);
            this.Controls.Add(this.tb_Hourse);
            this.Controls.Add(this.lb_Minutes);
            this.Controls.Add(this.lb_Hourse);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.rb_in);
            this.Controls.Add(this.rb_acurred_time);
            this.Controls.Add(this.cb_Action);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Minutes)).EndInit();
            this.sysTrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Action;
        private System.Windows.Forms.RadioButton rb_acurred_time;
        private System.Windows.Forms.RadioButton rb_in;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_Hourse;
        private System.Windows.Forms.Label lb_Minutes;
        private System.Windows.Forms.TrackBar tb_Hourse;
        private System.Windows.Forms.TrackBar tb_Minutes;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.NotifyIcon systemTray;
        private System.Windows.Forms.ContextMenuStrip sysTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Timer mainTimer;
    }
}

