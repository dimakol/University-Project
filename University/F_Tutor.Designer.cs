namespace University
{
    partial class F_Tutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Tutor));
            this.hello_label = new System.Windows.Forms.Label();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hello_label.Location = new System.Drawing.Point(12, 22);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(107, 20);
            this.hello_label.TabIndex = 3;
            this.hello_label.Text = "welcome here";
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePass.Image = global::University.Properties.Resources.password_change;
            this.btn_ChangePass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ChangePass.Location = new System.Drawing.Point(607, 12);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(120, 85);
            this.btn_ChangePass.TabIndex = 18;
            this.btn_ChangePass.Text = "Change Pass";
            this.btn_ChangePass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            this.btn_ChangePass.MouseHover += new System.EventHandler(this.btn_ChangePass_MouseHover);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::University.Properties.Resources.Log_Out;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(733, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = "Log Out";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::University.Properties.Resources.preferences_system_time;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(481, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reception";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::University.Properties.Resources.file_edit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(355, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit Info";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // F_Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::University.Properties.Resources.old_chem_teacher_timey_time_again_file_desktop_2560x1600_hd_wallpaper_579700;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 314);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.hello_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Tutor";
            this.Text = "Tutor Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.F_Tutor_SizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.F_Tutor_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.Button btn_ChangePass;
    }
}