namespace WindowsFormsApp1.Forms
{
    partial class Overtime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overtime));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btncancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtnightdiff = new DevExpress.XtraEditors.SpinEdit();
            this.txtspclotrate = new DevExpress.XtraEditors.SpinEdit();
            this.txtregholotrate = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.txtregotrate = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnightdiff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtspclotrate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtregholotrate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtregotrate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
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
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btncancel);
            this.groupControl1.Controls.Add(this.btnupdate);
            this.groupControl1.Controls.Add(this.txtnightdiff);
            this.groupControl1.Controls.Add(this.txtspclotrate);
            this.groupControl1.Controls.Add(this.txtregholotrate);
            this.groupControl1.Controls.Add(this.labelControl30);
            this.groupControl1.Controls.Add(this.txtregotrate);
            this.groupControl1.Controls.Add(this.labelControl31);
            this.groupControl1.Controls.Add(this.labelControl32);
            this.groupControl1.Controls.Add(this.labelControl33);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1014, 112);
            this.groupControl1.TabIndex = 151;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(690, 41);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 54);
            this.btncancel.TabIndex = 153;
            this.btncancel.Text = "Cancel";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(609, 41);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 54);
            this.btnupdate.TabIndex = 152;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtnightdiff
            // 
            this.txtnightdiff.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtnightdiff.Location = new System.Drawing.Point(466, 71);
            this.txtnightdiff.Name = "txtnightdiff";
            this.txtnightdiff.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtnightdiff.Properties.Appearance.Options.UseFont = true;
            this.txtnightdiff.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtnightdiff.Size = new System.Drawing.Size(137, 24);
            this.txtnightdiff.TabIndex = 149;
            // 
            // txtspclotrate
            // 
            this.txtspclotrate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtspclotrate.Location = new System.Drawing.Point(466, 41);
            this.txtspclotrate.Name = "txtspclotrate";
            this.txtspclotrate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtspclotrate.Properties.Appearance.Options.UseFont = true;
            this.txtspclotrate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtspclotrate.Size = new System.Drawing.Size(137, 24);
            this.txtspclotrate.TabIndex = 148;
            // 
            // txtregholotrate
            // 
            this.txtregholotrate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtregholotrate.Location = new System.Drawing.Point(170, 71);
            this.txtregholotrate.Name = "txtregholotrate";
            this.txtregholotrate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtregholotrate.Properties.Appearance.Options.UseFont = true;
            this.txtregholotrate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtregholotrate.Size = new System.Drawing.Size(126, 24);
            this.txtregholotrate.TabIndex = 147;
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl30.Appearance.Options.UseFont = true;
            this.labelControl30.Location = new System.Drawing.Point(12, 44);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(105, 17);
            this.labelControl30.TabIndex = 140;
            this.labelControl30.Text = "Regular OT Rate:";
            // 
            // txtregotrate
            // 
            this.txtregotrate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtregotrate.Location = new System.Drawing.Point(170, 41);
            this.txtregotrate.Name = "txtregotrate";
            this.txtregotrate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtregotrate.Properties.Appearance.Options.UseFont = true;
            this.txtregotrate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtregotrate.Size = new System.Drawing.Size(126, 24);
            this.txtregotrate.TabIndex = 146;
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl31.Appearance.Options.UseFont = true;
            this.labelControl31.Location = new System.Drawing.Point(308, 44);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(153, 17);
            this.labelControl31.TabIndex = 141;
            this.labelControl31.Text = "Special Holidaty OT Rate:";
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl32.Appearance.Options.UseFont = true;
            this.labelControl32.Location = new System.Drawing.Point(12, 74);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(153, 17);
            this.labelControl32.TabIndex = 142;
            this.labelControl32.Text = "Regular Holiday OT Rate:";
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.labelControl33.Appearance.Options.UseFont = true;
            this.labelControl33.Location = new System.Drawing.Point(308, 74);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(136, 17);
            this.labelControl33.TabIndex = 143;
            this.labelControl33.Text = "Night Differential Rate:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 112);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1014, 434);
            this.gridControl1.TabIndex = 152;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            // Overtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 546);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Overtime";
            this.Text = "Overtime";
            this.Load += new System.EventHandler(this.Overtime_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnightdiff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtspclotrate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtregholotrate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtregotrate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btncancel;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SpinEdit txtnightdiff;
        private DevExpress.XtraEditors.SpinEdit txtspclotrate;
        private DevExpress.XtraEditors.SpinEdit txtregholotrate;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.SpinEdit txtregotrate;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}