namespace BaiTapLonB_QT
{
    partial class FormB5
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
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnLeCuoi = new System.Windows.Forms.Button();
            this.btnChanDau = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.grpNhapSoNguyen = new System.Windows.Forms.GroupBox();
            this.btnNhapSo = new System.Windows.Forms.Button();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpChucNang.SuspendLayout();
            this.grpNhapSoNguyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoaDaySo
            // 
            this.btnXoaDaySo.Location = new System.Drawing.Point(520, 538);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(235, 34);
            this.btnXoaDaySo.TabIndex = 9;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = true;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.Red;
            this.btnKetThuc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKetThuc.Location = new System.Drawing.Point(142, 538);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(230, 34);
            this.btnKetThuc.TabIndex = 10;
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.FormattingEnabled = true;
            this.lsbDaySo.ItemHeight = 16;
            this.lsbDaySo.Location = new System.Drawing.Point(72, 193);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(361, 324);
            this.lsbDaySo.TabIndex = 8;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnXoaCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaDau);
            this.grpChucNang.Controls.Add(this.btnXoaChon);
            this.grpChucNang.Controls.Add(this.btnLeCuoi);
            this.grpChucNang.Controls.Add(this.btnChanDau);
            this.grpChucNang.Controls.Add(this.btnTang2);
            this.grpChucNang.Location = new System.Drawing.Point(432, 193);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(399, 324);
            this.grpChucNang.TabIndex = 7;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng:";
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaCuoi.Location = new System.Drawing.Point(65, 265);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(276, 32);
            this.btnXoaCuoi.TabIndex = 1;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = false;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaDau.Location = new System.Drawing.Point(65, 218);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(276, 32);
            this.btnXoaDau.TabIndex = 1;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = false;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaChon.Location = new System.Drawing.Point(65, 170);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(276, 32);
            this.btnXoaChon.TabIndex = 1;
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = false;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnLeCuoi
            // 
            this.btnLeCuoi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLeCuoi.Location = new System.Drawing.Point(65, 123);
            this.btnLeCuoi.Name = "btnLeCuoi";
            this.btnLeCuoi.Size = new System.Drawing.Size(276, 32);
            this.btnLeCuoi.TabIndex = 1;
            this.btnLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnLeCuoi.UseVisualStyleBackColor = false;
            this.btnLeCuoi.Click += new System.EventHandler(this.btnLeCuoi_Click);
            // 
            // btnChanDau
            // 
            this.btnChanDau.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChanDau.Location = new System.Drawing.Point(65, 71);
            this.btnChanDau.Name = "btnChanDau";
            this.btnChanDau.Size = new System.Drawing.Size(276, 32);
            this.btnChanDau.TabIndex = 1;
            this.btnChanDau.Text = "Chọn số chẵn đầu";
            this.btnChanDau.UseVisualStyleBackColor = false;
            this.btnChanDau.Click += new System.EventHandler(this.btnChanDau_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTang2.Location = new System.Drawing.Point(65, 23);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(276, 32);
            this.btnTang2.TabIndex = 1;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = false;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // grpNhapSoNguyen
            // 
            this.grpNhapSoNguyen.Controls.Add(this.btnNhapSo);
            this.grpNhapSoNguyen.Controls.Add(this.txtNhapSo);
            this.grpNhapSoNguyen.Location = new System.Drawing.Point(72, 92);
            this.grpNhapSoNguyen.Name = "grpNhapSoNguyen";
            this.grpNhapSoNguyen.Size = new System.Drawing.Size(759, 87);
            this.grpNhapSoNguyen.TabIndex = 6;
            this.grpNhapSoNguyen.TabStop = false;
            this.grpNhapSoNguyen.Text = "Nhập số nguyên";
            // 
            // btnNhapSo
            // 
            this.btnNhapSo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNhapSo.Location = new System.Drawing.Point(538, 22);
            this.btnNhapSo.Name = "btnNhapSo";
            this.btnNhapSo.Size = new System.Drawing.Size(138, 37);
            this.btnNhapSo.TabIndex = 1;
            this.btnNhapSo.Text = "Nhập số";
            this.btnNhapSo.UseVisualStyleBackColor = false;
            this.btnNhapSo.Click += new System.EventHandler(this.btnNhapSo_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(198, 21);
            this.txtNhapSo.Multiline = true;
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(279, 39);
            this.txtNhapSo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, -40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ứng dụng xử lý dãy số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ứng dụng xử lý dãy số";
            // 
            // FormB5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoaDaySo);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpNhapSoNguyen);
            this.Controls.Add(this.label1);
            this.Name = "FormB5";
            this.Text = "FormB5";
            this.grpChucNang.ResumeLayout(false);
            this.grpNhapSoNguyen.ResumeLayout(false);
            this.grpNhapSoNguyen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaDaySo;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnLeCuoi;
        private System.Windows.Forms.Button btnChanDau;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.GroupBox grpNhapSoNguyen;
        private System.Windows.Forms.Button btnNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}