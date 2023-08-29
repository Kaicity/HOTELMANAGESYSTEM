using BussinessLogic;
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

namespace THUEPHONG
{
    public partial class frmReportCongTy : Form
    {
        CONGTY _congty;

        public frmReportCongTy()
        {
            InitializeComponent();
        }

        private void frmReportCongTy_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            _congty = new CONGTY();

            //Khai bao che do xu ly bao cao, trong truong op nay lay bao cao o local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            //Che do xem report
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            loadDataRepor();
        }

        void loadDataRepor()
        {
            //Lay danh sach cong ty
            //Tra ve mot danh sach cong ty

            //truyen report

            this.reportViewer1.LocalReport.ReportPath = "./ReportModel/ReportCongTy.rdlc";

            //Report data source truyen vao dataset cong ty va mot danh sach object
            ReportDataSource rd = new ReportDataSource("DataSetCongTy", _congty.getAll());

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rd);

            this.reportViewer1.RefreshReport();


        }

    }
}
