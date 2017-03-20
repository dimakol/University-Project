namespace University
{
    partial class F_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Student));
            this.name_label = new System.Windows.Forms.Label();
            this.dept_label = new System.Windows.Forms.Label();
            this.avg_label = new System.Windows.Forms.Label();
            this.pts_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.btnRecept_Hours = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lib_button = new System.Windows.Forms.Button();
            this.btnAssignments = new System.Windows.Forms.Button();
            this.ex_button = new System.Windows.Forms.Button();
            this.inf_button = new System.Windows.Forms.Button();
            this.grd_button = new System.Windows.Forms.Button();
            this.crs_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.name_label.Location = new System.Drawing.Point(12, 12);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(156, 24);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "welcome + name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dept_label.Location = new System.Drawing.Point(12, 148);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(105, 24);
            this.dept_label.TabIndex = 6;
            this.dept_label.Text = "department";
            this.dept_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // avg_label
            // 
            this.avg_label.AutoSize = true;
            this.avg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.avg_label.Location = new System.Drawing.Point(12, 172);
            this.avg_label.Name = "avg_label";
            this.avg_label.Size = new System.Drawing.Size(78, 24);
            this.avg_label.TabIndex = 7;
            this.avg_label.Text = "average";
            this.avg_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pts_label
            // 
            this.pts_label.AutoSize = true;
            this.pts_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pts_label.Location = new System.Drawing.Point(12, 196);
            this.pts_label.Name = "pts_label";
            this.pts_label.Size = new System.Drawing.Size(60, 24);
            this.pts_label.TabIndex = 8;
            this.pts_label.Text = "points";
            this.pts_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.year_label.Location = new System.Drawing.Point(12, 124);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(103, 24);
            this.year_label.TabIndex = 9;
            this.year_label.Text = "year + sem";
            this.year_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnRecept_Hours
            // 
            this.btnRecept_Hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecept_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRecept_Hours.Image = global::University.Properties.Resources.preferences_system_time;
            this.btnRecept_Hours.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecept_Hours.Location = new System.Drawing.Point(548, 12);
            this.btnRecept_Hours.Name = "btnRecept_Hours";
            this.btnRecept_Hours.Size = new System.Drawing.Size(120, 85);
            this.btnRecept_Hours.TabIndex = 19;
            this.btnRecept_Hours.Text = "Reception";
            this.btnRecept_Hours.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecept_Hours.UseVisualStyleBackColor = true;
            this.btnRecept_Hours.Click += new System.EventHandler(this.btnRecept_Hours_Click);
            this.btnRecept_Hours.MouseHover += new System.EventHandler(this.btnRecept_Hours_MouseHover);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Image = global::University.Properties.Resources.add_course;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(422, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 85);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Courses";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // lib_button
            // 
            this.lib_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lib_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lib_button.Image = global::University.Properties.Resources.book;
            this.lib_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lib_button.Location = new System.Drawing.Point(674, 12);
            this.lib_button.Name = "lib_button";
            this.lib_button.Size = new System.Drawing.Size(120, 85);
            this.lib_button.TabIndex = 17;
            this.lib_button.Text = "Library";
            this.lib_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lib_button.UseVisualStyleBackColor = true;
            this.lib_button.Click += new System.EventHandler(this.lib_button_Click);
            this.lib_button.MouseHover += new System.EventHandler(this.lib_button_MouseHover);
            // 
            // btnAssignments
            // 
            this.btnAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAssignments.Image = global::University.Properties.Resources.password_change;
            this.btnAssignments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAssignments.Location = new System.Drawing.Point(926, 12);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(120, 85);
            this.btnAssignments.TabIndex = 16;
            this.btnAssignments.Text = "Change Pass";
            this.btnAssignments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssignments.UseVisualStyleBackColor = true;
            this.btnAssignments.Click += new System.EventHandler(this.btnAssignments_Click);
            this.btnAssignments.MouseHover += new System.EventHandler(this.btnAssignments_MouseHover);
            // 
            // ex_button
            // 
            this.ex_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ex_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ex_button.Image = global::University.Properties.Resources.Log_Out;
            this.ex_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ex_button.Location = new System.Drawing.Point(1052, 12);
            this.ex_button.Name = "ex_button";
            this.ex_button.Size = new System.Drawing.Size(120, 85);
            this.ex_button.TabIndex = 4;
            this.ex_button.Text = "Log Out";
            this.ex_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ex_button.UseVisualStyleBackColor = true;
            this.ex_button.Click += new System.EventHandler(this.ex_button_Click);
            this.ex_button.MouseHover += new System.EventHandler(this.ex_button_MouseHover);
            // 
            // inf_button
            // 
            this.inf_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inf_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.inf_button.Image = global::University.Properties.Resources.file_edit;
            this.inf_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inf_button.Location = new System.Drawing.Point(800, 12);
            this.inf_button.Name = "inf_button";
            this.inf_button.Size = new System.Drawing.Size(120, 85);
            this.inf_button.TabIndex = 3;
            this.inf_button.Text = "Edit Info";
            this.inf_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inf_button.UseVisualStyleBackColor = true;
            this.inf_button.Click += new System.EventHandler(this.inf_button_Click);
            this.inf_button.MouseHover += new System.EventHandler(this.inf_button_MouseHover);
            // 
            // grd_button
            // 
            this.grd_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grd_button.Image = global::University.Properties.Resources.Test_paper_48;
            this.grd_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.grd_button.Location = new System.Drawing.Point(170, 12);
            this.grd_button.Name = "grd_button";
            this.grd_button.Size = new System.Drawing.Size(120, 85);
            this.grd_button.TabIndex = 1;
            this.grd_button.Text = "My Grades";
            this.grd_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grd_button.UseVisualStyleBackColor = true;
            this.grd_button.Click += new System.EventHandler(this.grd_button_Click);
            this.grd_button.MouseHover += new System.EventHandler(this.grd_button_MouseHover);
            // 
            // crs_button
            // 
            this.crs_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crs_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.crs_button.Image = global::University.Properties.Resources.mycourse;
            this.crs_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.crs_button.Location = new System.Drawing.Point(296, 12);
            this.crs_button.Name = "crs_button";
            this.crs_button.Size = new System.Drawing.Size(120, 85);
            this.crs_button.TabIndex = 0;
            this.crs_button.Text = "My Courses";
            this.crs_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crs_button.UseVisualStyleBackColor = true;
            this.crs_button.Click += new System.EventHandler(this.crs_button_Click);
            this.crs_button.MouseHover += new System.EventHandler(this.crs_button_MouseHover);
            // 
            // F_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::University.Properties.Resources.blackboards_college_students_a_2560x1440_knowledgehi_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 417);
            this.Controls.Add(this.btnRecept_Hours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lib_button);
            this.Controls.Add(this.btnAssignments);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.pts_label);
            this.Controls.Add(this.avg_label);
            this.Controls.Add(this.dept_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.ex_button);
            this.Controls.Add(this.inf_button);
            this.Controls.Add(this.grd_button);
            this.Controls.Add(this.crs_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Student";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Student Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.f_student_Load);
            this.SizeChanged += new System.EventHandler(this.F_Student_SizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.F_Student_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crs_button;
        private System.Windows.Forms.Button grd_button;
        private System.Windows.Forms.Button inf_button;
        private System.Windows.Forms.Button ex_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label dept_label;
        private System.Windows.Forms.Label avg_label;
        private System.Windows.Forms.Label pts_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button lib_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRecept_Hours;
    }
}