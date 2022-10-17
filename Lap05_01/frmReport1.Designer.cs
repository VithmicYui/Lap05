namespace Lap05_01
{
    partial class Form1
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
            this.reportInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.optBangBaoGia = new System.Windows.Forms.RadioButton();
            this.cmbInvoidNo = new System.Windows.Forms.ComboBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.optGiaoHang = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // reportInvoice
            // 
            this.reportInvoice.LocalReport.ReportEmbeddedResource = "Lap05_01.PhieuGiaoHang.rdlc";
            this.reportInvoice.Location = new System.Drawing.Point(12, 196);
            this.reportInvoice.Name = "reportInvoice";
            this.reportInvoice.ServerReport.BearerToken = null;
            this.reportInvoice.Size = new System.Drawing.Size(1133, 314);
            this.reportInvoice.TabIndex = 0;
            // 
            // optBangBaoGia
            // 
            this.optBangBaoGia.AutoSize = true;
            this.optBangBaoGia.Location = new System.Drawing.Point(235, 35);
            this.optBangBaoGia.Name = "optBangBaoGia";
            this.optBangBaoGia.Size = new System.Drawing.Size(207, 20);
            this.optBangBaoGia.TabIndex = 1;
            this.optBangBaoGia.TabStop = true;
            this.optBangBaoGia.Text = "Xem Bảng Báo Giá Sản Phẩm";
            this.optBangBaoGia.UseVisualStyleBackColor = true;
            this.optBangBaoGia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmbInvoidNo
            // 
            this.cmbInvoidNo.FormattingEnabled = true;
            this.cmbInvoidNo.Location = new System.Drawing.Point(558, 35);
            this.cmbInvoidNo.Name = "cmbInvoidNo";
            this.cmbInvoidNo.Size = new System.Drawing.Size(403, 24);
            this.cmbInvoidNo.TabIndex = 2;
            this.cmbInvoidNo.SelectedIndexChanged += new System.EventHandler(this.cmbInvoidNo_SelectedIndexChanged);
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(857, 96);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(104, 33);
            this.btnxuat.TabIndex = 3;
            this.btnxuat.Text = "Xuất Report";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // optGiaoHang
            // 
            this.optGiaoHang.AutoSize = true;
            this.optGiaoHang.Location = new System.Drawing.Point(235, 70);
            this.optGiaoHang.Name = "optGiaoHang";
            this.optGiaoHang.Size = new System.Drawing.Size(160, 20);
            this.optGiaoHang.TabIndex = 4;
            this.optGiaoHang.TabStop = true;
            this.optGiaoHang.Text = "Xem Phiếu Giao Hàng";
            this.optGiaoHang.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 522);
            this.Controls.Add(this.optGiaoHang);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.cmbInvoidNo);
            this.Controls.Add(this.optBangBaoGia);
            this.Controls.Add(this.reportInvoice);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                                                                                " +
    "                         ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportInvoice;
        private System.Windows.Forms.RadioButton optBangBaoGia;
        private System.Windows.Forms.ComboBox cmbInvoidNo;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.RadioButton optGiaoHang;
    }
}

