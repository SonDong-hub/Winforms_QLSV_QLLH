namespace BT_QLSV_QLLH
{
    partial class Form1
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
            this.lb_dangnhap = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.chb_ghinhomk = new System.Windows.Forms.CheckBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.lb_qmk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_dangnhap
            // 
            this.lb_dangnhap.AutoSize = true;
            this.lb_dangnhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dangnhap.Location = new System.Drawing.Point(311, 61);
            this.lb_dangnhap.Name = "lb_dangnhap";
            this.lb_dangnhap.Size = new System.Drawing.Size(147, 32);
            this.lb_dangnhap.TabIndex = 0;
            this.lb_dangnhap.Text = "Đăng nhập";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(146, 114);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(88, 22);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Username";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(146, 142);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(88, 22);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Password";
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(254, 114);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(300, 22);
            this.txb_username.TabIndex = 3;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(254, 142);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(300, 22);
            this.txb_password.TabIndex = 3;
            // 
            // chb_ghinhomk
            // 
            this.chb_ghinhomk.AutoSize = true;
            this.chb_ghinhomk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ghinhomk.Location = new System.Drawing.Point(254, 170);
            this.chb_ghinhomk.Name = "chb_ghinhomk";
            this.chb_ghinhomk.Size = new System.Drawing.Size(134, 21);
            this.chb_ghinhomk.TabIndex = 4;
            this.chb_ghinhomk.Text = "Ghi nhớ mật khẩu";
            this.chb_ghinhomk.UseVisualStyleBackColor = true;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangnhap.FlatAppearance.BorderSize = 0;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Location = new System.Drawing.Point(308, 213);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(150, 40);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // lb_qmk
            // 
            this.lb_qmk.AutoSize = true;
            this.lb_qmk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qmk.Location = new System.Drawing.Point(449, 171);
            this.lb_qmk.Name = "lb_qmk";
            this.lb_qmk.Size = new System.Drawing.Size(105, 17);
            this.lb_qmk.TabIndex = 6;
            this.lb_qmk.Text = "Quên mật khẩu?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_qmk);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.chb_ghinhomk);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_dangnhap);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dangnhap;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.CheckBox chb_ghinhomk;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label lb_qmk;
    }
}

