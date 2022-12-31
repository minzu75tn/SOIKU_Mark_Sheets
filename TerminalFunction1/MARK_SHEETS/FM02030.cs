using System;
using System.ComponentModel;
using System.Data;
using System.Text;

using CommonBase;
using CommonBase.BaseForms;
using CommonBase.Alerts;
using CommonBase.Tables;
using CommonBase.Commons;
using NPOI.SS.Formula.Functions;
using System.Configuration;

namespace MARK_SHEETS
{
    public partial class FM02030 : BaseForm
    {
        public FM00000 PARRENT_FORM { get; set; } = null;

        private bool DoClose { get; set; } = false;
        private bool DoExecute { get; set; } = false;

        public FM02030()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM02030_Load(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                SetCmdNendo();
                SetCmdGouID();
                SetcmbKyoukaID();

                rdbJuku.Checked = true;

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

        private void FM02030_Shown(object sender, EventArgs e)
        {
            txtGroupKaijyou.Focus();
        }

        private void FM02030_FormClosing(object sender, FormClosingEventArgs e)
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

        private void rdbJuku_CheckedChanged(object sender, EventArgs e)
        {
            lblGroupKaijyou.Text = "会場コード";
            txtGroupKaijyou.Text = "";
            txtGroupKaijyouName.Text = "";
        }

        private void rdbGakou_CheckedChanged(object sender, EventArgs e)
        {
            lblGroupKaijyou.Text = "団体コード";
            txtGroupKaijyou.Text = "";
            txtGroupKaijyouName.Text = "";
        }

        private void txtGroupKaijyou_Leave(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            if (txtGroupKaijyou.TextLength != 0)
            {
                if (this.rdbJuku.Checked)
                {
                    txtGroupKaijyouName.Text = GetKaijyouName();
                }
                else
                {
                    txtGroupKaijyouName.Text = GetGroupName();
                }
            }
        }

        /// <summary>
        /// 「団体コード」名称を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private string GetGroupName()
        {
            string results = null;

            string SQLSTMT = SQL.GET_NAME.GET_GROUPID_NAME;
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@group_id", Convert.ToInt32(txtGroupKaijyou.Text));
            DataTable dt = Tables1.GetSelectRowsDataTable(SQLSTMT);
            if (dt != null)
            {
                if (dt.Rows.Count >= 1)
                {
                    results = dt.Rows[0]["name"] as string;
                }
            }
            return results;
        }

        /// <summary>
        /// 「会場コード」名称を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private string GetKaijyouName()
        {
            string results = null;

            string SQLSTMT = SQL.GET_NAME.GET_KAIJYOUID_NAME;
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kaijyou_id", Convert.ToInt32(txtGroupKaijyou.Text));
            DataTable dt = Tables1.GetSelectRowsDataTable(SQLSTMT);
            if (dt != null)
            {
                if (dt.Rows.Count >= 1)
                {
                    results = dt.Rows[0]["kaijyou_name"] as string;
                }
            }
            return results;
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
        }

        private void grpShoriJoken_Leave(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {

                if (txtGroupKaijyouName.Text.Length != 0
                    && cmbNendo.SelectedIndex >= 0
                    && cmbGouID.Text.Length != 0 && cmbKyoukaID.SelectedIndex >= 1 && cmbRyouiki.SelectedIndex >= 1)
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
        /// 「年度」候補を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private void SetCmdNendo()
        {
            int nendo = Common.GetNendo();
            cmbNendo.Items.Clear();
            cmbNendo.Items.Add(nendo - 1);
            cmbNendo.Items.Add(nendo);
            cmbNendo.Items.Add(nendo + 1);
            cmbNendo.SelectedIndex = 1;
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

            if (txtGroupKaijyouName.Text.Length == 0
                || cmbGouID.Text.Length == 0 || cmbKyoukaID.SelectedIndex <= 0 || cmbRyouiki.SelectedIndex <= 0)
            {
                string[] embedArray = new string[1] { "号数・教科・領域選択" };
                Messages1.ShowMessage("MS01010", embedArray);
                cmbGouID.Focus();
                return;
            }

            try
            {
                Global.RETENTION.GOU_ID = cmbGouID.Text;
                Global.RETENTION.KYOUKA_ID = cmbKyoukaID.SelectedValue.ToString();
                Global.RETENTION.SENTAKU_ID = cmbRyouiki.Text;
                Global.RETENTION.NENDO = cmbNendo.Text;
                Global.RETENTION.GROUPKAIJYOU_ID = txtGroupKaijyou.Text;

                // 「設問別データ」の取得
                // 「マーク紐付けデータ」の取得
                // 「マーク模範データ」の取得
                DataTable dt1 = GetSetumonbetuData();
                DataTable dt2 = GetMarkLinkData();
                DataTable dt3 = GetMarkMohanData();
                if (dt1.Rows.Count == 0 || dt2.Rows.Count == 0 || dt3.Rows.Count == 0)
                {
                    string[] embedArray = new string[1] { "「設問別データ」「紐付けデータ」もしくは「模範解答データ」が登録されていません。" };
                    Messages1.ShowMessage("MS80040", embedArray);
                    cmbGouID.Focus();
                    return;
                }
                Global.RETENTION.T36D = dt1;
                Global.RETENTION.T302D = dt2;
                Global.RETENTION.T303D = dt3;

                // 登録済み「解答データ」の取得
                DataTable retrieved = GetRetrievedList();
                if (retrieved.Rows.Count == 0)
                {
                    string[] embedArray = new string[1] { "解答データ" };
                    Messages1.ShowMessage("MS05020", embedArray);
                    cmbGouID.Focus();
                    return;
                }
                Global.RETENTION.T304D = retrieved;

                // Worker Start
                AddMessages("「自動採点実施」を開始しました。");
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = retrieved.Rows.Count;
                backgroundWorker1.RunWorkerAsync(retrieved.Rows.Count);

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

        /// <summary>
        /// 「設問別データ」の取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private DataTable GetSetumonbetuData()
        {
            string SQLSTMT = SQL.RELATED_T36D.SELECT_T36D_SAITEN;
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@ryouiki_sentaku_id", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));
            DataTable results = Tables1.GetSelectRowsDataTable(SQLSTMT);
            return results;
        }

        /// <summary>
        /// 「マーク紐付けデータ」の取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private DataTable GetMarkLinkData()
        {
            string SQLSTMT = SQL.RELATED_T302D.SELECT_T302D_SAITEN;
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@ryouiki_sentaku_id", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));
            DataTable results = Tables1.GetSelectRowsDataTable(SQLSTMT);
            return results;
        }

        /// <summary>
        /// 「マーク模範データ」の取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private DataTable GetMarkMohanData()
        {
            string SQLSTMT = SQL.RELATED_T303D.SELECT_T303D_SAITEN;
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@ryouiki_sentaku_id", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));
            DataTable results = Tables1.GetSelectRowsDataTable(SQLSTMT);
            return results;
        }

        /// <summary>
        /// 登録済み「解答データ」一覧を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private DataTable GetRetrievedList()
        {
            string SQLSTMT;

            if (rdbJuku.Checked)
            {
                // 塾・会場系
                SQLSTMT = SQL.RELATED_T304D.SELECT_T304D_LIST_KAIJYOU;
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kaijyou_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
            }
            else
            {
                // 学校系
                SQLSTMT = SQL.RELATED_T304D.SELECT_T304D_LIST_GROUP;
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@group_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
            }

            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@nendo", Convert.ToInt32(Global.RETENTION.NENDO));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@ryouiki_sentaku_id", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));

            DataTable dt = Tables1.GetSelectRowsDataTable(SQLSTMT);
            return dt;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            cmdCancel.Enabled = true;
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs args)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            // Get Parameter
            int untreated = (int)args.Argument;

            // Get Worker Object
            BackgroundWorker Worker = sender as BackgroundWorker;
            if (Worker == null)
            {
                throw new Exception("「Background Worker」の取得に失敗しました。");
            }

            // 生徒数分 繰返す
            int PROGRESS = 0;
            for (int ii = 0; ii < Global.RETENTION.T304D.Rows.Count; ii++)
            {
                var results = Create_PreTokuten_Data(ii, Worker, ref PROGRESS);
                if (!results)
                {
                    args.Cancel = true;
                    return;
                }
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

            string[] embedArray2 = new string[1] { "自動採点実施" };

            // Canceled
            if (e.Cancelled)
            {
                AddMessages("「自動採点実施」がキャンセルされました。");
                Messages1.ShowMessage("MS02020", embedArray2);
                Close();
                return;
            }

            // Normal Completed
            AddMessages("「自動採点実施」が完了しました。");
            Messages1.ShowMessage("MS02010", embedArray2);
        }

        /// <summary>
        /// 「自動採点実施」の実施
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private bool Create_PreTokuten_Data(int index, BackgroundWorker Worker, ref int PROGRESS)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            DataRow dtrT304D = null;

            try
            {
                PROGRESS++;

                dtrT304D = Global.RETENTION.T304D.Rows[index];
                Invoke(new delegate1(AddMessages_Thread), String.Format("「受験ID：{0000}」の自動採点を開始しました。", Convert.ToInt32(dtrT304D["juken_id"])));

                Global.RETENTION.T304D = GetMarkAnswerData(dtrT304D["juken_id"]);
                Invoke(new delegate1(AddMessages_Thread), String.Format(" >解答データの取得が完了しました。"));

                // delete
                string SQLSTMT1;

                if (rdbJuku.Checked)
                {
                    // 塾・会場系
                    SQLSTMT1 = SQL.RELATED_T155D.DELETE_T155D_KAIJYOU;
                    SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@kaijyou_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
                }
                else
                {
                    // 学校系
                    SQLSTMT1 = SQL.RELATED_T155D.DELETE_T155D_GROUP;
                    SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@group_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
                }
 
                SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
                SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@juken_id", Convert.ToInt32(dtrT304D["juken_id"]));
                SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
                SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@sentaku", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));
                bool results1 = Tables1.ExecuteModify(SQLSTMT1);
                Invoke(new delegate1(AddMessages_Thread), String.Format(" >プレ得点データの削除が完了しました。"));

                // insert
                string SQLSTMT2 = SQL.RELATED_T155D.INSERT_T155D_PARTS;
                SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
                SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@juken_id", Convert.ToInt32(dtrT304D["juken_id"]));
                SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
                SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@sentaku", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));

                // 正誤判定の実施（紐付け数分 繰返す）
                int tokuten = 0;
                StringBuilder columns = new StringBuilder();
                StringBuilder values = new StringBuilder();

                if (rdbJuku.Checked)
                {
                    // 塾・会場系
                    columns.Append(", kaijyou_id");
                }
                else
                {
                    // 学校系
                    columns.Append(", group_id");
                }
                values.Append(", " + Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));

                // 正誤設定
                for (int nn = 0; nn < Global.RETENTION.T302D.Rows.Count; nn++)
                {
                    DataRow dtrT302D = Global.RETENTION.T302D.Rows[nn];
                    int disabled = Convert.ToInt32(dtrT302D["auto_scoring_disable"]);

                    if (disabled == 0)
                    {
                        int seigo = 0;

                        int mondai_id = Convert.ToInt32(dtrT302D["mondai_id"]);
                        string field_name = Convert.ToString(dtrT302D["field_name"]);

                        DataRow[] dtrSelect1 = Global.RETENTION.T303D.Select("field_name = '" + field_name + "'");
                        DataRow[] dtrSelect2 = Global.RETENTION.T304D.Select("field_name = '" + field_name + "'");
                        if (dtrSelect1.Length == 0 || dtrSelect2.Length == 0)
                        {
                            if (dtrSelect1.Length == 0 || dtrSelect2.Length == 0)
                            {
                                Invoke(new delegate1(AddMessages_Thread), String.Format(" >模範解答と解答データ間で不整合を検出しました。"));
                                throw new Exception("模範解答と解答データ間で不整合を検出しました。");
                            }
                        }
                        else
                        {
                            seigo = dtrSelect1[0]["mark_value"].Equals(dtrSelect2[0]["mark_value"]) ? 1 : 2;
                        }
                        columns.Append(", seigo" + mondai_id);
                        values.Append(", " + seigo);

                        if (seigo == 1)
                        {
                            DataRow[] dtr = Global.RETENTION.T36D.Select("mondai_id = " + mondai_id);
                            int haiten = Convert.ToInt32(dtr[0]["haiten"]);
                            tokuten = tokuten + haiten;
                        }
                    }
                }
                SQLSTMT2 = CommonLogic1.ReplaceStatement(SQLSTMT2, "@columns_define", columns.ToString());
                SQLSTMT2 = CommonLogic1.ReplaceStatement(SQLSTMT2, "@values_define", values.ToString());

                // 設問ごとの配点の取得（設問数分 繰返す）。得点計の算出
                // すべての設問が自動採点対象で、すべて正誤判定されて場合のみ
                int auto_saiten = Global.RETENTION.T36D.Select("auto_saiten = 1").Count();
                if (Global.RETENTION.T36D.Rows.Count == auto_saiten)
                {
                    SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@tokuten", tokuten);
                }
                else
                {
                    SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@tokuten", 0);
                }

                bool results = Tables1.ExecuteModify(SQLSTMT2);
                if (!results)
                {
                    throw new Exception("テーブル登録処理で異常を検出しました。" + "(t155d_pre_tokuten)");
                }

                Invoke(new delegate1(AddMessages_Thread), String.Format("「受験ID：{0000}」の自動採点が完了しました。", Convert.ToInt32(dtrT304D["juken_id"])));

                // 進行状況の更新
                int Percents = Convert.ToInt32(((double)PROGRESS / (double)toolStripProgressBar1.Maximum) * 100);
                Worker.ReportProgress(Percents);

            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                Invoke(new delegate1(AddMessages_Thread), String.Format("「受験ID：{0000}」の自動採点に失敗しました。", Convert.ToInt32(dtrT304D["juken_id"])));
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 「解答データ」の取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private DataTable GetMarkAnswerData(object juken_id)
        {
            string SQLSTMT;

            if (rdbJuku.Checked)
            {
                // 塾・会場系
                SQLSTMT = SQL.RELATED_T304D.SELECT_T304D_LIST_KAIJYOU;
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kaijyou_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
            }
            else
            {
                // 学校系
                SQLSTMT = SQL.RELATED_T304D.SELECT_T304D_LIST_GROUP;
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@group_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
            }

            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@nendo", Convert.ToInt32(Global.RETENTION.NENDO));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@ryouiki_sentaku_id", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@juken_id", Convert.ToInt32(juken_id));

            DataTable dt = Tables1.GetSelectRowsDataTable(SQLSTMT);
            return dt;
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
