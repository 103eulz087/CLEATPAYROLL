using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsFormsApp1
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void barbtnEmployees_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Forms.Employees))
                {
                    form.Activate();
                    return;
                }
            }
            Forms.Employees housers = new Forms.Employees();
            housers.MdiParent = this;
            housers.Show();
        }

        private void barbtndesignation_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Forms.Designation))
                {
                    form.Activate();
                    return;
                }
            }
            Forms.Designation housers = new Forms.Designation();
            housers.MdiParent = this;
            housers.Show();
        }

        private void barbtnpayrolllist_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Forms.PayrollList))
                {
                    form.Activate();
                    return;
                }
            }
            Forms.PayrollList housers = new Forms.PayrollList();
            housers.MdiParent = this;
            housers.Show();
        }

        private void barbtnprocess_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.Payroll housers = new Forms.Payroll();
            housers.Show();
        }

        private void btnpayrollcode_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Forms.PayrollCode))
                {
                    form.Activate();
                    return;
                }
            }
            Forms.PayrollCode housers = new Forms.PayrollCode();
            housers.MdiParent = this;
            housers.Show();
        }

        private void barbtndeductions_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Forms.Deductions))
                {
                    form.Activate();
                    return;
                }
            }
            Forms.Deductions housers = new Forms.Deductions();
            housers.MdiParent = this;
            housers.Show();
        }

        private void barbtncashadvance_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Forms.CashAdvanced))
                {
                    form.Activate();
                    return;
                }
            }
            Forms.CashAdvanced housers = new Forms.CashAdvanced();
            housers.MdiParent = this;
            housers.Show();
        }

        private void barbtnUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Forms.Users))
                {
                    form.Activate();
                    return;
                }
            }
            Forms.Users housers = new Forms.Users();
            housers.MdiParent = this;
            housers.Show();
        }

        private void barbtnovertime_ItemClick(object sender, ItemClickEventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Forms.Overtime))
                {
                    form.Activate();
                    return;
                }
            }
            Forms.Overtime housers = new Forms.Overtime();
            housers.MdiParent = this;
            housers.Show();
        }
    }
}