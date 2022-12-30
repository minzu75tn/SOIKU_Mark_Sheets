
namespace MARK_SHEETS
{
    partial class FM00000
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenu1_sub1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenu3_sub1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdGetMarks = new System.Windows.Forms.Button();
            this.cmdEntryMarkLink = new System.Windows.Forms.Button();
            this.cmdGetModelAnswer = new System.Windows.Forms.Button();
            this.cmdGetAnswer = new System.Windows.Forms.Button();
            this.cmdAutoScoreing = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCheckAutoScoreing = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu1,
            this.tsmMenu3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu1
            // 
            this.tsmMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu1_sub1});
            this.tsmMenu1.Name = "tsmMenu1";
            this.tsmMenu1.ShortcutKeyDisplayString = "";
            this.tsmMenu1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.tsmMenu1.Size = new System.Drawing.Size(70, 20);
            this.tsmMenu1.Text = "ファイル (&F)";
            // 
            // tsmMenu1_sub1
            // 
            this.tsmMenu1_sub1.Name = "tsmMenu1_sub1";
            this.tsmMenu1_sub1.ShortcutKeyDisplayString = "";
            this.tsmMenu1_sub1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.tsmMenu1_sub1.Size = new System.Drawing.Size(232, 22);
            this.tsmMenu1_sub1.Text = "アプリケーションの終了 (&X)";
            this.tsmMenu1_sub1.Click += new System.EventHandler(this.tsmMenu1_sub1_Click);
            // 
            // tsmMenu3
            // 
            this.tsmMenu3.CheckOnClick = true;
            this.tsmMenu3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu3_sub1});
            this.tsmMenu3.Name = "tsmMenu3";
            this.tsmMenu3.ShortcutKeyDisplayString = "";
            this.tsmMenu3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.tsmMenu3.Size = new System.Drawing.Size(61, 20);
            this.tsmMenu3.Text = "表示 (&V)";
            // 
            // tsmMenu3_sub1
            // 
            this.tsmMenu3_sub1.Checked = true;
            this.tsmMenu3_sub1.CheckOnClick = true;
            this.tsmMenu3_sub1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmMenu3_sub1.Name = "tsmMenu3_sub1";
            this.tsmMenu3_sub1.ShortcutKeyDisplayString = "";
            this.tsmMenu3_sub1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.tsmMenu3_sub1.Size = new System.Drawing.Size(189, 22);
            this.tsmMenu3_sub1.Text = "ステータスバー (&S)";
            this.tsmMenu3_sub1.Click += new System.EventHandler(this.tsmMenu3_sub1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
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
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(295, 17);
            this.toolStripStatusLabel5.Spring = true;
            // 
            // cmdGetMarks
            // 
            this.cmdGetMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdGetMarks.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdGetMarks.Location = new System.Drawing.Point(35, 32);
            this.cmdGetMarks.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGetMarks.Name = "cmdGetMarks";
            this.cmdGetMarks.Size = new System.Drawing.Size(196, 32);
            this.cmdGetMarks.TabIndex = 2;
            this.cmdGetMarks.Text = "マーク位置情報取込み";
            this.cmdGetMarks.UseVisualStyleBackColor = false;
            this.cmdGetMarks.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdGetMarks.Click += new System.EventHandler(this.cmdGetMarks_Click);
            this.cmdGetMarks.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdGetMarks.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // cmdEntryMarkLink
            // 
            this.cmdEntryMarkLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdEntryMarkLink.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdEntryMarkLink.Location = new System.Drawing.Point(35, 72);
            this.cmdEntryMarkLink.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEntryMarkLink.Name = "cmdEntryMarkLink";
            this.cmdEntryMarkLink.Size = new System.Drawing.Size(196, 32);
            this.cmdEntryMarkLink.TabIndex = 24;
            this.cmdEntryMarkLink.Text = "設問＆マーク紐付け登録";
            this.cmdEntryMarkLink.UseVisualStyleBackColor = false;
            this.cmdEntryMarkLink.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdEntryMarkLink.Click += new System.EventHandler(this.cmdEntryMarkLink_Click);
            this.cmdEntryMarkLink.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdEntryMarkLink.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // cmdGetModelAnswer
            // 
            this.cmdGetModelAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdGetModelAnswer.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdGetModelAnswer.Location = new System.Drawing.Point(35, 112);
            this.cmdGetModelAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGetModelAnswer.Name = "cmdGetModelAnswer";
            this.cmdGetModelAnswer.Size = new System.Drawing.Size(196, 32);
            this.cmdGetModelAnswer.TabIndex = 25;
            this.cmdGetModelAnswer.Text = "模範解答データ取込み";
            this.cmdGetModelAnswer.UseVisualStyleBackColor = false;
            this.cmdGetModelAnswer.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdGetModelAnswer.Click += new System.EventHandler(this.cmdGetModelAnswer_Click);
            this.cmdGetModelAnswer.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdGetModelAnswer.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // cmdGetAnswer
            // 
            this.cmdGetAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdGetAnswer.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdGetAnswer.Location = new System.Drawing.Point(41, 32);
            this.cmdGetAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGetAnswer.Name = "cmdGetAnswer";
            this.cmdGetAnswer.Size = new System.Drawing.Size(196, 32);
            this.cmdGetAnswer.TabIndex = 26;
            this.cmdGetAnswer.Text = "解答データ取込み";
            this.cmdGetAnswer.UseVisualStyleBackColor = false;
            this.cmdGetAnswer.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdGetAnswer.Click += new System.EventHandler(this.cmdGetAnswer_Click);
            this.cmdGetAnswer.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdGetAnswer.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // cmdAutoScoreing
            // 
            this.cmdAutoScoreing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdAutoScoreing.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAutoScoreing.Location = new System.Drawing.Point(41, 72);
            this.cmdAutoScoreing.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAutoScoreing.Name = "cmdAutoScoreing";
            this.cmdAutoScoreing.Size = new System.Drawing.Size(196, 32);
            this.cmdAutoScoreing.TabIndex = 27;
            this.cmdAutoScoreing.Text = "自動採点実施";
            this.cmdAutoScoreing.UseVisualStyleBackColor = false;
            this.cmdAutoScoreing.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdAutoScoreing.Click += new System.EventHandler(this.cmdAutoScoreing_Click);
            this.cmdAutoScoreing.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdAutoScoreing.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCheckAutoScoreing);
            this.groupBox1.Controls.Add(this.cmdGetMarks);
            this.groupBox1.Controls.Add(this.cmdGetModelAnswer);
            this.groupBox1.Controls.Add(this.cmdEntryMarkLink);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(40, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 222);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "事前処理系";
            // 
            // cmdCheckAutoScoreing
            // 
            this.cmdCheckAutoScoreing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdCheckAutoScoreing.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCheckAutoScoreing.Location = new System.Drawing.Point(35, 152);
            this.cmdCheckAutoScoreing.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCheckAutoScoreing.Name = "cmdCheckAutoScoreing";
            this.cmdCheckAutoScoreing.Size = new System.Drawing.Size(196, 32);
            this.cmdCheckAutoScoreing.TabIndex = 27;
            this.cmdCheckAutoScoreing.Text = "自動採点事前チェック";
            this.cmdCheckAutoScoreing.UseVisualStyleBackColor = false;
            this.cmdCheckAutoScoreing.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdCheckAutoScoreing.Click += new System.EventHandler(this.cmdCheckAutoScoreing_Click);
            this.cmdCheckAutoScoreing.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdCheckAutoScoreing.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdGetAnswer);
            this.groupBox2.Controls.Add(this.cmdAutoScoreing);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(367, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 222);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "本番処理系";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.SystemColors.Control;
            this.txtServer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtServer.ForeColor = System.Drawing.Color.Red;
            this.txtServer.Location = new System.Drawing.Point(546, 34);
            this.txtServer.Name = "txtServer";
            this.txtServer.ReadOnly = true;
            this.txtServer.Size = new System.Drawing.Size(95, 27);
            this.txtServer.TabIndex = 31;
            this.txtServer.TabStop = false;
            this.txtServer.Text = "STEIS-1";
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FM00000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 395);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(703, 385);
            this.Name = "FM00000";
            this.Text = "マークシート対応 メニュー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM00000_FormClosing);
            this.Load += new System.EventHandler(this.FM00000_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu3_sub1;
        private System.Windows.Forms.Button cmdGetMarks;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu1_sub1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private Button cmdEntryMarkLink;
        private Button cmdGetModelAnswer;
        private Button cmdGetAnswer;
        private Button cmdAutoScoreing;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button cmdCheckAutoScoreing;
        private TextBox txtServer;
    }
}

