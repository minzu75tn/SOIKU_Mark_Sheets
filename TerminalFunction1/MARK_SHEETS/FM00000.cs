using System;

using CommonBase;
using CommonBase.BaseForms;
using CommonBase.Alerts;

namespace MARK_SHEETS
{
    public partial class FM00000 : BaseForm
    {
        private bool bolFinish;

        public FM00000()
        {
            base.InitializeComponent();
            InitializeComponent();
        }

        private void FM00000_Load(object sender, EventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            this.Width = 1050;
            this.Height = 600;

            tsmMenu4_sub1.Checked = true;

            this.toolStripStatusLabel1.Text = "v1.0";
            this.toolStripStatusLabel2.Text = "2022/10/15 15:22";
            this.toolStripStatusLabel3.Text = "";
            this.toolStripStatusLabel4.Text = "";
            this.toolStripStatusLabel5.Text = "";

            this.timer1.Interval = 500;
            this.timer1.Enabled = true;
            this.timer1.Start();

            tsmMenu1_sub1.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!bolFinish)
            {
                DateTime dtNow = DateTime.Now;
                this.toolStripStatusLabel5.Text = dtNow.ToShortDateString() + " " + dtNow.ToShortTimeString();
                this.timer1.Interval = 5000;
            }
            this.timer1.Enabled = true;
        }

        private void FM00000_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            string[] embedArray = new string[1] { "アプリケーションを終了してよろしいですか？" };
            DialogResult confirm = Messages1.ShowMessage("MS80020", embedArray);
            if (confirm == DialogResult.Yes)
            {
                bolFinish = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FM00000_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, "");

            try
            {
                Form frm;
                foreach (Form frm_loopVariable in this.MdiChildren)
                {
                    frm = frm_loopVariable;
                    frm.Dispose();
                    frm = null;
                }
            }
            catch (Exception ex)
            {
                Global.RETENTION.LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Error, ex.ToString());
                string[] embedArray = new string[1] { ex.Message };
                Messages1.ShowMessage("MS90010", embedArray);
            }
        }

        private void FM00000_Activated(object sender, EventArgs e)
        {
            ReDrawing();
        }

        private void FM00000_Resize(object sender, EventArgs e)
        {
            ReDrawing();
        }

        private void ReDrawing()
        {
            foreach (Form frm_loopVariable in this.MdiChildren)
            {
                if (frm_loopVariable.Name == "FM00010")
                {
                    Rectangle ra = this.ClientRectangle;
                    int xx = ra.Width - frm_loopVariable.Width - 15;
                    int yy = 10;
                    frm_loopVariable.Location = new Point(xx, yy);
                    break;
                }
            }

        }

        private void tsmMenu1_sub1_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in this.MdiChildren)
            {
                frm = frm_loopVariable;
                if (frm.Name.Equals("FM00010"))
                {
                    frm.Activate();
                    ReDrawing();
                    return;
                }
            }

            FM00010 NEWFORM = new FM00010()
            {
                MdiParent = this
            };
            NEWFORM.Show();
            ReDrawing();
        }

        private void tsmMenu1_sub2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmMenu2_sub1_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in this.MdiChildren)
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
                MdiParent = this
            };
            NEWFORM.Show();
        }

        private void tsmMenu2_sub2_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in this.MdiChildren)
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
                MdiParent = this
            };
            NEWFORM.Show();
        }

        private void tsmMenu2_sub3_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in this.MdiChildren)
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
                MdiParent = this
            };
            NEWFORM.Show();
        }

        private void tsmMenu2_sub4_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in this.MdiChildren)
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
                MdiParent = this
            };
            NEWFORM.Show();
        }

        private void tsmMenu3_sub1_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in this.MdiChildren)
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
                MdiParent = this
            };
            NEWFORM.Show();
        }

        private void tsmMenu3_sub2_Click(object sender, EventArgs e)
        {
            Form frm;
            // For Each frm In FM00000X.MdiChildren
            foreach (Form frm_loopVariable in this.MdiChildren)
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
                MdiParent = this
            };
            NEWFORM.Show();
        }

        private void tsmMenu4_sub1_Click(object sender, EventArgs e)
        {
            this.statusStrip1.Visible = tsmMenu4_sub1.Checked ? true : false;
        }

    }
}
