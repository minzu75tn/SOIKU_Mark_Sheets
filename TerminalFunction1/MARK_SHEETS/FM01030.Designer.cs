
namespace MARK_SHEETS
{
    partial class FM01030
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdExecute = new System.Windows.Forms.Button();
            this.dgvT36D = new System.Windows.Forms.DataGridView();
            this.t36d_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t36d_mondai_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t36d_daimon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t36d_syoumon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t36d_auto_saiten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdQuery = new System.Windows.Forms.Button();
            this.cmdLink = new System.Windows.Forms.Button();
            this.cmdUnLink = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdVagueLink = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvT302D = new System.Windows.Forms.DataGridView();
            this.t302d_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t302d_field_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t302d_mondai_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t302d_mondai_sub_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t302d_auto_scoring_disable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvT301D = new System.Windows.Forms.DataGridView();
            this.t301d_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t301d_field_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t301d_number_of_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlGouKyoukaSentaku = new System.Windows.Forms.Panel();
            this.pnlGouKyouka = new System.Windows.Forms.Panel();
            this.cmbKyoukaID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGouIDName = new System.Windows.Forms.TextBox();
            this.cmbGouID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRyouiki = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.cmdCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvT36D)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvT302D)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvT301D)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlGouKyoukaSentaku.SuspendLayout();
            this.pnlGouKyouka.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdExecute
            // 
            this.cmdExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExecute.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdExecute.Location = new System.Drawing.Point(799, 58);
            this.cmdExecute.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExecute.Name = "cmdExecute";
            this.cmdExecute.Size = new System.Drawing.Size(118, 32);
            this.cmdExecute.TabIndex = 2;
            this.cmdExecute.TabStop = false;
            this.cmdExecute.Text = "登 録";
            this.cmdExecute.UseVisualStyleBackColor = true;
            this.cmdExecute.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
            this.cmdExecute.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdExecute.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // dgvT36D
            // 
            this.dgvT36D.AllowUserToAddRows = false;
            this.dgvT36D.AllowUserToDeleteRows = false;
            this.dgvT36D.AllowUserToResizeRows = false;
            this.dgvT36D.ColumnHeadersHeight = 50;
            this.dgvT36D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvT36D.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t36d_seq,
            this.t36d_mondai_id,
            this.t36d_daimon,
            this.t36d_syoumon,
            this.t36d_auto_saiten});
            this.dgvT36D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvT36D.Location = new System.Drawing.Point(3, 21);
            this.dgvT36D.MultiSelect = false;
            this.dgvT36D.Name = "dgvT36D";
            this.dgvT36D.ReadOnly = true;
            this.dgvT36D.RowHeadersWidth = 25;
            this.dgvT36D.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvT36D.RowTemplate.Height = 25;
            this.dgvT36D.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvT36D.Size = new System.Drawing.Size(254, 269);
            this.dgvT36D.TabIndex = 5;
            // 
            // t36d_seq
            // 
            this.t36d_seq.DataPropertyName = "t36d_seq";
            this.t36d_seq.HeaderText = "#";
            this.t36d_seq.Name = "t36d_seq";
            this.t36d_seq.ReadOnly = true;
            this.t36d_seq.Width = 35;
            // 
            // t36d_mondai_id
            // 
            this.t36d_mondai_id.DataPropertyName = "t36d_mondai_id";
            dataGridViewCellStyle1.Format = "00";
            dataGridViewCellStyle1.NullValue = null;
            this.t36d_mondai_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.t36d_mondai_id.HeaderText = "問題ID";
            this.t36d_mondai_id.Name = "t36d_mondai_id";
            this.t36d_mondai_id.ReadOnly = true;
            this.t36d_mondai_id.Width = 40;
            // 
            // t36d_daimon
            // 
            this.t36d_daimon.DataPropertyName = "t36d_daimon";
            dataGridViewCellStyle2.Format = "00";
            this.t36d_daimon.DefaultCellStyle = dataGridViewCellStyle2;
            this.t36d_daimon.HeaderText = "大問ID";
            this.t36d_daimon.Name = "t36d_daimon";
            this.t36d_daimon.ReadOnly = true;
            this.t36d_daimon.Width = 40;
            // 
            // t36d_syoumon
            // 
            this.t36d_syoumon.DataPropertyName = "t36d_syoumon";
            dataGridViewCellStyle3.Format = "00";
            this.t36d_syoumon.DefaultCellStyle = dataGridViewCellStyle3;
            this.t36d_syoumon.HeaderText = "小問ID";
            this.t36d_syoumon.Name = "t36d_syoumon";
            this.t36d_syoumon.ReadOnly = true;
            this.t36d_syoumon.Width = 40;
            // 
            // t36d_auto_saiten
            // 
            this.t36d_auto_saiten.DataPropertyName = "t36d_auto_saiten";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.t36d_auto_saiten.DefaultCellStyle = dataGridViewCellStyle4;
            this.t36d_auto_saiten.HeaderText = "対象";
            this.t36d_auto_saiten.Name = "t36d_auto_saiten";
            this.t36d_auto_saiten.ReadOnly = true;
            this.t36d_auto_saiten.Width = 40;
            // 
            // cmdQuery
            // 
            this.cmdQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdQuery.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdQuery.Location = new System.Drawing.Point(660, 18);
            this.cmdQuery.Margin = new System.Windows.Forms.Padding(4);
            this.cmdQuery.Name = "cmdQuery";
            this.cmdQuery.Size = new System.Drawing.Size(118, 32);
            this.cmdQuery.TabIndex = 34;
            this.cmdQuery.TabStop = false;
            this.cmdQuery.Text = "照 会";
            this.cmdQuery.UseVisualStyleBackColor = true;
            this.cmdQuery.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdQuery.Click += new System.EventHandler(this.cmdQuery_Click);
            this.cmdQuery.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdQuery.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // cmdLink
            // 
            this.cmdLink.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdLink.Location = new System.Drawing.Point(526, 68);
            this.cmdLink.Margin = new System.Windows.Forms.Padding(4);
            this.cmdLink.Name = "cmdLink";
            this.cmdLink.Size = new System.Drawing.Size(90, 32);
            this.cmdLink.TabIndex = 37;
            this.cmdLink.TabStop = false;
            this.cmdLink.Text = "紐付け";
            this.cmdLink.UseVisualStyleBackColor = true;
            this.cmdLink.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdLink.Click += new System.EventHandler(this.cmdLink_Click);
            this.cmdLink.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdLink.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // cmdUnLink
            // 
            this.cmdUnLink.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdUnLink.Location = new System.Drawing.Point(526, 118);
            this.cmdUnLink.Margin = new System.Windows.Forms.Padding(4);
            this.cmdUnLink.Name = "cmdUnLink";
            this.cmdUnLink.Size = new System.Drawing.Size(90, 32);
            this.cmdUnLink.TabIndex = 38;
            this.cmdUnLink.TabStop = false;
            this.cmdUnLink.Text = "紐付け解除";
            this.cmdUnLink.UseVisualStyleBackColor = true;
            this.cmdUnLink.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdUnLink.Click += new System.EventHandler(this.cmdUnLink_Click);
            this.cmdUnLink.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdUnLink.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmdVagueLink);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.cmdUnLink);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cmdLink);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 313);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // cmdVagueLink
            // 
            this.cmdVagueLink.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdVagueLink.Location = new System.Drawing.Point(526, 184);
            this.cmdVagueLink.Margin = new System.Windows.Forms.Padding(4);
            this.cmdVagueLink.Name = "cmdVagueLink";
            this.cmdVagueLink.Size = new System.Drawing.Size(90, 32);
            this.cmdVagueLink.TabIndex = 40;
            this.cmdVagueLink.TabStop = false;
            this.cmdVagueLink.Text = "曖昧紐付け";
            this.cmdVagueLink.UseVisualStyleBackColor = true;
            this.cmdVagueLink.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdVagueLink.Click += new System.EventHandler(this.cmdVagueLink_Click);
            this.cmdVagueLink.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdVagueLink.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.dgvT302D);
            this.groupBox5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(628, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 293);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "〔302〕マーク紐付けデータ";
            // 
            // dgvT302D
            // 
            this.dgvT302D.AllowUserToAddRows = false;
            this.dgvT302D.AllowUserToDeleteRows = false;
            this.dgvT302D.AllowUserToResizeRows = false;
            this.dgvT302D.ColumnHeadersHeight = 50;
            this.dgvT302D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvT302D.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t302d_seq,
            this.t302d_field_id,
            this.t302d_mondai_id,
            this.t302d_mondai_sub_no,
            this.t302d_auto_scoring_disable});
            this.dgvT302D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvT302D.Location = new System.Drawing.Point(3, 21);
            this.dgvT302D.MultiSelect = false;
            this.dgvT302D.Name = "dgvT302D";
            this.dgvT302D.RowHeadersWidth = 25;
            this.dgvT302D.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvT302D.RowTemplate.Height = 25;
            this.dgvT302D.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvT302D.Size = new System.Drawing.Size(298, 269);
            this.dgvT302D.TabIndex = 7;
            // 
            // t302d_seq
            // 
            this.t302d_seq.DataPropertyName = "t302d_seq";
            this.t302d_seq.HeaderText = "#";
            this.t302d_seq.Name = "t302d_seq";
            this.t302d_seq.ReadOnly = true;
            this.t302d_seq.Width = 35;
            // 
            // t302d_field_id
            // 
            this.t302d_field_id.DataPropertyName = "t302d_field_id";
            this.t302d_field_id.HeaderText = "フィールドID";
            this.t302d_field_id.Name = "t302d_field_id";
            this.t302d_field_id.ReadOnly = true;
            // 
            // t302d_mondai_id
            // 
            this.t302d_mondai_id.DataPropertyName = "t302d_mondai_id";
            dataGridViewCellStyle5.Format = "00";
            this.t302d_mondai_id.DefaultCellStyle = dataGridViewCellStyle5;
            this.t302d_mondai_id.HeaderText = "問題ID";
            this.t302d_mondai_id.Name = "t302d_mondai_id";
            this.t302d_mondai_id.Width = 40;
            // 
            // t302d_mondai_sub_no
            // 
            this.t302d_mondai_sub_no.DataPropertyName = "t302d_mondai_sub_no";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.t302d_mondai_sub_no.DefaultCellStyle = dataGridViewCellStyle6;
            this.t302d_mondai_sub_no.HeaderText = "枝番";
            this.t302d_mondai_sub_no.Name = "t302d_mondai_sub_no";
            this.t302d_mondai_sub_no.Width = 30;
            // 
            // t302d_auto_scoring_disable
            // 
            this.t302d_auto_scoring_disable.DataPropertyName = "t302d_auto_scoring_disable";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.t302d_auto_scoring_disable.DefaultCellStyle = dataGridViewCellStyle7;
            this.t302d_auto_scoring_disable.HeaderText = "自動抑止";
            this.t302d_auto_scoring_disable.Name = "t302d_auto_scoring_disable";
            this.t302d_auto_scoring_disable.Width = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.dgvT301D);
            this.groupBox4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(272, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 293);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "〔301〕マーク位置データ";
            // 
            // dgvT301D
            // 
            this.dgvT301D.AllowUserToAddRows = false;
            this.dgvT301D.AllowUserToDeleteRows = false;
            this.dgvT301D.AllowUserToResizeRows = false;
            this.dgvT301D.ColumnHeadersHeight = 50;
            this.dgvT301D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvT301D.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t301d_seq,
            this.t301d_field_id,
            this.t301d_number_of_marks});
            this.dgvT301D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvT301D.Location = new System.Drawing.Point(3, 21);
            this.dgvT301D.MultiSelect = false;
            this.dgvT301D.Name = "dgvT301D";
            this.dgvT301D.ReadOnly = true;
            this.dgvT301D.RowHeadersWidth = 25;
            this.dgvT301D.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvT301D.RowTemplate.Height = 25;
            this.dgvT301D.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvT301D.Size = new System.Drawing.Size(234, 269);
            this.dgvT301D.TabIndex = 6;
            // 
            // t301d_seq
            // 
            this.t301d_seq.DataPropertyName = "t301d_seq";
            this.t301d_seq.HeaderText = "#";
            this.t301d_seq.Name = "t301d_seq";
            this.t301d_seq.ReadOnly = true;
            this.t301d_seq.Width = 35;
            // 
            // t301d_field_id
            // 
            this.t301d_field_id.DataPropertyName = "t301d_field_id";
            this.t301d_field_id.HeaderText = "フィールドID";
            this.t301d_field_id.Name = "t301d_field_id";
            this.t301d_field_id.ReadOnly = true;
            // 
            // t301d_number_of_marks
            // 
            this.t301d_number_of_marks.DataPropertyName = "t301d_number_of_marks";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.t301d_number_of_marks.DefaultCellStyle = dataGridViewCellStyle8;
            this.t301d_number_of_marks.HeaderText = "個数";
            this.t301d_number_of_marks.Name = "t301d_number_of_marks";
            this.t301d_number_of_marks.ReadOnly = true;
            this.t301d_number_of_marks.Width = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dgvT36D);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(6, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 293);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "〔36〕設問別データ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlGouKyoukaSentaku);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 93);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "処理条件";
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
            // txtGouIDName
            // 
            this.txtGouIDName.Location = new System.Drawing.Point(76, 34);
            this.txtGouIDName.Name = "txtGouIDName";
            this.txtGouIDName.ReadOnly = true;
            this.txtGouIDName.Size = new System.Drawing.Size(252, 25);
            this.txtGouIDName.TabIndex = 23;
            this.txtGouIDName.TabStop = false;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 41;
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
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(420, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(350, 16);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCancel.Location = new System.Drawing.Point(660, 58);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(118, 32);
            this.cmdCancel.TabIndex = 42;
            this.cmdCancel.TabStop = false;
            this.cmdCancel.Text = "キャンセル";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            this.cmdCancel.Enter += new System.EventHandler(this.Button_Enter);
            this.cmdCancel.Leave += new System.EventHandler(this.Button_Leave);
            // 
            // FM01030
            // 
            this.AcceptButton = this.cmdQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 449);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdQuery);
            this.Controls.Add(this.cmdExecute);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(980, 488);
            this.Name = "FM01030";
            this.Text = "設問＆マーク紐付け登録";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FM01030_FormClosing);
            this.Load += new System.EventHandler(this.FM01030_Load);
            this.Shown += new System.EventHandler(this.FM01030_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvT36D)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvT302D)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvT301D)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlGouKyoukaSentaku.ResumeLayout(false);
            this.pnlGouKyoukaSentaku.PerformLayout();
            this.pnlGouKyouka.ResumeLayout(false);
            this.pnlGouKyouka.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdExecute;
        private DataGridView dgvT36D;
        private Button cmdQuery;
        private Button cmdLink;
        private Button cmdUnLink;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private DataGridView dgvT302D;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private DataGridView dgvT301D;
        private Button cmdVagueLink;
        private GroupBox groupBox1;
        private Panel pnlGouKyoukaSentaku;
        private Panel pnlGouKyouka;
        private ComboBox cmbKyoukaID;
        private Label label2;
        private Label label1;
        private TextBox txtGouIDName;
        private ComboBox cmbGouID;
        private Label label3;
        private ComboBox cmbRyouiki;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button cmdCancel;
        private DataGridViewTextBoxColumn t36d_seq;
        private DataGridViewTextBoxColumn t36d_mondai_id;
        private DataGridViewTextBoxColumn t36d_daimon;
        private DataGridViewTextBoxColumn t36d_syoumon;
        private DataGridViewTextBoxColumn t36d_auto_saiten;
        private DataGridViewTextBoxColumn t302d_seq;
        private DataGridViewTextBoxColumn t302d_field_id;
        private DataGridViewTextBoxColumn t302d_mondai_id;
        private DataGridViewTextBoxColumn t302d_mondai_sub_no;
        private DataGridViewTextBoxColumn t302d_auto_scoring_disable;
        private DataGridViewTextBoxColumn t301d_seq;
        private DataGridViewTextBoxColumn t301d_field_id;
        private DataGridViewTextBoxColumn t301d_number_of_marks;
    }
}

