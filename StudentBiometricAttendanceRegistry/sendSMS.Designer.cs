namespace StudentBiometricAttendanceRegistry
{
    partial class frm_sendSMS
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
            this.btnsend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.Location = new System.Drawing.Point(469, 436);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(108, 40);
            this.btnsend.TabIndex = 0;
            this.btnsend.Text = "SEND";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(123, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NUMBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MESSAGE";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(188, 70);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(399, 20);
            this.txtKey.TabIndex = 5;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(188, 133);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(399, 20);
            this.txtSender.TabIndex = 6;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(188, 199);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(399, 72);
            this.txtNum.TabIndex = 7;
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(188, 294);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(399, 99);
            this.txtmessage.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Olive;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(188, 436);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 49);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_sendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(747, 497);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsend);
            this.Name = "frm_sendSMS";
            this.Text = "Send SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button btnBack;
    }
}