namespace BaiTapLonB_QT
{
    partial class FormB7
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKetQuaTinhToan = new System.Windows.Forms.GroupBox();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.lblPhuCapCV = new System.Windows.Forms.Label();
            this.txtLuongThoiGian = new System.Windows.Forms.TextBox();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.txtThuongNgay = new System.Windows.Forms.TextBox();
            this.lblThuongNgay = new System.Windows.Forms.Label();
            this.txtPhuCapCV = new System.Windows.Forms.TextBox();
            this.lblLuongThoiGian = new System.Windows.Forms.Label();
            this.grpThongTinNhap = new System.Windows.Forms.GroupBox();
            this.txtHeSoPhuCap = new System.Windows.Forms.TextBox();
            this.txtSoNgayCong = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.lblHeSoPhuCap = new System.Windows.Forms.Label();
            this.lblSoNgayCong = new System.Windows.Forms.Label();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grpKetQuaTinhToan.SuspendLayout();
            this.grpThongTinNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(531, 499);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 46);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLamLai.Location = new System.Drawing.Point(223, 499);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(117, 46);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "LÀM LẠI";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.ForeColor = System.Drawing.Color.Lime;
            this.btnTinhLuong.Location = new System.Drawing.Point(29, 499);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(117, 46);
            this.btnTinhLuong.TabIndex = 7;
            this.btnTinhLuong.Text = "TÍNH LƯƠNG";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÍNH LƯƠNG NHÂN VIÊN";
            // 
            // grpKetQuaTinhToan
            // 
            this.grpKetQuaTinhToan.Controls.Add(this.txtTongCong);
            this.grpKetQuaTinhToan.Controls.Add(this.lblPhuCapCV);
            this.grpKetQuaTinhToan.Controls.Add(this.txtLuongThoiGian);
            this.grpKetQuaTinhToan.Controls.Add(this.lblTongCong);
            this.grpKetQuaTinhToan.Controls.Add(this.txtThuongNgay);
            this.grpKetQuaTinhToan.Controls.Add(this.lblThuongNgay);
            this.grpKetQuaTinhToan.Controls.Add(this.txtPhuCapCV);
            this.grpKetQuaTinhToan.Controls.Add(this.lblLuongThoiGian);
            this.grpKetQuaTinhToan.Location = new System.Drawing.Point(420, 68);
            this.grpKetQuaTinhToan.Name = "grpKetQuaTinhToan";
            this.grpKetQuaTinhToan.Size = new System.Drawing.Size(349, 336);
            this.grpKetQuaTinhToan.TabIndex = 3;
            this.grpKetQuaTinhToan.TabStop = false;
            this.grpKetQuaTinhToan.Text = "KẾT QUẢ TÍNH TOÁN";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Location = new System.Drawing.Point(32, 290);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(311, 22);
            this.txtTongCong.TabIndex = 1;
            // 
            // lblPhuCapCV
            // 
            this.lblPhuCapCV.AutoSize = true;
            this.lblPhuCapCV.Location = new System.Drawing.Point(31, 43);
            this.lblPhuCapCV.Name = "lblPhuCapCV";
            this.lblPhuCapCV.Size = new System.Drawing.Size(113, 17);
            this.lblPhuCapCV.TabIndex = 0;
            this.lblPhuCapCV.Text = "Phụ cấp chức vụ";
            // 
            // txtLuongThoiGian
            // 
            this.txtLuongThoiGian.Location = new System.Drawing.Point(32, 217);
            this.txtLuongThoiGian.Name = "txtLuongThoiGian";
            this.txtLuongThoiGian.ReadOnly = true;
            this.txtLuongThoiGian.Size = new System.Drawing.Size(311, 22);
            this.txtLuongThoiGian.TabIndex = 1;
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(31, 263);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(94, 17);
            this.lblTongCong.TabIndex = 0;
            this.lblTongCong.Text = "TỔNG CỘNG";
            // 
            // txtThuongNgay
            // 
            this.txtThuongNgay.Location = new System.Drawing.Point(32, 148);
            this.txtThuongNgay.Name = "txtThuongNgay";
            this.txtThuongNgay.ReadOnly = true;
            this.txtThuongNgay.Size = new System.Drawing.Size(311, 22);
            this.txtThuongNgay.TabIndex = 1;
            // 
            // lblThuongNgay
            // 
            this.lblThuongNgay.AutoSize = true;
            this.lblThuongNgay.Location = new System.Drawing.Point(31, 111);
            this.lblThuongNgay.Name = "lblThuongNgay";
            this.lblThuongNgay.Size = new System.Drawing.Size(92, 17);
            this.lblThuongNgay.TabIndex = 0;
            this.lblThuongNgay.Text = "Thưởng ngày";
            // 
            // txtPhuCapCV
            // 
            this.txtPhuCapCV.Location = new System.Drawing.Point(32, 77);
            this.txtPhuCapCV.Name = "txtPhuCapCV";
            this.txtPhuCapCV.ReadOnly = true;
            this.txtPhuCapCV.Size = new System.Drawing.Size(311, 22);
            this.txtPhuCapCV.TabIndex = 1;
            // 
            // lblLuongThoiGian
            // 
            this.lblLuongThoiGian.AutoSize = true;
            this.lblLuongThoiGian.Location = new System.Drawing.Point(31, 189);
            this.lblLuongThoiGian.Name = "lblLuongThoiGian";
            this.lblLuongThoiGian.Size = new System.Drawing.Size(114, 17);
            this.lblLuongThoiGian.TabIndex = 0;
            this.lblLuongThoiGian.Text = "Lương Thời Gian";
            // 
            // grpThongTinNhap
            // 
            this.grpThongTinNhap.Controls.Add(this.txtHeSoPhuCap);
            this.grpThongTinNhap.Controls.Add(this.txtSoNgayCong);
            this.grpThongTinNhap.Controls.Add(this.txtLuongCoBan);
            this.grpThongTinNhap.Controls.Add(this.txtTenNV);
            this.grpThongTinNhap.Controls.Add(this.cboMaNV);
            this.grpThongTinNhap.Controls.Add(this.lblHeSoPhuCap);
            this.grpThongTinNhap.Controls.Add(this.lblSoNgayCong);
            this.grpThongTinNhap.Controls.Add(this.lblLuongCoBan);
            this.grpThongTinNhap.Controls.Add(this.lblTenNV);
            this.grpThongTinNhap.Controls.Add(this.lblMaNV);
            this.grpThongTinNhap.Location = new System.Drawing.Point(9, 68);
            this.grpThongTinNhap.Name = "grpThongTinNhap";
            this.grpThongTinNhap.Size = new System.Drawing.Size(349, 411);
            this.grpThongTinNhap.TabIndex = 4;
            this.grpThongTinNhap.TabStop = false;
            this.grpThongTinNhap.Text = "THÔNG TIN NHẬP";
            // 
            // txtHeSoPhuCap
            // 
            this.txtHeSoPhuCap.Location = new System.Drawing.Point(20, 368);
            this.txtHeSoPhuCap.Name = "txtHeSoPhuCap";
            this.txtHeSoPhuCap.Size = new System.Drawing.Size(311, 22);
            this.txtHeSoPhuCap.TabIndex = 1;
            // 
            // txtSoNgayCong
            // 
            this.txtSoNgayCong.Location = new System.Drawing.Point(20, 295);
            this.txtSoNgayCong.Name = "txtSoNgayCong";
            this.txtSoNgayCong.Size = new System.Drawing.Size(311, 22);
            this.txtSoNgayCong.TabIndex = 1;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(20, 226);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(311, 22);
            this.txtLuongCoBan.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(20, 155);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(311, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Items.AddRange(new object[] {
            "NVV1",
            "TVV2",
            "NNV3",
            "KKV4"});
            this.cboMaNV.Location = new System.Drawing.Point(20, 75);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(311, 24);
            this.cboMaNV.TabIndex = 1;
            this.cboMaNV.Text = "(Danh sách mã)";
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // lblHeSoPhuCap
            // 
            this.lblHeSoPhuCap.AutoSize = true;
            this.lblHeSoPhuCap.Location = new System.Drawing.Point(17, 331);
            this.lblHeSoPhuCap.Name = "lblHeSoPhuCap";
            this.lblHeSoPhuCap.Size = new System.Drawing.Size(100, 17);
            this.lblHeSoPhuCap.TabIndex = 0;
            this.lblHeSoPhuCap.Text = "Hệ số phụ cấp";
            // 
            // lblSoNgayCong
            // 
            this.lblSoNgayCong.AutoSize = true;
            this.lblSoNgayCong.Location = new System.Drawing.Point(17, 263);
            this.lblSoNgayCong.Name = "lblSoNgayCong";
            this.lblSoNgayCong.Size = new System.Drawing.Size(97, 17);
            this.lblSoNgayCong.TabIndex = 0;
            this.lblSoNgayCong.Text = "Số ngày Công";
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Location = new System.Drawing.Point(17, 189);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(98, 17);
            this.lblLuongCoBan.TabIndex = 0;
            this.lblLuongCoBan.Text = "Lương Cơ Bản";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(17, 111);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(99, 17);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(20, 28);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(97, 17);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // FormB7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 557);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpKetQuaTinhToan);
            this.Controls.Add(this.grpThongTinNhap);
            this.Name = "FormB7";
            this.Text = "FormB7";
            this.grpKetQuaTinhToan.ResumeLayout(false);
            this.grpKetQuaTinhToan.PerformLayout();
            this.grpThongTinNhap.ResumeLayout(false);
            this.grpThongTinNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpKetQuaTinhToan;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label lblPhuCapCV;
        private System.Windows.Forms.TextBox txtLuongThoiGian;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.TextBox txtThuongNgay;
        private System.Windows.Forms.Label lblThuongNgay;
        private System.Windows.Forms.TextBox txtPhuCapCV;
        private System.Windows.Forms.Label lblLuongThoiGian;
        private System.Windows.Forms.GroupBox grpThongTinNhap;
        private System.Windows.Forms.TextBox txtHeSoPhuCap;
        private System.Windows.Forms.TextBox txtSoNgayCong;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label lblHeSoPhuCap;
        private System.Windows.Forms.Label lblSoNgayCong;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
    }
}