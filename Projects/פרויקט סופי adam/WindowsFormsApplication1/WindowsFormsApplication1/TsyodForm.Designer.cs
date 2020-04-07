namespace WindowsFormsApplication1
{
    partial class TsyodForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearch = new System.Windows.Forms.Label();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtKhevra = new System.Windows.Forms.TextBox();
            this.txtShimosh = new System.Windows.Forms.TextBox();
            this.txtKamot = new System.Windows.Forms.TextBox();
            this.txtSapak = new System.Windows.Forms.TextBox();
            this.lblKhevra = new System.Windows.Forms.Label();
            this.lblShimosh = new System.Windows.Forms.Label();
            this.lblKamot = new System.Windows.Forms.Label();
            this.lblSapak = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.misparDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shimoshDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khevraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsyodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new WindowsFormsApplication1.HospitalDataSet();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnCloseSrch = new System.Windows.Forms.Button();
            this.splResult = new System.Windows.Forms.Splitter();
            this.lblResult = new System.Windows.Forms.Label();
            this.splHalf = new System.Windows.Forms.Splitter();
            this.pnlUpperActionButtons = new System.Windows.Forms.Panel();
            this.pnlLowerActionButtons = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.splData = new System.Windows.Forms.Splitter();
            this.lblData = new System.Windows.Forms.Label();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.pnlTexts = new System.Windows.Forms.Panel();
            this.hintKhevra = new System.Windows.Forms.Label();
            this.hintPrice = new System.Windows.Forms.Label();
            this.txtMispar = new System.Windows.Forms.TextBox();
            this.lblMispar = new System.Windows.Forms.Label();
            this.hintMispar = new System.Windows.Forms.Label();
            this.txtShem = new System.Windows.Forms.TextBox();
            this.lblShem = new System.Windows.Forms.Label();
            this.hintShem = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.hintSapak = new System.Windows.Forms.Label();
            this.hintKamot = new System.Windows.Forms.Label();
            this.hintShimosh = new System.Windows.Forms.Label();
            this.splSeparate = new System.Windows.Forms.Splitter();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlResultButtons = new System.Windows.Forms.Panel();
            this.lblSearchQuantity = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.splMoveUp = new System.Windows.Forms.Splitter();
            this.splMoveRight = new System.Windows.Forms.Splitter();
            this.tsyodTableAdapter = new WindowsFormsApplication1.HospitalDataSetTableAdapters.TsyodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsyodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.pnlResult.SuspendLayout();
            this.pnlUpperActionButtons.SuspendLayout();
            this.pnlLowerActionButtons.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlTables.SuspendLayout();
            this.pnlTexts.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlResultButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSearch.Location = new System.Drawing.Point(797, 26);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(124, 29);
            this.lblSearch.TabIndex = 79;
            this.lblSearch.Text = "חיפוש לפי:";
            // 
            // comboSearch
            // 
            this.comboSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSearch.BackColor = System.Drawing.Color.White;
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "- בחר -"});
            this.comboSearch.Location = new System.Drawing.Point(381, 23);
            this.comboSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboSearch.Size = new System.Drawing.Size(409, 37);
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
            this.btnSearch.Location = new System.Drawing.Point(797, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.MaximumSize = new System.Drawing.Size(123, 37);
            this.btnSearch.MinimumSize = new System.Drawing.Size(123, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 37);
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
            this.txtSearch.Location = new System.Drawing.Point(381, 66);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.Size = new System.Drawing.Size(409, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
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
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(381, 85);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "עדכן";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDel.Location = new System.Drawing.Point(191, 0);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(191, 85);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "מחק";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 85);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 36);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "🔃";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtKhevra
            // 
            this.txtKhevra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhevra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKhevra.Location = new System.Drawing.Point(381, 480);
            this.txtKhevra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKhevra.Name = "txtKhevra";
            this.txtKhevra.ReadOnly = true;
            this.txtKhevra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKhevra.Size = new System.Drawing.Size(409, 36);
            this.txtKhevra.TabIndex = 10;
            // 
            // txtShimosh
            // 
            this.txtShimosh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShimosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtShimosh.Location = new System.Drawing.Point(381, 423);
            this.txtShimosh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtShimosh.Name = "txtShimosh";
            this.txtShimosh.ReadOnly = true;
            this.txtShimosh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtShimosh.Size = new System.Drawing.Size(409, 36);
            this.txtShimosh.TabIndex = 9;
            // 
            // txtKamot
            // 
            this.txtKamot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKamot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKamot.Location = new System.Drawing.Point(381, 313);
            this.txtKamot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKamot.MaxLength = 5;
            this.txtKamot.Name = "txtKamot";
            this.txtKamot.ReadOnly = true;
            this.txtKamot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKamot.Size = new System.Drawing.Size(409, 36);
            this.txtKamot.TabIndex = 7;
            this.txtKamot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKamot_KeyPress);
            // 
            // txtSapak
            // 
            this.txtSapak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSapak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSapak.Location = new System.Drawing.Point(381, 258);
            this.txtSapak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSapak.Name = "txtSapak";
            this.txtSapak.ReadOnly = true;
            this.txtSapak.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSapak.Size = new System.Drawing.Size(409, 36);
            this.txtSapak.TabIndex = 6;
            // 
            // lblKhevra
            // 
            this.lblKhevra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhevra.AutoSize = true;
            this.lblKhevra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblKhevra.Location = new System.Drawing.Point(797, 480);
            this.lblKhevra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhevra.Name = "lblKhevra";
            this.lblKhevra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblKhevra.Size = new System.Drawing.Size(77, 29);
            this.lblKhevra.TabIndex = 66;
            this.lblKhevra.Text = "חברה:";
            // 
            // lblShimosh
            // 
            this.lblShimosh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShimosh.AutoSize = true;
            this.lblShimosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblShimosh.Location = new System.Drawing.Point(803, 426);
            this.lblShimosh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShimosh.Name = "lblShimosh";
            this.lblShimosh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblShimosh.Size = new System.Drawing.Size(85, 29);
            this.lblShimosh.TabIndex = 65;
            this.lblShimosh.Text = "שימוש:";
            // 
            // lblKamot
            // 
            this.lblKamot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKamot.AutoSize = true;
            this.lblKamot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblKamot.Location = new System.Drawing.Point(797, 313);
            this.lblKamot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKamot.Name = "lblKamot";
            this.lblKamot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblKamot.Size = new System.Drawing.Size(71, 29);
            this.lblKamot.TabIndex = 64;
            this.lblKamot.Text = "כמות:";
            // 
            // lblSapak
            // 
            this.lblSapak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSapak.AutoSize = true;
            this.lblSapak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSapak.Location = new System.Drawing.Point(799, 260);
            this.lblSapak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSapak.Name = "lblSapak";
            this.lblSapak.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSapak.Size = new System.Drawing.Size(63, 29);
            this.lblSapak.TabIndex = 63;
            this.lblSapak.Text = "ספק:";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.misparDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.spakDataGridViewTextBoxColumn,
            this.kamotDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.shimoshDataGridViewTextBoxColumn,
            this.khevraDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tsyodBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 41);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(930, 311);
            this.dataGridView.TabIndex = 22;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // misparDataGridViewTextBoxColumn
            // 
            this.misparDataGridViewTextBoxColumn.DataPropertyName = "mispar";
            this.misparDataGridViewTextBoxColumn.HeaderText = "מספר";
            this.misparDataGridViewTextBoxColumn.Name = "misparDataGridViewTextBoxColumn";
            this.misparDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "שם";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spakDataGridViewTextBoxColumn
            // 
            this.spakDataGridViewTextBoxColumn.DataPropertyName = "spak";
            this.spakDataGridViewTextBoxColumn.HeaderText = "ספק";
            this.spakDataGridViewTextBoxColumn.Name = "spakDataGridViewTextBoxColumn";
            this.spakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kamotDataGridViewTextBoxColumn
            // 
            this.kamotDataGridViewTextBoxColumn.DataPropertyName = "kamot";
            this.kamotDataGridViewTextBoxColumn.HeaderText = "כמות";
            this.kamotDataGridViewTextBoxColumn.Name = "kamotDataGridViewTextBoxColumn";
            this.kamotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "מחיר";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shimoshDataGridViewTextBoxColumn
            // 
            this.shimoshDataGridViewTextBoxColumn.DataPropertyName = "shimosh";
            this.shimoshDataGridViewTextBoxColumn.HeaderText = "שימוש";
            this.shimoshDataGridViewTextBoxColumn.Name = "shimoshDataGridViewTextBoxColumn";
            this.shimoshDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // khevraDataGridViewTextBoxColumn
            // 
            this.khevraDataGridViewTextBoxColumn.DataPropertyName = "khevra";
            this.khevraDataGridViewTextBoxColumn.HeaderText = "חברה";
            this.khevraDataGridViewTextBoxColumn.Name = "khevraDataGridViewTextBoxColumn";
            this.khevraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsyodBindingSource
            // 
            this.tsyodBindingSource.DataMember = "Tsyod";
            this.tsyodBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAccept.Location = new System.Drawing.Point(382, 0);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(191, 85);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "אישור";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResult.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 41);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewResult.MultiSelect = false;
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(884, 311);
            this.dataGridViewResult.TabIndex = 23;
            this.dataGridViewResult.SelectionChanged += new System.EventHandler(this.dataGridViewResult_SelectionChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(381, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 85);
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
            this.pnlResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(889, 352);
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
            this.btnCloseSrch.Location = new System.Drawing.Point(3, 2);
            this.btnCloseSrch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseSrch.Name = "btnCloseSrch";
            this.btnCloseSrch.Size = new System.Drawing.Size(85, 33);
            this.btnCloseSrch.TabIndex = 21;
            this.btnCloseSrch.Text = "סגור";
            this.btnCloseSrch.UseVisualStyleBackColor = false;
            this.btnCloseSrch.Click += new System.EventHandler(this.btnCloseSrch_Click);
            // 
            // splResult
            // 
            this.splResult.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.splResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.splResult.Enabled = false;
            this.splResult.Location = new System.Drawing.Point(0, 37);
            this.splResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splResult.Name = "splResult";
            this.splResult.Size = new System.Drawing.Size(884, 4);
            this.splResult.TabIndex = 83;
            this.splResult.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResult.Location = new System.Drawing.Point(0, 0);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(884, 37);
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
            this.splHalf.Location = new System.Drawing.Point(884, 0);
            this.splHalf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splHalf.Name = "splHalf";
            this.splHalf.Size = new System.Drawing.Size(5, 352);
            this.splHalf.TabIndex = 84;
            this.splHalf.TabStop = false;
            this.splHalf.Visible = false;
            // 
            // pnlUpperActionButtons
            // 
            this.pnlUpperActionButtons.Controls.Add(this.btnAccept);
            this.pnlUpperActionButtons.Controls.Add(this.btnDel);
            this.pnlUpperActionButtons.Controls.Add(this.btnAdd);
            this.pnlUpperActionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpperActionButtons.Location = new System.Drawing.Point(0, 337);
            this.pnlUpperActionButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUpperActionButtons.Name = "pnlUpperActionButtons";
            this.pnlUpperActionButtons.Size = new System.Drawing.Size(786, 85);
            this.pnlUpperActionButtons.TabIndex = 84;
            // 
            // pnlLowerActionButtons
            // 
            this.pnlLowerActionButtons.Controls.Add(this.btnCancel);
            this.pnlLowerActionButtons.Controls.Add(this.btnUpdate);
            this.pnlLowerActionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLowerActionButtons.Location = new System.Drawing.Point(0, 422);
            this.pnlLowerActionButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLowerActionButtons.Name = "pnlLowerActionButtons";
            this.pnlLowerActionButtons.Size = new System.Drawing.Size(786, 85);
            this.pnlLowerActionButtons.TabIndex = 85;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPrice.Location = new System.Drawing.Point(381, 369);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(409, 36);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.Location = new System.Drawing.Point(797, 369);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(71, 29);
            this.lblPrice.TabIndex = 87;
            this.lblPrice.Text = "מחיר:";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dataGridView);
            this.pnlData.Controls.Add(this.btnRefresh);
            this.pnlData.Controls.Add(this.splData);
            this.pnlData.Controls.Add(this.lblData);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(889, 0);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(930, 352);
            this.pnlData.TabIndex = 91;
            // 
            // splData
            // 
            this.splData.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splData.Cursor = System.Windows.Forms.Cursors.Default;
            this.splData.Dock = System.Windows.Forms.DockStyle.Top;
            this.splData.Enabled = false;
            this.splData.Location = new System.Drawing.Point(0, 37);
            this.splData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splData.Name = "splData";
            this.splData.Size = new System.Drawing.Size(930, 4);
            this.splData.TabIndex = 63;
            this.splData.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblData.Location = new System.Drawing.Point(0, 0);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(930, 37);
            this.lblData.TabIndex = 62;
            this.lblData.Text = "טבלת הציוד";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTables
            // 
            this.pnlTables.Controls.Add(this.pnlData);
            this.pnlTables.Controls.Add(this.pnlResult);
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTables.Location = new System.Drawing.Point(0, 0);
            this.pnlTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(1819, 352);
            this.pnlTables.TabIndex = 92;
            // 
            // pnlTexts
            // 
            this.pnlTexts.BackColor = System.Drawing.Color.Transparent;
            this.pnlTexts.Controls.Add(this.hintKhevra);
            this.pnlTexts.Controls.Add(this.hintPrice);
            this.pnlTexts.Controls.Add(this.txtMispar);
            this.pnlTexts.Controls.Add(this.lblMispar);
            this.pnlTexts.Controls.Add(this.hintMispar);
            this.pnlTexts.Controls.Add(this.txtShem);
            this.pnlTexts.Controls.Add(this.lblShem);
            this.pnlTexts.Controls.Add(this.hintShem);
            this.pnlTexts.Controls.Add(this.btnClean);
            this.pnlTexts.Controls.Add(this.comboSearch);
            this.pnlTexts.Controls.Add(this.lblKamot);
            this.pnlTexts.Controls.Add(this.txtKhevra);
            this.pnlTexts.Controls.Add(this.txtKamot);
            this.pnlTexts.Controls.Add(this.btnSearch);
            this.pnlTexts.Controls.Add(this.txtSearch);
            this.pnlTexts.Controls.Add(this.lblKhevra);
            this.pnlTexts.Controls.Add(this.lblSapak);
            this.pnlTexts.Controls.Add(this.txtShimosh);
            this.pnlTexts.Controls.Add(this.lblShimosh);
            this.pnlTexts.Controls.Add(this.lblPrice);
            this.pnlTexts.Controls.Add(this.txtPrice);
            this.pnlTexts.Controls.Add(this.lblSearch);
            this.pnlTexts.Controls.Add(this.txtSapak);
            this.pnlTexts.Controls.Add(this.hintSapak);
            this.pnlTexts.Controls.Add(this.hintKamot);
            this.pnlTexts.Controls.Add(this.hintShimosh);
            this.pnlTexts.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTexts.Location = new System.Drawing.Point(851, 357);
            this.pnlTexts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTexts.Name = "pnlTexts";
            this.pnlTexts.Size = new System.Drawing.Size(968, 532);
            this.pnlTexts.TabIndex = 94;
            // 
            // hintKhevra
            // 
            this.hintKhevra.ForeColor = System.Drawing.Color.Red;
            this.hintKhevra.Location = new System.Drawing.Point(509, 460);
            this.hintKhevra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintKhevra.Name = "hintKhevra";
            this.hintKhevra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintKhevra.Size = new System.Drawing.Size(285, 16);
            this.hintKhevra.TabIndex = 161;
            this.hintKhevra.Text = "label5";
            this.hintKhevra.Visible = false;
            // 
            // hintPrice
            // 
            this.hintPrice.ForeColor = System.Drawing.Color.Red;
            this.hintPrice.Location = new System.Drawing.Point(509, 351);
            this.hintPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintPrice.Name = "hintPrice";
            this.hintPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintPrice.Size = new System.Drawing.Size(285, 16);
            this.hintPrice.TabIndex = 159;
            this.hintPrice.Text = "label5";
            this.hintPrice.Visible = false;
            // 
            // txtMispar
            // 
            this.txtMispar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMispar.Location = new System.Drawing.Point(381, 142);
            this.txtMispar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMispar.Name = "txtMispar";
            this.txtMispar.ReadOnly = true;
            this.txtMispar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMispar.Size = new System.Drawing.Size(409, 36);
            this.txtMispar.TabIndex = 155;
            // 
            // lblMispar
            // 
            this.lblMispar.AutoSize = true;
            this.lblMispar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMispar.Location = new System.Drawing.Point(803, 142);
            this.lblMispar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMispar.Name = "lblMispar";
            this.lblMispar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMispar.Size = new System.Drawing.Size(77, 29);
            this.lblMispar.TabIndex = 154;
            this.lblMispar.Text = "מספר:";
            // 
            // hintMispar
            // 
            this.hintMispar.ForeColor = System.Drawing.Color.Red;
            this.hintMispar.Location = new System.Drawing.Point(512, 122);
            this.hintMispar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintMispar.Name = "hintMispar";
            this.hintMispar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintMispar.Size = new System.Drawing.Size(285, 16);
            this.hintMispar.TabIndex = 156;
            this.hintMispar.Text = "label1";
            this.hintMispar.Visible = false;
            // 
            // txtShem
            // 
            this.txtShem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtShem.Location = new System.Drawing.Point(381, 199);
            this.txtShem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtShem.Name = "txtShem";
            this.txtShem.ReadOnly = true;
            this.txtShem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShem.Size = new System.Drawing.Size(409, 36);
            this.txtShem.TabIndex = 152;
            // 
            // lblShem
            // 
            this.lblShem.AutoSize = true;
            this.lblShem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblShem.Location = new System.Drawing.Point(803, 199);
            this.lblShem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShem.Name = "lblShem";
            this.lblShem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblShem.Size = new System.Drawing.Size(52, 29);
            this.lblShem.TabIndex = 151;
            this.lblShem.Text = "שם:";
            // 
            // hintShem
            // 
            this.hintShem.ForeColor = System.Drawing.Color.Red;
            this.hintShem.Location = new System.Drawing.Point(512, 181);
            this.hintShem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintShem.Name = "hintShem";
            this.hintShem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintShem.Size = new System.Drawing.Size(285, 16);
            this.hintShem.TabIndex = 153;
            this.hintShem.Text = "label2";
            this.hintShem.Visible = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(52, 60);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(92, 37);
            this.btnClean.TabIndex = 142;
            this.btnClean.Text = "נקה";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // hintSapak
            // 
            this.hintSapak.ForeColor = System.Drawing.Color.Red;
            this.hintSapak.Location = new System.Drawing.Point(509, 239);
            this.hintSapak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintSapak.Name = "hintSapak";
            this.hintSapak.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintSapak.Size = new System.Drawing.Size(285, 16);
            this.hintSapak.TabIndex = 157;
            this.hintSapak.Text = "label3";
            this.hintSapak.Visible = false;
            // 
            // hintKamot
            // 
            this.hintKamot.ForeColor = System.Drawing.Color.Red;
            this.hintKamot.Location = new System.Drawing.Point(509, 295);
            this.hintKamot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintKamot.Name = "hintKamot";
            this.hintKamot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintKamot.Size = new System.Drawing.Size(285, 16);
            this.hintKamot.TabIndex = 158;
            this.hintKamot.Text = "label4";
            this.hintKamot.Visible = false;
            // 
            // hintShimosh
            // 
            this.hintShimosh.ForeColor = System.Drawing.Color.Red;
            this.hintShimosh.Location = new System.Drawing.Point(509, 404);
            this.hintShimosh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintShimosh.Name = "hintShimosh";
            this.hintShimosh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hintShimosh.Size = new System.Drawing.Size(285, 16);
            this.hintShimosh.TabIndex = 160;
            this.hintShimosh.Text = "label5";
            this.hintShimosh.Visible = false;
            // 
            // splSeparate
            // 
            this.splSeparate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splSeparate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splSeparate.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splSeparate.Dock = System.Windows.Forms.DockStyle.Top;
            this.splSeparate.Enabled = false;
            this.splSeparate.Location = new System.Drawing.Point(0, 352);
            this.splSeparate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splSeparate.MinimumSize = new System.Drawing.Size(1500, 4);
            this.splSeparate.Name = "splSeparate";
            this.splSeparate.Size = new System.Drawing.Size(1819, 5);
            this.splSeparate.TabIndex = 95;
            this.splSeparate.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.pnlResultButtons);
            this.pnlButtons.Controls.Add(this.pnlUpperActionButtons);
            this.pnlButtons.Controls.Add(this.pnlLowerActionButtons);
            this.pnlButtons.Controls.Add(this.splMoveUp);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(65, 357);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(786, 532);
            this.pnlButtons.TabIndex = 98;
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
            this.pnlResultButtons.Location = new System.Drawing.Point(47, 20);
            this.pnlResultButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResultButtons.MaximumSize = new System.Drawing.Size(593, 160);
            this.pnlResultButtons.MinimumSize = new System.Drawing.Size(593, 160);
            this.pnlResultButtons.Name = "pnlResultButtons";
            this.pnlResultButtons.Size = new System.Drawing.Size(593, 160);
            this.pnlResultButtons.TabIndex = 106;
            this.pnlResultButtons.Visible = false;
            // 
            // lblSearchQuantity
            // 
            this.lblSearchQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSearchQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSearchQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSearchQuantity.Location = new System.Drawing.Point(0, 0);
            this.lblSearchQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchQuantity.Name = "lblSearchQuantity";
            this.lblSearchQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchQuantity.Size = new System.Drawing.Size(589, 60);
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
            this.btnLast.Location = new System.Drawing.Point(33, 96);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(117, 43);
            this.btnLast.TabIndex = 14;
            this.btnLast.Text = "האחרון";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(445, 96);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(117, 43);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "הראשון";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(159, 96);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 43);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(320, 96);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(117, 43);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "הקודם";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // splMoveUp
            // 
            this.splMoveUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splMoveUp.Location = new System.Drawing.Point(0, 507);
            this.splMoveUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splMoveUp.Name = "splMoveUp";
            this.splMoveUp.Size = new System.Drawing.Size(786, 25);
            this.splMoveUp.TabIndex = 105;
            this.splMoveUp.TabStop = false;
            // 
            // splMoveRight
            // 
            this.splMoveRight.Location = new System.Drawing.Point(0, 357);
            this.splMoveRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splMoveRight.Name = "splMoveRight";
            this.splMoveRight.Size = new System.Drawing.Size(65, 532);
            this.splMoveRight.TabIndex = 105;
            this.splMoveRight.TabStop = false;
            // 
            // tsyodTableAdapter
            // 
            this.tsyodTableAdapter.ClearBeforeFill = true;
            // 
            // TsyodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1819, 889);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTexts);
            this.Controls.Add(this.splMoveRight);
            this.Controls.Add(this.splSeparate);
            this.Controls.Add(this.pnlTables);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TsyodForm";
            this.Text = "TsyodForm";
            this.Load += new System.EventHandler(this.TsyodForm_Load);
            this.SizeChanged += new System.EventHandler(this.TsyodForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsyodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.pnlUpperActionButtons.ResumeLayout(false);
            this.pnlLowerActionButtons.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlTables.ResumeLayout(false);
            this.pnlTexts.ResumeLayout(false);
            this.pnlTexts.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlResultButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtKhevra;
        private System.Windows.Forms.TextBox txtShimosh;
        private System.Windows.Forms.TextBox txtKamot;
        private System.Windows.Forms.TextBox txtSapak;
        private System.Windows.Forms.Label lblKhevra;
        private System.Windows.Forms.Label lblShimosh;
        private System.Windows.Forms.Label lblKamot;
        private System.Windows.Forms.Label lblSapak;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Panel pnlUpperActionButtons;
        private System.Windows.Forms.Panel pnlLowerActionButtons;
        //private System.Windows.Forms.DataGridViewImageColumn khevraDataGridViewImageColumn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Splitter splResult;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Splitter splData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.Panel pnlTexts;
        private System.Windows.Forms.Splitter splSeparate;
        private System.Windows.Forms.Splitter splHalf;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCloseSrch;
        private System.Windows.Forms.Splitter splMoveRight;
        private System.Windows.Forms.Splitter splMoveUp;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource tsyodBindingSource;
        private HospitalDataSetTableAdapters.TsyodTableAdapter tsyodTableAdapter;
        private System.Windows.Forms.Panel pnlResultButtons;
        private System.Windows.Forms.Label lblSearchQuantity;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shimoshDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khevraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtMispar;
        private System.Windows.Forms.Label lblMispar;
        private System.Windows.Forms.Label hintMispar;
        private System.Windows.Forms.TextBox txtShem;
        private System.Windows.Forms.Label lblShem;
        private System.Windows.Forms.Label hintShem;
        private System.Windows.Forms.Label hintSapak;
        private System.Windows.Forms.Label hintPrice;
        private System.Windows.Forms.Label hintKamot;
        private System.Windows.Forms.Label hintKhevra;
        private System.Windows.Forms.Label hintShimosh;
    }
}