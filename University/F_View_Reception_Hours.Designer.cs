namespace University
{
    partial class F_View_Reception_Hours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_View_Reception_Hours));
            this.listBox_Employees = new System.Windows.Forms.ListBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Employees
            // 
            this.listBox_Employees.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_Employees.FormattingEnabled = true;
            this.listBox_Employees.ItemHeight = 20;
            this.listBox_Employees.Location = new System.Drawing.Point(12, 12);
            this.listBox_Employees.Name = "listBox_Employees";
            this.listBox_Employees.Size = new System.Drawing.Size(168, 284);
            this.listBox_Employees.TabIndex = 0;
            this.listBox_Employees.SelectedIndexChanged += new System.EventHandler(this.listBox_Employees_SelectedIndexChanged);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDay.Location = new System.Drawing.Point(210, 21);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(51, 24);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Day:";
            // 
            // tbDay
            // 
            this.tbDay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbDay.Location = new System.Drawing.Point(261, 21);
            this.tbDay.Name = "tbDay";
            this.tbDay.ReadOnly = true;
            this.tbDay.Size = new System.Drawing.Size(174, 26);
            this.tbDay.TabIndex = 2;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStart.Location = new System.Drawing.Point(204, 105);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(57, 24);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEnd.Location = new System.Drawing.Point(207, 187);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(54, 24);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "End:";
            // 
            // tbStart
            // 
            this.tbStart.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbStart.Location = new System.Drawing.Point(261, 105);
            this.tbStart.Name = "tbStart";
            this.tbStart.ReadOnly = true;
            this.tbStart.Size = new System.Drawing.Size(174, 26);
            this.tbStart.TabIndex = 5;
            // 
            // tbEnd
            // 
            this.tbEnd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbEnd.Location = new System.Drawing.Point(261, 189);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.ReadOnly = true;
            this.tbEnd.Size = new System.Drawing.Size(174, 26);
            this.tbEnd.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(186, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_View_Reception_Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.listBox_Employees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_View_Reception_Hours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reception Hours";
            this.Load += new System.EventHandler(this.F_View_Reception_Hours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Employees;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Button button1;
    }
}