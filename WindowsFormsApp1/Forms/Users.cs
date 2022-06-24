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

namespace WindowsFormsApp1.Forms
{
    public partial class Users : DevExpress.XtraEditors.XtraForm
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            display();
        }

        private void display()
        {
            Database.display("SELECT * FROM view_Users", gridControl1, gridView1); 
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            HelperFunction.EnableTextFields(this);
            HelperFunction.EnableCheckbox(this);

            btnnew.Enabled = false;
            btnadd.Enabled = true;
            btncancel.Enabled = true;
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperFunction.ClearAllText(this);
            HelperFunction.EnableCheckbox(this);
            HelperFunction.EnableTextFields(this);
            txtfullname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FullName").ToString();
            txtuserid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UserID").ToString();
            txtuserid.Enabled = false;
            btnnew.Enabled = false;
            btnadd.Enabled = false;
            btnupdate.Enabled = true;
            btncancel.Enabled = true;
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ok = HelperFunction.ConfirmDialog("Are you sure?", "Delete User");
            if (ok)
            {
                Database.ExecuteQuery("DELETE FROM Users WHERE UserID='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UserID").ToString() + "'", "Successfully Deleted");
                display();
            }
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.ExecuteQuery($"UPDATE Users SET Password='123456' WHERE UserID='{txtuserid.Text}'", "Successfully Updated!..");
        }
        void add()
        { 
            if (HelperFunction.isTextfieldEmpty(txtfullname, txtpass, txtuserid))
            {
                XtraMessageBox.Show("Please Input All Valid Fields");
            }
            else
            {
                Database.ExecuteQuery("INSERT INTO Users VALUES('" + txtuserid.Text + "','" + txtfullname.Text + "','" +  txtpass.Text + "','" + DateTime.Now.ToString() + "')", "Succesfully Added!");
                HelperFunction.ClearAllText(this);
                HelperFunction.DisableTextFields(this);
                HelperFunction.DisableCheckbox(this);
               
                display();

                btnnew.Enabled = true;
                btnadd.Enabled = false;
                btnupdate.Enabled = false;
                btncancel.Enabled = false;
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (HelperFunction.isTextfieldEmpty(txtfullname,  txtpass, txtuserid))
                {
                    XtraMessageBox.Show("Please Input All Valid Fields");
                }
                else
                {
                    Database.ExecuteQuery("UPDATE Users SET Fullname='" + txtfullname.Text + "',Password='" + txtpass.Text + "' WHERE UserID='" + txtuserid.Text + "' ", "Successfully Updated!");
                    HelperFunction.ClearAllText(this);
                    HelperFunction.DisableTextFields(this);
                    HelperFunction.DisableCheckbox(this);
                  
                    display();

                    btnnew.Enabled = true;
                    btnadd.Enabled = false;
                    btnupdate.Enabled = false;
                    btncancel.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            HelperFunction.ClearAllText(this); 
            HelperFunction.DisableCheckbox(this);
            HelperFunction.DisableTextFields(this); 
            btnnew.Enabled = true;
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
        }
    }
}