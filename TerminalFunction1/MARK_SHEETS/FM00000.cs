using System;
using System.Windows.Forms;

using CommonBase;
using CommonBase.BaseForms;

namespace MARK_SHEETS
{
    public partial class FM00000 : BaseForm
    {
        public FM00000()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM00000_Load(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            txtServer.Text = Global.RETENTION.DB_DATA_SOURCE.Substring(0, 5).ToUpper() + "-" + Global.RETENTION.DB_DATA_SOURCE.Substring(5);
            tsmMenu3_sub1.Checked = true;

            this.toolStripStatusLabel1.Text = "v1.0";
            this.toolStripStatusLabel2.Text = "2022/10/15 15:22";
            this.toolStripStatusLabel3.Text = "";
            this.toolStripStatusLabel4.Text = "";
            this.toolStripStatusLabel5.Text = "";
        }

        private void FM00000_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");
            if (cmdGetMarks.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tsmMenu1_sub1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmMenu3_sub1_Click(object sender, EventArgs e)
        {
            this.statusStrip1.Visible = tsmMenu3_sub1.Checked ? true : false;
        }

        private void cmdGetMarks_Click(object sender, EventArgs e)
        {
            FM01010 LOWER = new FM01010();
            LOWER.PARRENT_FORM = this;
            LOWER.ShowDialog();
        }

        private void cmdEntryMarkLink_Click(object sender, EventArgs e)
        {
            FM01030 LOWER = new FM01030();
            LOWER.PARRENT_FORM = this;
            LOWER.ShowDialog();
        }

        private void cmdGetModelAnswer_Click(object sender, EventArgs e)
        {
            FM01040 LOWER = new FM01040();
            LOWER.PARRENT_FORM = this;
            LOWER.ShowDialog();
        }

        private void cmdCheckAutoScoreing_Click(object sender, EventArgs e)
        {
            FM01060 LOWER = new FM01060();
            LOWER.PARRENT_FORM = this;
            LOWER.ShowDialog();
        }

        private void cmdGetAnswer_Click(object sender, EventArgs e)
        {
            FM02010 LOWER = new FM02010();
            LOWER.PARRENT_FORM = this;
            LOWER.ShowDialog();
        }

        private void cmdAutoScoreing_Click(object sender, EventArgs e)
        {
            FM02020 LOWER = new FM02020();
            LOWER.PARRENT_FORM = this;
            LOWER.ShowDialog();
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
