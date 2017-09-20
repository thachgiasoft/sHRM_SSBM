﻿namespace iHRM.Win.Frm.Report
{
    partial class ReportNhanVienVangMat
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookupTimKiem = new DevExpress.XtraEditors.LookUpEdit();
            this.chonKyLuong1 = new iHRM.Win.UC.ChonKyLuong();
            this.chonPhongBan1 = new iHRM.Win.UC.ChonPhongBan();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTimKiem.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grd);
            this.splitContainerControl1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1362, 434);
            this.splitContainerControl1.SplitterPosition = 164;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lookupTimKiem);
            this.panel1.Controls.Add(this.chonKyLuong1);
            this.panel1.Controls.Add(this.chonPhongBan1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 406);
            this.panel1.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(7, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 19);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Loại nghỉ:";
            // 
            // lookupTimKiem
            // 
            this.lookupTimKiem.Location = new System.Drawing.Point(6, 88);
            this.lookupTimKiem.MinimumSize = new System.Drawing.Size(10, 0);
            this.lookupTimKiem.Name = "lookupTimKiem";
            this.lookupTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lookupTimKiem.Properties.Appearance.Options.UseFont = true;
            this.lookupTimKiem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lookupTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupTimKiem.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("text", "Loại nghỉ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("value", "Giá trị")});
            this.lookupTimKiem.Properties.DisplayMember = "text";
            this.lookupTimKiem.Properties.NullText = "";
            this.lookupTimKiem.Properties.ValueMember = "value";
            this.lookupTimKiem.Size = new System.Drawing.Size(156, 26);
            this.lookupTimKiem.TabIndex = 7;
            // 
            // chonKyLuong1
            // 
            this.chonKyLuong1.DenNgay = new System.DateTime(2016, 3, 16, 0, 0, 0, 0);
            this.chonKyLuong1.isVisibleKyLuong = false;
            this.chonKyLuong1.Location = new System.Drawing.Point(6, 119);
            this.chonKyLuong1.Name = "chonKyLuong1";
            this.chonKyLuong1.Size = new System.Drawing.Size(154, 99);
            this.chonKyLuong1.TabIndex = 6;
            this.chonKyLuong1.TuNgay = new System.DateTime(2016, 2, 17, 0, 0, 0, 0);
            // 
            // chonPhongBan1
            // 
            this.chonPhongBan1.Location = new System.Drawing.Point(6, 26);
            this.chonPhongBan1.Name = "chonPhongBan1";
            this.chonPhongBan1.SelectedValue = null;
            this.chonPhongBan1.Size = new System.Drawing.Size(156, 28);
            this.chonPhongBan1.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(6, 4);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 3, 3, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Phòng ban:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(164, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFind
            // 
            this.btnFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFind.Image = global::iHRM.Win.Properties.Resources.btnFind_Image;
            this.btnFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(94, 25);
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 28);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.grd.Size = new System.Drawing.Size(1193, 406);
            this.grd.TabIndex = 3;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.grv.Appearance.HeaderPanel.Options.UseFont = true;
            this.grv.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grv.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grv.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grv.Appearance.Row.Options.UseFont = true;
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn7,
            this.gridColumn12,
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn9,
            this.gridColumn13,
            this.gridColumn4});
            this.grv.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsBehavior.Editable = false;
            this.grv.OptionsCustomization.AllowFilter = false;
            this.grv.OptionsSelection.MultiSelect = true;
            this.grv.OptionsView.ColumnAutoWidth = false;
            this.grv.OptionsView.ShowAutoFilterRow = true;
            this.grv.OptionsView.ShowFooter = true;
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Mã NV";
            this.gridColumn2.FieldName = "EmployeeID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "EmployeeID", "Tổng: {0:#,0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 76;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Nhân viên";
            this.gridColumn3.FieldName = "EmployeeName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 155;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "Ngày sinh";
            this.gridColumn7.FieldName = "Birthday";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 85;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn12.AppearanceCell.Options.UseFont = true;
            this.gridColumn12.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn12.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn12.AppearanceHeader.Options.UseFont = true;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "Số CMND";
            this.gridColumn12.FieldName = "IDCard";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            this.gridColumn12.Width = 89;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Chức vụ";
            this.gridColumn8.FieldName = "PosName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 97;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Phòng ban";
            this.gridColumn6.FieldName = "DepName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 162;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Ngày vào";
            this.gridColumn5.FieldName = "AppliedDate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 110;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Ngày nghỉ";
            this.gridColumn1.FieldName = "ngay";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 116;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn9.AppearanceCell.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn9.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.Caption = "Lý do";
            this.gridColumn9.FieldName = "lydo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn13.AppearanceCell.Options.UseFont = true;
            this.gridColumn13.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn13.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn13.AppearanceHeader.Options.UseFont = true;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "Số ngày";
            this.gridColumn13.FieldName = "songay";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 9;
            this.gridColumn13.Width = 97;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Ghi chú";
            this.gridColumn4.FieldName = "ghiChu";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "Xóa";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1193, 28);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton2.Image = global::iHRM.Win.Properties.Resources.exxcel;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(64, 25);
            this.toolStripButton2.Text = "Excel";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ReportNhanVienVangMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 434);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ReportNhanVienVangMat";
            this.Text = "BC nhân viên vắng mặt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Viewer_FormClosed);
            this.Load += new System.EventHandler(this.Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTimKiem.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btnFind;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.GridControl grd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Panel panel1;
        private UC.ChonPhongBan chonPhongBan1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private UC.ChonKyLuong chonKyLuong1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LookUpEdit lookupTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}