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

namespace THUEPHONG.FormReport
{
    public partial class frmReportDatPhongDon : Form
    {   
        frmDatPhong _objFormDP = (frmDatPhong)Application.OpenForms["frmDatPhong"];
        frmDatPhongDon _objFormDPD = (frmDatPhongDon)Application.OpenForms["frmDatPhongDon"];

        public frmReportDatPhongDon()
        {
            InitializeComponent();
        }

        private void frmChiTietDatPhongTheoDoan_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            //Khai bao che do xu ly bao cao, trong truong op nay lay bao cao o local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            //Che do xem report
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            if(_objFormDP != null)
            {
                loadReportDatPhongTheoDoanCT(_objFormDP._idDatPhong);
            }
            else
            {
                loadReportDatPhongTheoDoanCT(_objFormDPD._idDatPhong);
            }
        }

        void loadReportDatPhongTheoDoanCT(int iddp)
        {
            DateTime currentDate = DateTime.Now;
                
            //truyen report

            this.reportViewer1.LocalReport.ReportPath = "./ReportModel/ReportDatPhongTheoDoanChiTiet.rdlc";

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "./ReportModel/ReportDatPhongTheoDoanChiTiet.rdlc";

            //Report data source truyen vao dataset DPCT va mot danh sach object
            ReportDataSource rd = new ReportDataSource("DataSetDatPhongTheoDoanChiTiet", myFunction.callStoreProcPhieuDatPhongChiTiet(iddp));

            ReportParameter prDay = new ReportParameter("paramDay", currentDate.Day.ToString());
            ReportParameter prMonth = new ReportParameter("paramMonth", currentDate.Month.ToString());
            ReportParameter prYear = new ReportParameter("paramYear", currentDate.Year.ToString());

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { prDay, prMonth, prYear });


            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rd);

            this.reportViewer1.RefreshReport();
        }
    }
}
