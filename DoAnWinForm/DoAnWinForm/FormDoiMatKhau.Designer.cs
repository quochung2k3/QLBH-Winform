namespace DoAnWinForm
{
    partial class FormDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMatKhau));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnShowPass2 = new System.Windows.Forms.Button();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Info;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(248, 264);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(158, 46);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Info;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(432, 264);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(158, 46);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "Xác nhận";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnShowPass2
            // 
            this.btnShowPass2.BackColor = System.Drawing.SystemColors.Window;
            this.btnShowPass2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPass2.BackgroundImage")));
            this.btnShowPass2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPass2.FlatAppearance.BorderSize = 0;
            this.btnShowPass2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowPass2.Location = new System.Drawing.Point(542, 182);
            this.btnShowPass2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPass2.Name = "btnShowPass2";
            this.btnShowPass2.Size = new System.Drawing.Size(47, 42);
            this.btnShowPass2.TabIndex = 28;
            this.btnShowPass2.UseVisualStyleBackColor = false;
            this.btnShowPass2.Click += new System.EventHandler(this.btnShowPass2_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(248, 180);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(342, 45);
            this.txtMatKhauMoi.TabIndex = 27;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(59, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.SystemColors.Window;
            this.btnShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPass.BackgroundImage")));
            this.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowPass.Location = new System.Drawing.Point(542, 98);
            this.btnShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(47, 42);
            this.btnShowPass.TabIndex = 25;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhauCu.Location = new System.Drawing.Point(248, 97);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(342, 45);
            this.txtMatKhauCu.TabIndex = 24;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mật khẩu hiện tại:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.Location = new System.Drawing.Point(248, 22);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(342, 45);
            this.txtUsername.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username:";
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(629, 329);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnShowPass2);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "FormDoiMatKhau";
            this.Text = "FormDoiMatKhau";
            this.Load += new System.EventHandler(this.FormDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnShowPass2;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
    }
}