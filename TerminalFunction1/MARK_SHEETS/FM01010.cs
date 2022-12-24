using System;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Configuration;
using System.Collections;

using CommonBase;
using CommonBase.BaseForms;
using CommonBase.Alerts;
using CommonBase.Commons;
using CommonBase.CsvFiles;
using CommonBase.Tables;
using NPOI.HPSF;
using NPOI.Util;

namespace MARK_SHEETS
{
    public partial class FM01010 : BaseForm
    {
        public FM00000 PARRENT_FORM { get; set; } = null;
        public Retention RETENTION { get; set; } = null;

        private bool DoClose { get; set; } = false;
        private bool DoExecute { get; set; } = false;

        public FM01010()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM01010_Load(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

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
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void FM01010_Shown(object sender, EventArgs e)
        {
            cmbGouID.Focus();
        }

        private void FM01010_FormClosing(object sender, FormClosingEventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");
            if (DoExecute)
            {
                e.Cancel = true;
            }
            DoClose = true;

            // Processing Results
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "List Messages.", "started.");
            for (int ii = 0; ii < lstMessages.Items.Count; ii++)
            {
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "List Messages.", lstMessages.Items[ii]);
            }
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "List Messages.", "ended.");
        }

        private void cmbGouID_Leave(object sender, EventArgs e)
        {
            if (DoClose) return;

            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, cmbGouID.Text);

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
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void cmbGouID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoClose) return;

            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, cmbGouID.Text);

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
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void cmbKyoukaID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoClose) return;

            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, cmbKyoukaID.Text);
            cmbRyouiki.DataSource = null;
        }

        private void pnlGouKyouka_Leave(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                if (cmbGouID.SelectedIndex >= 1 && cmbKyoukaID.SelectedIndex >= 1)
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
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void pnlGouKyoukaSentaku_Leave(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                if (cmbGouID.SelectedIndex >= 1 && cmbKyoukaID.SelectedIndex >= 1 && cmbRyouiki.SelectedIndex >= 1)
                {
                    cmdExecute.Enabled = true;
                    DoExecute = !cmdExecute.Enabled;
                }
            }
            catch (Exception ex)
            {
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
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
            string SQLSTMT = SQL.GET_LIST.GET_GOUID_LIST;
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
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            if (cmbGouID.SelectedIndex <= 0 || cmbKyoukaID.SelectedIndex <= 0 || cmbRyouiki.SelectedIndex <= 0)
            {
                string[] embedArray = new string[1] { "号数・教科・領域選択" };
                Messages1.ShowMessage("MS01010", embedArray);
                cmbGouID.Focus();
                return;
            }

            try
            {
                RETENTION.GOU_ID = cmbGouID.Text;
                RETENTION.KYOUKA_ID = cmbKyoukaID.SelectedValue.ToString();
                RETENTION.SENTAKU_ID = cmbRyouiki.Text;

                // file

                DateTime dtNow = DateTime.Now;
                string drives = ConfigurationManager.AppSettings[ConstantCommon.CONFIG_SERVER_DRIVE];
                string filePath = drives + Constant.MARKS_DESIGN_FOLDER;
                string filename = $"{Constant.MARKS_LOCATE_FILE}_{RETENTION.GOU_ID}_{RETENTION.KYOUKA_ID}-{RETENTION.SENTAKU_ID}_{dtNow.ToString("yyyyMMdd")}{Constant.FILE_EXTENTION_CSV}";
                string fullPath = "";

                openFileDialog1.Title = "ファイルの選択";
                openFileDialog1.InitialDirectory = filePath;
                openFileDialog1.FileName = filename;
                openFileDialog1.Filter = "CSVファイル(*.csv;*.csv)|*.*";
                openFileDialog1.FilterIndex = 1;
                DialogResult results = openFileDialog1.ShowDialog();
                if (results == DialogResult.OK)
                {
                    // fullPath = drives + Constant.MARKS_DESIGN_FOLDER + @"\" + openFileDialog1.FileName;
                    fullPath = openFileDialog1.FileName;
                }
                else
                {
                    cmdExecute.Focus();
                    return;
                }

                if (!CommonLogic1.ExistsFile(fullPath))
                {
                    string[] embedArray = new string[1] { Path.GetFileName(fullPath) };
                    Messages1.ShowMessage("MS05020", embedArray);
                    cmbGouID.Focus();
                    return;
                }

                // Get Line Count
                var lineCount = File.ReadLines(fullPath).Count();

                // Worker Start
                AddMessages("「マーク位置情報取込み」を開始しました。");
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = lineCount;
                backgroundWorker1.RunWorkerAsync(fullPath);

                cmdExecute.Enabled = false;
                cmdCancel.Enabled = true;
                DoExecute = !cmdExecute.Enabled;
            }
            catch (Exception ex)
            {
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            cmdCancel.Enabled = true;
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs args)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            // Get Parameter
            string filePath = (string)args.Argument;

            // Get Worker Object
            BackgroundWorker Worker = sender as BackgroundWorker;
            if (Worker == null)
            {
                throw new Exception("「Background Worker」の取得に失敗しました。");
            }

            var results = Insert_mark_locate_data(filePath, Worker);
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
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            cmdCancel.Enabled = false;
            DoExecute = false;

            // On Error or Cancel
            if (e.Error != null)
            {
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, e.Error.ToString());
                string[] embedArray1 = new string[1] { e.Error.ToString() };
                Messages1.ShowMessage("MS90010", embedArray1);
                return;
            }

            string[] embedArray2 = new string[1] { "マーク位置情報取込み" };

            // Canceled
            if (e.Cancelled)
            {
                AddMessages("「マーク位置情報取込み」がキャンセルされました。");
                Messages1.ShowMessage("MS02020", embedArray2);
                Close();
                return;
            }

            // Normal Completed
            AddMessages("「マーク位置情報取込み」が完了しました。");
            Messages1.ShowMessage("MS02010", embedArray2);
        }

        /// <summary>
        /// 「マーク位置情報取込み」の実施
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private bool Insert_mark_locate_data(string filePath, BackgroundWorker Worker)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                Invoke(new delegate1(AddMessages_Thread), String.Format("[{0}]の取込みを開始しました。", Path.GetFileName(filePath)));

                // delete
                string SQLSTMT = SQL.RELATED_T301D.DELETE_T301D;
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(RETENTION.GOU_ID));
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(RETENTION.KYOUKA_ID));
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@ryouiki_sentaku_id", Convert.ToInt32(RETENTION.SENTAKU_ID));
                bool deleted = Tables1.ExecuteDelete(SQLSTMT);

                // insert
                string results = null;
                ArrayList arrayList = CsvFile1.Csv2Hash(filePath, true, ref results);

                ArrayList SQLARRAY = new ArrayList();
                for (int ii = 0; ii < arrayList.Count; ii++)
                {
                    Hashtable hash = (Hashtable)arrayList[ii];

                    string SQLSTMT2 = SQL.RELATED_T301D.INSERT_T301D;
                    SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@gou_id", Convert.ToInt32(RETENTION.GOU_ID));
                    SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@kyouka_id", Convert.ToInt32(RETENTION.KYOUKA_ID));
                    SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@ryouiki_sentaku_id", Convert.ToInt32(RETENTION.SENTAKU_ID));
                    SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@field_id", Convert.ToInt32(hash["field_id"]));
                    SQLSTMT2 = CommonLogic1.ReplaceStatementString(SQLSTMT2, "@field_name", Convert.ToString(hash["field_name"]));
                    SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@number_of_marks", Convert.ToInt32(hash["number_of_marks"]));
                    SQLSTMT2 = CommonLogic1.ReplaceStatementString(SQLSTMT2, "@mark_default_value", Convert.ToString(hash["mark_default_value"]));
                    SQLARRAY.Add(SQLSTMT2);
                }
                bool results2 = Tables1.ExecuteModifyMultiple(SQLARRAY);
                if (!results2)
                {
                    throw new Exception("テーブル登録処理で異常を検出しました。" + "(301d_mark_locate_data)");
                }

                Invoke(new delegate1(AddMessages_Thread), String.Format("[{0}]の取込みが完了しました。", Path.GetFileName(filePath)));

                // 進行状況の更新
                // int PROGRESS = 0;
                // int Percents = Convert.ToInt32(((double)PROGRESS / (double)toolStripProgressBar1.Maximum) * 100);
                // Worker.ReportProgress(Percents);

            }
            catch (Exception ex)
            {
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                Invoke(new delegate1(AddMessages_Thread), String.Format("[{0}]の取込みに失敗しました。", Path.GetFileName(filePath)));
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
