using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WindowsFormsApp1.Classes;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApp1.Forms
{
    public partial class PayrollList : DevExpress.XtraEditors.XtraForm
    {
        object payid = null;
        public PayrollList()
        {
            InitializeComponent();
        }

        private void PayrollList_Load(object sender, EventArgs e)
        {
            populate();
        }
        void populate()
        { 
            Database.displaySearchlookupEdit("SELECT * FROM dbo.view_PAYROLLCODE", txtpayrollcode, "CodeDesc", "CodeDesc");

        }
        void display()
        {
            Database.display($"SELECT * FROM dbo.view_PayrollList WHERE PayID='{payid}'", gridControl1, gridView2);
            gridView2.Columns[0].Visible = false;
        }

        private void txtpayrollcode_EditValueChanged(object sender, EventArgs e)
        {
            payid = SearchLookUpClass.getSingleValue(txtpayrollcode, "ID");
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            display();
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "GRSPAY");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "NETPAY");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "ALLWNCE");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "REGOTAMNT");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "REGHOLAMNT");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "SPCLHOLAMNT");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "NGHTDFFAMNT");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "SSS");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "HDMF");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "PHEALTH");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "SSS_ER");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "HMDF_ER");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "PHEALTH_ER");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "SSSLOAN");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "SSSCALLOAN");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "HMDFLOAN");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "HDMFCALLOAN");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "HDMFHSNGLOAN");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "CA");
            Classes.DevXGridViewSettings.ShowFooterTotal(gridView2, "WHT"); 
        }


        void printRep()
        {
            //var row = Database.getMultipleQuery("ReportHeaderSettings", "ReportName='StockOrderRep'", "Heading,ImageWidth,ImageHeight,Caption1,Caption2");

            //string companyname = row["Heading"].ToString();
            //string imagewidth = row["ImageWidth"].ToString();
            //string imageheight = row["ImageHeight"].ToString();
            //string caption1 = row["Caption1"].ToString();
            //string caption2 = row["Caption2"].ToString();

            //Reporting.PayrollList xct = new Reporting.PayrollList();
            Reporting.SamplePaylist xct = new Reporting.SamplePaylist();

            //Classes.Utilities.GetImageDevEx(xct.xrPictureBox1, "ReportHeaderSettings", "ReportName='StockOrderRep'", "ImageLogo");
            //xct.xrPictureBox1.SizeF = new SizeF(float.Parse(imagewidth), float.Parse(imageheight));
            //xct.xrcompanyname.Text = companyname;
            //xct.xrcaption1.Text = caption1;
            //xct.xrcaption2.Text = caption2;

            //xct.Landscape = true;
            //xct.PaperKind = System.Drawing.Printing.PaperKind.Legal;
            //xct.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 100);

            //xct.xrbranchname.Text = branchname;// comboBox1.Text;
            //xct.xrdate.Text = txteffectivitydate.Text;//getDateRequest().Substring(0, 10);
            //xct.xrdateprocessed.Text = Convert.ToDateTime(dateprocessed).ToShortDateString();
            //xct.xrrequestedby.Text = txtrequestedby.Text;// getRequestedBy();
            //xct.xrpono.Text = txtpono.Text;//comboBox2.Text;
            //xct.xrbranchaddress.Text = branchaddress;
            //xct.xrpreparedby.Text = txtpreparedby.Text;

            //xct.Bands[BandKind.Detail].Controls.Add(HelperFunction.CopyGridControl(this.gridControl1));
            //xct.Bands[BandKind.Detail].Font = new System.Drawing.Font("Tahoma", 7);
            ReportPrintTool report = new ReportPrintTool(xct);
            report.ShowRibbonPreviewDialog();
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            printRep();
        }
    }
}