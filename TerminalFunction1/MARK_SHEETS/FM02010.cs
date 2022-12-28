using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

using CommonBase;
using CommonBase.BaseForms;
using CommonBase.Alerts;
using CommonBase.Tables;

using CommonBase.Commons;
using CommonBase.CsvFiles;
using System.Text;

namespace MARK_SHEETS
{
    public partial class FM02010 : BaseForm
    {
        public FM00000 PARRENT_FORM { get; set; } = null;

        private bool DoClose { get; set; } = false;
        private bool DoExecute { get; set; } = false;

        public FM02010()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM02010_Load(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                SetCmdNendo();
                SetCmdGouID();
                SetcmbKyoukaID();

                rdbJuku.Checked = true;
                rdbGakou.Enabled = false;

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

        private void FM02010_Shown(object sender, EventArgs e)
        {
            txtGroupKaijyou.Focus();
        }

        private void FM02010_FormClosing(object sender, FormClosingEventArgs e)
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
            string SQLSTMT = SQL.GET_LIST.GET_GOUID_LIST_JUKUKAIJYOU;
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

            DialogResult confirm = DialogResult.No;
            if (chkDifferent.Checked)
            {
                string[] embedArray = new string[1] { "処理条件を満たす、すべての解答を取込みし直します。\n実行してよろしいですか？" };
                confirm = Messages1.ShowMessage("MS80020", embedArray);
                if (confirm == DialogResult.No) return;
            }
            else
            {
                string[] embedArray = new string[1] { "処理条件を満たす、未取込みのもののみ対象とします。\n実行してよろしいですか？" };
                confirm = Messages1.ShowMessage("MS80020", embedArray);
                if (confirm == DialogResult.No) return;
            }

            try
            {
                Global.RETENTION.GOU_ID = cmbGouID.Text;
                Global.RETENTION.KYOUKA_ID = cmbKyoukaID.SelectedValue.ToString();
                Global.RETENTION.SENTAKU_ID = cmbRyouiki.Text;
                Global.RETENTION.NENDO = cmbRyouiki.Text;
                Global.RETENTION.GROUPKAIJYOU_ID = txtGroupKaijyou.Text;
                Global.RETENTION.DIFFERRENT = chkDifferent.Checked;

                // 登録済み取得
                DataTable retrieved = GetRetrievedList();

                // Folder (\号数\Marks\)
                DateTime dtNow = DateTime.Now;
                string drives = ConfigurationManager.AppSettings[ConstantCommon.CONFIG_SERVER_DRIVE];
                StringBuilder filePath = new StringBuilder();
                filePath.Append(drives);
                filePath.Append(@"\");
                filePath.Append(Convert.ToInt32(Global.RETENTION.GOU_ID).ToString("000"));
                filePath.Append(@"\");
                filePath.Append(Constant.MARKS_PRODUCT_FOLDER);

                // File   (20212019010001_2021201100000.jpg)
                StringBuilder filename = new StringBuilder();
                filename.Append(Global.RETENTION.NENDO);
                filename.Append(Convert.ToInt32(Global.RETENTION.GOU_ID).ToString("000"));
                filename.Append(Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID).ToString("000"));
                filename.Append("*");
                filename.Append("_");
                filename.Append(Global.RETENTION.NENDO);
                filename.Append(Convert.ToInt32(Global.RETENTION.GOU_ID).ToString("000"));
                filename.Append(Convert.ToInt32(Global.RETENTION.KYOUKA_ID).ToString("000"));
                filename.Append("0000");
                filename.Append(Constant.FILE_EXTENTION_CSV);

                // Get Files
                DirectoryInfo di = new DirectoryInfo(filePath.ToString());
                IEnumerable<FileInfo> patterns = di.EnumerateFiles(filename.ToString());

                // 未処理分の抽出
                ArrayList untreated = new ArrayList();
                foreach (FileInfo ff in patterns)
                {
                    Console.WriteLine(ff.Name + ", " + ff.FullName);

                    StringBuilder wheres = new StringBuilder();
                    wheres.Append("nendo=" + ff.Name.Substring(0, 4));
                    wheres.Append(" and ");
                    wheres.Append("gou_id=" + ff.Name.Substring(4, 3));
                    wheres.Append(" and ");
                    wheres.Append("kaijyou_id=" + ff.Name.Substring(7, 3));
                    wheres.Append(" and ");
                    wheres.Append("kyouka_id=" + ff.Name.Substring(22, 2));
                    wheres.Append(" and ");
                    wheres.Append("juken_id=" + ff.Name.Substring(10, 4));
                    DataRow[] dr = retrieved.Select(wheres.ToString());
                    if (dr.Length == 0)
                    {
                        untreated.Add(ff.FullName);
                    }
                }

                // Worker Start
                AddMessages("「自動採点事前チェック」を開始しました。");
                Global.RETENTION.UPTREATED = untreated;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = untreated.Count;
                backgroundWorker1.RunWorkerAsync(untreated.Count);

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
        /// 登録済み「解答データ」一覧を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private DataTable GetRetrievedList()
        {
            string SQLSTMT = SQL.RELATED_T304D.SELECT_T304D_LIST;
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@nendo", Convert.ToInt32(Global.RETENTION.NENDO));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
            SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kaijyou_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
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

            var results = Insert_mark_answer_data(Global.RETENTION.UPTREATED, Worker);
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
        /// 「解答データ取込み」の実施
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private bool Insert_mark_answer_data(ArrayList untreated, BackgroundWorker Worker)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            int PROGRESS = 0;
            string fullpath = null;

            try
            {

                for (int nn = 0; nn < untreated.Count; nn++)
                {
                    PROGRESS++;
                    fullpath = Convert.ToString(untreated[nn]);
                    Invoke(new delegate1(AddMessages_Thread), String.Format("[{0}]の取込みを開始しました。", Path.GetFileName(fullpath)));

                    // delete
                    if (Global.RETENTION.DIFFERRENT)
                    {
                        string SQLSTMT = SQL.RELATED_T304D.DELETE_T304D_KAIJYOU;
                        SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@nendo", Convert.ToInt32(Global.RETENTION.NENDO));
                        SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
                        SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kaijyou_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
                        SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@juken_id", Convert.ToInt32((Path.GetFileName(fullpath)).Substring(10, 4)));
                        SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
                        SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@ryouiki_sentaku_id", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));
                        bool deleted = Tables1.ExecuteDelete(SQLSTMT);
                    }

                    // insert
                    string results = null;
                    ArrayList arrayList = CsvFile1.Csv2Hash(fullpath, true, ref results);

                    ArrayList SQLARRAY = new ArrayList();
                    for (int ii = 0; ii < arrayList.Count; ii++)
                    {
                        Hashtable hash = (Hashtable)arrayList[ii];

                        string SQLSTMT2 = SQL.RELATED_T304D.INSERT_T304D_KAIJYOU;
                        SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@nendo", Convert.ToInt32(Global.RETENTION.NENDO));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@gou_id", Convert.ToInt32(Global.RETENTION.GOU_ID));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@kaijyou_id", Convert.ToInt32(Global.RETENTION.GROUPKAIJYOU_ID));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@juken_id", Convert.ToInt32((Path.GetFileName(fullpath)).Substring(10, 4)));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@kyouka_id", Convert.ToInt32(Global.RETENTION.KYOUKA_ID));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@ryouiki_sentaku_id", Convert.ToInt32(Global.RETENTION.SENTAKU_ID));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@field_id", Convert.ToInt32(hash["field_id"]));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementString(SQLSTMT2, "@field_name", Convert.ToString(hash["field_name"]));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementString(SQLSTMT2, "@mark_value", Convert.ToString(hash["mark_value"]));
                        SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@status", Convert.ToInt32(hash["status"]));
                        SQLARRAY.Add(SQLSTMT2);
                    }
                    bool results2 = Tables1.ExecuteModifyMultiple(SQLARRAY);
                    if (!results2)
                    {
                        throw new Exception("テーブル登録処理で異常を検出しました。" + "(t304d_mark_answer_data)");
                    }

                    Invoke(new delegate1(AddMessages_Thread), String.Format("[{0}]の取込みが完了しました。", Path.GetFileName(fullpath)));

                    // 進行状況の更新
                    int Percents = Convert.ToInt32(((double)PROGRESS / (double)toolStripProgressBar1.Maximum) * 100);
                    Worker.ReportProgress(Percents);
                }
            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                Invoke(new delegate1(AddMessages_Thread), String.Format("[{0}]の取込みに失敗しました。", Path.GetFileName(fullpath)));
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
                return false;
            }
            return true;
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
