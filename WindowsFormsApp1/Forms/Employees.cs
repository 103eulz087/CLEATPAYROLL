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
    public partial class Employees : DevExpress.XtraEditors.XtraForm
    {
        object designationid = null;
        object taxid = null;
        string id = "";
        string fname = "";
        string mname = "";
        string lname = "";
        string dateofbirth = "";
        string designation = "";
        string address = "";
        string taxstatus = "";
        string nosl = "";
        string novl = "";
        string datehired = "";

        public Employees()
        {
            InitializeComponent();
        }

        void clear()
        {
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtdateofbirth.Text = "";
            txtdesignation.Text = "";
            txtaddress.Text = "";
            txttaxstatus.Text = "";
            txtnosl.Text = "";
            txtnovl.Text = "";
            txtid.Text = "";
            txtdatehired.Text = ""; 
            txtcontactno.Text = "";
        }

        void disablefields()
        {
            txtfname.Enabled = false;
            txtmname.Enabled = false;
            txtlname.Enabled = false;
            txtdateofbirth.Enabled = false;
            txtdesignation.Enabled = false;
            txtaddress.Enabled = false;
            txttaxstatus.Enabled = false;
            txtnosl.Enabled = false;
            txtnovl.Enabled = false;
            txtid.Enabled = false;
            txtdatehired.Enabled = false; 
            txtcontactno.Enabled = false;
            
        }
        void enablefields()
        {
            txtfname.Enabled = true;
            txtmname.Enabled = true;
            txtlname.Enabled = true;
            txtdateofbirth.Enabled = true;
            txtdesignation.Enabled = true;
            txtaddress.Enabled = true;
            txttaxstatus.Enabled = true;
            txtnosl.Enabled = true;
            txtnovl.Enabled = true;
            txtdatehired.Enabled = true;
            //txtrate.Enabled = true;
            txtcontactno.Enabled = true;
        }

        void populate()
        {
            Database.displaySearchlookupEdit("SELECT DES_ID,DES_NAME as Designation,DES_RATE as Rate,DES_ALLOWANCE as Allowance FROM dbo.DESIGNATION", txtdesignation, "Designation", "Designation");
            Database.displaySearchlookupEdit("SELECT TAX_ID,TAX_CODE as TaxCode,TAX_DESC as Description FROM dbo.TAXCODE", txttaxstatus, "TaxCode", "TaxCode");
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            int newid = 0;
            newid = IDGenerator.getIDNumber("EMPLOYEE", "EMP_ID", 1);
            txtid.Text = newid.ToString();
            enablefields();
            populate();
            
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btncancel.Enabled = true;
        }

        void display()
        {
            Database.display("SELECT * FROM dbo.view_EMPLOYEE", gridControl1, gridView2);
            Classes.DevXGridViewSettings.ShowFooterCountTotal(gridView2, "ID");
        }

        void execSP(string option)
        {
                SqlConnection con = Database.getConnection();
                con.Open();
                try
                {
                    string query = "spfunc_CRUDEmployee";
                    SqlCommand com = new SqlCommand(query, con);
                    com.Parameters.AddWithValue("@parmid", txtid.Text);
                    com.Parameters.AddWithValue("@parmfname", txtfname.Text);
                    com.Parameters.AddWithValue("@parmmname", txtmname.Text);
                    com.Parameters.AddWithValue("@parmlname", txtlname.Text);
                    com.Parameters.AddWithValue("@parmaddress", txtaddress.Text);
                    com.Parameters.AddWithValue("@parmcontactno", txtcontactno.Text);
                    com.Parameters.AddWithValue("@parmbdate", txtdateofbirth.Text);
                    com.Parameters.AddWithValue("@parmdatehired", txtdatehired.Text);
                    com.Parameters.AddWithValue("@parmdesignation", designationid.ToString());
                    com.Parameters.AddWithValue("@parmtaxstatus", taxid.ToString());
                    com.Parameters.AddWithValue("@parmphoto", "");
                    com.Parameters.AddWithValue("@parmsig", "");
                    com.Parameters.AddWithValue("@parmsl", txtnosl.Text);
                    com.Parameters.AddWithValue("@parmvl", txtnovl.Text); 
                    com.Parameters.AddWithValue("@parmaddedby", "Eulz"); 
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

            bool ok = Database.checkifExist("SELECT TOP(1) EMP_ID FROM dbo.EMPLOYEE WHERE EMP_ID='" + txtid.Text.Trim() + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in Employees Table.. Please use Edit Function");
                return;
            }
            else
            {
                //Database.ExecuteQuery("INSERT INTO dbo.EMPLOYEE VALUES('" + txtid.Text + "','" + txtfname.Text + "','"++"')", "Successfully Added");
                execSP("1");
                XtraMessageBox.Show("Employee Successfully Added!");
                clear();

                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;

                disablefields();
                display();
            }
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
            fname = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "FirstName").ToString();
            mname = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MiddleName").ToString();
            lname = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "LastName").ToString();
            dateofbirth = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "BirthDate").ToString();
            designation = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Designation").ToString();
            address = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Address").ToString();
            taxstatus = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TaxStatus").ToString();
            nosl = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SL").ToString();
            novl = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "VL").ToString();
            datehired = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DateHired").ToString();

            txtid.Text = id;
            txtfname.Text = fname;
            txtmname.Text = mname;
            txtlname.Text = lname;
            txtdateofbirth.Text = dateofbirth;
            txtdesignation.Text = designation;
            txtaddress.Text = address;
            txttaxstatus.Text = taxstatus;
            txtnosl.Text = nosl;
            txtnovl.Text = novl;
            txtdatehired.Text = datehired;

            enablefields();

            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            execSP("2");
            XtraMessageBox.Show("Employee Successfully Updated!");
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

        private void txtdesignation_EditValueChanged(object sender, EventArgs e)
        {
            designationid = SearchLookUpClass.getSingleValue(txtdesignation, "DES_ID");
        }

        private void txttaxstatus_EditValueChanged(object sender, EventArgs e)
        {
            taxid = SearchLookUpClass.getSingleValue(txtdesignation, "TAX_ID");
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            disablefields();
            display();
        }
    }
}