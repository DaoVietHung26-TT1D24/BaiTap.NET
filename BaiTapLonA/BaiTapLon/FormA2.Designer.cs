namespace BaiTapLonA
{
    partial class FormA2
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
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblChieuDai = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(339, 262);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(114, 34);
            this.btnLamLai.TabIndex = 17;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(154, 262);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(114, 34);
            this.btnTinh.TabIndex = 16;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(163, 214);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(290, 22);
            this.txtDienTich.TabIndex = 15;
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(163, 168);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.Size = new System.Drawing.Size(290, 22);
            this.txtChuVi.TabIndex = 14;
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(163, 83);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(290, 22);
            this.txtChieuDai.TabIndex = 13;
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(68, 217);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(63, 17);
            this.lblDienTich.TabIndex = 12;
            this.lblDienTich.Text = "Diện tích";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(68, 171);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(47, 17);
            this.lblChuVi.TabIndex = 11;
            this.lblChuVi.Text = "Chu vi";
            // 
            // lblChieuDai
            // 
            this.lblChieuDai.AutoSize = true;
            this.lblChieuDai.Location = new System.Drawing.Point(68, 83);
            this.lblChieuDai.Name = "lblChieuDai";
            this.lblChieuDai.Size = new System.Drawing.Size(67, 17);
            this.lblChieuDai.TabIndex = 10;
            this.lblChieuDai.Text = "Chiều dài";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(25, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(598, 36);
            this.lblTieuDe.TabIndex = 9;
            this.lblTieuDe.Text = "TÍNH CHU VI, DIỆN TÍCH HÌNH CHỮ NHẬT";
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(163, 126);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(290, 22);
            this.txtChieuRong.TabIndex = 19;
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Location = new System.Drawing.Point(68, 128);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(77, 17);
            this.lblChieuRong.TabIndex = 18;
            this.lblChieuRong.Text = "Chiều rộng";
            // 
            // FormA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 321);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.lblChieuRong);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.lblChieuDai);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "FormA2";
            this.Text = "FormA2";
            this.Load += new System.EventHandler(this.FormA2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblChieuDai;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.Label lblChieuRong;
    }
}