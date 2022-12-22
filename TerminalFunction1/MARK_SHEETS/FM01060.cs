﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Windows.Forms;

using CommonBase;
using CommonBase.BaseForms;
using CommonBase.Alerts;
using CommonBase.XMLparser;
using CommonBase.Tables;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;

namespace MARK_SHEETS
{
    public partial class FM01060 : BaseForm
    {
        public FM00000 PARRENT_FORM { get; set; } = null;
        public Retention RETENTION { get; set; } = null;

        public FM01060()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM01060_Load(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, $"{Name} {(sender as Control).Name} Load");

            this.toolStripStatusLabel1.Text = "";
            this.toolStripStatusLabel2.Text = "";
            this.toolStripStatusLabel3.Text = "";
            this.toolStripStatusLabel4.Text = "";
            this.toolStripStatusLabel5.Text = "";
        }

        private void FM01060_FormClosing(object sender, FormClosingEventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, $"{Name} {(sender as Control).Name} FormClosing");
            if (cmdExecute.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void cmbGouID_Leave(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, $"{Name} {(sender as Control).Name} Leave: |{(sender as ComboBox).Text}|");
            int indexs = cmbGouID.FindStringExact(cmbGouID.Text);
            if (indexs >= 1)
            {
                cmbGouID.SelectedIndex = indexs;
            }
            if (cmbGouID.SelectedIndex >= 0 || !String.IsNullOrEmpty(cmbGouID.Text))
            {
                txtGouIDName.Text = GetGouIDName();
            }
            else
            {
                txtGouIDName.Text = "";
            }
        }

        /// <summary>
        /// 「号数」名称を取得
        /// </summary>
        /// <param name></param>
        /// <returns></returns>
        private string GetGouIDName()
        {
            var result = Tables1.ExecuteSql(conn =>
            {
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = SQL.GET_NAME.GET_GOUID_NAME;
                    command.Parameters.Add(new SqlParameter("@GOU_ID", cmbGouID.Text));
                    using (var reader = command.ExecuteReader())
                    {
                        string names = null;
                        if (reader.Read())
                        {
                            names = reader["test_name"] as string;
                        }
                        return names;
                    }
                }
            });
            return result;
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
