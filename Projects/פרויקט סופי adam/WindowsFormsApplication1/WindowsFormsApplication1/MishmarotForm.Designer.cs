namespace WindowsFormsApplication1
{
    partial class MishmarotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splMoveUp = new System.Windows.Forms.Splitter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnCloseSrch = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.splResult = new System.Windows.Forms.Splitter();
            this.lblResult = new System.Windows.Forms.Label();
            this.splHalf = new System.Windows.Forms.Splitter();
            this.pnlUpperActionButtons = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.pnlLowerActionButtons = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.zhotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mishmarotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new WindowsFormsApplication1.HospitalDataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splData = new System.Windows.Forms.Splitter();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlTexts = new System.Windows.Forms.Panel();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.radioButtonEnd = new System.Windows.Forms.RadioButton();
            this.radioButtonStart = new System.Windows.Forms.RadioButton();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.hintEnd = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.hintStart = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.hintEndDate = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtZhot = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblZhot = new System.Windows.Forms.Label();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.hintStartDate = new System.Windows.Forms.Label();
            this.hintZhot = new System.Windows.Forms.Label();
            this.splSeparate = new System.Windows.Forms.Splitter();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.pnlResultButtons = new System.Windows.Forms.Panel();
            this.lblSearchQuantity = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.splMoveRight = new System.Windows.Forms.Splitter();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.mishmarotTableAdapter = new WindowsFormsApplication1.HospitalDataSetTableAdapters.MishmarotTableAdapter();
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.pnlUpperActionButtons.SuspendLayout();
            this.pnlLowerActionButtons.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            this.pnlTexts.SuspendLayout();
            this.pnlTables.SuspendLayout();
            this.pnlResultButtons.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splMoveUp
            // 
            this.splMoveUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splMoveUp.Location = new System.Drawing.Point(0, 411);
            this.splMoveUp.Margin = new System.Windows.Forms.Padding(2);
            this.splMoveUp.Name = "splMoveUp";
            this.splMoveUp.Size = new System.Drawing.Size(594, 20);
            this.splMoveUp.TabIndex = 105;
            this.splMoveUp.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(286, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 69);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.btnCloseSrch);
            this.pnlResult.Controls.Add(this.dataGridViewResult);
            this.pnlResult.Controls.Add(this.splResult);
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Controls.Add(this.splHalf);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlResult.Location = new System.Drawing.Point(0, 0);
            this.pnlResult.Margin = new System.Windows.Forms.Padding(2);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(678, 286);
            this.pnlResult.TabIndex = 83;
            this.pnlResult.Visible = false;
            // 
            // btnCloseSrch
            // 
            this.btnCloseSrch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCloseSrch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCloseSrch.FlatAppearance.BorderSize = 0;
            this.btnCloseSrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCloseSrch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseSrch.Location = new System.Drawing.Point(2, 2);
            this.btnCloseSrch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseSrch.Name = "btnCloseSrch";
            this.btnCloseSrch.Size = new System.Drawing.Size(64, 27);
            this.btnCloseSrch.TabIndex = 21;
            this.btnCloseSrch.Text = "סגור";
            this.btnCloseSrch.UseVisualStyleBackColor = false;
            this.btnCloseSrch.Click += new System.EventHandler(this.btnCloseSrch_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewResult.MultiSelect = false;
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(673, 253);
            this.dataGridViewResult.TabIndex = 23;
            this.dataGridViewResult.SelectionChanged += new System.EventHandler(this.dataGridViewResult_SelectionChanged);
            // 
            // splResult
            // 
            this.splResult.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.splResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.splResult.Enabled = false;
            this.splResult.Location = new System.Drawing.Point(0, 30);
            this.splResult.Name = "splResult";
            this.splResult.Size = new System.Drawing.Size(673, 3);
            this.splResult.TabIndex = 83;
            this.splResult.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(673, 30);
            this.lblResult.TabIndex = 82;
            this.lblResult.Text = "תוצאות החיפוש";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splHalf
            // 
            this.splHalf.BackColor = System.Drawing.Color.DimGray;
            this.splHalf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splHalf.Cursor = System.Windows.Forms.Cursors.Default;
            this.splHalf.Dock = System.Windows.Forms.DockStyle.Right;
            this.splHalf.Enabled = false;
            this.splHalf.Location = new System.Drawing.Point(673, 0);
            this.splHalf.Name = "splHalf";
            this.splHalf.Size = new System.Drawing.Size(5, 286);
            this.splHalf.TabIndex = 84;
            this.splHalf.TabStop = false;
            this.splHalf.Visible = false;
            // 
            // pnlUpperActionButtons
            // 
            this.pnlUpperActionButtons.Controls.Add(this.btnAccept);
            this.pnlUpperActionButtons.Controls.Add(this.btnDel);
            this.pnlUpperActionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpperActionButtons.Location = new System.Drawing.Point(0, 273);
            this.pnlUpperActionButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpperActionButtons.Name = "pnlUpperActionButtons";
            this.pnlUpperActionButtons.Size = new System.Drawing.Size(594, 69);
            this.pnlUpperActionButtons.TabIndex = 84;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAccept.Location = new System.Drawing.Point(286, 0);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(143, 69);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "אישור";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDel.Location = new System.Drawing.Point(0, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(286, 69);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "מחק";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pnlLowerActionButtons
            // 
            this.pnlLowerActionButtons.Controls.Add(this.btnCancel);
            this.pnlLowerActionButtons.Controls.Add(this.btnUpdate);
            this.pnlLowerActionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLowerActionButtons.Location = new System.Drawing.Point(0, 342);
            this.pnlLowerActionButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLowerActionButtons.Name = "pnlLowerActionButtons";
            this.pnlLowerActionButtons.Size = new System.Drawing.Size(594, 69);
            this.pnlLowerActionButtons.TabIndex = 85;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(286, 69);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dataGridView);
            this.pnlData.Controls.Add(this.btnRefresh);
            this.pnlData.Controls.Add(this.splData);
            this.pnlData.Controls.Add(this.lblData);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(678, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(686, 286);
            this.pnlData.TabIndex = 91;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zhotDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.mishmarotBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 33);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(686, 253);
            this.dataGridView.TabIndex = 22;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // zhotDataGridViewTextBoxColumn
            // 
            this.zhotDataGridViewTextBoxColumn.DataPropertyName = "zhot";
            this.zhotDataGridViewTextBoxColumn.HeaderText = "תעודת זהות";
            this.zhotDataGridViewTextBoxColumn.Name = "zhotDataGridViewTextBoxColumn";
            this.zhotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "התחלה";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "סיום";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mishmarotBindingSource
            // 
            this.mishmarotBindingSource.DataMember = "Mishmarot";
            this.mishmarotBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefresh.Location = new System.Drawing.Point(0, -2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 32);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "🔃";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // splData
            // 
            this.splData.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splData.Cursor = System.Windows.Forms.Cursors.Default;
            this.splData.Dock = System.Windows.Forms.DockStyle.Top;
            this.splData.Enabled = false;
            this.splData.Location = new System.Drawing.Point(0, 30);
            this.splData.Name = "splData";
            this.splData.Size = new System.Drawing.Size(686, 3);
            this.splData.TabIndex = 63;
            this.splData.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblData.Location = new System.Drawing.Point(0, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(686, 30);
            this.lblData.TabIndex = 62;
            this.lblData.Text = "טבלת ";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTexts
            // 
            this.pnlTexts.BackColor = System.Drawing.Color.Transparent;
            this.pnlTexts.Controls.Add(this.timeEnd);
            this.pnlTexts.Controls.Add(this.timeStart);
            this.pnlTexts.Controls.Add(this.radioButtonEnd);
            this.pnlTexts.Controls.Add(this.radioButtonStart);
            this.pnlTexts.Controls.Add(this.lblEnd);
            this.pnlTexts.Controls.Add(this.txtEnd);
            this.pnlTexts.Controls.Add(this.hintEnd);
            this.pnlTexts.Controls.Add(this.txtStart);
            this.pnlTexts.Controls.Add(this.lblStart);
            this.pnlTexts.Controls.Add(this.hintStart);
            this.pnlTexts.Controls.Add(this.dateEnd);
            this.pnlTexts.Controls.Add(this.lblEndDate);
            this.pnlTexts.Controls.Add(this.txtEndDate);
            this.pnlTexts.Controls.Add(this.hintEndDate);
            this.pnlTexts.Controls.Add(this.dateStart);
            this.pnlTexts.Controls.Add(this.btnClean);
            this.pnlTexts.Controls.Add(this.txtStartDate);
            this.pnlTexts.Controls.Add(this.txtZhot);
            this.pnlTexts.Controls.Add(this.lblStartDate);
            this.pnlTexts.Controls.Add(this.lblZhot);
            this.pnlTexts.Controls.Add(this.comboSearch);
            this.pnlTexts.Controls.Add(this.btnSearch);
            this.pnlTexts.Controls.Add(this.txtSearch);
            this.pnlTexts.Controls.Add(this.lblSearch);
            this.pnlTexts.Controls.Add(this.hintStartDate);
            this.pnlTexts.Controls.Add(this.hintZhot);
            this.pnlTexts.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTexts.Location = new System.Drawing.Point(638, 291);
            this.pnlTexts.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTexts.Name = "pnlTexts";
            this.pnlTexts.Size = new System.Drawing.Size(726, 431);
            this.pnlTexts.TabIndex = 107;
            // 
            // timeEnd
            // 
            this.timeEnd.Enabled = false;
            this.timeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(295, 316);
            this.timeEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(19, 30);
            this.timeEnd.TabIndex = 166;
            this.timeEnd.ValueChanged += new System.EventHandler(this.timeEnd_ValueChanged);
            // 
            // timeStart
            // 
            this.timeStart.Enabled = false;
            this.timeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(294, 216);
            this.timeStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(19, 30);
            this.timeStart.TabIndex = 165;
            this.timeStart.ValueChanged += new System.EventHandler(this.timeStart_ValueChanged);
            // 
            // radioButtonEnd
            // 
            this.radioButtonEnd.AutoSize = true;
            this.radioButtonEnd.Location = new System.Drawing.Point(178, 297);
            this.radioButtonEnd.Name = "radioButtonEnd";
            this.radioButtonEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonEnd.Size = new System.Drawing.Size(105, 17);
            this.radioButtonEnd.TabIndex = 164;
            this.radioButtonEnd.TabStop = true;
            this.radioButtonEnd.Text = "עדכן זמן הסיום";
            this.radioButtonEnd.UseVisualStyleBackColor = true;
            this.radioButtonEnd.Visible = false;
            this.radioButtonEnd.CheckedChanged += new System.EventHandler(this.radioButtonEnd_CheckedChanged);
            // 
            // radioButtonStart
            // 
            this.radioButtonStart.AutoSize = true;
            this.radioButtonStart.Location = new System.Drawing.Point(166, 198);
            this.radioButtonStart.Name = "radioButtonStart";
            this.radioButtonStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonStart.Size = new System.Drawing.Size(116, 17);
            this.radioButtonStart.TabIndex = 163;
            this.radioButtonStart.TabStop = true;
            this.radioButtonStart.Text = "עדכן זמן ההתחלה";
            this.radioButtonStart.UseVisualStyleBackColor = true;
            this.radioButtonStart.Visible = false;
            this.radioButtonStart.CheckedChanged += new System.EventHandler(this.radioButtonStart_CheckedChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEnd.Location = new System.Drawing.Point(578, 321);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEnd.Size = new System.Drawing.Size(92, 25);
            this.lblEnd.TabIndex = 157;
            this.lblEnd.Text = "שעת סיום:";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEnd.Location = new System.Drawing.Point(312, 316);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ReadOnly = true;
            this.txtEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEnd.Size = new System.Drawing.Size(260, 30);
            this.txtEnd.TabIndex = 156;
            // 
            // hintEnd
            // 
            this.hintEnd.ForeColor = System.Drawing.Color.Red;
            this.hintEnd.Location = new System.Drawing.Point(295, 301);
            this.hintEnd.Name = "hintEnd";
            this.hintEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintEnd.Size = new System.Drawing.Size(277, 13);
            this.hintEnd.TabIndex = 158;
            this.hintEnd.Text = "label5";
            this.hintEnd.Visible = false;
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtStart.Location = new System.Drawing.Point(309, 216);
            this.txtStart.Name = "txtStart";
            this.txtStart.ReadOnly = true;
            this.txtStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStart.Size = new System.Drawing.Size(263, 30);
            this.txtStart.TabIndex = 153;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStart.Location = new System.Drawing.Point(578, 219);
            this.lblStart.Name = "lblStart";
            this.lblStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStart.Size = new System.Drawing.Size(109, 25);
            this.lblStart.TabIndex = 152;
            this.lblStart.Text = "שעת התחלה:";
            // 
            // hintStart
            // 
            this.hintStart.ForeColor = System.Drawing.Color.Red;
            this.hintStart.Location = new System.Drawing.Point(294, 200);
            this.hintStart.Name = "hintStart";
            this.hintStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintStart.Size = new System.Drawing.Size(278, 13);
            this.hintStart.TabIndex = 154;
            this.hintStart.Text = "label3";
            this.hintStart.Visible = false;
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateEnd.Location = new System.Drawing.Point(295, 264);
            this.dateEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(18, 30);
            this.dateEnd.TabIndex = 151;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEndDate.Location = new System.Drawing.Point(578, 269);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEndDate.Size = new System.Drawing.Size(106, 25);
            this.lblEndDate.TabIndex = 147;
            this.lblEndDate.Text = "תאריך סיום:";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEndDate.Location = new System.Drawing.Point(312, 264);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEndDate.Size = new System.Drawing.Size(260, 30);
            this.txtEndDate.TabIndex = 146;
            // 
            // hintEndDate
            // 
            this.hintEndDate.ForeColor = System.Drawing.Color.Red;
            this.hintEndDate.Location = new System.Drawing.Point(295, 249);
            this.hintEndDate.Name = "hintEndDate";
            this.hintEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintEndDate.Size = new System.Drawing.Size(277, 13);
            this.hintEndDate.TabIndex = 149;
            this.hintEndDate.Text = "label4";
            this.hintEndDate.Visible = false;
            // 
            // dateStart
            // 
            this.dateStart.Enabled = false;
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateStart.Location = new System.Drawing.Point(294, 168);
            this.dateStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(19, 30);
            this.dateStart.TabIndex = 142;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(39, 49);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(69, 30);
            this.btnClean.TabIndex = 141;
            this.btnClean.Text = "נקה";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtStartDate.Location = new System.Drawing.Point(311, 168);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStartDate.Size = new System.Drawing.Size(261, 30);
            this.txtStartDate.TabIndex = 101;
            // 
            // txtZhot
            // 
            this.txtZhot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtZhot.Location = new System.Drawing.Point(295, 117);
            this.txtZhot.MaxLength = 9;
            this.txtZhot.Name = "txtZhot";
            this.txtZhot.ReadOnly = true;
            this.txtZhot.Size = new System.Drawing.Size(277, 30);
            this.txtZhot.TabIndex = 100;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStartDate.Location = new System.Drawing.Point(578, 168);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStartDate.Size = new System.Drawing.Size(123, 25);
            this.lblStartDate.TabIndex = 96;
            this.lblStartDate.Text = "תאריך התחלה:";
            // 
            // lblZhot
            // 
            this.lblZhot.AutoSize = true;
            this.lblZhot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblZhot.Location = new System.Drawing.Point(578, 122);
            this.lblZhot.Name = "lblZhot";
            this.lblZhot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblZhot.Size = new System.Drawing.Size(109, 25);
            this.lblZhot.TabIndex = 95;
            this.lblZhot.Text = "תעודת זהות:";
            // 
            // comboSearch
            // 
            this.comboSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSearch.BackColor = System.Drawing.Color.White;
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.IntegralHeight = false;
            this.comboSearch.ItemHeight = 25;
            this.comboSearch.Items.AddRange(new object[] {
            "- בחר -"});
            this.comboSearch.Location = new System.Drawing.Point(295, 14);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboSearch.Size = new System.Drawing.Size(308, 33);
            this.comboSearch.TabIndex = 0;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(607, 49);
            this.btnSearch.MaximumSize = new System.Drawing.Size(92, 30);
            this.btnSearch.MinimumSize = new System.Drawing.Size(92, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "חפש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearch.Location = new System.Drawing.Point(295, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(308, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSearch.Location = new System.Drawing.Point(607, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(97, 25);
            this.lblSearch.TabIndex = 79;
            this.lblSearch.Text = "חיפוש לפי:";
            // 
            // hintStartDate
            // 
            this.hintStartDate.ForeColor = System.Drawing.Color.Red;
            this.hintStartDate.Location = new System.Drawing.Point(295, 150);
            this.hintStartDate.Name = "hintStartDate";
            this.hintStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintStartDate.Size = new System.Drawing.Size(277, 13);
            this.hintStartDate.TabIndex = 126;
            this.hintStartDate.Text = "label2";
            this.hintStartDate.Visible = false;
            // 
            // hintZhot
            // 
            this.hintZhot.ForeColor = System.Drawing.Color.Red;
            this.hintZhot.Location = new System.Drawing.Point(295, 103);
            this.hintZhot.Name = "hintZhot";
            this.hintZhot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintZhot.Size = new System.Drawing.Size(277, 13);
            this.hintZhot.TabIndex = 125;
            this.hintZhot.Text = "label1";
            this.hintZhot.Visible = false;
            // 
            // splSeparate
            // 
            this.splSeparate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splSeparate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splSeparate.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splSeparate.Dock = System.Windows.Forms.DockStyle.Top;
            this.splSeparate.Enabled = false;
            this.splSeparate.Location = new System.Drawing.Point(0, 286);
            this.splSeparate.Margin = new System.Windows.Forms.Padding(2);
            this.splSeparate.MinimumSize = new System.Drawing.Size(1126, 4);
            this.splSeparate.Name = "splSeparate";
            this.splSeparate.Size = new System.Drawing.Size(1364, 5);
            this.splSeparate.TabIndex = 108;
            this.splSeparate.TabStop = false;
            // 
            // pnlTables
            // 
            this.pnlTables.Controls.Add(this.pnlData);
            this.pnlTables.Controls.Add(this.pnlResult);
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTables.Location = new System.Drawing.Point(0, 0);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(1364, 286);
            this.pnlTables.TabIndex = 106;
            // 
            // pnlResultButtons
            // 
            this.pnlResultButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResultButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlResultButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResultButtons.Controls.Add(this.lblSearchQuantity);
            this.pnlResultButtons.Controls.Add(this.btnLast);
            this.pnlResultButtons.Controls.Add(this.btnFirst);
            this.pnlResultButtons.Controls.Add(this.btnNext);
            this.pnlResultButtons.Controls.Add(this.btnPrevious);
            this.pnlResultButtons.Location = new System.Drawing.Point(35, 16);
            this.pnlResultButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlResultButtons.MaximumSize = new System.Drawing.Size(446, 131);
            this.pnlResultButtons.MinimumSize = new System.Drawing.Size(446, 131);
            this.pnlResultButtons.Name = "pnlResultButtons";
            this.pnlResultButtons.Size = new System.Drawing.Size(446, 131);
            this.pnlResultButtons.TabIndex = 104;
            this.pnlResultButtons.Visible = false;
            // 
            // lblSearchQuantity
            // 
            this.lblSearchQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSearchQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSearchQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSearchQuantity.Location = new System.Drawing.Point(0, 0);
            this.lblSearchQuantity.Name = "lblSearchQuantity";
            this.lblSearchQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchQuantity.Size = new System.Drawing.Size(442, 49);
            this.lblSearchQuantity.TabIndex = 99;
            this.lblSearchQuantity.Text = "ציוד: X מתוך Y";
            this.lblSearchQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(25, 78);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(88, 35);
            this.btnLast.TabIndex = 14;
            this.btnLast.Text = "האחרון";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(334, 78);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(88, 35);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "הראשון";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(119, 78);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 35);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(240, 78);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(88, 35);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "הקודם";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // splMoveRight
            // 
            this.splMoveRight.Location = new System.Drawing.Point(0, 291);
            this.splMoveRight.Margin = new System.Windows.Forms.Padding(2);
            this.splMoveRight.Name = "splMoveRight";
            this.splMoveRight.Size = new System.Drawing.Size(44, 431);
            this.splMoveRight.TabIndex = 110;
            this.splMoveRight.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.pnlResultButtons);
            this.pnlButtons.Controls.Add(this.pnlUpperActionButtons);
            this.pnlButtons.Controls.Add(this.pnlLowerActionButtons);
            this.pnlButtons.Controls.Add(this.splMoveUp);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(44, 291);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(594, 431);
            this.pnlButtons.TabIndex = 109;
            // 
            // mishmarotTableAdapter
            // 
            this.mishmarotTableAdapter.ClearBeforeFill = true;
            // 
            // MishmarotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1364, 722);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTexts);
            this.Controls.Add(this.splMoveRight);
            this.Controls.Add(this.splSeparate);
            this.Controls.Add(this.pnlTables);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MishmarotForm";
            this.Text = "DoctorNursesForm";
            this.Load += new System.EventHandler(this.MishmarotForm_Load);
            this.SizeChanged += new System.EventHandler(this.MishmarotForm_SizeChanged);
            this.pnlResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.pnlUpperActionButtons.ResumeLayout(false);
            this.pnlLowerActionButtons.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            this.pnlTexts.ResumeLayout(false);
            this.pnlTexts.PerformLayout();
            this.pnlTables.ResumeLayout(false);
            this.pnlResultButtons.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splMoveUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Button btnCloseSrch;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Splitter splResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Splitter splHalf;
        private System.Windows.Forms.Panel pnlUpperActionButtons;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel pnlLowerActionButtons;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Splitter splData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel pnlTexts;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Splitter splSeparate;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.Panel pnlResultButtons;
        private System.Windows.Forms.Label lblSearchQuantity;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Splitter splMoveRight;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TextBox txtZhot;
        private System.Windows.Forms.Label lblZhot;
        //private HospitalDataSet hospitalDataSet;
        //private HospitalDataSetTableAdapters.DoctorsNursesTableAdapter doctorsNursesTableAdapter;      
        private System.Windows.Forms.Label hintZhot;
        private System.Windows.Forms.Label hintStartDate;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label hintEndDate;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource mishmarotBindingSource;
        private HospitalDataSetTableAdapters.MishmarotTableAdapter mishmarotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label hintEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label hintStart;
        private System.Windows.Forms.RadioButton radioButtonEnd;
        private System.Windows.Forms.RadioButton radioButtonStart;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}