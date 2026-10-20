namespace BaiTapLonC
{
    partial class FormC2
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
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnDemLe = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.rdoGiam = new System.Windows.Forms.RadioButton();
            this.rdoTang = new System.Windows.Forms.RadioButton();
            this.rdoMin = new System.Windows.Forms.RadioButton();
            this.rdoMax = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMangGoc = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(382, 375);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(202, 50);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(154, 375);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(202, 50);
            this.btnMin.TabIndex = 10;
            this.btnMin.Text = "Tìm phần tử nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnTimMin_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(382, 319);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(202, 50);
            this.btnSapXep.TabIndex = 11;
            this.btnSapXep.Text = "Sắp xếp tăng";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXepTang_Click);
            // 
            // btnDemLe
            // 
            this.btnDemLe.Location = new System.Drawing.Point(154, 319);
            this.btnDemLe.Name = "btnDemLe";
            this.btnDemLe.Size = new System.Drawing.Size(202, 50);
            this.btnDemLe.TabIndex = 12;
            this.btnDemLe.Text = "Đếm các số lẻ";
            this.btnDemLe.UseVisualStyleBackColor = true;
            this.btnDemLe.Click += new System.EventHandler(this.btnDemSoLe_Click);
            // 
            // btnTongLe
            // 
            this.btnTongLe.Location = new System.Drawing.Point(382, 263);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(202, 50);
            this.btnTongLe.TabIndex = 13;
            this.btnTongLe.Text = "Tổng các số lẻ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            this.btnTongLe.Click += new System.EventHandler(this.btnTongSoLe_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(154, 263);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(202, 50);
            this.btnXuat.TabIndex = 14;
            this.btnXuat.Text = "Xuất ngẫu nhiên";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuatNgauNhien_Click);
            // 
            // rdoGiam
            // 
            this.rdoGiam.AutoSize = true;
            this.rdoGiam.Location = new System.Drawing.Point(579, 196);
            this.rdoGiam.Name = "rdoGiam";
            this.rdoGiam.Size = new System.Drawing.Size(62, 21);
            this.rdoGiam.TabIndex = 5;
            this.rdoGiam.TabStop = true;
            this.rdoGiam.Text = "Giảm";
            this.rdoGiam.UseVisualStyleBackColor = true;
            // 
            // rdoTang
            // 
            this.rdoTang.AutoSize = true;
            this.rdoTang.Location = new System.Drawing.Point(404, 196);
            this.rdoTang.Name = "rdoTang";
            this.rdoTang.Size = new System.Drawing.Size(62, 21);
            this.rdoTang.TabIndex = 6;
            this.rdoTang.TabStop = true;
            this.rdoTang.Text = "Tăng";
            this.rdoTang.UseVisualStyleBackColor = true;
            // 
            // rdoMin
            // 
            this.rdoMin.AutoSize = true;
            this.rdoMin.Location = new System.Drawing.Point(237, 196);
            this.rdoMin.Name = "rdoMin";
            this.rdoMin.Size = new System.Drawing.Size(51, 21);
            this.rdoMin.TabIndex = 7;
            this.rdoMin.TabStop = true;
            this.rdoMin.Text = "Min";
            this.rdoMin.UseVisualStyleBackColor = true;
            // 
            // rdoMax
            // 
            this.rdoMax.AutoSize = true;
            this.rdoMax.Location = new System.Drawing.Point(89, 196);
            this.rdoMax.Name = "rdoMax";
            this.rdoMax.Size = new System.Drawing.Size(54, 21);
            this.rdoMax.TabIndex = 8;
            this.rdoMax.TabStop = true;
            this.rdoMax.Text = "Max";
            this.rdoMax.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(190, 21);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(392, 31);
            this.txtKetQua.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMangGoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng gốc:";
            // 
            // txtMangGoc
            // 
            this.txtMangGoc.Location = new System.Drawing.Point(190, 21);
            this.txtMangGoc.Multiline = true;
            this.txtMangGoc.Name = "txtMangGoc";
            this.txtMangGoc.Size = new System.Drawing.Size(392, 31);
            this.txtMangGoc.TabIndex = 0;
            // 
            // FormC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 451);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnDemLe);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.rdoGiam);
            this.Controls.Add(this.rdoTang);
            this.Controls.Add(this.rdoMin);
            this.Controls.Add(this.rdoMax);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormC2";
            this.Text = "Tìm dãy số Cao/Thấp";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnDemLe;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.RadioButton rdoGiam;
        private System.Windows.Forms.RadioButton rdoTang;
        private System.Windows.Forms.RadioButton rdoMin;
        private System.Windows.Forms.RadioButton rdoMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMangGoc;
    }
}

