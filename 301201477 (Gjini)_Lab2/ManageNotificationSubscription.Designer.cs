namespace _301201477__Gjini__Lab2
{
    partial class ManageNotificationSubscription
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
            this.chckEmail = new System.Windows.Forms.CheckBox();
            this.chckSms = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSms = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSms = new System.Windows.Forms.Label();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chckEmail
            // 
            this.chckEmail.AutoSize = true;
            this.chckEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckEmail.Location = new System.Drawing.Point(42, 52);
            this.chckEmail.Name = "chckEmail";
            this.chckEmail.Size = new System.Drawing.Size(202, 22);
            this.chckEmail.TabIndex = 0;
            this.chckEmail.Text = "Notification Sent by Email:";
            this.chckEmail.UseVisualStyleBackColor = true;
            this.chckEmail.CheckedChanged += new System.EventHandler(this.chckEmail_CheckedChanged);
            // 
            // chckSms
            // 
            this.chckSms.AutoSize = true;
            this.chckSms.Location = new System.Drawing.Point(42, 100);
            this.chckSms.Name = "chckSms";
            this.chckSms.Size = new System.Drawing.Size(166, 19);
            this.chckSms.TabIndex = 1;
            this.chckSms.Text = "Notification Sent by SMS:";
            this.chckSms.UseVisualStyleBackColor = true;
            this.chckSms.CheckedChanged += new System.EventHandler(this.chckSms_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(478, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSms
            // 
            this.txtSms.Location = new System.Drawing.Point(478, 100);
            this.txtSms.Name = "txtSms";
            this.txtSms.Size = new System.Drawing.Size(100, 20);
            this.txtSms.TabIndex = 3;
            this.txtSms.TextChanged += new System.EventHandler(this.txtSms_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(626, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(155, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Invalid Email Address";
            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Location = new System.Drawing.Point(626, 105);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new System.Drawing.Size(100, 19);
            this.lblSms.TabIndex = 5;
            this.lblSms.Text = "Invalid phone";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(42, 242);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(148, 44);
            this.btnSubscribe.TabIndex = 6;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(274, 242);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(146, 44);
            this.btnUnsubscribe.TabIndex = 7;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(506, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ManageNotificationSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.lblSms);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSms);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chckSms);
            this.Controls.Add(this.chckEmail);
            this.Name = "ManageNotificationSubscription";
            this.Text = "Manage Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckEmail;
        private System.Windows.Forms.CheckBox chckSms;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSms;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSms;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnCancel;
    }
}