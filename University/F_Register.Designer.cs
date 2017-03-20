namespace University
{
    partial class F_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.fname_box = new System.Windows.Forms.TextBox();
            this.lname_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_radio = new System.Windows.Forms.RadioButton();
            this.f_radio = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.mail_box = new System.Windows.Forms.TextBox();
            this.phon_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dept_box = new System.Windows.Forms.ComboBox();
            this.grade_label = new System.Windows.Forms.Label();
            this.grade_box = new System.Windows.Forms.TextBox();
            this.ok_button = new System.Windows.Forms.Button();
            this.ex_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(66, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // user_box
            // 
            this.user_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.user_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user_box.Location = new System.Drawing.Point(97, 13);
            this.user_box.MaxLength = 12;
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(146, 23);
            this.user_box.TabIndex = 1;
            // 
            // pass_box
            // 
            this.pass_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pass_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pass_box.Location = new System.Drawing.Point(97, 39);
            this.pass_box.MaxLength = 12;
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(146, 23);
            this.pass_box.TabIndex = 2;
            this.pass_box.UseSystemPasswordChar = true;
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.id_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.id_box.Location = new System.Drawing.Point(97, 65);
            this.id_box.MaxLength = 9;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(146, 23);
            this.id_box.TabIndex = 3;
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // type_box
            // 
            this.type_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.type_box.FormattingEnabled = true;
            this.type_box.Location = new System.Drawing.Point(357, 64);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(135, 24);
            this.type_box.TabIndex = 10;
            // 
            // fname_box
            // 
            this.fname_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fname_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fname_box.Location = new System.Drawing.Point(97, 91);
            this.fname_box.MaxLength = 12;
            this.fname_box.Name = "fname_box";
            this.fname_box.Size = new System.Drawing.Size(146, 23);
            this.fname_box.TabIndex = 4;
            // 
            // lname_box
            // 
            this.lname_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lname_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lname_box.Location = new System.Drawing.Point(97, 117);
            this.lname_box.MaxLength = 12;
            this.lname_box.Name = "lname_box";
            this.lname_box.Size = new System.Drawing.Size(146, 23);
            this.lname_box.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "First name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(13, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(265, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type:";
            // 
            // m_radio
            // 
            this.m_radio.AutoSize = true;
            this.m_radio.BackColor = System.Drawing.Color.Transparent;
            this.m_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_radio.Location = new System.Drawing.Point(331, 39);
            this.m_radio.Name = "m_radio";
            this.m_radio.Size = new System.Drawing.Size(56, 21);
            this.m_radio.TabIndex = 8;
            this.m_radio.TabStop = true;
            this.m_radio.Text = "Male";
            this.m_radio.UseVisualStyleBackColor = false;
            // 
            // f_radio
            // 
            this.f_radio.AutoSize = true;
            this.f_radio.BackColor = System.Drawing.Color.Transparent;
            this.f_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.f_radio.Location = new System.Drawing.Point(393, 39);
            this.f_radio.Name = "f_radio";
            this.f_radio.Size = new System.Drawing.Size(72, 21);
            this.f_radio.TabIndex = 9;
            this.f_radio.TabStop = true;
            this.f_radio.Text = "Female";
            this.f_radio.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(265, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender:";
            // 
            // mail_box
            // 
            this.mail_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mail_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mail_box.Location = new System.Drawing.Point(97, 143);
            this.mail_box.MaxLength = 200;
            this.mail_box.Name = "mail_box";
            this.mail_box.Size = new System.Drawing.Size(146, 23);
            this.mail_box.TabIndex = 6;
            // 
            // phon_box
            // 
            this.phon_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.phon_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phon_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phon_box.Location = new System.Drawing.Point(322, 13);
            this.phon_box.MaxLength = 10;
            this.phon_box.Name = "phon_box";
            this.phon_box.Size = new System.Drawing.Size(170, 23);
            this.phon_box.TabIndex = 7;
            this.phon_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phon_box_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(40, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "E-Mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(265, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(265, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Department:";
            // 
            // dept_box
            // 
            this.dept_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dept_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dept_box.FormattingEnabled = true;
            this.dept_box.ItemHeight = 16;
            this.dept_box.Location = new System.Drawing.Point(357, 90);
            this.dept_box.Name = "dept_box";
            this.dept_box.Size = new System.Drawing.Size(135, 24);
            this.dept_box.TabIndex = 11;
            // 
            // grade_label
            // 
            this.grade_label.AutoSize = true;
            this.grade_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grade_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grade_label.Location = new System.Drawing.Point(265, 67);
            this.grade_label.Name = "grade_label";
            this.grade_label.Size = new System.Drawing.Size(65, 17);
            this.grade_label.TabIndex = 23;
            this.grade_label.Text = "Average:";
            // 
            // grade_box
            // 
            this.grade_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grade_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grade_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grade_box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grade_box.Location = new System.Drawing.Point(336, 65);
            this.grade_box.MaxLength = 3;
            this.grade_box.Name = "grade_box";
            this.grade_box.Size = new System.Drawing.Size(156, 23);
            this.grade_box.TabIndex = 24;
            this.grade_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grade_box_KeyPress);
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ok_button.Image = global::University.Properties.Resources.Ok_icon1;
            this.ok_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ok_button.Location = new System.Drawing.Point(268, 124);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(110, 42);
            this.ok_button.TabIndex = 12;
            this.ok_button.Text = "Confirm";
            this.ok_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // ex_button
            // 
            this.ex_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ex_button.Image = global::University.Properties.Resources.delete_icon;
            this.ex_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ex_button.Location = new System.Drawing.Point(384, 124);
            this.ex_button.Name = "ex_button";
            this.ex_button.Size = new System.Drawing.Size(110, 42);
            this.ex_button.TabIndex = 13;
            this.ex_button.Text = "Cancel";
            this.ex_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ex_button.UseVisualStyleBackColor = true;
            this.ex_button.Click += new System.EventHandler(this.ex_button_Click);
            // 
            // F_Register
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 182);
            this.Controls.Add(this.grade_box);
            this.Controls.Add(this.grade_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dept_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phon_box);
            this.Controls.Add(this.mail_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.f_radio);
            this.Controls.Add(this.m_radio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lname_box);
            this.Controls.Add(this.fname_box);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.ex_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.f_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button ex_button;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.TextBox fname_box;
        private System.Windows.Forms.TextBox lname_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton m_radio;
        private System.Windows.Forms.RadioButton f_radio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mail_box;
        private System.Windows.Forms.TextBox phon_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dept_box;
        private System.Windows.Forms.Label grade_label;
        private System.Windows.Forms.TextBox grade_box;
    }
}