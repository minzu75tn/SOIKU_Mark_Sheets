
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdExecute = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKyoukaID = new System.Windows.Forms.ComboBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdCLose = new System.Windows.Forms.Button();
            this.txtGouIDName = new System.Windows.Forms.TextBox();
            this.txtGroupIDName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGouID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNendo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbGakou = new System.Windows.Forms.RadioButton();
            this.rdbJuku = new System.Windows.Forms.RadioButton();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.txtKaijyouID = new System.Windows.Forms.TextBox();
            this.lblKaijyouID = new System.Windows.Forms.Label();
            this.txtKaijyouIDName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
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
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(100, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(408, 17);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // cmdExecute
            // 
            this.cmdExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExecute.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdExecute.Location = new System.Drawing.Point(491, 313);
            this.cmdExecute.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(118, 32);
            this.cmdExecute.TabIndex = 2;
            this.cmdExecute.Text = "実 行";
            this.cmdExecute.UseVisualStyleBackColor = true;
            this.cmdExecute.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
            this.cmdExecute.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdExecute.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // lstMessages
            // 
            this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessages.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.Location = new System.Drawing.Point(12, 171);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(4);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(775, 186);
            this.lstMessages.TabIndex = 14;
            this.lstMessages.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(449, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "教科コード :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbKyoukaID
            // 
            this.cmbKyoukaID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKyoukaID.FormattingEnabled = true;
            this.cmbKyoukaID.Items.AddRange(new object[] {
            "数学"});
            this.cmbKyoukaID.Location = new System.Drawing.Point(520, 75);
            this.cmbKyoukaID.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKyoukaID.MaxLength = 3;
            this.cmbKyoukaID.Name = "cmbKyoukaID";
            this.cmbKyoukaID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbKyoukaID.Size = new System.Drawing.Size(62, 21);
            this.cmbKyoukaID.TabIndex = 19;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCancel.Location = new System.Drawing.Point(669, 60);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(118, 32);
            this.cmdCancel.TabIndex = 21;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdCLose
            // 
            this.cmdCLose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCLose.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCLose.Location = new System.Drawing.Point(669, 365);
            this.cmdCLose.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCLose.Name = "cmdCLose";
            this.cmdCLose.Size = new System.Drawing.Size(118, 32);
            this.cmdCLose.TabIndex = 22;
            this.cmdCLose.Text = "閉じる";
            this.cmdCLose.UseVisualStyleBackColor = true;
            // 
            // txtGouIDName
            // 
            this.txtGouIDName.Location = new System.Drawing.Point(87, 106);
            this.txtGouIDName.Name = "txtGouIDName";
            this.txtGouIDName.Size = new System.Drawing.Size(211, 25);
            this.txtGouIDName.TabIndex = 25;
            this.txtGouIDName.Text = "号数名称";
            // 
            // txtGroupIDName
            // 
            this.txtGroupIDName.Location = new System.Drawing.Point(349, 106);
            this.txtGroupIDName.Name = "txtGroupIDName";
            this.txtGroupIDName.Size = new System.Drawing.Size(223, 25);
            this.txtGroupIDName.TabIndex = 26;
            this.txtGroupIDName.Text = "団体名称";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGouID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNendo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtGroupID);
            this.groupBox1.Controls.Add(this.lblGroupID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGroupIDName);
            this.groupBox1.Controls.Add(this.cmbKyoukaID);
            this.groupBox1.Controls.Add(this.txtGouIDName);
            this.groupBox1.Controls.Add(this.txtKaijyouID);
            this.groupBox1.Controls.Add(this.lblKaijyouID);
            this.groupBox1.Controls.Add(this.txtKaijyouIDName);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 149);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "処理条件";
            // 
            // txtGouID
            // 
            this.txtGouID.Location = new System.Drawing.Point(191, 75);
            this.txtGouID.Name = "txtGouID";
            this.txtGouID.Size = new System.Drawing.Size(46, 25);
            this.txtGouID.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(147, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "号数 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNendo
            // 
            this.txtNendo.Location = new System.Drawing.Point(87, 75);
            this.txtNendo.Name = "txtNendo";
            this.txtNendo.Size = new System.Drawing.Size(46, 25);
            this.txtNendo.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "年度 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbGakou);
            this.groupBox2.Controls.Add(this.rdbJuku);
            this.groupBox2.Location = new System.Drawing.Point(27, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 45);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "実施種別";
            // 
            // rdbGakou
            // 
            this.rdbGakou.AutoSize = true;
            this.rdbGakou.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbGakou.Location = new System.Drawing.Point(37, 18);
            this.rdbGakou.Name = "rdbGakou";
            this.rdbGakou.Size = new System.Drawing.Size(65, 21);
            this.rdbGakou.TabIndex = 30;
            this.rdbGakou.TabStop = true;
            this.rdbGakou.Text = "学校系";
            this.rdbGakou.UseVisualStyleBackColor = true;
            this.rdbGakou.CheckedChanged += new System.EventHandler(this.rdbGakou_CheckedChanged);
            // 
            // rdbJuku
            // 
            this.rdbJuku.AutoSize = true;
            this.rdbJuku.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbJuku.Location = new System.Drawing.Point(127, 18);
            this.rdbJuku.Name = "rdbJuku";
            this.rdbJuku.Size = new System.Drawing.Size(85, 21);
            this.rdbJuku.TabIndex = 31;
            this.rdbJuku.TabStop = true;
            this.rdbJuku.Text = "塾・会場系";
            this.rdbJuku.UseVisualStyleBackColor = true;
            this.rdbJuku.CheckedChanged += new System.EventHandler(this.rdbJuku_CheckedChanged);
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(347, 74);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(71, 25);
            this.txtGroupID.TabIndex = 29;
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGroupID.Location = new System.Drawing.Point(271, 78);
            this.lblGroupID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(69, 13);
            this.lblGroupID.TabIndex = 28;
            this.lblGroupID.Text = "団体コード :";
            this.lblGroupID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKaijyouID
            // 
            this.txtKaijyouID.Location = new System.Drawing.Point(347, 74);
            this.txtKaijyouID.Name = "txtKaijyouID";
            this.txtKaijyouID.Size = new System.Drawing.Size(71, 25);
            this.txtKaijyouID.TabIndex = 37;
            // 
            // lblKaijyouID
            // 
            this.lblKaijyouID.AutoSize = true;
            this.lblKaijyouID.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKaijyouID.Location = new System.Drawing.Point(271, 78);
            this.lblKaijyouID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKaijyouID.Name = "lblKaijyouID";
            this.lblKaijyouID.Size = new System.Drawing.Size(69, 13);
            this.lblKaijyouID.TabIndex = 36;
            this.lblKaijyouID.Text = "会場コード :";
            this.lblKaijyouID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKaijyouIDName
            // 
            this.txtKaijyouIDName.Location = new System.Drawing.Point(349, 106);
            this.txtKaijyouIDName.Name = "txtKaijyouIDName";
            this.txtKaijyouIDName.Size = new System.Drawing.Size(223, 25);
            this.txtKaijyouIDName.TabIndex = 40;
            this.txtKaijyouIDName.Text = "会場名称";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(669, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "実 行";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FM02010
            // 
            this.AcceptButton = this.cmdExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdCLose);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdExecute);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 422);
            this.Name = "FM02010";
            this.Text = "解答データ取込み";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM02010_FormClosing);
            this.Load += new System.EventHandler(this.FM02010_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button cmdExecute;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        internal System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private Label label3;
        private ComboBox cmbKyoukaID;
        private Button cmdCancel;
        private Button cmdCLose;
        private TextBox txtGouIDName;
        private TextBox txtGroupIDName;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtGroupID;
        private Label lblGroupID;
        private TextBox txtGouID;
        private Label label5;
        private TextBox txtKaijyouID;
        private Label lblKaijyouID;
        private TextBox txtNendo;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton rdbGakou;
        private RadioButton rdbJuku;
        private TextBox txtKaijyouIDName;
    }
}

