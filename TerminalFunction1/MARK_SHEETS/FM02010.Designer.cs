
namespace MARK_SHEETS
{
    partial class FM02010
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private new void InitializeComponent()
        {
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtGroupKaijyouName = new System.Windows.Forms.TextBox();
            this.grpShoriJoken = new System.Windows.Forms.GroupBox();
            this.pnlGouKyoukaSentaku = new System.Windows.Forms.Panel();
            this.cmbNendo = new System.Windows.Forms.ComboBox();
            this.pnlGouKyouka = new System.Windows.Forms.Panel();
            this.cmbKyoukaID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGouIDName = new System.Windows.Forms.TextBox();
            this.cmbGouID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRyouiki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbGakou = new System.Windows.Forms.RadioButton();
            this.rdbJuku = new System.Windows.Forms.RadioButton();
            this.txtGroupKaijyou = new System.Windows.Forms.TextBox();
            this.lblGroupKaijyou = new System.Windows.Forms.Label();
            this.chkDifferent = new System.Windows.Forms.CheckBox();
            this.cmdExecute = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.grpShoriJoken.SuspendLayout();
            this.pnlGouKyoukaSentaku.SuspendLayout();
            this.pnlGouKyouka.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMessages
            // 
            this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessages.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.Location = new System.Drawing.Point(12, 166);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(4);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(874, 225);
            this.lstMessages.TabIndex = 2;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdCancel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCancel.Location = new System.Drawing.Point(751, 113);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(118, 32);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.TabStop = false;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            this.cmdCancel.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdCancel.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // txtGroupKaijyouName
            // 
            this.txtGroupKaijyouName.Location = new System.Drawing.Point(456, 34);
            this.txtGroupKaijyouName.Name = "txtGroupKaijyouName";
            this.txtGroupKaijyouName.ReadOnly = true;
            this.txtGroupKaijyouName.Size = new System.Drawing.Size(223, 25);
            this.txtGroupKaijyouName.TabIndex = 3;
            this.txtGroupKaijyouName.TabStop = false;
            // 
            // grpShoriJoken
            // 
            this.grpShoriJoken.Controls.Add(this.pnlGouKyoukaSentaku);
            this.grpShoriJoken.Controls.Add(this.groupBox2);
            this.grpShoriJoken.Controls.Add(this.txtGroupKaijyouName);
            this.grpShoriJoken.Controls.Add(this.txtGroupKaijyou);
            this.grpShoriJoken.Controls.Add(this.lblGroupKaijyou);
            this.grpShoriJoken.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpShoriJoken.Location = new System.Drawing.Point(12, 7);
            this.grpShoriJoken.Name = "grpShoriJoken";
            this.grpShoriJoken.Size = new System.Drawing.Size(712, 149);
            this.grpShoriJoken.TabIndex = 1;
            this.grpShoriJoken.TabStop = false;
            this.grpShoriJoken.Text = "処理条件";
            this.grpShoriJoken.Leave += new System.EventHandler(this.grpShoriJoken_Leave);
            // 
            // pnlGouKyoukaSentaku
            // 
            this.pnlGouKyoukaSentaku.Controls.Add(this.cmbNendo);
            this.pnlGouKyoukaSentaku.Controls.Add(this.pnlGouKyouka);
            this.pnlGouKyoukaSentaku.Controls.Add(this.label4);
            this.pnlGouKyoukaSentaku.Controls.Add(this.cmbRyouiki);
            this.pnlGouKyoukaSentaku.Controls.Add(this.label2);
            this.pnlGouKyoukaSentaku.Location = new System.Drawing.Point(27, 68);
            this.pnlGouKyoukaSentaku.Name = "pnlGouKyoukaSentaku";
            this.pnlGouKyoukaSentaku.Size = new System.Drawing.Size(652, 73);
            this.pnlGouKyoukaSentaku.TabIndex = 41;
            this.pnlGouKyoukaSentaku.Leave += new System.EventHandler(this.pnlGouKyoukaSentaku_Leave);
            // 
            // cmbNendo
            // 
            this.cmbNendo.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNendo.FormattingEnabled = true;
            this.cmbNendo.Location = new System.Drawing.Point(59, 10);
            this.cmbNendo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNendo.MaxLength = 3;
            this.cmbNendo.Name = "cmbNendo";
            this.cmbNendo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbNendo.Size = new System.Drawing.Size(60, 21);
            this.cmbNendo.TabIndex = 1;
            this.cmbNendo.Enter += new System.EventHandler(this.Common_Enter);
            // 
            // pnlGouKyouka
            // 
            this.pnlGouKyouka.Controls.Add(this.cmbKyoukaID);
            this.pnlGouKyouka.Controls.Add(this.label1);
            this.pnlGouKyouka.Controls.Add(this.label3);
            this.pnlGouKyouka.Controls.Add(this.txtGouIDName);
            this.pnlGouKyouka.Controls.Add(this.cmbGouID);
            this.pnlGouKyouka.Location = new System.Drawing.Point(138, 4);
            this.pnlGouKyouka.Name = "pnlGouKyouka";
            this.pnlGouKyouka.Size = new System.Drawing.Size(331, 63);
            this.pnlGouKyouka.TabIndex = 2;
            this.pnlGouKyouka.Leave += new System.EventHandler(this.pnlGouKyouka_Leave);
            // 
            // cmbKyoukaID
            // 
            this.cmbKyoukaID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKyoukaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKyoukaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKyoukaID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKyoukaID.FormattingEnabled = true;
            this.cmbKyoukaID.Location = new System.Drawing.Point(238, 4);
            this.cmbKyoukaID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKyoukaID.MaxLength = 3;
            this.cmbKyoukaID.Name = "cmbKyoukaID";
            this.cmbKyoukaID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbKyoukaID.Size = new System.Drawing.Size(62, 21);
            this.cmbKyoukaID.TabIndex = 3;
            this.cmbKyoukaID.SelectedIndexChanged += new System.EventHandler(this.cmbKyoukaID_SelectedIndexChanged);
            this.cmbKyoukaID.Enter += new System.EventHandler(this.Common_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "教科コード :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "号 数 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGouIDName
            // 
            this.txtGouIDName.Location = new System.Drawing.Point(60, 32);
            this.txtGouIDName.Name = "txtGouIDName";
            this.txtGouIDName.ReadOnly = true;
            this.txtGouIDName.Size = new System.Drawing.Size(252, 25);
            this.txtGouIDName.TabIndex = 4;
            this.txtGouIDName.TabStop = false;
            // 
            // cmbGouID
            // 
            this.cmbGouID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGouID.FormattingEnabled = true;
            this.cmbGouID.Location = new System.Drawing.Point(60, 4);
            this.cmbGouID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGouID.MaxLength = 3;
            this.cmbGouID.Name = "cmbGouID";
            this.cmbGouID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbGouID.Size = new System.Drawing.Size(54, 21);
            this.cmbGouID.TabIndex = 1;
            this.cmbGouID.SelectedIndexChanged += new System.EventHandler(this.cmbGouID_SelectedIndexChanged);
            this.cmbGouID.Enter += new System.EventHandler(this.Common_Enter);
            this.cmbGouID.Leave += new System.EventHandler(this.cmbGouID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(486, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "領域選択 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRyouiki
            // 
            this.cmbRyouiki.BackColor = System.Drawing.SystemColors.Window;
            this.cmbRyouiki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRyouiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRyouiki.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRyouiki.FormattingEnabled = true;
            this.cmbRyouiki.Location = new System.Drawing.Point(554, 10);
            this.cmbRyouiki.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRyouiki.MaxLength = 3;
            this.cmbRyouiki.Name = "cmbRyouiki";
            this.cmbRyouiki.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbRyouiki.Size = new System.Drawing.Size(62, 21);
            this.cmbRyouiki.TabIndex = 4;
            this.cmbRyouiki.Enter += new System.EventHandler(this.Common_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "年度 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbGakou);
            this.groupBox2.Controls.Add(this.rdbJuku);
            this.groupBox2.Location = new System.Drawing.Point(27, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "実施種別";
            // 
            // rdbGakou
            // 
            this.rdbGakou.AutoSize = true;
            this.rdbGakou.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbGakou.Location = new System.Drawing.Point(144, 16);
            this.rdbGakou.Name = "rdbGakou";
            this.rdbGakou.Size = new System.Drawing.Size(65, 21);
            this.rdbGakou.TabIndex = 0;
            this.rdbGakou.TabStop = true;
            this.rdbGakou.Text = "学校系";
            this.rdbGakou.UseVisualStyleBackColor = true;
            // 
            // rdbJuku
            // 
            this.rdbJuku.AutoSize = true;
            this.rdbJuku.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbJuku.Location = new System.Drawing.Point(34, 16);
            this.rdbJuku.Name = "rdbJuku";
            this.rdbJuku.Size = new System.Drawing.Size(85, 21);
            this.rdbJuku.TabIndex = 1;
            this.rdbJuku.TabStop = true;
            this.rdbJuku.Text = "塾・会場系";
            this.rdbJuku.UseVisualStyleBackColor = true;
            this.rdbJuku.CheckedChanged += new System.EventHandler(this.rdbJuku_CheckedChanged);
            // 
            // txtGroupKaijyou
            // 
            this.txtGroupKaijyou.Location = new System.Drawing.Point(371, 34);
            this.txtGroupKaijyou.Name = "txtGroupKaijyou";
            this.txtGroupKaijyou.Size = new System.Drawing.Size(71, 25);
            this.txtGroupKaijyou.TabIndex = 2;
            this.txtGroupKaijyou.Enter += new System.EventHandler(this.Common_Enter);
            this.txtGroupKaijyou.Leave += new System.EventHandler(this.txtGroupKaijyou_Leave);
            // 
            // lblGroupKaijyou
            // 
            this.lblGroupKaijyou.AutoSize = true;
            this.lblGroupKaijyou.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGroupKaijyou.Location = new System.Drawing.Point(299, 38);
            this.lblGroupKaijyou.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupKaijyou.Name = "lblGroupKaijyou";
            this.lblGroupKaijyou.Size = new System.Drawing.Size(73, 13);
            this.lblGroupKaijyou.TabIndex = 1;
            this.lblGroupKaijyou.Text = "会場・団体 :";
            this.lblGroupKaijyou.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkDifferent
            // 
            this.chkDifferent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDifferent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDifferent.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.chkDifferent.Location = new System.Drawing.Point(735, 52);
            this.chkDifferent.Name = "chkDifferent";
            this.chkDifferent.Size = new System.Drawing.Size(149, 53);
            this.chkDifferent.TabIndex = 4;
            this.chkDifferent.TabStop = false;
            this.chkDifferent.Text = "処理条件を満たすものすべて再取込み";
            this.chkDifferent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDifferent.UseVisualStyleBackColor = true;
            // 
            // cmdExecute
            // 
            this.cmdExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdExecute.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdExecute.Location = new System.Drawing.Point(751, 27);
            this.cmdExecute.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(118, 32);
            this.cmdExecute.TabIndex = 3;
            this.cmdExecute.TabStop = false;
            this.cmdExecute.Text = "実 行";
            this.cmdExecute.UseVisualStyleBackColor = false;
            this.cmdExecute.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
            this.cmdExecute.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdExecute.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(355, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(350, 16);
            // 
            // FM02010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdExecute);
            this.Controls.Add(this.grpShoriJoken);
            this.Controls.Add(this.chkDifferent);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.lstMessages);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(915, 1000);
            this.MinimumSize = new System.Drawing.Size(915, 468);
            this.Name = "FM02010";
            this.Text = "解答データ取込み";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM02010_FormClosing);
            this.Load += new System.EventHandler(this.FM02010_Load);
            this.Shown += new System.EventHandler(this.FM02010_Shown);
            this.grpShoriJoken.ResumeLayout(false);
            this.grpShoriJoken.PerformLayout();
            this.pnlGouKyoukaSentaku.ResumeLayout(false);
            this.pnlGouKyoukaSentaku.PerformLayout();
            this.pnlGouKyouka.ResumeLayout(false);
            this.pnlGouKyouka.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ListBox lstMessages;
        private Button cmdCancel;
        private TextBox txtGroupKaijyouName;
        private GroupBox grpShoriJoken;
        private Button cmdExecute;
        private TextBox txtGroupKaijyou;
        private Label lblGroupKaijyou;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rdbGakou;
        private RadioButton rdbJuku;
        private CheckBox chkDifferent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlGouKyoukaSentaku;
        private Panel pnlGouKyouka;
        private ComboBox cmbKyoukaID;
        private Label label1;
        private Label label3;
        private TextBox txtGouIDName;
        private ComboBox cmbGouID;
        private Label label4;
        private ComboBox cmbRyouiki;
        private ComboBox cmbNendo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}

