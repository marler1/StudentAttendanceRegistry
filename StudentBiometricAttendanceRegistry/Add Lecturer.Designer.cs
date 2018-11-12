namespace StudentBiometricAttendanceRegistry
{
    partial class Add_Lecturer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitLecDetails_btb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lecPassword_txt = new System.Windows.Forms.TextBox();
            this.lecUsername_txt = new System.Windows.Forms.TextBox();
            this.lecPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lecEmail_txt = new System.Windows.Forms.TextBox();
            this.lecTel_txt = new System.Windows.Forms.TextBox();
            this.lecLname_txt = new System.Windows.Forms.TextBox();
            this.lecFname_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSMS = new System.Windows.Forms.Button();
            this.adminLogout_btn = new System.Windows.Forms.Button();
            this.addUnit_btn = new System.Windows.Forms.Button();
            this.addLec_btn = new System.Windows.Forms.Button();
            this.regStudent_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telephone *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email *";
            // 
            // submitLecDetails_btb
            // 
            this.submitLecDetails_btb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.submitLecDetails_btb.ForeColor = System.Drawing.Color.White;
            this.submitLecDetails_btb.Location = new System.Drawing.Point(415, 355);
            this.submitLecDetails_btb.Name = "submitLecDetails_btb";
            this.submitLecDetails_btb.Size = new System.Drawing.Size(141, 42);
            this.submitLecDetails_btb.TabIndex = 7;
            this.submitLecDetails_btb.Text = "SUBMIT";
            this.submitLecDetails_btb.UseVisualStyleBackColor = false;
            this.submitLecDetails_btb.Click += new System.EventHandler(this.submitLecDetails_btb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.lecPassword_txt);
            this.groupBox1.Controls.Add(this.lecUsername_txt);
            this.groupBox1.Controls.Add(this.lecPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lecEmail_txt);
            this.groupBox1.Controls.Add(this.lecTel_txt);
            this.groupBox1.Controls.Add(this.lecLname_txt);
            this.groupBox1.Controls.Add(this.lecFname_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.submitLecDetails_btb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(269, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 426);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "key in lecturer\'s details";
            // 
            // lecPassword_txt
            // 
            this.lecPassword_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecPassword_txt.Location = new System.Drawing.Point(36, 315);
            this.lecPassword_txt.Name = "lecPassword_txt";
            this.lecPassword_txt.PasswordChar = '*';
            this.lecPassword_txt.Size = new System.Drawing.Size(520, 24);
            this.lecPassword_txt.TabIndex = 17;
            // 
            // lecUsername_txt
            // 
            this.lecUsername_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecUsername_txt.Location = new System.Drawing.Point(36, 254);
            this.lecUsername_txt.Name = "lecUsername_txt";
            this.lecUsername_txt.Size = new System.Drawing.Size(520, 24);
            this.lecUsername_txt.TabIndex = 16;
            // 
            // lecPassword
            // 
            this.lecPassword.AutoSize = true;
            this.lecPassword.Location = new System.Drawing.Point(36, 287);
            this.lecPassword.Name = "lecPassword";
            this.lecPassword.Size = new System.Drawing.Size(59, 13);
            this.lecPassword.TabIndex = 15;
            this.lecPassword.Text = "password *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "username *";
            // 
            // lecEmail_txt
            // 
            this.lecEmail_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecEmail_txt.Location = new System.Drawing.Point(36, 201);
            this.lecEmail_txt.Name = "lecEmail_txt";
            this.lecEmail_txt.Size = new System.Drawing.Size(520, 24);
            this.lecEmail_txt.TabIndex = 13;
            this.lecEmail_txt.TextChanged += new System.EventHandler(this.lecEmail_txt_TextChanged);
            // 
            // lecTel_txt
            // 
            this.lecTel_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecTel_txt.Location = new System.Drawing.Point(37, 155);
            this.lecTel_txt.MaxLength = 10;
            this.lecTel_txt.Name = "lecTel_txt";
            this.lecTel_txt.Size = new System.Drawing.Size(519, 24);
            this.lecTel_txt.TabIndex = 11;
            this.lecTel_txt.TextChanged += new System.EventHandler(this.lecTel_txt_TextChanged);
            // 
            // lecLname_txt
            // 
            this.lecLname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecLname_txt.Location = new System.Drawing.Point(38, 94);
            this.lecLname_txt.Name = "lecLname_txt";
            this.lecLname_txt.Size = new System.Drawing.Size(518, 24);
            this.lecLname_txt.TabIndex = 9;
            // 
            // lecFname_txt
            // 
            this.lecFname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecFname_txt.Location = new System.Drawing.Point(37, 41);
            this.lecFname_txt.Name = "lecFname_txt";
            this.lecFname_txt.Size = new System.Drawing.Size(519, 24);
            this.lecFname_txt.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnSMS);
            this.panel1.Controls.Add(this.adminLogout_btn);
            this.panel1.Controls.Add(this.addUnit_btn);
            this.panel1.Controls.Add(this.addLec_btn);
            this.panel1.Controls.Add(this.regStudent_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 441);
            this.panel1.TabIndex = 9;
            // 
            // btnSMS
            // 
            this.btnSMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSMS.ForeColor = System.Drawing.Color.Black;
            this.btnSMS.Location = new System.Drawing.Point(3, 299);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(242, 55);
            this.btnSMS.TabIndex = 12;
            this.btnSMS.Text = "SEND SMS";
            this.btnSMS.UseVisualStyleBackColor = false;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // adminLogout_btn
            // 
            this.adminLogout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.adminLogout_btn.Location = new System.Drawing.Point(3, 367);
            this.adminLogout_btn.Name = "adminLogout_btn";
            this.adminLogout_btn.Size = new System.Drawing.Size(242, 45);
            this.adminLogout_btn.TabIndex = 8;
            this.adminLogout_btn.Text = "LOG OUT";
            this.adminLogout_btn.UseVisualStyleBackColor = false;
            this.adminLogout_btn.Click += new System.EventHandler(this.adminLogout_btn_Click);
            // 
            // addUnit_btn
            // 
            this.addUnit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addUnit_btn.Location = new System.Drawing.Point(3, 238);
            this.addUnit_btn.Name = "addUnit_btn";
            this.addUnit_btn.Size = new System.Drawing.Size(242, 55);
            this.addUnit_btn.TabIndex = 6;
            this.addUnit_btn.Text = "ADD UNIT";
            this.addUnit_btn.UseVisualStyleBackColor = false;
            this.addUnit_btn.Click += new System.EventHandler(this.addUnit_btn_Click);
            // 
            // addLec_btn
            // 
            this.addLec_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addLec_btn.Location = new System.Drawing.Point(3, 186);
            this.addLec_btn.Name = "addLec_btn";
            this.addLec_btn.Size = new System.Drawing.Size(242, 46);
            this.addLec_btn.TabIndex = 4;
            this.addLec_btn.Text = "ADD LECTURER";
            this.addLec_btn.UseVisualStyleBackColor = false;
            this.addLec_btn.Click += new System.EventHandler(this.addLec_btn_Click);
            // 
            // regStudent_btn
            // 
            this.regStudent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.regStudent_btn.Location = new System.Drawing.Point(3, 138);
            this.regStudent_btn.Name = "regStudent_btn";
            this.regStudent_btn.Size = new System.Drawing.Size(242, 45);
            this.regStudent_btn.TabIndex = 2;
            this.regStudent_btn.Text = "REGISTER STUDENT";
            this.regStudent_btn.UseVisualStyleBackColor = false;
            this.regStudent_btn.Click += new System.EventHandler(this.regStudent_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Better life through Technology";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentBiometricAttendanceRegistry.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Maroon;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(97, 355);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(141, 42);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Add_Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Lecturer";
            this.Text = "Add_Lecturer";
            this.Load += new System.EventHandler(this.Add_Lecturer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitLecDetails_btb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lecEmail_txt;
        private System.Windows.Forms.TextBox lecTel_txt;
        private System.Windows.Forms.TextBox lecLname_txt;
        private System.Windows.Forms.TextBox lecFname_txt;
        private System.Windows.Forms.TextBox lecPassword_txt;
        private System.Windows.Forms.TextBox lecUsername_txt;
        private System.Windows.Forms.Label lecPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adminLogout_btn;
        private System.Windows.Forms.Button addUnit_btn;
        private System.Windows.Forms.Button addLec_btn;
        private System.Windows.Forms.Button regStudent_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSMS;
        private System.Windows.Forms.Button btn_back;
    }
}