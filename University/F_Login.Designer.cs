namespace University
{
    partial class F_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.reg_button = new System.Windows.Forms.Button();
            this.log_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.pass_Click);
            // 
            // user_box
            // 
            this.user_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.user_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.user_box.Location = new System.Drawing.Point(128, 36);
            this.user_box.MaxLength = 12;
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(130, 26);
            this.user_box.TabIndex = 1;
            this.user_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pass_box
            // 
            this.pass_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pass_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pass_box.Location = new System.Drawing.Point(128, 64);
            this.pass_box.MaxLength = 12;
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(130, 26);
            this.pass_box.TabIndex = 2;
            this.pass_box.UseSystemPasswordChar = true;
            this.pass_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reg_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pass_box);
            this.groupBox1.Controls.Add(this.log_button);
            this.groupBox1.Controls.Add(this.user_box);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            this.groupBox1.LocationChanged += new System.EventHandler(this.groupBox1_LocationChanged);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(22, 95);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // reg_button
            // 
            this.reg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.reg_button.Image = global::University.Properties.Resources._1430426618_document_pencil;
            this.reg_button.Location = new System.Drawing.Point(138, 118);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(120, 42);
            this.reg_button.TabIndex = 4;
            this.reg_button.Text = "Register";
            this.reg_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // log_button
            // 
            this.log_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.log_button.Image = ((System.Drawing.Image)(resources.GetObject("log_button.Image")));
            this.log_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.log_button.Location = new System.Drawing.Point(12, 118);
            this.log_button.Name = "log_button";
            this.log_button.Size = new System.Drawing.Size(120, 42);
            this.log_button.TabIndex = 3;
            this.log_button.Text = "Login";
            this.log_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.log_button.UseVisualStyleBackColor = true;
            this.log_button.Click += new System.EventHandler(this.log_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University.Properties.Resources.membership_icon;
            this.pictureBox1.Location = new System.Drawing.Point(287, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // F_Login
            // 
            this.AcceptButton = this.log_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 182);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.f_login_Load_1);
            this.LocationChanged += new System.EventHandler(this.F_Login_LocationChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button log_button;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

