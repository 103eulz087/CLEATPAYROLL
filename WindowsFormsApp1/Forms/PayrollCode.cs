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
    public partial class PayrollCode : DevExpress.XtraEditors.XtraForm
    {
        string id=""
             , CodeDesc=""
             , StartDate=""
             , EndDate = "";

        public PayrollCode()
        {
            InitializeComponent();
        }

        private void PayrollCode_Load(object sender, EventArgs e)
        {
            display();
        }


        void clear()
        {
            txtid.Text = "";
            txtcodedesc.Text = "";
            txtdatestart.Text = "";
            txtdateend.Text = "";
        }

        void disablefields()
        {
            txtid.Enabled = false;
            txtcodedesc.Enabled = false;
            txtdatestart.Enabled = false;
            txtdateend.Enabled = false;
        }
        void enablefields()
        {
            txtcodedesc.Enabled = true;
            txtdatestart.Enabled = true;
            txtdateend.Enabled = true;
        }
        void display()
        {
            Database.display("SELECT * FROM dbo.view_PAYROLLCODE", gridControl1, gridView2);
        }


        private void btnnew_Click(object sender, EventArgs e)
        {
            int newid = 0;
            newid = IDGenerator.getIDNumber("PAYROLLCODE", "PAY_ID", 1);
            txtid.Text = newid.ToString();
            enablefields();
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            execSP("2");
            XtraMessageBox.Show("PayrollCode Successfully Updated!");
            clear();
            disablefields();
            btnnew.Enabled = true;
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
            display();
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
                string query = "spfunc_CRUDPayrollCode";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@parmid", txtid.Text);
                com.Parameters.AddWithValue("@parmcodedesc", txtcodedesc.Text);
                com.Parameters.AddWithValue("@parmstartdate", txtdatestart.Text);
                com.Parameters.AddWithValue("@parmenddate", txtdateend.Text);
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

            bool ok = Database.checkifExist("SELECT TOP(1) PAY_ID FROM dbo.PAYROLLCODE WHERE PAY_ID='" + txtid.Text.Trim() + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in PayrollCode Table.. Please use Edit Function");
                return;
            }
            else
            {
                //Database.ExecuteQuery("INSERT INTO dbo.EMPLOYEE VALUES('" + txtid.Text + "','" + txtfname.Text + "','"++"')", "Successfully Added");
                execSP("1");
                XtraMessageBox.Show("PayrollCode Successfully Added!");
                clear();

                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;

                disablefields();
                display();
            }
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
            CodeDesc = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "CodeDesc").ToString();
            StartDate = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "StartDate").ToString();
            EndDate = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "EndDate").ToString();

            txtid.Text = id;
            txtcodedesc.Text = CodeDesc;
            txtdatestart.Text = StartDate;
            txtdateend.Text = EndDate;

            enablefields();

            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }
    }
}