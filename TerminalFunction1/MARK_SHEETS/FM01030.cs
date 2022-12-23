using System;
using System.Text;
using System.Data;
using System.Windows.Forms;

using CommonBase;
using CommonBase.BaseForms;
using CommonBase.Alerts;
using CommonBase.Commons;
using CommonBase.Tables;


namespace MARK_SHEETS
{
    public partial class FM01030 : BaseForm
    {
        public FM00000 PARRENT_FORM { get; set; } = null;
        public Retention RETENTION { get; set; } = null;

        private bool DoClose { get; set; } = false;
        private bool DoChange { get; set; } = false;

        public FM01030()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM01030_Load(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                SetCmdGouID();
                SetcmbKyoukaID();

                cmdQuery.Enabled = false;
                cmdCancel.Enabled = true;
                cmdExecute.Enabled = false;

                cmdLink.Enabled = false;
                cmdUnLink.Enabled = false;
                cmdVagueLink.Enabled = false;

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

        private void FM01030_Shown(object sender, EventArgs e)
        {
            cmbGouID.Focus();
        }

        private void FM01030_FormClosing(object sender, FormClosingEventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");
            if (DoChange)
            {
                DialogResult results = Messages1.ShowMessage("MS04010");
                if (results != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
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
                    cmdQuery.Enabled = true;
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

        private void cmdQuery_Click(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                (dgvT36D.DataSource as DataTable)?.Clear();
                (dgvT301D.DataSource as DataTable)?.Clear();
                (dgvT302D.DataSource as DataTable)?.Clear();

                string SQLSTMT1 = SQL.RELATED_T36D.SELECT_T36D_FM01030;
                SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@gou_id", Convert.ToInt32(cmbGouID.Text));
                SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@kyouka_id", Convert.ToInt32(cmbKyoukaID.SelectedValue));
                SQLSTMT1 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT1, "@ryouiki_sentaku_id", Convert.ToInt32(cmbRyouiki.Text));
                dgvT36D.DataSource = Tables1.GetSelectRowsDataTable(SQLSTMT1);

                string SQLSTMT2 = SQL.RELATED_T301D.SELECT_T301D_FM01030;
                SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@gou_id", Convert.ToInt32(cmbGouID.Text));
                SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@kyouka_id", Convert.ToInt32(cmbKyoukaID.SelectedValue));
                SQLSTMT2 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT2, "@ryouiki_sentaku_id", Convert.ToInt32(cmbRyouiki.Text));
                dgvT301D.DataSource = Tables1.GetSelectRowsDataTable(SQLSTMT2);

                string SQLSTMT3 = SQL.RELATED_T302D.SELECT_T302D_FM01030;
                SQLSTMT3 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT3, "@gou_id", Convert.ToInt32(cmbGouID.Text));
                SQLSTMT3 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT3, "@kyouka_id", Convert.ToInt32(cmbKyoukaID.SelectedValue));
                SQLSTMT3 = CommonLogic1.ReplaceStatementNumeric(SQLSTMT3, "@ryouiki_sentaku_id", Convert.ToInt32(cmbRyouiki.Text));
                DataTable dt = Tables1.GetSelectRowsDataTable(SQLSTMT3);
                if (dt.Rows.Count >= 1)
                {
                    dgvT302D.DataSource = dt;
                }
                else
                {
                    Create_mark_link_data();
                    dgvT302D.DataSource = Tables1.GetSelectRowsDataTable(SQLSTMT3);
                }

                cmdLink.Enabled = true;
                cmdUnLink.Enabled = true;
                cmdVagueLink.Enabled = true;
            }
            catch (Exception ex)
            {
                RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        /// <summary>
        /// 「マーク紐付けデータ」の作成
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private void Create_mark_link_data()
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                string SQLSTMT = SQL.RELATED_T302D.INSERT_T302D_FROM_T301D;
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@gou_id", Convert.ToInt32(cmbGouID.Text));
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@kyouka_id", Convert.ToInt32(cmbKyoukaID.SelectedValue));
                SQLSTMT = CommonLogic1.ReplaceStatementNumeric(SQLSTMT, "@ryouiki_sentaku_id", Convert.ToInt32(cmbRyouiki.Text));
                bool results = Tables1.ExecuteModify(SQLSTMT);
                if (!results)
                {
                    throw new Exception("テーブル登録処理で異常を検出しました。" + "(t302d_mark_link_data)");
                }
            }
            catch (Exception ex)
            {
                throw; 
            }
            return;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            cmbGouID.SelectedIndex = 0;
            txtGouIDName.Text = "";
            cmbKyoukaID.SelectedIndex = 0;
            cmbRyouiki.DataSource = null;

            (dgvT36D.DataSource as DataTable)?.Clear();
            (dgvT301D.DataSource as DataTable)?.Clear();
            (dgvT302D.DataSource as DataTable)?.Clear();

            cmdQuery.Enabled = false;
            cmdExecute.Enabled = false;

            cmdLink.Enabled = false;
            cmdUnLink.Enabled = false;
            cmdVagueLink.Enabled = false;
        }

        private void cmdExecute_Click(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

        }

        private void cmdLink_Click(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            if (dgvT36D.SelectedRows.Count >= 1 && dgvT301D.SelectedRows.Count >= 1)
            {
                DataGridViewRow selected1 = dgvT36D.SelectedRows[0];
                DataGridViewRow selected2 = dgvT301D.SelectedRows[0];

                if (!Convert.ToString(Convert.ToString(selected2.Cells[1].Value)).Equals("1"))
                {
                    string[] embedArray = new string[1] { "マーク採点の設問じゃない" };
                    Messages1.ShowMessage("MS01020", embedArray);
                }
                int mondai_id = Convert.ToInt32( selected1.Cells[1].Value);
                string field_id = Convert.ToString(selected2.Cells[1].Value);

                for (int ii = 0; ii < dgvT302D.Rows.Count; ii++)
                {
                    if (Convert.ToString(dgvT302D[1, ii].Value).Equals(field_id))
                    {
                        dgvT302D.Rows[ii].Cells["t302d_mondai_id"].Value = mondai_id;
                        dgvT302D.Rows[ii].Cells["t302d_mondai_sub_no"].Value = 0;
                        DoChange = true;
                        break;
                    }
                }
            }
            else
            {
                string[] embedArray = new string[1] { "候補が選択されていない" };
                Messages1.ShowMessage("MS01020", embedArray);
                if (dgvT36D.SelectedRows.Count >= 1)
                {
                    dgvT301D.Focus();
                }
                else
                {
                    dgvT36D.Focus();
                }
            }
        }

        private void cmdUnLink_Click(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            if (dgvT302D.SelectedRows.Count >= 1)
            {
                DataGridViewRow selected = dgvT302D.SelectedRows[0];
                selected.Cells["t302d_mondai_id"].Value = "";
                selected.Cells["t302d_mondai_sub_no"].Value = "";
                selected.Cells["t302d_auto_scoring_disable"].Value = "";
            }
            else
            {
                string[] embedArray = new string[1] { "候補が選択されていない" };
                Messages1.ShowMessage("MS01020", embedArray);
                dgvT302D.Focus();
            }
        }

        private void cmdVagueLink_Click(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

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
