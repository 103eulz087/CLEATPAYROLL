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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 253);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(764, 385);
            this.panelControl1.TabIndex = 151;
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
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
    }
}