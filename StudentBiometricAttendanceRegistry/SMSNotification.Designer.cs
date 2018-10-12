namespace StudentBiometricAttendanceRegistry
{
    partial class SMSNotification
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(529, 336);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(114, 52);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(262, 336);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 52);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipient.Location = new System.Drawing.Point(157, 107);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(29, 18);
            this.lblRecipient.TabIndex = 2;
            this.lblRecipient.Text = "TO";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(101, 169);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(82, 18);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "MESSAGE";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(189, 107);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(286, 26);
            this.txtNumber.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(189, 165);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(473, 136);
            this.txtMessage.TabIndex = 5;
            // 
            // SMSNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSend);
            this.Name = "SMSNotification";
            this.Text = "SMSNotification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtMessage;
    }
}