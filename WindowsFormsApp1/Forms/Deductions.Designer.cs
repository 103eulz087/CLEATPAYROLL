namespace WindowsFormsApp1.Forms
{
    partial class Deductions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deductions));
            this.txtempid = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txthdmfhousingloan = new DevExpress.XtraEditors.SpinEdit();
            this.txthdmfcalloan = new DevExpress.XtraEditors.SpinEdit();
            this.txthdmfloan = new DevExpress.XtraEditors.SpinEdit();
            this.txtssscalloan = new DevExpress.XtraEditors.SpinEdit();
            this.txtsssloan = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.txtphealthemplyr = new DevExpress.XtraEditors.SpinEdit();
            this.txthdmfemplyr = new DevExpress.XtraEditors.SpinEdit();
            this.txtsssemplyr = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.txtphealthemp = new DevExpress.XtraEditors.SpinEdit();
            this.txthdmfemp = new DevExpress.XtraEditors.SpinEdit();
            this.txtsssemp = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtempid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfhousingloan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfcalloan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfloan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtssscalloan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsssloan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtphealthemplyr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfemplyr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsssemplyr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphealthemp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfemp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsssemp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(159, 35);
            this.txtempid.Name = "txtempid";
            this.txtempid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtempid.Properties.Appearance.Options.UseFont = true;
            this.txtempid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtempid.Properties.NullText = "";
            this.txtempid.Properties.PopupView = this.searchLookUpEdit1View;
            this.txtempid.Size = new System.Drawing.Size(262, 24);
            this.txtempid.TabIndex = 88;
            this.txtempid.EditValueChanged += new System.EventHandler(this.txtempid_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(12, 38);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(105, 17);
            this.labelControl8.TabIndex = 87;
            this.labelControl8.Text = "Select Employee:";
            // 
            // txthdmfhousingloan
            // 
            this.txthdmfhousingloan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txthdmfhousingloan.Location = new System.Drawing.Point(159, 185);
            this.txthdmfhousingloan.Name = "txthdmfhousingloan";
            this.txthdmfhousingloan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txthdmfhousingloan.Properties.Appearance.Options.UseFont = true;
            this.txthdmfhousingloan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txthdmfhousingloan.Size = new System.Drawing.Size(137, 24);
            this.txthdmfhousingloan.TabIndex = 149;
            // 
            // txthdmfcalloan
            // 
            this.txthdmfcalloan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txthdmfcalloan.Location = new System.Drawing.Point(159, 155);
            this.txthdmfcalloan.Name = "txthdmfcalloan";
            this.txthdmfcalloan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txthdmfcalloan.Properties.Appearance.Options.UseFont = true;
            this.txthdmfcalloan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txthdmfcalloan.Size = new System.Drawing.Size(137, 24);
            this.txthdmfcalloan.TabIndex = 148;
            // 
            // txthdmfloan
            // 
            this.txthdmfloan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txthdmfloan.Location = new System.Drawing.Point(159, 125);
            this.txthdmfloan.Name = "txthdmfloan";
            this.txthdmfloan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txthdmfloan.Properties.Appearance.Options.UseFont = true;
            this.txthdmfloan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txthdmfloan.Size = new System.Drawing.Size(137, 24);
            this.txthdmfloan.TabIndex = 147;
            // 
            // txtssscalloan
            // 
            this.txtssscalloan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtssscalloan.Location = new System.Drawing.Point(159, 95);
            this.txtssscalloan.Name = "txtssscalloan";
            this.txtssscalloan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtssscalloan.Properties.Appearance.Options.UseFont = true;
            this.txtssscalloan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtssscalloan.Size = new System.Drawing.Size(137, 24);
            this.txtssscalloan.TabIndex = 146;
            // 
            // txtsssloan
            // 
            this.txtsssloan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtsssloan.Location = new System.Drawing.Point(159, 65);
            this.txtsssloan.Name = "txtsssloan";
            this.txtsssloan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtsssloan.Properties.Appearance.Options.UseFont = true;
            this.txtsssloan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtsssloan.Size = new System.Drawing.Size(137, 24);
            this.txtsssloan.TabIndex = 145;
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl33.Appearance.Options.UseFont = true;
            this.labelControl33.Location = new System.Drawing.Point(12, 188);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(128, 17);
            this.labelControl33.TabIndex = 143;
            this.labelControl33.Text = "HDMF Housing Loan:";
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl32.Appearance.Options.UseFont = true;
            this.labelControl32.Location = new System.Drawing.Point(12, 128);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(75, 17);
            this.labelControl32.TabIndex = 142;
            this.labelControl32.Text = "HDMF Loan:";
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl31.Appearance.Options.UseFont = true;
            this.labelControl31.Location = new System.Drawing.Point(12, 158);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(131, 17);
            this.labelControl31.TabIndex = 141;
            this.labelControl31.Text = "HDMF Calamity Loan:";
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Location = new System.Drawing.Point(12, 98);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(119, 17);
            this.labelControl30.TabIndex = 140;
            this.labelControl30.Text = "SSS Calamity Loan:";
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl29.Appearance.Options.UseFont = true;
            this.labelControl29.Location = new System.Drawing.Point(12, 68);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(63, 17);
            this.labelControl29.TabIndex = 139;
            this.labelControl29.Text = "SSS Loan:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl38);
            this.groupControl1.Controls.Add(this.labelControl39);
            this.groupControl1.Controls.Add(this.txtphealthemplyr);
            this.groupControl1.Controls.Add(this.txthdmfemplyr);
            this.groupControl1.Controls.Add(this.txtsssemplyr);
            this.groupControl1.Controls.Add(this.labelControl25);
            this.groupControl1.Controls.Add(this.labelControl26);
            this.groupControl1.Controls.Add(this.labelControl27);
            this.groupControl1.Controls.Add(this.txtphealthemp);
            this.groupControl1.Controls.Add(this.txthdmfemp);
            this.groupControl1.Controls.Add(this.txtsssemp);
            this.groupControl1.Controls.Add(this.labelControl22);
            this.groupControl1.Controls.Add(this.labelControl23);
            this.groupControl1.Controls.Add(this.labelControl24);
            this.groupControl1.Controls.Add(this.btncancel);
            this.groupControl1.Controls.Add(this.btnupdate);
            this.groupControl1.Controls.Add(this.btnadd);
            this.groupControl1.Controls.Add(this.btnnew);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txthdmfhousingloan);
            this.groupControl1.Controls.Add(this.txtempid);
            this.groupControl1.Controls.Add(this.txthdmfcalloan);
            this.groupControl1.Controls.Add(this.labelControl29);
            this.groupControl1.Controls.Add(this.txthdmfloan);
            this.groupControl1.Controls.Add(this.labelControl30);
            this.groupControl1.Controls.Add(this.txtssscalloan);
            this.groupControl1.Controls.Add(this.labelControl31);
            this.groupControl1.Controls.Add(this.txtsssloan);
            this.groupControl1.Controls.Add(this.labelControl32);
            this.groupControl1.Controls.Add(this.labelControl33);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(764, 253);
            this.groupControl1.TabIndex = 150;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(357, 215);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(60, 26);
            this.btncancel.TabIndex = 153;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(291, 215);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(60, 26);
            this.btnupdate.TabIndex = 152;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(225, 215);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(60, 26);
            this.btnadd.TabIndex = 151;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(159, 215);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(60, 26);
            this.btnnew.TabIndex = 150;
            this.btnnew.Text = "New";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 253);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(764, 385);
            this.panelControl1.TabIndex = 151;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(760, 381);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseUp);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.ForestGreen;
            this.gridView2.Appearance.GroupRow.BackColor2 = System.Drawing.Color.LimeGreen;
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Gold;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.ColumnPanelRowHeight = 0;
            this.gridView2.FooterPanelHeight = 0;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.GroupRowHeight = 0;
            this.gridView2.LevelIndent = 0;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.ViewCaptionHeight = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemsToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 56);
            // 
            // editItemsToolStripMenuItem
            // 
            this.editItemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editItemsToolStripMenuItem.Image")));
            this.editItemsToolStripMenuItem.Name = "editItemsToolStripMenuItem";
            this.editItemsToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.editItemsToolStripMenuItem.Text = "Edit Items";
            this.editItemsToolStripMenuItem.Click += new System.EventHandler(this.editItemsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // labelControl38
            // 
            this.labelControl38.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl38.Appearance.Options.UseFont = true;
            this.labelControl38.Location = new System.Drawing.Point(323, 67);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(137, 18);
            this.labelControl38.TabIndex = 167;
            this.labelControl38.Text = "EMPLOYEE SHARE";
            // 
            // labelControl39
            // 
            this.labelControl39.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl39.Appearance.Options.UseFont = true;
            this.labelControl39.Location = new System.Drawing.Point(519, 67);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(139, 18);
            this.labelControl39.TabIndex = 166;
            this.labelControl39.Text = "EMPLOYER SHARE";
            // 
            // txtphealthemplyr
            // 
            this.txtphealthemplyr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtphealthemplyr.Location = new System.Drawing.Point(584, 154);
            this.txtphealthemplyr.Name = "txtphealthemplyr";
            this.txtphealthemplyr.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtphealthemplyr.Properties.Appearance.Options.UseFont = true;
            this.txtphealthemplyr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtphealthemplyr.Size = new System.Drawing.Size(97, 24);
            this.txtphealthemplyr.TabIndex = 165;
            // 
            // txthdmfemplyr
            // 
            this.txthdmfemplyr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txthdmfemplyr.Location = new System.Drawing.Point(584, 124);
            this.txthdmfemplyr.Name = "txthdmfemplyr";
            this.txthdmfemplyr.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txthdmfemplyr.Properties.Appearance.Options.UseFont = true;
            this.txthdmfemplyr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txthdmfemplyr.Size = new System.Drawing.Size(97, 24);
            this.txthdmfemplyr.TabIndex = 164;
            // 
            // txtsssemplyr
            // 
            this.txtsssemplyr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtsssemplyr.Location = new System.Drawing.Point(584, 95);
            this.txtsssemplyr.Name = "txtsssemplyr";
            this.txtsssemplyr.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtsssemplyr.Properties.Appearance.Options.UseFont = true;
            this.txtsssemplyr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtsssemplyr.Size = new System.Drawing.Size(97, 24);
            this.txtsssemplyr.TabIndex = 163;
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl25.Appearance.Options.UseFont = true;
            this.labelControl25.Location = new System.Drawing.Point(517, 157);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(63, 17);
            this.labelControl25.TabIndex = 162;
            this.labelControl25.Text = "PhilHealth:";
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Location = new System.Drawing.Point(517, 127);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(55, 17);
            this.labelControl26.TabIndex = 161;
            this.labelControl26.Text = "Pag-Ibig:";
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Location = new System.Drawing.Point(517, 98);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(29, 17);
            this.labelControl27.TabIndex = 160;
            this.labelControl27.Text = "SSS:";
            // 
            // txtphealthemp
            // 
            this.txtphealthemp.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtphealthemp.Location = new System.Drawing.Point(395, 154);
            this.txtphealthemp.Name = "txtphealthemp";
            this.txtphealthemp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtphealthemp.Properties.Appearance.Options.UseFont = true;
            this.txtphealthemp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtphealthemp.Size = new System.Drawing.Size(97, 24);
            this.txtphealthemp.TabIndex = 159;
            // 
            // txthdmfemp
            // 
            this.txthdmfemp.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txthdmfemp.Location = new System.Drawing.Point(395, 124);
            this.txthdmfemp.Name = "txthdmfemp";
            this.txthdmfemp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txthdmfemp.Properties.Appearance.Options.UseFont = true;
            this.txthdmfemp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txthdmfemp.Size = new System.Drawing.Size(97, 24);
            this.txthdmfemp.TabIndex = 158;
            // 
            // txtsssemp
            // 
            this.txtsssemp.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtsssemp.Location = new System.Drawing.Point(395, 95);
            this.txtsssemp.Name = "txtsssemp";
            this.txtsssemp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtsssemp.Properties.Appearance.Options.UseFont = true;
            this.txtsssemp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtsssemp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsssemp.Properties.EditFormat.FormatString = "###.##";
            this.txtsssemp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsssemp.Properties.Mask.EditMask = "####.##";
            this.txtsssemp.Size = new System.Drawing.Size(97, 24);
            this.txtsssemp.TabIndex = 157;
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(323, 157);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(63, 17);
            this.labelControl22.TabIndex = 156;
            this.labelControl22.Text = "PhilHealth:";
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(323, 127);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(55, 17);
            this.labelControl23.TabIndex = 155;
            this.labelControl23.Text = "Pag-Ibig:";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Location = new System.Drawing.Point(323, 98);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(29, 17);
            this.labelControl24.TabIndex = 154;
            this.labelControl24.Text = "SSS:";
            // 
            // Deductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 638);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Deductions";
            this.Text = "Deductions";
            this.Load += new System.EventHandler(this.Deductions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtempid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfhousingloan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfcalloan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfloan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtssscalloan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsssloan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtphealthemplyr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfemplyr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsssemplyr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphealthemp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthdmfemp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsssemp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit txtempid;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit txthdmfhousingloan;
        private DevExpress.XtraEditors.SpinEdit txthdmfcalloan;
        private DevExpress.XtraEditors.SpinEdit txthdmfloan;
        private DevExpress.XtraEditors.SpinEdit txtssscalloan;
        private DevExpress.XtraEditors.SpinEdit txtsssloan;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnnew;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.SpinEdit txtphealthemplyr;
        private DevExpress.XtraEditors.SpinEdit txthdmfemplyr;
        private DevExpress.XtraEditors.SpinEdit txtsssemplyr;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.SpinEdit txtphealthemp;
        private DevExpress.XtraEditors.SpinEdit txthdmfemp;
        private DevExpress.XtraEditors.SpinEdit txtsssemp;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl24;
    }
}