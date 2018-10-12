namespace StudentBiometricAttendanceRegistry
{
    partial class frm_message
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
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(602, 349);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 38);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Maroon;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(291, 349);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 38);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Teal;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(123, 100);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(34, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "TO:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Teal;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(63, 191);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(94, 20);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "MESSAGE:";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(163, 94);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(290, 26);
            this.txtTo.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(163, 145);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(524, 165);
            this.txtMessage.TabIndex = 5;
            // 
            // frm_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_send);
            this.Name = "frm_message";
            this.Text = "SEND MESSAGE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtMessage;
    }
}