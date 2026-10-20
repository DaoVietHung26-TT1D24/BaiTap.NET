namespace BaiTapLonB_QT
{
    partial class FormB4
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
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.grpTuyChon = new System.Windows.Forms.GroupBox();
            this.rdoBSCNN = new System.Windows.Forms.RadioButton();
            this.rdoUSCLN = new System.Windows.Forms.RadioButton();
            this.gprNhapDuLieu = new System.Windows.Forms.GroupBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblSoA = new System.Windows.Forms.Label();
            this.grpKetQua.SuspendLayout();
            this.grpTuyChon.SuspendLayout();
            this.gprNhapDuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.btnThoat);
            this.grpKetQua.Controls.Add(this.btnTim);
            this.grpKetQua.Controls.Add(this.txtKetQua);
            this.grpKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQua.Location = new System.Drawing.Point(69, 235);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(620, 148);
            this.grpKetQua.TabIndex = 4;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Magenta;
            this.btnThoat.Location = new System.Drawing.Point(392, 89);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 32);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Magenta;
            this.btnTim.Location = new System.Drawing.Point(392, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(163, 32);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKetQua.BackColor = System.Drawing.Color.Indigo;
            this.txtKetQua.ForeColor = System.Drawing.Color.White;
            this.txtKetQua.Location = new System.Drawing.Point(77, 44);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(216, 32);
            this.txtKetQua.TabIndex = 1;
            this.txtKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpTuyChon
            // 
            this.grpTuyChon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpTuyChon.Controls.Add(this.rdoBSCNN);
            this.grpTuyChon.Controls.Add(this.rdoUSCLN);
            this.grpTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTuyChon.Location = new System.Drawing.Point(492, 27);
            this.grpTuyChon.Name = "grpTuyChon";
            this.grpTuyChon.Size = new System.Drawing.Size(235, 176);
            this.grpTuyChon.TabIndex = 2;
            this.grpTuyChon.TabStop = false;
            this.grpTuyChon.Text = "Tùy chọn:";
            // 
            // rdoBSCNN
            // 
            this.rdoBSCNN.AutoSize = true;
            this.rdoBSCNN.Location = new System.Drawing.Point(46, 105);
            this.rdoBSCNN.Name = "rdoBSCNN";
            this.rdoBSCNN.Size = new System.Drawing.Size(94, 24);
            this.rdoBSCNN.TabIndex = 0;
            this.rdoBSCNN.TabStop = true;
            this.rdoBSCNN.Text = "BSCNN";
            this.rdoBSCNN.UseVisualStyleBackColor = true;
            // 
            // rdoUSCLN
            // 
            this.rdoUSCLN.AutoSize = true;
            this.rdoUSCLN.Checked = true;
            this.rdoUSCLN.Location = new System.Drawing.Point(46, 47);
            this.rdoUSCLN.Name = "rdoUSCLN";
            this.rdoUSCLN.Size = new System.Drawing.Size(92, 24);
            this.rdoUSCLN.TabIndex = 0;
            this.rdoUSCLN.TabStop = true;
            this.rdoUSCLN.Text = "USCLN";
            this.rdoUSCLN.UseVisualStyleBackColor = true;
            // 
            // gprNhapDuLieu
            // 
            this.gprNhapDuLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gprNhapDuLieu.Controls.Add(this.txtSoB);
            this.gprNhapDuLieu.Controls.Add(this.txtSoA);
            this.gprNhapDuLieu.Controls.Add(this.lblSoB);
            this.gprNhapDuLieu.Controls.Add(this.lblSoA);
            this.gprNhapDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gprNhapDuLieu.Location = new System.Drawing.Point(12, 27);
            this.gprNhapDuLieu.Name = "gprNhapDuLieu";
            this.gprNhapDuLieu.Size = new System.Drawing.Size(439, 176);
            this.gprNhapDuLieu.TabIndex = 3;
            this.gprNhapDuLieu.TabStop = false;
            this.gprNhapDuLieu.Text = "Nhập dữ liệu:";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(168, 118);
            this.txtSoB.Multiline = true;
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(260, 36);
            this.txtSoB.TabIndex = 1;
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(168, 44);
            this.txtSoA.Multiline = true;
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(260, 36);
            this.txtSoA.TabIndex = 1;
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(32, 121);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(118, 20);
            this.lblSoB.TabIndex = 0;
            this.lblSoB.Text = "Số nguyên b:";
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(32, 47);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(118, 20);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số nguyên a:";
            // 
            // FormB4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 411);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpTuyChon);
            this.Controls.Add(this.gprNhapDuLieu);
            this.Name = "FormB4";
            this.Text = "FormB4";
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.grpTuyChon.ResumeLayout(false);
            this.grpTuyChon.PerformLayout();
            this.gprNhapDuLieu.ResumeLayout(false);
            this.gprNhapDuLieu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox grpTuyChon;
        private System.Windows.Forms.RadioButton rdoBSCNN;
        private System.Windows.Forms.RadioButton rdoUSCLN;
        private System.Windows.Forms.GroupBox gprNhapDuLieu;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoA;
    }
}