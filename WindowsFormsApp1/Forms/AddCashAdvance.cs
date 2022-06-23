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
    public partial class AddCashAdvance : DevExpress.XtraEditors.XtraForm
    {
        public static bool isdone = false;
        public AddCashAdvance()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtid.Text) || String.IsNullOrEmpty(txtnovl.Text))
            {
                XtraMessageBox.Show("Fields must not Empty");
            }
            else
            {
                Database.ExecuteQuery($"INSERT INTO dbo.CASHADVANCELEDGER VALUES('{txtid.Text}','Cash Advanced',0,'{txtnovl.Value}',0,0,'{txtnovl.Value}','{DateTime.Now.ToString()}','{DateTime.Now.ToString()}','{Login.Fullname}','{Login.Fullname}')","Successfully Added");
                isdone = true;
                this.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}