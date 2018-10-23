namespace StudentBiometricAttendanceRegistry
{
    partial class unitName_cb
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
            this.addUnit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unitCode_cb = new System.Windows.Forms.ComboBox();
            this.year_cb = new System.Windows.Forms.ComboBox();
            this.course_cb = new System.Windows.Forms.ComboBox();
            this.unitName_txt = new System.Windows.Forms.ComboBox();
            this.lecturer_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.department_btn = new System.Windows.Forms.Button();
            this.addCourse_btn = new System.Windows.Forms.Button();
            this.adminLogout_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addLec_btn = new System.Windows.Forms.Button();
            this.regStudent_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addUnit_btn
            // 
            this.addUnit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addUnit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUnit_btn.ForeColor = System.Drawing.Color.Black;
            this.addUnit_btn.Location = new System.Drawing.Point(440, 370);
            this.addUnit_btn.Name = "addUnit_btn";
            this.addUnit_btn.Size = new System.Drawing.Size(140, 56);
            this.addUnit_btn.TabIndex = 0;
            this.addUnit_btn.Text = "SUBMIT";
            this.addUnit_btn.UseVisualStyleBackColor = false;
            this.addUnit_btn.Click += new System.EventHandler(this.addUnit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "lecturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Year";
            // 
            // unitCode_cb
            // 
            this.unitCode_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitCode_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitCode_cb.FormattingEnabled = true;
            this.unitCode_cb.Items.AddRange(new object[] {
            "BIT 2201",
            "ICS 2100",
            "BIT 2701",
            "BIT 2607",
            "BIT 2200",
            "ICS 2767"});
            this.unitCode_cb.Location = new System.Drawing.Point(355, 78);
            this.unitCode_cb.Name = "unitCode_cb";
            this.unitCode_cb.Size = new System.Drawing.Size(433, 26);
            this.unitCode_cb.TabIndex = 13;
            // 
            // year_cb
            // 
            this.year_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_cb.FormattingEnabled = true;
            this.year_cb.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.year_cb.Location = new System.Drawing.Point(355, 311);
            this.year_cb.Name = "year_cb";
            this.year_cb.Size = new System.Drawing.Size(433, 26);
            this.year_cb.TabIndex = 14;
            // 
            // course_cb
            // 
            this.course_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_cb.FormattingEnabled = true;
            this.course_cb.Items.AddRange(new object[] {
            "BSc. Computer Science",
            "BSc. Information Technology",
            "BSc. Business Information Technology",
            "Bachelor of Commerce",
            "BSc. Mechanical Enginnering",
            "BSc. Civil Enginnering",
            "BSc. Nursing"});
            this.course_cb.Location = new System.Drawing.Point(355, 256);
            this.course_cb.Name = "course_cb";
            this.course_cb.Size = new System.Drawing.Size(433, 26);
            this.course_cb.TabIndex = 15;
            // 
            // unitName_txt
            // 
            this.unitName_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitName_txt.FormattingEnabled = true;
            this.unitName_txt.Items.AddRange(new object[] {
            "Operating Systems 1",
            "Distributed Systems",
            "Human Computer Interactions",
            "Fundamentals of Computeter Security",
            "Computer Network Design"});
            this.unitName_txt.Location = new System.Drawing.Point(355, 146);
            this.unitName_txt.Name = "unitName_txt";
            this.unitName_txt.Size = new System.Drawing.Size(433, 26);
            this.unitName_txt.TabIndex = 16;
            // 
            // lecturer_txt
            // 
            this.lecturer_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturer_txt.Location = new System.Drawing.Point(355, 201);
            this.lecturer_txt.Name = "lecturer_txt";
            this.lecturer_txt.Size = new System.Drawing.Size(433, 24);
            this.lecturer_txt.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.department_btn);
            this.panel1.Controls.Add(this.addCourse_btn);
            this.panel1.Controls.Add(this.adminLogout_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addLec_btn);
            this.panel1.Controls.Add(this.regStudent_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 475);
            this.panel1.TabIndex = 18;
            // 
            // department_btn
            // 
            this.department_btn.BackColor = System.Drawing.Color.Teal;
            this.department_btn.ForeColor = System.Drawing.Color.Transparent;
            this.department_btn.Location = new System.Drawing.Point(3, 126);
            this.department_btn.Name = "department_btn";
            this.department_btn.Size = new System.Drawing.Size(242, 45);
            this.department_btn.TabIndex = 10;
            this.department_btn.Text = "HOME";
            this.department_btn.UseVisualStyleBackColor = false;
            // 
            // addCourse_btn
            // 
            this.addCourse_btn.BackColor = System.Drawing.Color.Teal;
            this.addCourse_btn.ForeColor = System.Drawing.Color.Transparent;
            this.addCourse_btn.Location = new System.Drawing.Point(3, 332);
            this.addCourse_btn.Name = "addCourse_btn";
            this.addCourse_btn.Size = new System.Drawing.Size(242, 45);
            this.addCourse_btn.TabIndex = 9;
            this.addCourse_btn.Text = "ADD COURSE";
            this.addCourse_btn.UseVisualStyleBackColor = false;
            // 
            // adminLogout_btn
            // 
            this.adminLogout_btn.BackColor = System.Drawing.Color.Teal;
            this.adminLogout_btn.ForeColor = System.Drawing.Color.Transparent;
            this.adminLogout_btn.Location = new System.Drawing.Point(3, 383);
            this.adminLogout_btn.Name = "adminLogout_btn";
            this.adminLogout_btn.Size = new System.Drawing.Size(242, 45);
            this.adminLogout_btn.TabIndex = 8;
            this.adminLogout_btn.Text = "LOG OUT";
            this.adminLogout_btn.UseVisualStyleBackColor = false;
            this.adminLogout_btn.Click += new System.EventHandler(this.adminLogout_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(3, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD UNIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addLec_btn
            // 
            this.addLec_btn.BackColor = System.Drawing.Color.Teal;
            this.addLec_btn.ForeColor = System.Drawing.Color.Transparent;
            this.addLec_btn.Location = new System.Drawing.Point(3, 228);
            this.addLec_btn.Name = "addLec_btn";
            this.addLec_btn.Size = new System.Drawing.Size(242, 46);
            this.addLec_btn.TabIndex = 4;
            this.addLec_btn.Text = "ADD LECTURER";
            this.addLec_btn.UseVisualStyleBackColor = false;
            // 
            // regStudent_btn
            // 
            this.regStudent_btn.BackColor = System.Drawing.Color.Teal;
            this.regStudent_btn.ForeColor = System.Drawing.Color.Transparent;
            this.regStudent_btn.Location = new System.Drawing.Point(3, 177);
            this.regStudent_btn.Name = "regStudent_btn";
            this.regStudent_btn.Size = new System.Drawing.Size(242, 45);
            this.regStudent_btn.TabIndex = 2;
            this.regStudent_btn.Text = "REGISTER STUDENT";
            this.regStudent_btn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(42, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Better life through Technology";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentBiometricAttendanceRegistry.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // unitName_cb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lecturer_txt);
            this.Controls.Add(this.unitName_txt);
            this.Controls.Add(this.course_cb);
            this.Controls.Add(this.year_cb);
            this.Controls.Add(this.unitCode_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUnit_btn);
            this.Name = "unitName_cb";
            this.Text = "select unit name";
            this.Load += new System.EventHandler(this.unitName_cb_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUnit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox unitCode_cb;
        private System.Windows.Forms.ComboBox year_cb;
        private System.Windows.Forms.ComboBox course_cb;
        private System.Windows.Forms.ComboBox unitName_txt;
        private System.Windows.Forms.TextBox lecturer_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button department_btn;
        private System.Windows.Forms.Button addCourse_btn;
        private System.Windows.Forms.Button adminLogout_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addLec_btn;
        private System.Windows.Forms.Button regStudent_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}