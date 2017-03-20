namespace University
{
    partial class F_Secretary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Secretary));
            this.name_label = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnMyInfo = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.name_label.ForeColor = System.Drawing.Color.Black;
            this.name_label.Location = new System.Drawing.Point(8, 12);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(156, 24);
            this.name_label.TabIndex = 14;
            this.name_label.Text = "welcome + name";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLogout.Image = global::University.Properties.Resources.Log_Out;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(1033, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 85);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.ex_button_Click);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(375, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSendMail.ForeColor = System.Drawing.Color.Black;
            this.btnSendMail.Image = global::University.Properties.Resources.Mailbig;
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSendMail.Location = new System.Drawing.Point(655, 12);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(120, 85);
            this.btnSendMail.TabIndex = 18;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnCancelMail_Click);
            this.btnSendMail.MouseHover += new System.EventHandler(this.btnSendMail_MouseHover);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnChangePass.Image = global::University.Properties.Resources.password_change;
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePass.Location = new System.Drawing.Point(907, 12);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(120, 85);
            this.btnChangePass.TabIndex = 17;
            this.btnChangePass.Text = "Change Pass";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChange_Pass_Click);
            this.btnChangePass.MouseHover += new System.EventHandler(this.btnChangePass_MouseHover);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddCourse.Image = global::University.Properties.Resources.add_course;
            this.btnAddCourse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCourse.Location = new System.Drawing.Point(277, 12);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(120, 85);
            this.btnAddCourse.TabIndex = 15;
            this.btnAddCourse.Text = "Add Courses";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAssignments_Click);
            this.btnAddCourse.MouseHover += new System.EventHandler(this.btnAddCourse_MouseHover);
            // 
            // btnMyInfo
            // 
            this.btnMyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMyInfo.Image = global::University.Properties.Resources.file_edit;
            this.btnMyInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMyInfo.Location = new System.Drawing.Point(781, 12);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new System.Drawing.Size(120, 85);
            this.btnMyInfo.TabIndex = 3;
            this.btnMyInfo.Text = "Edit My Info";
            this.btnMyInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMyInfo.UseVisualStyleBackColor = true;
            this.btnMyInfo.Click += new System.EventHandler(this.inf_button_Click);
            this.btnMyInfo.MouseHover += new System.EventHandler(this.btnMyInfo_MouseHover);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddStudent.Image = global::University.Properties.Resources.contact_new;
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStudent.Location = new System.Drawing.Point(403, 12);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(120, 85);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.add_button_Click);
            this.btnAddStudent.MouseHover += new System.EventHandler(this.btnAddStudent_MouseHover);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEditStudent.Image = global::University.Properties.Resources.edit_student;
            this.btnEditStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditStudent.Location = new System.Drawing.Point(529, 12);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(120, 85);
            this.btnEditStudent.TabIndex = 2;
            this.btnEditStudent.Text = "Edit Students";
            this.btnEditStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.edt_button_Click);
            this.btnEditStudent.MouseHover += new System.EventHandler(this.btnEditStudent_MouseHover);
            // 
            // F_Secretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::University.Properties.Resources.office_interior_desktop_1920x1200_hd_wallpaper_1188766;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 369);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyInfo);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnEditStudent);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Secretary";
            this.Text = "Secretary Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Secretary_FormClosed);
            this.Load += new System.EventHandler(this.F_Secretary_Load);
            this.SizeChanged += new System.EventHandler(this.F_Secretary_SizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.F_Secretary_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMyInfo;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnSendMail;
    }
}