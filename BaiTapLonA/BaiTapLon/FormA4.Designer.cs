namespace BaiTapLonA
{
    partial class FormA4
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
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtChiSoCuoi = new System.Windows.Forms.TextBox();
            this.txtChiSoDau = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblChiSoCuoi = new System.Windows.Forms.Label();
            this.lblChiSoDau = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(254, 220);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(114, 34);
            this.btnLamLai.TabIndex = 17;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(86, 220);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(114, 34);
            this.btnDongY.TabIndex = 16;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // txtSoTien
            // 
            this.txtSoTien.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSoTien.Location = new System.Drawing.Point(206, 173);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.Size = new System.Drawing.Size(131, 15);
            this.txtSoTien.TabIndex = 15;
            // 
            // txtChiSoCuoi
            // 
            this.txtChiSoCuoi.Location = new System.Drawing.Point(206, 122);
            this.txtChiSoCuoi.Name = "txtChiSoCuoi";
            this.txtChiSoCuoi.Size = new System.Drawing.Size(131, 22);
            this.txtChiSoCuoi.TabIndex = 14;
            // 
            // txtChiSoDau
            // 
            this.txtChiSoDau.Location = new System.Drawing.Point(206, 80);
            this.txtChiSoDau.Name = "txtChiSoDau";
            this.txtChiSoDau.Size = new System.Drawing.Size(131, 22);
            this.txtChiSoDau.TabIndex = 13;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(77, 173);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(123, 17);
            this.lblSoTien.TabIndex = 12;
            this.lblSoTien.Text = "Số tiền phải đóng:";
            // 
            // lblChiSoCuoi
            // 
            this.lblChiSoCuoi.AutoSize = true;
            this.lblChiSoCuoi.Location = new System.Drawing.Point(77, 125);
            this.lblChiSoCuoi.Name = "lblChiSoCuoi";
            this.lblChiSoCuoi.Size = new System.Drawing.Size(77, 17);
            this.lblChiSoCuoi.TabIndex = 11;
            this.lblChiSoCuoi.Text = "Chỉ số cuối";
            // 
            // lblChiSoDau
            // 
            this.lblChiSoDau.AutoSize = true;
            this.lblChiSoDau.Location = new System.Drawing.Point(77, 80);
            this.lblChiSoDau.Name = "lblChiSoDau";
            this.lblChiSoDau.Size = new System.Drawing.Size(75, 17);
            this.lblChiSoDau.TabIndex = 10;
            this.lblChiSoDau.Text = "Chỉ số đầu";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(98, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(239, 36);
            this.lblTieuDe.TabIndex = 9;
            this.lblTieuDe.Text = "TÍNH TIỀN ĐIỆN";
            // 
            // FormA4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 282);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtChiSoCuoi);
            this.Controls.Add(this.txtChiSoDau);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.lblChiSoCuoi);
            this.Controls.Add(this.lblChiSoDau);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "FormA4";
            this.Text = "FormA4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtChiSoCuoi;
        private System.Windows.Forms.TextBox txtChiSoDau;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label lblChiSoCuoi;
        private System.Windows.Forms.Label lblChiSoDau;
        private System.Windows.Forms.Label lblTieuDe;
    }
}