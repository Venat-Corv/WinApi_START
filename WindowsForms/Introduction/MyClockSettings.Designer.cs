namespace Introduction
{
    partial class MyClockSettings
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
            this.cb_ClocktopMost = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_ClocktopMost
            // 
            this.cb_ClocktopMost.AutoSize = true;
            this.cb_ClocktopMost.Location = new System.Drawing.Point(13, 13);
            this.cb_ClocktopMost.Name = "cb_ClocktopMost";
            this.cb_ClocktopMost.Size = new System.Drawing.Size(116, 17);
            this.cb_ClocktopMost.TabIndex = 0;
            this.cb_ClocktopMost.Text = "Поверх всех окон";
            this.cb_ClocktopMost.UseVisualStyleBackColor = true;
            this.cb_ClocktopMost.CheckedChanged += new System.EventHandler(this.cb_ClocktopMost_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(196, 142);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Location = new System.Drawing.Point(13, 37);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(100, 17);
            this.cbShowDate.TabIndex = 3;
            this.cbShowDate.Text = "Показать дату";
            this.cbShowDate.UseVisualStyleBackColor = true;
            // 
            // MyClockSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 177);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cb_ClocktopMost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MyClockSettings";
            this.Text = "MyClockSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_ClocktopMost;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbShowDate;
    }
}