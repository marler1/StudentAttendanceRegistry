namespace StudentBiometricAttendanceRegistry
{
    partial class attReport_frm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.dataToPrint_lbl = new System.Windows.Forms.Label();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(644, 398);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(102, 40);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.Green;
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(822, 400);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(93, 38);
            this.print_btn.TabIndex = 2;
            this.print_btn.Text = "PRINT";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // dataToPrint_lbl
            // 
            this.dataToPrint_lbl.AutoSize = true;
            this.dataToPrint_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataToPrint_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataToPrint_lbl.Location = new System.Drawing.Point(283, 15);
            this.dataToPrint_lbl.Name = "dataToPrint_lbl";
            this.dataToPrint_lbl.Size = new System.Drawing.Size(222, 20);
            this.dataToPrint_lbl.TabIndex = 3;
            this.dataToPrint_lbl.Text = "Attendance Report Print Form";
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.lblUnit);
            this.panelPrint.Controls.Add(this.label3);
            this.panelPrint.Controls.Add(this.lblCourse);
            this.panelPrint.Controls.Add(this.dataGridView1);
            this.panelPrint.Controls.Add(this.label1);
            this.panelPrint.Controls.Add(this.dataToPrint_lbl);
            this.panelPrint.Location = new System.Drawing.Point(13, 3);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(927, 391);
            this.panelPrint.TabIndex = 4;
            this.panelPrint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrint_Paint);
            // 
            // lblUnit
            // 
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(112, 92);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(497, 25);
            this.lblUnit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit:";
            // 
            // lblCourse
            // 
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(112, 44);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(497, 25);
            this.lblCourse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course:";
            // 
            // attReport_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.panelPrint);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.cancel_btn);
            this.Name = "attReport_frm";
            this.Text = "View Attendance Report";
            this.Load += new System.EventHandler(this.attReport_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Label dataToPrint_lbl;
        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label label1;
    }
}