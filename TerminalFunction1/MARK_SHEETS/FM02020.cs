using System;
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
    public partial class FM02020 : BaseForm
    {
        public FM00000 PARRENT_FORM { get; set; } = null;
        public Retention RETENTION { get; set; } = null;

        public FM02020()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM02020_Load(object sender, EventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, $"{Name} {(sender as Control).Name} Load");

            rdbGakou.Checked = true;

            this.toolStripStatusLabel1.Text = "";
            this.toolStripStatusLabel2.Text = "";
            this.toolStripStatusLabel3.Text = "";
        }

        private void FM02020_FormClosing(object sender, FormClosingEventArgs e)
        {
            RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, $"{Name} {(sender as Control).Name} FormClosing");
            if (cmdExecute.Enabled == false)
            {
                e.Cancel = true;
            }
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
