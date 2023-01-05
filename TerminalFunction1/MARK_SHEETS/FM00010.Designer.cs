
namespace MARK_SHEETS
{
    partial class FM00010
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
            this.cmdGetMarks = new System.Windows.Forms.Button();
            this.cmdEntryMarkLink = new System.Windows.Forms.Button();
            this.cmdGetModelAnswer = new System.Windows.Forms.Button();
            this.cmdGetAnswer = new System.Windows.Forms.Button();
            this.cmdAutoScoreing = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCheckAutoScoreing = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGetMarks
            // 
            this.cmdGetMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdGetMarks.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdGetMarks.Location = new System.Drawing.Point(22, 32);
            this.cmdGetMarks.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGetMarks.Name = "cmdGetMarks";
            this.cmdGetMarks.Size = new System.Drawing.Size(171, 32);
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
            this.cmdEntryMarkLink.Location = new System.Drawing.Point(22, 72);
            this.cmdEntryMarkLink.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEntryMarkLink.Name = "cmdEntryMarkLink";
            this.cmdEntryMarkLink.Size = new System.Drawing.Size(171, 32);
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
            this.cmdGetModelAnswer.Location = new System.Drawing.Point(22, 112);
            this.cmdGetModelAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGetModelAnswer.Name = "cmdGetModelAnswer";
            this.cmdGetModelAnswer.Size = new System.Drawing.Size(171, 32);
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
            this.cmdGetAnswer.Location = new System.Drawing.Point(22, 32);
            this.cmdGetAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.cmdGetAnswer.Name = "cmdGetAnswer";
            this.cmdGetAnswer.Size = new System.Drawing.Size(171, 32);
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
            this.cmdAutoScoreing.Location = new System.Drawing.Point(22, 72);
            this.cmdAutoScoreing.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAutoScoreing.Name = "cmdAutoScoreing";
            this.cmdAutoScoreing.Size = new System.Drawing.Size(171, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 207);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "事前処理系";
            // 
            // cmdCheckAutoScoreing
            // 
            this.cmdCheckAutoScoreing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cmdCheckAutoScoreing.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCheckAutoScoreing.Location = new System.Drawing.Point(22, 152);
            this.cmdCheckAutoScoreing.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCheckAutoScoreing.Name = "cmdCheckAutoScoreing";
            this.cmdCheckAutoScoreing.Size = new System.Drawing.Size(171, 32);
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
            this.groupBox2.Location = new System.Drawing.Point(9, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 125);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "本番処理系";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.SystemColors.Control;
            this.txtServer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtServer.ForeColor = System.Drawing.Color.Red;
            this.txtServer.Location = new System.Drawing.Point(131, 7);
            this.txtServer.Name = "txtServer";
            this.txtServer.ReadOnly = true;
            this.txtServer.Size = new System.Drawing.Size(95, 27);
            this.txtServer.TabIndex = 31;
            this.txtServer.TabStop = false;
            this.txtServer.Text = "STEIS-1";
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FM00010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 392);
            this.ControlBox = false;
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(252, 431);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(252, 431);
            this.Name = "FM00010";
            this.Text = "マークシート対応 メニュー";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM00010_FormClosing);
            this.Load += new System.EventHandler(this.FM00010_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdGetMarks;
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

