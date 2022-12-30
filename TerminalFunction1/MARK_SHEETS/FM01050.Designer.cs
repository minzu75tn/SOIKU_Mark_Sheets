
namespace MARK_SHEETS
{
    partial class FM01050
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbKyoukaID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRyouiki = new System.Windows.Forms.ComboBox();
            this.txtGouIDName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlGouKyouka = new System.Windows.Forms.Panel();
            this.cmbGouID = new System.Windows.Forms.ComboBox();
            this.pnlGouKyoukaSentaku = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.cmdExecute = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.pnlGouKyouka.SuspendLayout();
            this.pnlGouKyoukaSentaku.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(350, 16);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(539, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cmbKyoukaID
            // 
            this.cmbKyoukaID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKyoukaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKyoukaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKyoukaID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKyoukaID.FormattingEnabled = true;
            this.cmbKyoukaID.Location = new System.Drawing.Point(254, 6);
            this.cmbKyoukaID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKyoukaID.MaxLength = 3;
            this.cmbKyoukaID.Name = "cmbKyoukaID";
            this.cmbKyoukaID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbKyoukaID.Size = new System.Drawing.Size(62, 21);
            this.cmbKyoukaID.TabIndex = 2;
            this.cmbKyoukaID.SelectedIndexChanged += new System.EventHandler(this.cmbKyoukaID_SelectedIndexChanged);
            this.cmbKyoukaID.Enter += new System.EventHandler(this.Common_Enter);
            this.cmbKyoukaID.Leave += new System.EventHandler(this.pnlGouKyouka_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(178, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "教科コード :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "号 数 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(378, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "領域選択 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRyouiki
            // 
            this.cmbRyouiki.BackColor = System.Drawing.SystemColors.Window;
            this.cmbRyouiki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRyouiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRyouiki.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRyouiki.FormattingEnabled = true;
            this.cmbRyouiki.Location = new System.Drawing.Point(454, 12);
            this.cmbRyouiki.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRyouiki.MaxLength = 3;
            this.cmbRyouiki.Name = "cmbRyouiki";
            this.cmbRyouiki.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbRyouiki.Size = new System.Drawing.Size(62, 21);
            this.cmbRyouiki.TabIndex = 3;
            this.cmbRyouiki.Enter += new System.EventHandler(this.Common_Enter);
            // 
            // txtGouIDName
            // 
            this.txtGouIDName.Location = new System.Drawing.Point(76, 34);
            this.txtGouIDName.Name = "txtGouIDName";
            this.txtGouIDName.ReadOnly = true;
            this.txtGouIDName.Size = new System.Drawing.Size(252, 25);
            this.txtGouIDName.TabIndex = 23;
            this.txtGouIDName.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(731, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlGouKyouka
            // 
            this.pnlGouKyouka.Controls.Add(this.cmbKyoukaID);
            this.pnlGouKyouka.Controls.Add(this.label2);
            this.pnlGouKyouka.Controls.Add(this.label1);
            this.pnlGouKyouka.Controls.Add(this.txtGouIDName);
            this.pnlGouKyouka.Controls.Add(this.cmbGouID);
            this.pnlGouKyouka.Location = new System.Drawing.Point(14, 6);
            this.pnlGouKyouka.Name = "pnlGouKyouka";
            this.pnlGouKyouka.Size = new System.Drawing.Size(357, 63);
            this.pnlGouKyouka.TabIndex = 2;
            this.pnlGouKyouka.Leave += new System.EventHandler(this.pnlGouKyouka_Leave);
            // 
            // cmbGouID
            // 
            this.cmbGouID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGouID.FormattingEnabled = true;
            this.cmbGouID.Location = new System.Drawing.Point(76, 6);
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
            // pnlGouKyoukaSentaku
            // 
            this.pnlGouKyoukaSentaku.Controls.Add(this.pnlGouKyouka);
            this.pnlGouKyoukaSentaku.Controls.Add(this.label3);
            this.pnlGouKyoukaSentaku.Controls.Add(this.cmbRyouiki);
            this.pnlGouKyoukaSentaku.Location = new System.Drawing.Point(13, 14);
            this.pnlGouKyoukaSentaku.Name = "pnlGouKyoukaSentaku";
            this.pnlGouKyoukaSentaku.Size = new System.Drawing.Size(551, 73);
            this.pnlGouKyoukaSentaku.TabIndex = 0;
            this.pnlGouKyoukaSentaku.Leave += new System.EventHandler(this.pnlGouKyoukaSentaku_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlGouKyoukaSentaku);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 93);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "処理条件";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdCancel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCancel.Location = new System.Drawing.Point(600, 57);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(118, 32);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.TabStop = false;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            this.cmdCancel.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdCancel.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // lstMessages
            // 
            this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessages.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.Location = new System.Drawing.Point(14, 103);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(4);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(704, 251);
            this.lstMessages.TabIndex = 8;
            // 
            // cmdExecute
            // 
            this.cmdExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdExecute.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdExecute.Location = new System.Drawing.Point(600, 17);
            this.cmdExecute.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(118, 32);
            this.cmdExecute.TabIndex = 10;
            this.cmdExecute.TabStop = false;
            this.cmdExecute.Text = "実 行";
            this.cmdExecute.UseVisualStyleBackColor = false;
            this.cmdExecute.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
            this.cmdExecute.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdExecute.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // FM01050
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 388);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.cmdExecute);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(747, 1000);
            this.MinimumSize = new System.Drawing.Size(747, 427);
            this.Name = "FM01050";
            this.Text = "模範解答データ取込み";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM01050_FormClosing);
            this.Load += new System.EventHandler(this.FM01050_Load);
            this.Shown += new System.EventHandler(this.FM01050_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlGouKyouka.ResumeLayout(false);
            this.pnlGouKyouka.PerformLayout();
            this.pnlGouKyoukaSentaku.ResumeLayout(false);
            this.pnlGouKyoukaSentaku.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbKyoukaID;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cmbRyouiki;
        private TextBox txtGouIDName;
        private StatusStrip statusStrip1;
        private Panel pnlGouKyouka;
        private ComboBox cmbGouID;
        private Panel pnlGouKyoukaSentaku;
        private GroupBox groupBox1;
        private Button cmdCancel;
        internal ListBox lstMessages;
        private Button cmdExecute;
    }
}

