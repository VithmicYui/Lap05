using Lap05_01.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lap05_01
{
    public partial class Form1 : Form
    {
        InvoiceDbContext db = new InvoiceDbContext();

        

        public Form1()
        {
            InitializeComponent();
            optBangBaoGia.Checked = true;
           // cmbInvoidNo.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dataSource = db.Invoices.OrderByDescending(x => x.DeliveryDate).ToList();
            cmbInvoidNo.DataSource = dataSource;
            cmbInvoidNo.DisplayMember = "InvoiceNo";
            cmbInvoidNo.ValueMember = "InvoiceNo"; 
            this.reportInvoice.RefreshReport();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            InvoiceDbContext context = new InvoiceDbContext();
            if (optBangBaoGia.Checked == true) //TH báo giá
            {
                List<Product> listProduct = context.Products.ToList();
                this.reportInvoice.LocalReport.ReportPath = "C:/Users/Yui/source/repos/Lap05/Lap05_01/BangBaoGia.rdlc"; //nh copy report     
                var reportDataSource = new ReportDataSource("ProductDataSet", listProduct);
                this.reportInvoice.LocalReport.DataSources.Clear();
                this.reportInvoice.LocalReport.DataSources.Add(reportDataSource);
                this.reportInvoice.LocalReport.DisplayName = "Bảng Báo Giá";
            }
            else //TH chi ti
            {
                

                Invoice invoice = context.Invoices.FirstOrDefault(p => p.InvoiceNo == cmbInvoidNo.Text);
                List<Order> listOrder = context.Orders.Where(p => p.InvoiceNo == cmbInvoidNo.Text).ToList();
               
                
                //S d ng 2 tham s truy n vào cho report
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("invoiceNo", invoice.InvoiceNo);
                param[1] = new ReportParameter("DeliveryDateStr", string.Format("Ngày " + invoice.DeliveryDate.ToString("dd/MM/yyyy")));
                this.reportInvoice.LocalReport.ReportPath = "C:/Users/Yui/source/repos/Lap05/Lap05_01/PhieuGiaoHang.rdlc"; //nh copy report->debug
                this.reportInvoice.LocalReport.SetParameters(param);
                var reportDataSource = new ReportDataSource("OrderDataSet", listOrder);
                this.reportInvoice.LocalReport.DataSources.Clear();
                this.reportInvoice.LocalReport.DataSources.Add(reportDataSource);
                this.reportInvoice.LocalReport.DisplayName = "Phiếu giao hàng"; //tên hi n th
            }
            this.reportInvoice.RefreshReport();
        }

        private void cmbInvoidNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
