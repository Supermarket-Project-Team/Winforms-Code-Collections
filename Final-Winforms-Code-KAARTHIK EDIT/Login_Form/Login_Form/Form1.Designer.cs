namespace Login_Form
{
    partial class form_login
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
            this.Login_panel = new System.Windows.Forms.Panel();
            this.cmb_designation = new System.Windows.Forms.ComboBox();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.lbl_mart_name = new System.Windows.Forms.Label();
            this.lbl_username_error = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.Login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_panel.Controls.Add(this.cmb_designation);
            this.Login_panel.Controls.Add(this.lbl_designation);
            this.Login_panel.Controls.Add(this.lbl_mart_name);
            this.Login_panel.Controls.Add(this.lbl_username_error);
            this.Login_panel.Controls.Add(this.btn_Login);
            this.Login_panel.Controls.Add(this.btn_exit);
            this.Login_panel.Controls.Add(this.txt_password);
            this.Login_panel.Controls.Add(this.txt_username);
            this.Login_panel.Controls.Add(this.lbl_password);
            this.Login_panel.Controls.Add(this.lbl_username);
            this.Login_panel.Location = new System.Drawing.Point(12, 12);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(455, 306);
            this.Login_panel.TabIndex = 0;
            // 
            // cmb_designation
            // 
            this.cmb_designation.FormattingEnabled = true;
            this.cmb_designation.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "SALESMAN"});
            this.cmb_designation.Location = new System.Drawing.Point(183, 177);
            this.cmb_designation.Name = "cmb_designation";
            this.cmb_designation.Size = new System.Drawing.Size(192, 21);
            this.cmb_designation.TabIndex = 10;
            this.cmb_designation.Text = "--Select--";
            // 
            // lbl_designation
            // 
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation.Location = new System.Drawing.Point(79, 177);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(90, 18);
            this.lbl_designation.TabIndex = 9;
            this.lbl_designation.Text = "Designation:";
            // 
            // lbl_mart_name
            // 
            this.lbl_mart_name.AutoSize = true;
            this.lbl_mart_name.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mart_name.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_mart_name.Location = new System.Drawing.Point(141, 13);
            this.lbl_mart_name.Name = "lbl_mart_name";
            this.lbl_mart_name.Size = new System.Drawing.Size(179, 51);
            this.lbl_mart_name.TabIndex = 8;
            this.lbl_mart_name.Text = "LuLu Mart";
            this.lbl_mart_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_username_error
            // 
            this.lbl_username_error.AutoSize = true;
            this.lbl_username_error.Location = new System.Drawing.Point(158, 104);
            this.lbl_username_error.Name = "lbl_username_error";
            this.lbl_username_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_username_error.TabIndex = 7;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Ivory;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(276, 226);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(98, 30);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Ivory;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(160, 226);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 30);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(183, 130);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(192, 26);
            this.txt_password.TabIndex = 4;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(183, 92);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(192, 22);
            this.txt_username.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(82, 132);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(79, 18);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(80, 92);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 18);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username:";
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(479, 330);
            this.Controls.Add(this.Login_panel);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_username_error;
        private System.Windows.Forms.Label lbl_mart_name;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.ComboBox cmb_designation;
    }
}

