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
using System.Data.SqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class Payroll : DevExpress.XtraEditors.XtraForm
    {
        object payid = null;
        object taxid = null;
        object id = null;
        object contactno = null;
        object designation = null;
        object taxstatus = null;

        double leavewithPay = 0.0,absentAmount=0.0,totalOTHours=0.0,totalOTAmount=0.0;
        public Payroll()
        {
            InitializeComponent();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            populate();
            loadInfo();
        }

        void populate()
        {
            Database.displaySearchlookupEdit("SELECT * FROM dbo.view_EMPPayrollInfo", txtempid, "FullName", "FullName");
            Database.displaySearchlookupEdit("SELECT * FROM dbo.view_PAYROLLCODE", txtpayrollcode, "CodeDesc", "CodeDesc");
           
        }

        private void txtempid_EditValueChanged(object sender, EventArgs e)
        {
            id = SearchLookUpClass.getSingleValue(txtempid, "ID");
            taxid = SearchLookUpClass.getSingleValue(txtempid, "TaxID"); 
            contactno = SearchLookUpClass.getSingleValue(txtempid, "ContactNo");
            designation = SearchLookUpClass.getSingleValue(txtempid, "Designation");
            taxstatus = SearchLookUpClass.getSingleValue(txtempid, "TaxDesc");

            txtcontactno.Text = contactno.ToString();
            txtdesignation.Text = designation.ToString();
            txtstatus.Text = taxstatus.ToString();

            loadInfo();
            loadGovtBenefits();
        }

        void loadGovtBenefits() //SSS PIBIG PHEALTH
        {
            string sssemp = Database.getSingleResultSet($"SELECT dbo.func_getSSSContribution('{id}',1,2)"); //dailyrate
            string sssemplyr = Database.getSingleResultSet($"SELECT dbo.func_getSSSContribution('{id}',2,2)"); //dailyrate

            string hdmfemp = Database.getSingleResultSet($"SELECT dbo.func_getHDMFContribution('{id}',1,2)"); //allowance
            string hdmfemplyr = Database.getSingleResultSet($"SELECT dbo.func_getHDMFContribution('{id}',2,2)"); //allowance

            string phealthemp = Database.getSingleResultSet($"SELECT dbo.func_getPHEALTHContribution('{id}',1,2)"); //hourlyrate
            string phealthemplyr = Database.getSingleResultSet($"SELECT dbo.func_getPHEALTHContribution('{id}',2,2)"); //hourlyrate

            txtsssemp.Text = sssemp;
            txtsssemplyr.Text = sssemplyr;
            txthdmfemp.Text = hdmfemp;
            txthdmfemplyr.Text = hdmfemplyr;
            txtphealthemp.Text = phealthemp;
            txtphealthemplyr.Text = phealthemplyr;
        }

        void loadInfo()
        {
            string rate = Database.getSingleResultSet($"SELECT dbo.func_getRate('{id}','1','1','1')"); //dailyrate
            string allowance = Database.getSingleResultSet($"SELECT dbo.func_getRate('{id}','1','2','1')"); //allowance
            string hourlyrate = Database.getSingleResultSet($"SELECT dbo.func_getRate('{id}',1,1,2)"); //hourlyrate
           
            //cashadvance
            string ca = Database.getSingleResultSet($"SELECT TOP(1) CSH_ADVANCE FROM dbo.CASHADVANCE WHERE EMP_ID='{id}'");//13thmonth

            string tresemonth = Database.getSingleResultSet($"SELECT dbo.func_get13thMonth('{id}','200','{rate}')");//13thmonth
           string sl = Database.getSingleResultSet($"SELECT dbo.func_getLeaveBal('{id}','2')");//sl
            string vl = Database.getSingleResultSet($"SELECT dbo.func_getLeaveBal('{id}','1')"); //vl

            txtcashadvance.Text = ca;

            txtdailyrate.Text = rate;
            txtallowance.Text = allowance;
            txthourlyrate.Text = hourlyrate;
            txtaccum13.Text = tresemonth;
            txtsl.Text = sl;
            txtvl.Text = vl;
        }

        private void txtleavewithpay_EditValueChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtleavewithpay.Value) > (Convert.ToInt32(txtsl.Value) + Convert.ToInt32(txtvl.Value)))
            {
                XtraMessageBox.Show("Insufficient Leaved Balance");
                txtleavewithpay.Text = "0";
            }
            else
            {
                updateChange();
            }
        }

        void updateChange()
        {
            double daystotal = 0.0,totaldayspaidamount=0.0,paidallowance=0.0,tresemonthcurrpay=0.0;
            daystotal=(Convert.ToDouble(txtdaysworked.Value) - Convert.ToDouble(txtabsent.Value) - Convert.ToDouble(txtleavewithpay.Value));
            txtdaystotal.Text = daystotal.ToString();
            totaldayspaidamount = Convert.ToDouble(txtdailyrate.Value) * daystotal;
            leavewithPay = totaldayspaidamount; //global var
            absentAmount = Convert.ToDouble(txtabsent.Value) * Convert.ToDouble(txtdailyrate.Value);
            paidallowance = Math.Floor(daystotal) * Convert.ToDouble(txtallowance.Value);
           
            txtpaidallowance.Text = paidallowance.ToString();

            txtregotamnt.Text = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{id}',{txtregothrs.Value},1)");
            txtregholotamnt.Text = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{id}','{txtregholothrs.Value}','2')");
            txtspclholotamnt.Text = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{id}','{txtspclholothrs.Value}','3')");
            txtnightpremiumamnt.Text = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{id}','{txtnightpremium.Value}','4')");

            //ot adj 13thmnth tax adj
            //(@parmtotdayswork*@parmrate)/12 tresemonth
            tresemonthcurrpay = Math.Round((Convert.ToDouble(txtdaysworked.Value) * Convert.ToDouble(txtdailyrate.Value)) / 12,2);
            txttresemonthcurrpay.Text = tresemonthcurrpay.ToString();

            double totalot =0.0,grosspay = 0.0,totaltaxableincome=0.0,totalemployeeshare=0.0;

            totalot = Convert.ToDouble(txtregotamnt.Value) + Convert.ToDouble(txtregholotamnt.Value) + Convert.ToDouble(txtspclholotamnt.Value) + Convert.ToDouble(txtnightpremiumamnt.Value);

            totalOTHours = Convert.ToDouble(txtregothrs.Value) + Convert.ToDouble(txtregholothrs.Value) + Convert.ToDouble(txtspclholothrs.Value) + Convert.ToDouble(txtnightpremium.Value);
            totalOTAmount = totalot;

            grosspay = totaldayspaidamount+ paidallowance + totalot + Convert.ToDouble(txtotadj.Value) + Convert.ToDouble(txttresemonth.Value) + Convert.ToDouble(txttaxadjadd.Value);
            txtgrosspay.Text = grosspay.ToString();

            totalemployeeshare = Convert.ToDouble(txtsssemp.Value) + Convert.ToDouble(txthdmfemp.Value) + Convert.ToDouble(txtphealthemp.Value);

            totaltaxableincome = grosspay - totalemployeeshare;
            txttotaltaxableincome.Text = totaltaxableincome.ToString();

            //DEDUCTIONS
            
            txtwht.Text = Database.getSingleResultSet($"SELECT dbo.func_getWHT('{id}','{totaltaxableincome}',{taxid})");

            string SSSLoan = "", SSSCalLoan = "", HDMFLoan = "", HDMFCalLoan = "", HDMFHousingLoan = "";
            bool isExist = Database.checkifExist($"SELECT TOP(1) EMP_ID FROM dbo.DEDUCTIONS WHERE EMP_ID='{id}'");
            if(isExist)
            {
                var rowz = Database.getMultipleQuery($"SELECT * FROM dbo.view_DEDUCTIONS WHERE ID='{id}'", "SSSLoan,SSSCalLoan,HDMFLoan,HDMFCalLoan,HDMFHousingLoan");
                SSSLoan = rowz["SSSLoan"].ToString();
                SSSCalLoan = rowz["SSSCalLoan"].ToString();
                HDMFLoan = rowz["HDMFLoan"].ToString();
                HDMFCalLoan = rowz["HDMFCalLoan"].ToString();
                HDMFHousingLoan = rowz["HDMFHousingLoan"].ToString();
            }
            else
            {
                SSSLoan = txtsssloan.Text;
                SSSCalLoan = txtssscalloan.Text;
                HDMFLoan = txthdmfloan.Text;
                HDMFCalLoan = txthdmfcalloan.Text;
                HDMFHousingLoan = txthdmfhousingloan.Text;
            }

            txtsssloan.Text = SSSLoan;
            txtssscalloan.Text = SSSCalLoan;
            txthdmfloan.Text = HDMFLoan;
            txthdmfcalloan.Text = HDMFCalLoan;
            txthdmfhousingloan.Text = HDMFHousingLoan;

            double totaldeductions = 0.0;
            totaldeductions = Convert.ToDouble(txtsssloan.Value) + Convert.ToDouble(txtssscalloan.Value) + Convert.ToDouble(txthdmfloan.Value)
                + Convert.ToDouble(txthdmfcalloan.Value) + Convert.ToDouble(txthdmfhousingloan.Value) + Convert.ToDouble(txtcashadvancepay.Value)
                +Convert.ToDouble(txttaxadjdeduct.Value) + Convert.ToDouble(txtotherdeduction.Value) + Convert.ToDouble(txtwht.Value);

            txttotaldeductions.Text = totaldeductions.ToString();

            //NETPAY
            double netpay = 0.0;
            netpay = Convert.ToDouble(txttotaltaxableincome.Value) - totaldeductions;
            txtnetpay.Text = netpay.ToString();
        }

        private void txtdaysworked_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtabsent_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

     
        //void otRateChangedAmount()
        //{
        //    string otrate = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{txtregothrs.Value}','1')");
        //}

        private void txtregothrs_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
            //txtregotamnt.Text = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{id}',{txtregothrs.Value},1)"); 
        }

        private void txtregholothrs_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
            //txtregholotamnt.Text = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{id}','{txtregholothrs.Value}','2')");
        }

        private void txtspclholothrs_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
            //txtspclholotamnt.Text = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{id}','{txtspclholothrs.Value}','3')");
        }

        private void txtnightpremium_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
            //txtnightpremiumamnt.Text = Database.getSingleResultSet($"SELECT dbo.func_getOTRate('{id}','{txtnightpremium.Value}','4')");
        }

        private void txtsssemp_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txthdmfemp_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtphealthemp_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtgrosspay_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpayrollcode_EditValueChanged(object sender, EventArgs e)
        {
            payid = SearchLookUpClass.getSingleValue(txtpayrollcode, "ID");
        }



        void execSP()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                string query = "spfunc_ProcessPayroll";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@parmpayid", payid.ToString());
                com.Parameters.AddWithValue("@parmempid", id.ToString());
                com.Parameters.AddWithValue("@parmdaysworked", txtdaysworked.Text);
                com.Parameters.AddWithValue("@parmnoofleaved", txtleavewithpay.Text);
                com.Parameters.AddWithValue("@parmleavedamount", leavewithPay);//daily rate * leaveamount
                com.Parameters.AddWithValue("@parmnoofabsent", txtabsent.Text);
                com.Parameters.AddWithValue("@parmabsentamount", absentAmount);//daily rate * absent
                com.Parameters.AddWithValue("@parmdaystotal", txtdaystotal.Text);
                com.Parameters.AddWithValue("@parmregothrs", txtregholothrs.Text);
                com.Parameters.AddWithValue("@parmregotamount", txtregotamnt.Text);
                com.Parameters.AddWithValue("@parmregholot", txtregholothrs.Text);
                com.Parameters.AddWithValue("@parmregholotamount", txtregholotamnt.Text);
                com.Parameters.AddWithValue("@parmspclholot", txtspclholothrs.Text);
                com.Parameters.AddWithValue("@parmspclholotamount", txtspclholotamnt.Text);
                com.Parameters.AddWithValue("@parmnightdiff", txtnightpremium.Text);
                com.Parameters.AddWithValue("@parmnightdiffamount", txtnightpremiumamnt.Text);
                com.Parameters.AddWithValue("@parmtotalothrs", totalOTHours); //total ot hours
                com.Parameters.AddWithValue("@parmtotalotamount", totalOTAmount);//total ot amount
                com.Parameters.AddWithValue("@parmallowance", txtpaidallowance.Text);
                com.Parameters.AddWithValue("@parmtaxadj", txttaxadjadd.Text);
                com.Parameters.AddWithValue("@parmotadj", txtotadj.Text);
                com.Parameters.AddWithValue("@parmtresemonthcurrpay", txttresemonthcurrpay.Text);
                com.Parameters.AddWithValue("@parmtresemonth", txttresemonth.Text);
                com.Parameters.AddWithValue("@parmgrosspay", txtgrosspay.Text);

                com.Parameters.AddWithValue("@parmsssloan", txtssscalloan.Text);
                com.Parameters.AddWithValue("@parmssscalloan", txtssscalloan.Text);
                com.Parameters.AddWithValue("@parmhdmfloan", txthdmfloan.Text);
                com.Parameters.AddWithValue("@parmhdmfcalloan", txthdmfcalloan.Text);
                com.Parameters.AddWithValue("@parmhdmfhousingloan", txthdmfhousingloan.Text);

                com.Parameters.AddWithValue("@parmsssemployee", txtsssemp.Text);
                com.Parameters.AddWithValue("@parmhdmfemployee", txthdmfemp.Text);
                com.Parameters.AddWithValue("@parmphealthemployee", txtphealthemp.Text);

                com.Parameters.AddWithValue("@parmsssemployer", txtsssemplyr.Text);
                com.Parameters.AddWithValue("@parmhdmfemployer", txthdmfemplyr.Text);
                com.Parameters.AddWithValue("@parmphealthemployer", txtphealthemplyr.Text);
                com.Parameters.AddWithValue("@parmwht", txtwht.Text);
                com.Parameters.AddWithValue("@parmtaxadjdeduction", txttaxadjdeduct.Text);
                com.Parameters.AddWithValue("@parmotherdeduction", txtotherdeduction.Text);
                com.Parameters.AddWithValue("@parmcashadvancepay", txtcashadvancepay.Text);
                com.Parameters.AddWithValue("@parmtotaldeduction", txttotaldeductions.Text);
                com.Parameters.AddWithValue("@parmtotaltaxableincome", txttotaltaxableincome.Text);
                com.Parameters.AddWithValue("@parmtotalnetpay", txtnetpay.Text);
                com.Parameters.AddWithValue("@parmcutoffbegin", "");
                com.Parameters.AddWithValue("@parmcutoffend", "");
                com.Parameters.AddWithValue("@parmaddedby", Login.Fullname);
                //com.Parameters.AddWithValue("@parmoption", option);
                com.CommandTimeout = 180;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = query;
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        void processPayroll()
        {
            bool isExists = Database.checkifExist($"SELECT TOP(1) EMP_ID FROM dbo.PAYLIST WHERE EMP_ID='{id}' AND PAY_ID='{payid}'");
            if(String.IsNullOrEmpty(txtpayrollcode.Text) || String.IsNullOrEmpty(txtempid.Text))
            {
                XtraMessageBox.Show("Payroll Code must not Empty!!...");
            }
            else if(isExists)
            {
                XtraMessageBox.Show("This is Already Processed");
            }
            else
            {
                execSP();
                XtraMessageBox.Show("Successfully Processed");
            }
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            processPayroll();
            clear();
        }

        private void txttotaldeductions_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtnetpay_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtwht_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtsssloan_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtssscalloan_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txthdmfloan_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txthdmfcalloan_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txthdmfhousingloan_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txttresemonth_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txttresemonth.Value) > Convert.ToDouble(txtaccum13.Value))
            {
                txttresemonth.Text = txtaccum13.Text;
            }
            updateChange();
        }

        private void txtotadj_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txttaxadjadd_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtpaidallowance_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtcashadvancepay_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtcashadvancepay.Value) > Convert.ToDouble(txtcashadvance.Value))
            {
                txtcashadvancepay.Text = txtcashadvance.Text;
            }
            updateChange();
        }

        private void txttaxadjdeduct_EditValueChanged(object sender, EventArgs e)
        {
            updateChange();
        }

        private void txtotherdeduction_EditValueChanged(object sender, EventArgs e)
        {
            
            updateChange();
        }

        void clear()
        {
            txtabsent.Text = "";
            txtaccum13.Text = "";
            txtallowance.Text = "";
            txtcashadvance.Text = "";
            txtcashadvancepay.Text = "";
            txtcontactno.Text = "";
            txtdailyrate.Text = "";
            txtdaystotal.Text = "";
            txtdaysworked.Text = "";
            txtdesignation.Text = "";
            txtempid.Text = "";
            txtgrosspay.Text = "";
            txthdmfcalloan.Text = "";
            txthdmfemp.Text = "";
            txthdmfemplyr.Text = "";
            txthdmfhousingloan.Text = "";
            txthdmfloan.Text = "";
            txthourlyrate.Text = "";
            txtleavewithpay.Text = "";
            txtnetpay.Text = "";
            txtnightpremium.Text = "";
            txtnightpremiumamnt.Text = "";
            txtotadj.Text = "";
            txtotherdeduction.Text = "";
            txtpaidallowance.Text = "";
            txtpayrollcode.Text = "";
            txtphealthemp.Text = "";
            txtphealthemplyr.Text = "";
            txtregholotamnt.Text = "";
            txtregholothrs.Text = "";
            txtregotamnt.Text = "";
            txtregothrs.Text = "";
            txtsl.Text = "";
            txtspclholotamnt.Text = "";
            txtspclholothrs.Text = "";
            txtssscalloan.Text = "";
            txtsssemp.Text = "";
            txtsssemplyr.Text = "";
            txtsssloan.Text = "";
            txtstatus.Text = "";
            txttaxadjadd.Text = "";
            txttaxadjdeduct.Text = "";
            txttotaldeductions.Text = "";
            txttotaltaxableincome.Text = "";
            txttresemonth.Text = "";
            txtvl.Text = "";
            txtwht.Text = "";
        }
    }
}