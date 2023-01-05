using System;

using CommonBase;
using CommonBase.BaseForms;

namespace MARK_SHEETS
{
    public partial class FM00010 : BaseForm
    {
        public FM00010()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM00010_Load(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            txtServer.Text = Global.RETENTION.DB_DATA_SOURCE.Substring(0, 5).ToUpper() + "-" + Global.RETENTION.DB_DATA_SOURCE.Substring(5);
        }

        private void FM00010_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");
        }

        private void cmdGetMarks_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in Program.FM00000X.MdiChildren)
            {
                frm = frm_loopVariable;
                if (frm.Name.Equals("FM01010"))
                {
                    frm.Activate();
                    return;
                }
            }

            FM01010 NEWFORM = new FM01010()
            {
                MdiParent = Program.FM00000X
            };
            NEWFORM.Show();
        }

        private void cmdEntryMarkLink_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in Program.FM00000X.MdiChildren)
            {
                frm = frm_loopVariable;
                if (frm.Name.Equals("FM01030"))
                {
                    frm.Activate();
                    return;
                }
            }

            FM01030 NEWFORM = new FM01030()
            {
                MdiParent = Program.FM00000X
            };
            NEWFORM.Show();
        }

        private void cmdGetModelAnswer_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in Program.FM00000X.MdiChildren)
            {
                frm = frm_loopVariable;
                if (frm.Name.Equals("FM01050"))
                {
                    frm.Activate();
                    return;
                }
            }

            FM01050 NEWFORM = new FM01050()
            {
                MdiParent = Program.FM00000X
            };
            NEWFORM.Show();
        }

        private void cmdCheckAutoScoreing_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in Program.FM00000X.MdiChildren)
            {
                frm = frm_loopVariable;
                if (frm.Name.Equals("FM01070"))
                {
                    frm.Activate();
                    return;
                }
            }

            FM01070 NEWFORM = new FM01070()
            {
                MdiParent = Program.FM00000X
            };
            NEWFORM.Show();
        }

        private void cmdGetAnswer_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in Program.FM00000X.MdiChildren)
            {
                frm = frm_loopVariable;
                if (frm.Name.Equals("FM02010"))
                {
                    frm.Activate();
                    return;
                }
            }

            FM02010 NEWFORM = new FM02010()
            {
                MdiParent = Program.FM00000X
            };
            NEWFORM.Show();
        }

        private void cmdAutoScoreing_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in Program.FM00000X.MdiChildren)
            {
                frm = frm_loopVariable;
                if (frm.Name.Equals("FM02030"))
                {
                    frm.Activate();
                    return;
                }
            }

            FM02030 NEWFORM = new FM02030()
            {
                MdiParent = Program.FM00000X
            };
            NEWFORM.Show();
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
