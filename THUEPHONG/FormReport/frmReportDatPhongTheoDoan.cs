using BussinessLogic;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG.FormReport
{
    public partial class frmReportDatPhongTheoDoan : Form
    {
        DATPHONG _datphong;
        frmDatPhong objFrmDatPhong = (frmDatPhong)Application.OpenForms["frmDatPhong"];

        public frmReportDatPhongTheoDoan()
        {
            InitializeComponent();
        }

        private void frmReportDatPhongTheoDoan_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();

            //Khai bao che do xu ly bao cao, trong truong op nay lay bao cao o local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            //Che do xem report
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            PageSettings pageSettings= new PageSettings();
            pageSettings.PaperSize = new PaperSize("A2", 1500, 2000);

            reportViewer1.SetPageSettings(pageSettings);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            _datphong = new DATPHONG();
            loadReportDatPhongTheoDoan();

        }

        void loadReportDatPhongTheoDoan()
        {
            //truyen report

            this.reportViewer1.LocalReport.ReportPath = "./ReportModel/ReportDatPhongTheoDoan.rdlc";

            //Report data source truyen vao dataset cong ty va mot danh sach object
            ReportDataSource rd = new ReportDataSource("DataSetDatPhongTheoDoan", _datphong.getAllDaTaDP(objFrmDatPhong.dateDiTuNgay.Value, objFrmDatPhong.dateDiDenNgay.Value,
                objFrmDatPhong._maCty, objFrmDatPhong._maDvi));

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rd);

            this.reportViewer1.RefreshReport();
        }
    }
}
