namespace University
{
    partial class F_Password_Recovery
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
            this.id_box = new System.Windows.Forms.TextBox();
            this.mail_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.id_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.id_box.Location = new System.Drawing.Point(112, 44);
            this.id_box.MaxLength = 9;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(157, 26);
            this.id_box.TabIndex = 1;
            this.id_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_box_KeyPress);
            // 
            // mail_box
            // 
            this.mail_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mail_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mail_box.Location = new System.Drawing.Point(85, 82);
            this.mail_box.MaxLength = 200;
            this.mail_box.Name = "mail_box";
            this.mail_box.Size = new System.Drawing.Size(184, 26);
            this.mail_box.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft MHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please enter your information below:";
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.back_button.Image = global::University.Properties.Resources.back__2_;
            this.back_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.back_button.Location = new System.Drawing.Point(150, 118);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(120, 42);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Go Back";
            this.back_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // send_button
            // 
            this.send_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.send_button.Image = global::University.Properties.Resources.mail_send2;
            this.send_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.send_button.Location = new System.Drawing.Point(24, 118);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(120, 42);
            this.send_button.TabIndex = 3;
            this.send_button.Text = "Recover";
            this.send_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // F_Password_Recovery
            // 
            this.AcceptButton = this.send_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mail_box);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Password_Recovery";
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.F_Password_Recovery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox mail_box;
        private System.Windows.Forms.Label label3;
    }
}