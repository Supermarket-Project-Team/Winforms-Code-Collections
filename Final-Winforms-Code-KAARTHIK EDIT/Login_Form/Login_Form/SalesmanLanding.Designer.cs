namespace Login_Form
{
    partial class SalesmanLanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanLanding));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.img_salesman = new System.Windows.Forms.PictureBox();
            this.lbl_mart_name = new System.Windows.Forms.Label();
            this.btn_logout_salesman = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.lbl_notification_salesman = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_salesman_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_salesman)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_mart_name);
            this.panel1.Controls.Add(this.btn_logout_salesman);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 531);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_salesman_name);
            this.panel3.Controls.Add(this.img_salesman);
            this.panel3.Location = new System.Drawing.Point(61, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 163);
            this.panel3.TabIndex = 6;
            // 
            // img_salesman
            // 
            this.img_salesman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img_salesman.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img_salesman.ErrorImage")));
            this.img_salesman.Image = ((System.Drawing.Image)(resources.GetObject("img_salesman.Image")));
            this.img_salesman.Location = new System.Drawing.Point(23, 35);
            this.img_salesman.Name = "img_salesman";
            this.img_salesman.Size = new System.Drawing.Size(122, 89);
            this.img_salesman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_salesman.TabIndex = 6;
            this.img_salesman.TabStop = false;
            // 
            // lbl_mart_name
            // 
            this.lbl_mart_name.AutoSize = true;
            this.lbl_mart_name.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mart_name.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_mart_name.Location = new System.Drawing.Point(30, 29);
            this.lbl_mart_name.Name = "lbl_mart_name";
            this.lbl_mart_name.Size = new System.Drawing.Size(239, 51);
            this.lbl_mart_name.TabIndex = 5;
            this.lbl_mart_name.Text = "Cetacean Mart";
            this.lbl_mart_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_logout_salesman
            // 
            this.btn_logout_salesman.FlatAppearance.BorderSize = 0;
            this.btn_logout_salesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout_salesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout_salesman.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_logout_salesman.Location = new System.Drawing.Point(20, 366);
            this.btn_logout_salesman.Name = "btn_logout_salesman";
            this.btn_logout_salesman.Size = new System.Drawing.Size(249, 44);
            this.btn_logout_salesman.TabIndex = 4;
            this.btn_logout_salesman.Text = "Log Out";
            this.btn_logout_salesman.UseVisualStyleBackColor = true;
            this.btn_logout_salesman.Click += new System.EventHandler(this.btn_logout_salesman_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.FlatAppearance.BorderSize = 0;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_billing.Location = new System.Drawing.Point(20, 313);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(249, 47);
            this.btn_billing.TabIndex = 2;
            this.btn_billing.Text = "Billing Page";
            this.btn_billing.UseVisualStyleBackColor = true;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // lbl_notification_salesman
            // 
            this.lbl_notification_salesman.AutoSize = true;
            this.lbl_notification_salesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notification_salesman.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_notification_salesman.Location = new System.Drawing.Point(505, 42);
            this.lbl_notification_salesman.Name = "lbl_notification_salesman";
            this.lbl_notification_salesman.Size = new System.Drawing.Size(100, 20);
            this.lbl_notification_salesman.TabIndex = 8;
            this.lbl_notification_salesman.Text = "Notification";
            this.lbl_notification_salesman.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(322, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 386);
            this.panel2.TabIndex = 7;
            // 
            // lbl_salesman_name
            // 
            this.lbl_salesman_name.AutoSize = true;
            this.lbl_salesman_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesman_name.Location = new System.Drawing.Point(62, 127);
            this.lbl_salesman_name.Name = "lbl_salesman_name";
            this.lbl_salesman_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_salesman_name.TabIndex = 7;
            // 
            // SalesmanLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1028, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_notification_salesman);
            this.Controls.Add(this.panel2);
            this.Name = "SalesmanLanding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesmanLanding";
            this.Load += new System.EventHandler(this.SalesmanLanding_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_salesman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img_salesman;
        private System.Windows.Forms.Label lbl_mart_name;
        private System.Windows.Forms.Button btn_logout_salesman;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Label lbl_notification_salesman;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_salesman_name;
    }
}