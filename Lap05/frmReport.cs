using Lap05.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap05
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            StudentDbContext context = new StudentDbContext();
            List<Student1> listStudent = context.Student1.ToList(); //l y t t c sv 
            List<StudentReport> listReport = new List<StudentReport>();
            foreach (Student1 i in listStudent)
            {
                StudentReport temp = new StudentReport();
                temp.StudentID = i.StudentID;
                temp.FullName = i.FullName;
                temp.AverageScore = i.AverageScore;
                temp.FacultyName = i.Faculty1.FacultyName;
                listReport.Add(temp);
            }
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("StudentDataSet", listReport);

            this.reportViewer1.LocalReport.DataSources.Clear(); //clear 
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
           
        }


    }
}
