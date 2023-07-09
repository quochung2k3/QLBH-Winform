namespace DoAnWinForm
{
    partial class FormCapNhatSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncake = new System.Windows.Forms.Button();
            this.btntea = new System.Windows.Forms.Button();
            this.btncf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btncake);
            this.panel1.Controls.Add(this.btntea);
            this.panel1.Controls.Add(this.btncf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // btncake
            // 
            this.btncake.BackColor = System.Drawing.Color.Moccasin;
            this.btncake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncake.Location = new System.Drawing.Point(577, 111);
            this.btncake.Name = "btncake";
            this.btncake.Size = new System.Drawing.Size(196, 74);
            this.btncake.TabIndex = 2;
            this.btncake.Text = "Cập nhật CAKE";
            this.btncake.UseVisualStyleBackColor = false;
            this.btncake.Click += new System.EventHandler(this.btncake_Click_1);
            // 
            // btntea
            // 
            this.btntea.BackColor = System.Drawing.Color.Moccasin;
            this.btntea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntea.Location = new System.Drawing.Point(293, 111);
            this.btntea.Name = "btntea";
            this.btntea.Size = new System.Drawing.Size(196, 74);
            this.btntea.TabIndex = 1;
            this.btntea.Text = "Cập nhật TEA";
            this.btntea.UseVisualStyleBackColor = false;
            this.btntea.Click += new System.EventHandler(this.btntea_Click_1);
            // 
            // btncf
            // 
            this.btncf.BackColor = System.Drawing.Color.Moccasin;
            this.btncf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncf.Location = new System.Drawing.Point(24, 111);
            this.btncf.Name = "btncf";
            this.btncf.Size = new System.Drawing.Size(196, 74);
            this.btncf.TabIndex = 0;
            this.btncf.Text = "Cập nhật COFFEE";
            this.btncf.UseVisualStyleBackColor = false;
            this.btncf.Click += new System.EventHandler(this.btncf_Click_1);
            // 
            // FormCapNhatSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormCapNhatSanPham";
            this.Text = "FormCapNhatSanPham";
            this.Load += new System.EventHandler(this.FormCapNhatSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncake;
        private System.Windows.Forms.Button btntea;
        private System.Windows.Forms.Button btncf;
    }
}