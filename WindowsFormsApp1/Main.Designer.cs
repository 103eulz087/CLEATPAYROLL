namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barbtnEmployees = new DevExpress.XtraBars.BarButtonItem();
            this.barbtndesignation = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.barbtncashadvance = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnovertime = new DevExpress.XtraBars.BarButtonItem();
            this.barbtndeductions = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnprocess = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnpayrolllist = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnpayrollcode = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnCustomersInfo = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.skinRibbonGalleryBarItem2,
            this.barbtnEmployees,
            this.barbtndesignation,
            this.barbtnUsers,
            this.barbtncashadvance,
            this.barbtnovertime,
            this.barbtndeductions,
            this.barbtnprocess,
            this.barbtnpayrolllist,
            this.barButtonItem1,
            this.btnpayrollcode});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.Size = new System.Drawing.Size(1244, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 1;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // barbtnEmployees
            // 
            this.barbtnEmployees.Caption = "Employees";
            this.barbtnEmployees.Id = 2;
            this.barbtnEmployees.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.Employee_32x32__2_;
            this.barbtnEmployees.Name = "barbtnEmployees";
            this.barbtnEmployees.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnEmployees_ItemClick);
            // 
            // barbtndesignation
            // 
            this.barbtndesignation.Caption = "Designation";
            this.barbtndesignation.Id = 3;
            this.barbtndesignation.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.Employees_32x32;
            this.barbtndesignation.Name = "barbtndesignation";
            this.barbtndesignation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtndesignation_ItemClick);
            // 
            // barbtnUsers
            // 
            this.barbtnUsers.Caption = "Users Info";
            this.barbtnUsers.Id = 4;
            this.barbtnUsers.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.UserKey_32x32;
            this.barbtnUsers.Name = "barbtnUsers";
            this.barbtnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnUsers_ItemClick);
            // 
            // barbtncashadvance
            // 
            this.barbtncashadvance.Caption = "Cash Advance";
            this.barbtncashadvance.Id = 5;
            this.barbtncashadvance.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.Currency_32x32__2_;
            this.barbtncashadvance.Name = "barbtncashadvance";
            this.barbtncashadvance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtncashadvance_ItemClick);
            // 
            // barbtnovertime
            // 
            this.barbtnovertime.Caption = "Overtime";
            this.barbtnovertime.Id = 6;
            this.barbtnovertime.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.Time_32x32__2_;
            this.barbtnovertime.Name = "barbtnovertime";
            this.barbtnovertime.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnovertime_ItemClick);
            // 
            // barbtndeductions
            // 
            this.barbtndeductions.Caption = "Deductions";
            this.barbtndeductions.Id = 7;
            this.barbtndeductions.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.LessThan_32x32;
            this.barbtndeductions.Name = "barbtndeductions";
            this.barbtndeductions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtndeductions_ItemClick);
            // 
            // barbtnprocess
            // 
            this.barbtnprocess.Caption = "Process Payroll";
            this.barbtnprocess.Id = 8;
            this.barbtnprocess.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.Refresh_32x32__5_;
            this.barbtnprocess.Name = "barbtnprocess";
            this.barbtnprocess.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnprocess_ItemClick);
            // 
            // barbtnpayrolllist
            // 
            this.barbtnpayrolllist.Caption = "Payroll List";
            this.barbtnpayrolllist.Id = 9;
            this.barbtnpayrolllist.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.ListByDate_32x32;
            this.barbtnpayrolllist.Name = "barbtnpayrolllist";
            this.barbtnpayrolllist.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnpayrolllist_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "MasterFile";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnpayrollcode
            // 
            this.btnpayrollcode.Caption = "Payroll Code";
            this.btnpayrollcode.Id = 11;
            this.btnpayrollcode.ImageOptions.LargeImage = global::WindowsFormsApp1.Properties.Resources.Scheduler_32x32;
            this.btnpayrollcode.Name = "btnpayrollcode";
            this.btnpayrollcode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnpayrollcode_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HOME";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Themes";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnEmployees);
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnUsers);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "GENERAL ADMINISTRATION";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtndesignation);
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtncashadvance);
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnovertime);
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtndeductions);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnpayrollcode);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "SETTINGS";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnprocess);
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnpayrolllist);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "PROCESSOR";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 625);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1244, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.xtraTabbedMdiManager1.Appearance.BackColor2 = System.Drawing.Color.DimGray;
            this.xtraTabbedMdiManager1.Appearance.BorderColor = System.Drawing.Color.White;
            this.xtraTabbedMdiManager1.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.xtraTabbedMdiManager1.Appearance.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.Appearance.Options.UseBorderColor = true;
            this.xtraTabbedMdiManager1.Appearance.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.BackColor = System.Drawing.Color.DarkSlateGray;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabbedMdiManager1.AppearancePage.Header.ForeColor = System.Drawing.Color.RoyalBlue;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.DarkTurquoise;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 111;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnCustomersInfo
            // 
            this.btnCustomersInfo.Caption = "Customers Info";
            this.btnCustomersInfo.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnCustomersInfo.Id = 37;
            this.btnCustomersInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCustomersInfo.ImageOptions.LargeImage")));
            this.btnCustomersInfo.Name = "btnCustomersInfo";
            this.btnCustomersInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 649);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barbtnEmployees;
        private DevExpress.XtraBars.BarButtonItem barbtndesignation;
        private DevExpress.XtraBars.BarButtonItem barbtnUsers;
        private DevExpress.XtraBars.BarButtonItem barbtncashadvance;
        private DevExpress.XtraBars.BarButtonItem barbtnovertime;
        private DevExpress.XtraBars.BarButtonItem barbtndeductions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnCustomersInfo;
        private DevExpress.XtraBars.BarButtonItem barbtnprocess;
        private DevExpress.XtraBars.BarButtonItem barbtnpayrolllist;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnpayrollcode;
    }
}