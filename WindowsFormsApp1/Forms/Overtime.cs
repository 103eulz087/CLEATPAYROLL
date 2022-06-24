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
    public partial class Overtime : DevExpress.XtraEditors.XtraForm
    {
        public Overtime()
        {
            InitializeComponent();
        }

        private void Overtime_Load(object sender, EventArgs e)
        {
            Database.display("SELECT * FROM dbo.OVERTIME", gridControl1, gridView2);
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(gridControl1, e.Location);
        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnightdiff.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OT_NIGHTDIFF").ToString();
            txtregholotrate.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OT_REGHOLIDAY").ToString();
            txtregotrate.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OT_REGULAR").ToString();
            txtspclotrate.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OT_SPCLHOLIDAY").ToString();
        }

        void clear()
        {
            txtnightdiff.Text = "";
            txtregholotrate.Text = "";
            txtregotrate.Text = "";
            txtspclotrate.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtnightdiff.Text) || String.IsNullOrEmpty(txtregholotrate.Text) || String.IsNullOrEmpty(txtregotrate.Text) || String.IsNullOrEmpty(txtspclotrate.Text))
            {
                XtraMessageBox.Show("Fields must not Empty");
            }
            else
            {
                Database.ExecuteQuery($"UPDATE dbo.OVERTIME SET OT_NIGHTDIFF='{txtnightdiff.Text}',OT_REGHOLIDAY='{txtregholotrate.Text}',OT_REGULAR='{txtregotrate.Text},OT_SPCLHOLIDAY='{txtspclotrate.Text }' WHERE ADDEDBY='system'", "Successfully Updated");
                clear();
            }
        }
    }
}