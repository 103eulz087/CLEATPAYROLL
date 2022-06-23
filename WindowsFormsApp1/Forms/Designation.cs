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
    public partial class Designation : DevExpress.XtraEditors.XtraForm
    {
        string id="", rate="",designationName="", allowance="";
        public Designation()
        {
            InitializeComponent();
        }

        private void Designation_Load(object sender, EventArgs e)
        {
            display();
        }
        void clear()
        {
            txtid.Text = "";
            txtrate.Text = "";
            txtallowance.Text = "";
            txtdesc.Text = "";
        }

        void disablefields()
        {
            txtid.Enabled = false;
            txtrate.Enabled = false;
            txtallowance.Enabled = false;
            txtdesc.Enabled = false;
        }
        void enablefields()
        {

            txtrate.Enabled = true;
            txtallowance.Enabled = true;
            txtdesc.Enabled = true; 
        }
        void display()
        {
            Database.display("SELECT * FROM dbo.view_DESIGNATION", gridControl2, gridView2);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            int newid = 0;
            newid = IDGenerator.getIDNumber("DESIGNATION", "DES_ID", 1);
            txtid.Text = newid.ToString();
            enablefields();

            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btncancel.Enabled = true;
        }

        void execSP(string option)
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            try
            {
                string query = "spfunc_CRUDDesignation";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@parmid", txtid.Text);
                com.Parameters.AddWithValue("@parmdesignation", txtdesc.Text);
                com.Parameters.AddWithValue("@parmrate", txtrate.Text);
                com.Parameters.AddWithValue("@parmallowance", txtallowance.Text);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            execSP("2");
            XtraMessageBox.Show("Designation Successfully Updated!");
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

        private void btnadd_Click(object sender, EventArgs e)
        {

            bool ok = Database.checkifExist("SELECT TOP(1) DES_ID FROM dbo.DESIGNATION WHERE DES_ID='" + txtid.Text.Trim() + "' ");
            if (ok)
            {
                XtraMessageBox.Show("Already Exist in Designation Table.. Please use Edit Function");
                return;
            }
            else
            {
                //Database.ExecuteQuery("INSERT INTO dbo.EMPLOYEE VALUES('" + txtid.Text + "','" + txtfname.Text + "','"++"')", "Successfully Added");
                execSP("1");
                XtraMessageBox.Show("Designation Successfully Added!");
                clear();

                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;

                disablefields();
                display();
            }
        }

        private void gridControl2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl2, e.Location);
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ID").ToString();
            designationName = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Designation").ToString();
            rate = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Rate").ToString();
            allowance = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Allowance").ToString();
          
            txtid.Text = id;
            txtdesc.Text = designationName;
            txtrate.Text = rate;
            txtallowance.Text = allowance;
            

            enablefields();

            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }
    }
}