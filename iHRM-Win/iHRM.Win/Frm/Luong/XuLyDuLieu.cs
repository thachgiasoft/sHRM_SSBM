﻿using iHRM.Common.Code;
using iHRM.Win.Cls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iHRM.Win.Frm.Luong
{
    public partial class XuLyDuLieu : dlgCustomBase
    {
        Common.dlgChonDoiTuong chonDT = new Common.dlgChonDoiTuong();

        public XuLyDuLieu()
        {
            InitializeComponent();
        }
        private void XuLyDuLieu_Load(object sender, EventArgs e)
        {
            txtTuNgay.DateTime = txtDenNgay.DateTime = DateTime.Today;
            simpleButton1.Enabled = simpleButton2.Enabled = LoginHelper.user.isAdmin;
            simpleButton1.Visible = simpleButton2.Visible = LoginHelper.user.isAdmin;
        }

        private void txtDoiTuong_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (chonDT.ShowDialog() == DialogResult.OK)
                txtDoiTuong.Text = chonDT.SelectedText;
        }

        private void btnDoImport_Click(object sender, EventArgs e)
        {
            btnDoImport.Enabled = false;
            btnDoImport.Image = Properties.Resources.loading;
            if (!bgw_import.IsBusy)
                bgw_import.RunWorkerAsync();
        }

        private void bgw_import_DoWork(object sender, DoWorkEventArgs e)
        {
            iHRM.Win.ExtClass.Luong.XuLyDuLieu_1dong controller = new iHRM.Win.ExtClass.Luong.XuLyDuLieu_1dong(LoginHelper.user);

            controller.lp.OnOutMessage += (msg) => { bgw_import.ReportProgress(1, msg); };
            controller.lp.OnSetMaxValue += () => { bgw_import.ReportProgress(2, controller.lp.MaxValue); };
            controller.lp.OnSetValue += () => { bgw_import.ReportProgress(3, controller.lp.CurrentValue); };
            controller.lp.OnSetTitle += (title) => { bgw_import.ReportProgress(4, title); };
            controller.doAnalyza(txtTuNgay.DateTime
                , txtDenNgay.DateTime
                , chonDT.SelectedIndex == 1 ? chonDT.SelectedValue : ""
                , chonDT.SelectedIndex == 2 ? chonDT.SelectedValue : ""
                , chonDT.SelectedIndex == 3 ? Convert.ToInt32(chonDT.SelectedValue) : 0
                , checkEdit1.Checked
            );
        }
        private void bgw_import_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    outLog(e.UserState.ToString());
                    break;
                case 2:
                    prg.Properties.Maximum = (int)e.UserState;
                    break;
                case 3:
                    prg.EditValue = e.UserState;
                    break;
                case 4:

                    break;
            }
        }
        private void bgw_import_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnDoImport.Enabled = true;
            btnDoImport.Image = Properties.Resources.play;
            prg.EditValue = prg.Properties.Maximum;
        }
        
        #region chot cong
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ChotBangLuong(true);
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ChotBangLuong(false);
        }
        private void ChotBangLuong(bool isLock)
        {
            Core.Business.Logic.Luong.TinhLuong logic = new Core.Business.Logic.Luong.TinhLuong();
            DateTime cMonth = new DateTime(txtTuNgay.DateTime.Year, txtTuNgay.DateTime.Month, 1);

            int ii = 0;
            if (chonDT.SelectedIndex == 1)
            {
                ii = logic.ChotBangLuong_WithEmp(cMonth, chonDT.SelectedValue, isLock);
                outLog(string.Format("Chốt bảng lương ({1}) hoàn tất ({0} bản ghi) ", ii, chonDT.SelectedText));
            }
            else if (chonDT.SelectedIndex == 2)
            {
                ii = logic.ChotBangLuong_WithDept(cMonth, chonDT.SelectedValue, isLock);
                outLog(string.Format("Chốt bảng lương ({1}) hoàn tất ({0} bản ghi) ", ii, chonDT.SelectedText));
            }
            else if (chonDT.SelectedIndex == 3)
            {
                ii = logic.ChotBangLuong_WithGroup1(cMonth, Convert.ToInt32(chonDT.SelectedValue), isLock);
                outLog(string.Format("Chốt bảng lương ({1}) hoàn tất ({0} bản ghi) ", ii, chonDT.SelectedText));
            }
            else
            {
                ii = logic.ChotBangLuong(cMonth, isLock);
                outLog(string.Format("Chốt bảng lương hoàn tất ({0} bản ghi) ", ii));
            }
        }
        #endregion

        void outLog(string log)
        {
            richTextBox1.AppendText(string.Format("\n{0:HH:mm:ss}: {1}", DateTime.Now, log));
        }
    }
}
