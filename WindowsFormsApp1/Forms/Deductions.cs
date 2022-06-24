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
    public partial class Deductions : DevExpress.XtraEditors.XtraForm
    {
        object id = null;
        string SSSLoan =""
               ,SSSCalLoan = ""
               ,HDMFLoan = ""
               ,HDMFCalLoan = ""
               ,HDMFHousingLoan = "";

        public Deductions()
        {
            InitializeComponent();
        }

        private void Deductions_Load(object sender, EventArgs e)
        {
            disablefields();
            display();
            populate();
        }

        void populate()
        {
            Database.displaySearchlookupEdit("SELECT * FROM dbo.view_EMPPayrollInfo", txtempid, "FullName", "FullName"); 
        }
        void clear()
        {
            txtempid.Text = "";
            txthdmfcalloan.Text = "";
            txthdmfhousingloan.Text = "";
            txthdmfloan.Text = "";
            txtssscalloan.Text = "";
            txtsssloan.Text = "";
        }

        void disablefields()
        {
            txtempid.Enabled = false;
            txthdmfcalloan.Enabled = false;
            txthdmfhousingloan.Enabled = false;
            txthdmfloan.Enabled = false;
            txtssscalloan.Enabled = false;
            txtsssloan.Enabled = false;
        }
        void enablefields()
        {
            txtempid.Enabled = true;
            txthdmfcalloan.Enabled = true;
            txthdmfhousingloan.Enabled = true;
            txthdmfloan.Enabled = true;
            txtssscalloan.Enabled = true;
            txtsssloan.Enabled = true;
        }
        void display()
        {
            Database.display("SELECT * FROM dbo.view_DEDUCTIONS", gridControl1, gridView2);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            enablefields();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            execSP("2");
            XtraMessageBox.Show("Deductions Successfully Updated!");
            clear();
            disablefields();
            btnnew.Enabled = true;
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
            display();
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool confirm = HelperFunction.ConfirmDialog("Are you sure you want to delete this Deduction?","Delete Deduction");
            if (confirm)
            {
                Database.ExecuteQuery($"DELETE FROM dbo.DEDUCTIONS WHERE EMP_ID='{gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString()}'");
                display();
            }
            else
                return;
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
            disablefields();

            btnnew.Enabled = true;
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
        }

        void execSP(string option)
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                string query = "spfunc_CRUDDeductions";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@parmid", id);
                com.Parameters.AddWithValue("@parmsssloan", txtsssloan.Text);
                com.Parameters.AddWithValue("@parmssscalloan", txtssscalloan.Text);
                com.Parameters.AddWithValue("@parmhdmfloan", txthdmfloan.Text);
                com.Parameters.AddWithValue("@parmhdmfcalloan", txthdmfcalloan.Text);
                com.Parameters.AddWithValue("@parmhdmfhousingloan", txthdmfhousingloan.Text);
                com.Parameters.AddWithValue("@parmaddedby", Login.Fullname);
                com.Parameters.AddWithValue("@parmoption", option);
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
        private void btnadd_Click(object sender, EventArgs e)
        {

            bool ok = Database.checkifExist("SELECT TOP(1) EMP_ID FROM dbo.DEDUCTIONS WHERE EMP_ID='" + id + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in Deductions Table.. Please use Edit Function");
                return;
            }
            else
            {
                //Database.ExecuteQuery("INSERT INTO dbo.EMPLOYEE VALUES('" + txtid.Text + "','" + txtfname.Text + "','"++"')", "Successfully Added");
                execSP("1");
                XtraMessageBox.Show("Deductions Successfully Added!");
                clear();

                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;

                disablefields();
                display();
            }
        }

        private void txtempid_EditValueChanged(object sender, EventArgs e)
        {
            id = SearchLookUpClass.getSingleValue(txtempid, "ID");
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
            SSSLoan = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SSSLoan").ToString();
            SSSCalLoan = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SSSCalLoan").ToString();
            HDMFLoan = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "HDMFLoan").ToString();
            HDMFCalLoan = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "HDMFCalLoan").ToString();
            HDMFHousingLoan = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "HDMFHousingLoan").ToString();

            txtsssloan.Text = SSSLoan;
            txtssscalloan.Text = SSSCalLoan;
            txthdmfloan.Text = HDMFLoan;
            txthdmfcalloan.Text = HDMFCalLoan;
            txthdmfhousingloan.Text = HDMFHousingLoan;
           
            enablefields();

            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }
    }
}