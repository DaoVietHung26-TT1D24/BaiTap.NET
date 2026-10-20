namespace BaiTapLonC
{
    partial class FormC3
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
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMin = new System.Windows.Forms.RadioButton();
            this.rdoMax = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdGiam = new System.Windows.Forms.RadioButton();
            this.rdoTang = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.txtKetQuaSapXep = new System.Windows.Forms.TextBox();
            this.txtDaySo = new System.Windows.Forms.TextBox();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(245, 168);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(354, 127);
            this.txtKetQua.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMin);
            this.groupBox1.Controls.Add(this.rdoMax);
            this.groupBox1.Location = new System.Drawing.Point(35, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Min/Max";
            // 
            // rdMin
            // 
            this.rdMin.AutoSize = true;
            this.rdMin.Location = new System.Drawing.Point(21, 71);
            this.rdMin.Name = "rdMin";
            this.rdMin.Size = new System.Drawing.Size(51, 21);
            this.rdMin.TabIndex = 0;
            this.rdMin.TabStop = true;
            this.rdMin.Text = "Min";
            this.rdMin.UseVisualStyleBackColor = true;
            // 
            // rdoMax
            // 
            this.rdoMax.AutoSize = true;
            this.rdoMax.Location = new System.Drawing.Point(21, 44);
            this.rdoMax.Name = "rdoMax";
            this.rdoMax.Size = new System.Drawing.Size(54, 21);
            this.rdoMax.TabIndex = 0;
            this.rdoMax.TabStop = true;
            this.rdoMax.Text = "Max";
            this.rdoMax.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dãy số vừa nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập N";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdGiam);
            this.groupBox2.Controls.Add(this.rdoTang);
            this.groupBox2.Location = new System.Drawing.Point(35, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 97);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp";
            // 
            // rdGiam
            // 
            this.rdGiam.AutoSize = true;
            this.rdGiam.Location = new System.Drawing.Point(21, 58);
            this.rdGiam.Name = "rdGiam";
            this.rdGiam.Size = new System.Drawing.Size(62, 21);
            this.rdGiam.TabIndex = 0;
            this.rdGiam.TabStop = true;
            this.rdGiam.Text = "Giảm";
            this.rdGiam.UseVisualStyleBackColor = true;
            // 
            // rdoTang
            // 
            this.rdoTang.AutoSize = true;
            this.rdoTang.Location = new System.Drawing.Point(21, 32);
            this.rdoTang.Name = "rdoTang";
            this.rdoTang.Size = new System.Drawing.Size(62, 21);
            this.rdoTang.TabIndex = 0;
            this.rdoTang.TabStop = true;
            this.rdoTang.Text = "Tăng";
            this.rdoTang.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(632, 293);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 40);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(632, 229);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(163, 40);
            this.btnSapXep.TabIndex = 13;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(632, 168);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(163, 40);
            this.btnMinMax.TabIndex = 14;
            this.btnMinMax.Text = "Tìm Min-Max";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(632, 103);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(163, 40);
            this.btnTaoMang.TabIndex = 15;
            this.btnTaoMang.Text = "Tạo mảng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // txtKetQuaSapXep
            // 
            this.txtKetQuaSapXep.Location = new System.Drawing.Point(245, 320);
            this.txtKetQuaSapXep.Multiline = true;
            this.txtKetQuaSapXep.Name = "txtKetQuaSapXep";
            this.txtKetQuaSapXep.ReadOnly = true;
            this.txtKetQuaSapXep.Size = new System.Drawing.Size(354, 97);
            this.txtKetQuaSapXep.TabIndex = 9;
            // 
            // txtDaySo
            // 
            this.txtDaySo.Location = new System.Drawing.Point(245, 105);
            this.txtDaySo.Multiline = true;
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.ReadOnly = true;
            this.txtDaySo.Size = new System.Drawing.Size(354, 49);
            this.txtDaySo.TabIndex = 10;
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(245, 48);
            this.txtNhapN.Multiline = true;
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(354, 31);
            this.txtNhapN.TabIndex = 11;
            // 
            // FormC3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 464);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.txtKetQuaSapXep);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.txtNhapN);
            this.Name = "FormC3";
            this.Text = "FormC3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMin;
        private System.Windows.Forms.RadioButton rdoMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdGiam;
        private System.Windows.Forms.RadioButton rdoTang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.TextBox txtKetQuaSapXep;
        private System.Windows.Forms.TextBox txtDaySo;
        private System.Windows.Forms.TextBox txtNhapN;
    }
}