namespace BaiTapLonA
{
    partial class FormA3
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.txtHKII = new System.Windows.Forms.TextBox();
            this.txtHKI = new System.Windows.Forms.TextBox();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.lblHKII = new System.Windows.Forms.Label();
            this.lblHKI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(89, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(274, 32);
            this.lblTieuDe.TabIndex = 10;
            this.lblTieuDe.Text = "XẾP LOẠI HỌC TẬP";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(258, 197);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(114, 34);
            this.btnLamLai.TabIndex = 18;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(73, 197);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(114, 34);
            this.btnDongY.TabIndex = 17;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Location = new System.Drawing.Point(181, 148);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.ReadOnly = true;
            this.txtXepLoai.Size = new System.Drawing.Size(182, 22);
            this.txtXepLoai.TabIndex = 16;
            // 
            // txtHKII
            // 
            this.txtHKII.Location = new System.Drawing.Point(181, 102);
            this.txtHKII.Name = "txtHKII";
            this.txtHKII.Size = new System.Drawing.Size(182, 22);
            this.txtHKII.TabIndex = 15;
            // 
            // txtHKI
            // 
            this.txtHKI.Location = new System.Drawing.Point(181, 60);
            this.txtHKI.Name = "txtHKI";
            this.txtHKI.Size = new System.Drawing.Size(182, 22);
            this.txtHKI.TabIndex = 14;
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Location = new System.Drawing.Point(86, 148);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(59, 17);
            this.lblXepLoai.TabIndex = 13;
            this.lblXepLoai.Text = "Xếp loại";
            // 
            // lblHKII
            // 
            this.lblHKII.AutoSize = true;
            this.lblHKII.Location = new System.Drawing.Point(86, 105);
            this.lblHKII.Name = "lblHKII";
            this.lblHKII.Size = new System.Drawing.Size(69, 17);
            this.lblHKII.TabIndex = 12;
            this.lblHKII.Text = "Điểm HKII";
            // 
            // lblHKI
            // 
            this.lblHKI.AutoSize = true;
            this.lblHKI.Location = new System.Drawing.Point(86, 60);
            this.lblHKI.Name = "lblHKI";
            this.lblHKI.Size = new System.Drawing.Size(66, 17);
            this.lblHKI.TabIndex = 11;
            this.lblHKI.Text = "Điểm HKI";
            // 
            // FormA3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 251);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.txtHKII);
            this.Controls.Add(this.txtHKI);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.lblHKII);
            this.Controls.Add(this.lblHKI);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "FormA3";
            this.Text = "FormA3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.TextBox txtHKII;
        private System.Windows.Forms.TextBox txtHKI;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.Label lblHKII;
        private System.Windows.Forms.Label lblHKI;
    }
}