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
    public partial class CashAdvanced : DevExpress.XtraEditors.XtraForm
    {
        object id = null;
        public CashAdvanced()
        {
            InitializeComponent();
        }

        private void CashAdvanced_Load(object sender, EventArgs e)
        {
            populate();
        }

        void populate()
        {
            Database.displaySearchlookupEdit("SELECT * FROM dbo.view_EMPPayrollInfo", txtempid, "FullName", "FullName");
        }

        void populateLedger()
        {
            Database.display($"SELECT SeqNo,Particulars,BeginningBalance,Debit,Credit,EndingBalance,DateUpdated,UpdatedBy " +
                $"FROM dbo.view_CASHADVANCELEDGER WHERE EmpID='{id}' ORDER BY SeqNo ASC", gridControl1, gridView2);
        }

        private void txtempid_EditValueChanged(object sender, EventArgs e)
        {
            id = SearchLookUpClass.getSingleValue(txtempid, "ID");
            txtbalance.Text = Database.getSingleResultSet($"SELECT CSH_ADVANCE FROM dbo.CASHADVANCE WHERE EMP_ID={id}");
            populateLedger();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //ADD CASH ADVANCE
            if(String.IsNullOrEmpty(txtempid.Text))
            {
                XtraMessageBox.Show("Please Select Employee First");
            }
            else
            {
                //show form
                Forms.AddCashAdvance addc = new AddCashAdvance();
                addc.txtid.Text = id.ToString();
                addc.ShowDialog(this);

                if(AddCashAdvance.isdone == true)
                {
                    addc.Dispose();
                    populateLedger();
                    txtbalance.Text = Database.getSingleResultSet($"SELECT CSH_ADVANCE FROM dbo.CASHADVANCED WHERE EMP_ID='{id.ToString()}'");
                }
            }
        }
    }
}