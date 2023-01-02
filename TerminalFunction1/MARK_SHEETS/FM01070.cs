using System;
using System.Data;
using System.ComponentModel;
using System.Collections;
using System.Text;

using CommonBase;
using CommonBase.BaseForms;
using CommonBase.Alerts;
using CommonBase.Commons;
using CommonBase.CsvFiles;
using CommonBase.Tables;
using System.Configuration;

namespace MARK_SHEETS
{

    public partial class FM01070 : BaseForm
    {
        public FM00000 PARRENT_FORM { get; set; } = null;

        private bool DoClose { get; set; } = false;
        private bool DoExecute { get; set; } = false;

        public FM01070()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM01070_Load(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                SetCmdGouID();
                SetcmbKyoukaID();

                cmdExecute.Enabled = false;
                cmdCancel.Enabled = false;

                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel2.Text = "";
                toolStripStatusLabel3.Text = "";
            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }
        private void FM01070_Shown(object sender, EventArgs e)
        {
            cmbGouID.Focus();
        }

        private void FM01070_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");
            if (DoExecute)
            {
                e.Cancel = true;
            }
            DoClose = true;

            // Processing Results
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "List Messages.", "started.");
            for (int ii = 0; ii < lstMessages.Items.Count; ii++)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "List Messages.", lstMessages.Items[ii]);
            }
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "List Messages.", "ended.");
        }

        private void cmbGouID_Leave(object sender, EventArgs e)
        {
            if (DoClose) return;

            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, cmbGouID.Text);

            try
            {
                if (cmbGouID.Text.Length == 0)
                {
                    txtGouIDName.Text = "";
                }
                else if (cmbGouID.Text.Length < 3)
                {
                    cmbGouID.Text = new String('0', 3 - cmbGouID.Text.Length) + cmbGouID.Text;
                    txtGouIDName.Text = GetGouIDName();
                }
                else
                {
                    int indexs = cmbGouID.FindStringExact(cmbGouID.Text);
                    txtGouIDName.Text = GetGouIDName();
                }
            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void cmbGouID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoClose) return;

            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, cmbGouID.Text);

            try
            {
                int indexs = cmbGouID.SelectedIndex;
                if (indexs <= 0)
                {
                    txtGouIDName.Text = "";
                }
                else
                {
                    txtGouIDName.Text = GetGouIDName();
                }
                cmbRyouiki.DataSource = null;
            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void cmbKyoukaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoClose) return;

            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, cmbKyoukaID.Text);
            cmbRyouiki.DataSource = null;
        }

        private void pnlGouKyouka_Leave(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                if (cmbGouID.Text.Length != 0 && cmbKyoukaID.SelectedIndex >= 1)
                {
                    if (cmbRyouiki.Items.Count <= 0)
                    {
                        SetRyouikiSentaku();
                        if (cmbRyouiki.Items.Count <= 1)
                        {
                            string[] embedArray = new string[1] { "選択可能な「領域選択」がありません" };
                            Messages1.ShowMessage("MS01020", embedArray);
                            cmbGouID.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void pnlGouKyoukaSentaku_Leave(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                if (cmbGouID.Text.Length != 0)
                {
                    cmdExecute.Enabled = true;
                    DoExecute = !cmdExecute.Enabled;
                }
            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        /// <summary>
        /// 「号数」候補を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private void SetCmdGouID()
        {
            string SQLSTMT = SQL.GET_LIST.GET_GOUID_LIST_EXCLUDE;
            string exclude = ConfigurationManager.AppSettings[ConstantCommon.CONFIG_EXCLUDE_TEST];
            SQLSTMT = CommonLogic1.ReplaceStatement(SQLSTMT, "@exclude", exclude);
            cmbGouID.DataSource = Tables1.GetSelectRowsDataTable(SQLSTMT);
            cmbGouID.DisplayMember = "gou_id_display";
            cmbGouID.ValueMember = "gou_id";
        }

        /// <summary>
        /// 「教科」候補を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private void SetcmbKyoukaID()
        {
            string SQLSTMT = SQL.GET_LIST.GET_KYOUKAID_LIST;
            cmbKyoukaID.DataSource = Tables1.GetSelectRowsDataTable(SQLSTMT);
            cmbKyoukaID.DisplayMember = "kyouka_name";
            cmbKyoukaID.ValueMember = "kyouka_id";
        }

        /// <summary>
        /// 「号数」名称を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private string GetGouIDName()
        {
            string results = null;

            string SQLSTMT = SQL.GET_NAME.GET_GOUID_NAME;
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(cmbGouID.Text));
            DataTable dt = Tables1.GetSelectRowsDataTable(SQLSTMT);
            if (dt != null)
            {
                results = dt.Rows[0]["test_name"] as string;
            }
            return results;
        }

        /// <summary>
        /// 「領域選択」を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private void SetRyouikiSentaku()
        {
            cmbRyouiki.DataSource = null;

            string SQLSTMT = SQL.GET_LIST.GET_RYOUIKI_SENTAKU_LIST;
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(cmbGouID.Text));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(cmbKyoukaID.SelectedValue));
            cmbRyouiki.DataSource = Tables1.GetSelectRowsDataTable(SQLSTMT);
            cmbRyouiki.DisplayMember = "ryouiki_sentaku_id";
            cmbRyouiki.ValueMember = "ryouiki_sentaku_id";
            return;
        }

        /// <summary>
        /// 処理経過メッセージの表示
        /// </summary>
        /// <param name=">Messages">メッセージです。</param>
        /// <returns></returns>
        private void AddMessages(string Messages)
        {
            DateTime dtNow = DateTime.Now;
            var strDate = dtNow.ToString("yyyy/MM/dd HH:mm:ss.fff");
            lstMessages.Items.Add(strDate + " " + Messages);
            lstMessages.Refresh();
            lstMessages.SelectedIndex = lstMessages.Items.Count - 1;
        }

        private void cmdExecute_Click(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            if (cmbGouID.Text.Length == 0)
            {
                string[] embedArray = new string[1] { "号数" };
                Messages1.ShowMessage("MS01010", embedArray);
                cmbGouID.Focus();
                return;
            }

            try
            {
                Global.RETENTION.GOU_ID = cmbGouID.Text;
                Global.RETENTION.KYOUKA_ID = cmbKyoukaID.SelectedValue.ToString();
                Global.RETENTION.SENTAKU_ID = cmbRyouiki.Text;

                // Worker Start
                AddMessages("「自動採点事前チェック」を開始しました。");
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = 00;
                backgroundWorker1.RunWorkerAsync();

                cmdExecute.Enabled = false;
                cmdCancel.Enabled = true;
                DoExecute = !cmdExecute.Enabled;
            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            cmdCancel.Enabled = false;
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs args)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            // Get Parameter (nothing)
            string filePath = (string)args.Argument;

            // Get Worker Object
            BackgroundWorker Worker = sender as BackgroundWorker;
            if (Worker == null)
            {
                throw new Exception("「Background Worker」の取得に失敗しました。");
            }

            var results = CheckConsistency(Worker);
            if (!results)
            {
                args.Cancel = true;
                return;
            }

            // Exit
            return;
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int percentage = e.ProgressPercentage > 100 ? 100 : e.ProgressPercentage;
            int values = (Convert.ToInt32((double)toolStripProgressBar1.Maximum * ((double)percentage / 100)));
            toolStripProgressBar1.Value = values;
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            cmdCancel.Enabled = false;
            DoExecute = false;

            // On Error or Cancel
            if (e.Error != null)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, e.Error.ToString());
                string[] embedArray1 = new string[1] { e.Error.ToString() };
                Messages1.ShowMessage("MS90010", embedArray1);
                return;
            }

            string[] embedArray2 = new string[1] { "自動採点事前チェック" };

            // Canceled
            if (e.Cancelled)
            {
                AddMessages("「自動採点事前チェック」がキャンセルされました。");
                Messages1.ShowMessage("MS02020", embedArray2);
                Close();
                return;
            }

            // Normal Completed
            AddMessages("「自動採点事前チェック」が完了しました。");
            Messages1.ShowMessage("MS02010", embedArray2);
        }

        /// <summary>
        /// 「自動採点事前チェック」の実施
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private bool CheckConsistency(BackgroundWorker Worker)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                Invoke(new delegate1(AddMessages_Thread), "整合性検証データを取得します。");
                DataTable consistency = GetConsistencyData();
                Invoke(new delegate1(AddMessages_Thread), "整合性検証データの取得が完了しました。");
                if (consistency.Rows.Count == 0)
                {
                    Invoke(new delegate1(AddMessages_Thread), "検証対象データが有りません、処理を中断します。");
                    return true;
                }
                Invoke(new delegate1(AddMessages_Thread), "検証対象データは " + consistency.Rows.Count + " 件です。");

                // check
                for (int ii = 0; ii < consistency.Rows.Count; ii++)
                {
                    DataRow dtr = consistency.Rows[ii];

                    int checks = 0;
                    if (!String.IsNullOrEmpty(Convert.ToString(dtr["t36d_CT"]))
                        && Convert.ToInt32(dtr["t36d_CT"]) == 0)
                    {
                        if ((!String.IsNullOrEmpty(Convert.ToString(dtr["t301d_CT"]))
                            && Convert.ToInt32(dtr["t301d_CT"]) != 0)
                            || (!String.IsNullOrEmpty(Convert.ToString(dtr["t302d_CT"])) 
                            && Convert.ToInt32(dtr["t302d_CT"]) != 0)
                            || (!String.IsNullOrEmpty(Convert.ToString(dtr["t303d_CT"]))
                            && Convert.ToInt32(dtr["t303d_CT"]) != 0))
                        {
                            checks = 1;
                        }
                    }
                    else
                    {
                        if ((!String.IsNullOrEmpty(Convert.ToString(dtr["t301d_CT"]))
                            && Convert.ToInt32(dtr["t301d_CT"]) == 0)
                            || (!String.IsNullOrEmpty(Convert.ToString(dtr["t302d_CT"]))
                            && Convert.ToInt32(dtr["t302d_CT"]) == 0)
                            || (!String.IsNullOrEmpty(Convert.ToString(dtr["t303d_CT"]))
                            && Convert.ToInt32(dtr["t303d_CT"]) == 0))
                        {
                            checks = 2;
                        }
                        else
                        {
                            if (Convert.ToInt32(dtr["t301d_CT"]) != Convert.ToInt32(dtr["t302d_CT"])
                             || Convert.ToInt32(dtr["t302d_CT"]) != Convert.ToInt32(dtr["t303d_CT"])
                             || Convert.ToInt32(dtr["t303d_CT"]) != Convert.ToInt32(dtr["t301d_CT"]))
                            {
                                checks = 3;
                            }
                        }
                    }

                    string elements = " >[" 
                        + "号数:" + String.Format("{0:000}", Convert.ToInt32(dtr["gou_id"])) + "-"
                        + "教科:" + String.Format("{0:00}", Convert.ToInt32(dtr["kyouka_id"])) + "-"
                        + "領域選択:" + Convert.ToString(dtr["ryouiki_sentaku_id"])
                        + "] ";

                    switch (checks)
                    {
                        case 0:
                            Invoke(new delegate1(AddMessages_Thread), elements + " -> 不整合なし");
                            break;
                        case 1:
                            Invoke(new delegate1(AddMessages_Thread), elements + " -> 不整合あり" + " >>自動採点の対象外で、マーク関連の情報が登録あり");
                            break;
                        case 2:
                            Invoke(new delegate1(AddMessages_Thread), elements + " -> 不整合あり" + " >>自動採点の対象で、マーク関連の情報が登録なし");
                            break;
                        case 3:
                            Invoke(new delegate1(AddMessages_Thread), elements + " -> 不整合あり" + " >>自動採点の対象で、マーク関連の設問数に不一致あり");
                            break;
                        default:
                            Invoke(new delegate1(AddMessages_Thread), elements + " -> 不整合あり" + " >>マーク関連の情報が不完全");
                            break;
                    }
                }

                // 進行状況の更新
                // int PROGRESS = 0;
                // int Percents = Convert.ToInt32(((double)PROGRESS / (double)toolStripProgressBar1.Maximum) * 100);
                // Worker.ReportProgress(Percents);

            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                Invoke(new delegate1(AddMessages_Thread), String.Format("自動採点事前チェックで異常を検出しました。"));
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 「整合性」検証データを取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private DataTable GetConsistencyData()
        {
            try
            {
                StringBuilder condition = new StringBuilder();
                condition.Append(" WHERE ");
                condition.Append("target.gou_id=" + Global.RETENTION.GOU_ID);
                if (Convert.ToInt32(Global.RETENTION.KYOUKA_ID) >= 10)
                {
                    condition.Append(" AND target.kyouka_id=" + Global.RETENTION.KYOUKA_ID);
                }
                if (Global.RETENTION.SENTAKU_ID.Length != 0)
                {
                    condition.Append(" AND target.ryouiki_sentaku_id=" + Global.RETENTION.SENTAKU_ID);
                }

                string SQLSTMT = SQL.GET_CORRELATION.GET_CONSISTENCY_COUNT;
                SQLSTMT = CommonLogic1.ReplaceStatement(SQLSTMT, "@condition", condition.ToString());
                DataTable results = Tables1.GetSelectRowsDataTable(SQLSTMT);
                if (results == null)
                {
                    throw new Exception("整合性検証データの取得に失敗しました。");
                }
                return results;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        delegate void delegate1(String Messages);

        /// <summary>
        /// 処理経過メッセージの表示
        /// </summary>
        /// <param name=">Messages">メッセージです。</param>
        /// <returns></returns>
        private void AddMessages_Thread(string Messages)
        {
            AddMessages(Messages);
        }

        private void Common_Enter(object sender, EventArgs e)
        {
            SetSelectALL(sender as Control);
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            ButtonFocusEnter(sender, e);
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            ButtonFocusLeave(sender, e);
        }

        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.Enabled)
            {
                ButtonColorEnabled(button);
            }
            else
            {
                ButtonColorDisabled(button);
            }
        }

    }
}
