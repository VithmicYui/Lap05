using Lap05_2.Modelss;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap05_2
{
    public partial class frmThongke : Form
    {
        ThongKeDbContext db = new ThongKeDbContext();

       

        public frmThongke()
        {
            InitializeComponent();
        }

        private void frmThongke_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void optDay_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInXem_Click(object sender, EventArgs e)
        {
            List<Order> listOrder = db.Orders.ToList();
            if (optDay.Checked)
            {
                var orders = db.Orders.Where(x => DbFunctions.TruncateTime(x.Invoice.DeliveryDate) == DbFunctions.TruncateTime(dtDay.Value)).GroupBy(x => new
                {
                    x.InvoiceNo,
                    x.Invoice.DeliveryDate,
                }).ToList().Select((x, i) => new ThongkeReport()
                {
                    Index = i + 1,
                    InvoiceNo = x.Key.InvoiceNo,
                    DeliveryDate = x.Key.DeliveryDate,
                    Total = x.Sum(y => (double)y.Quantity * (double)y.Price)
                }).ToList();

                if (Order.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hoá đơn nào!");
                    return;
                }
                this.reportViewer1.LocalReport.ReportPath = "ThongKe.rdlc";
                var reportDataSource = new ReportDataSource("DataSet", orders);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            else if (optMonth.Checked)
            {
                var orders = db.Orders.Where(x => x.Invoice.DeliveryDate.Month == dtDay.Value.Month && x.Invoice.DeliveryDate.Year == dtMonth.Value.Year).GroupBy(x => new
                {
                    x.InvoiceNo,
                    x.Invoice.DeliveryDate,
                }
                ).ToList();
                if(orders.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hoá đơn nào");
                    return;
                }
                this.reportViewer1.LocalReport.ReportPath = "ThongKe.rdlc";
                var reportDataSource = new ReportDataSource("DataSet", orders);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            }
            else
            {
                var orders = db.Orders.Where(x => x.Invoice.DeliveryDate >= dtF.Value && dtT.Value >= x.Invoice.DeliveryDate).GroupBy(x => new
                {
                    x.InvoiceNo,
                    x.Invoice.DeliveryDate,

                }

                ).ToList().Select((x, i) => new ThongkeReport()
                {
                    Index = i + 1,
                    InvoiceNo = x.Key.InvoiceNo,
                    DeliveryDate = x.Key.DeliveryDate,
                    Total = x.Sum(y => (double)y.Quantity * (double)y.Price)
                }
                ).ToList();
                if(orders.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hoá đơn nào");
                    return;
                }
                this.reportViewer1.LocalReport.ReportPath = "ThongKe.rdlc";
                var reportDataSource = new ReportDataSource("DataSet", orders);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
