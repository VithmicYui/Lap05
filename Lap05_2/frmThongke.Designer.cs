namespace Lap05_2
{
    partial class frmThongke
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
            this.ttDonhang = new System.Windows.Forms.GroupBox();
            this.dtT = new System.Windows.Forms.DateTimePicker();
            this.dtF = new System.Windows.Forms.DateTimePicker();
            this.dtMonth = new System.Windows.Forms.DateTimePicker();
            this.optfDay = new System.Windows.Forms.RadioButton();
            this.optMonth = new System.Windows.Forms.RadioButton();
            this.btnInXem = new System.Windows.Forms.Button();
            this.dtDay = new System.Windows.Forms.DateTimePicker();
            this.optDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.productOrderDataSet1 = new Lap05_2.ProductOrderDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ttDonhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ttDonhang
            // 
            this.ttDonhang.Controls.Add(this.dtT);
            this.ttDonhang.Controls.Add(this.dtF);
            this.ttDonhang.Controls.Add(this.dtMonth);
            this.ttDonhang.Controls.Add(this.optfDay);
            this.ttDonhang.Controls.Add(this.optMonth);
            this.ttDonhang.Controls.Add(this.btnInXem);
            this.ttDonhang.Controls.Add(this.dtDay);
            this.ttDonhang.Controls.Add(this.optDay);
            this.ttDonhang.Controls.Add(this.label1);
            this.ttDonhang.Location = new System.Drawing.Point(80, 12);
            this.ttDonhang.Name = "ttDonhang";
            this.ttDonhang.Size = new System.Drawing.Size(804, 181);
            this.ttDonhang.TabIndex = 0;
            this.ttDonhang.TabStop = false;
            this.ttDonhang.Text = "Thông Tin Đơn Hàng";
            // 
            // dtT
            // 
            this.dtT.CustomFormat = "dd/MM/yyyy";
            this.dtT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtT.Location = new System.Drawing.Point(513, 105);
            this.dtT.Name = "dtT";
            this.dtT.Size = new System.Drawing.Size(126, 22);
            this.dtT.TabIndex = 9;
            // 
            // dtF
            // 
            this.dtF.CustomFormat = "dd/MM/yyyy";
            this.dtF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtF.Location = new System.Drawing.Point(338, 105);
            this.dtF.Name = "dtF";
            this.dtF.Size = new System.Drawing.Size(126, 22);
            this.dtF.TabIndex = 8;
            // 
            // dtMonth
            // 
            this.dtMonth.CustomFormat = "MM/yyyy";
            this.dtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth.Location = new System.Drawing.Point(338, 61);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.Size = new System.Drawing.Size(126, 22);
            this.dtMonth.TabIndex = 7;
            // 
            // optfDay
            // 
            this.optfDay.AutoSize = true;
            this.optfDay.Location = new System.Drawing.Point(203, 105);
            this.optfDay.Name = "optfDay";
            this.optfDay.Size = new System.Drawing.Size(101, 20);
            this.optfDay.TabIndex = 6;
            this.optfDay.TabStop = true;
            this.optfDay.Text = "Xem từ ngày";
            this.optfDay.UseVisualStyleBackColor = true;
            // 
            // optMonth
            // 
            this.optMonth.AutoSize = true;
            this.optMonth.Location = new System.Drawing.Point(203, 63);
            this.optMonth.Name = "optMonth";
            this.optMonth.Size = new System.Drawing.Size(120, 20);
            this.optMonth.TabIndex = 5;
            this.optMonth.TabStop = true;
            this.optMonth.Text = "Xem theo tháng";
            this.optMonth.UseVisualStyleBackColor = true;
            // 
            // btnInXem
            // 
            this.btnInXem.Location = new System.Drawing.Point(564, 152);
            this.btnInXem.Name = "btnInXem";
            this.btnInXem.Size = new System.Drawing.Size(75, 23);
            this.btnInXem.TabIndex = 4;
            this.btnInXem.Text = "In/Xem";
            this.btnInXem.UseVisualStyleBackColor = true;
            this.btnInXem.Click += new System.EventHandler(this.btnInXem_Click);
            // 
            // dtDay
            // 
            this.dtDay.CustomFormat = "dd/MM/yyyy";
            this.dtDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDay.Location = new System.Drawing.Point(338, 19);
            this.dtDay.Name = "dtDay";
            this.dtDay.Size = new System.Drawing.Size(126, 22);
            this.dtDay.TabIndex = 3;
            // 
            // optDay
            // 
            this.optDay.AutoSize = true;
            this.optDay.Location = new System.Drawing.Point(203, 22);
            this.optDay.Name = "optDay";
            this.optDay.Size = new System.Drawing.Size(117, 20);
            this.optDay.TabIndex = 1;
            this.optDay.TabStop = true;
            this.optDay.Text = "Xem theo ngày";
            this.optDay.UseVisualStyleBackColor = true;
            this.optDay.CheckedChanged += new System.EventHandler(this.optDay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // productOrderDataSet1
            // 
            this.productOrderDataSet1.DataSetName = "ProductOrderDataSet";
            this.productOrderDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lap05_2.ThongKe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(73, 219);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(811, 205);
            this.reportViewer1.TabIndex = 1;
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ttDonhang);
            this.Name = "frmThongke";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmThongke_Load);
            this.ttDonhang.ResumeLayout(false);
            this.ttDonhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ttDonhang;
        private System.Windows.Forms.DateTimePicker dtT;
        private System.Windows.Forms.DateTimePicker dtF;
        private System.Windows.Forms.DateTimePicker dtMonth;
        private System.Windows.Forms.RadioButton optfDay;
        private System.Windows.Forms.RadioButton optMonth;
        private System.Windows.Forms.Button btnInXem;
        private System.Windows.Forms.DateTimePicker dtDay;
        private System.Windows.Forms.RadioButton optDay;
        private System.Windows.Forms.Label label1;
        private ProductOrderDataSet productOrderDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

