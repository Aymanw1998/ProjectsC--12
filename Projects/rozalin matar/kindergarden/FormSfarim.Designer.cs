namespace kindergarden
{
    partial class FormSfarim
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
        /// Required method for Designer support - do not Modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_sfarim = new System.Windows.Forms.DataGridView();
            this.booksNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBorrowingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDOfBorrowingKidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfarimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergardenDataSet = new kindergarden.kindergardenDataSet();
            this.sfarimTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.sfarimTableAdapter();
            this.lbl_dateToReturn = new System.Windows.Forms.Label();
            this.lbl_dateOfBorrowing = new System.Windows.Forms.Label();
            this.lbl_nameB = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_booksName = new System.Windows.Forms.TextBox();
            this.MoP_toReturn = new System.Windows.Forms.DateTimePicker();
            this.MoP_borrowing = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_rf = new System.Windows.Forms.Button();
            this.pnl_results = new System.Windows.Forms.Panel();
            this.btn_closeResults = new System.Windows.Forms.Button();
            this.dataGridView_search = new System.Windows.Forms.DataGridView();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_sfarim = new System.Windows.Forms.ComboBox();
            this.txt_IDBorrowingKid = new System.Windows.Forms.MaskedTextBox();
            this.pnl_up = new System.Windows.Forms.Panel();
            this.pnl_table = new System.Windows.Forms.Panel();
            this.pnl_sadot = new System.Windows.Forms.Panel();
            this.lbl_n = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sfarim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfarimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).BeginInit();
            this.pnl_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).BeginInit();
            this.pnl_up.SuspendLayout();
            this.pnl_table.SuspendLayout();
            this.pnl_sadot.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_sfarim
            // 
            this.dataGridView_sfarim.AllowUserToAddRows = false;
            this.dataGridView_sfarim.AllowUserToDeleteRows = false;
            this.dataGridView_sfarim.AllowUserToResizeColumns = false;
            this.dataGridView_sfarim.AllowUserToResizeRows = false;
            this.dataGridView_sfarim.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_sfarim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_sfarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sfarim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booksNameDataGridViewTextBoxColumn,
            this.dateOfBorrowingDataGridViewTextBoxColumn,
            this.dateToReturnDataGridViewTextBoxColumn,
            this.iDOfBorrowingKidDataGridViewTextBoxColumn});
            this.dataGridView_sfarim.DataSource = this.sfarimBindingSource;
            this.dataGridView_sfarim.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_sfarim.Enabled = false;
            this.dataGridView_sfarim.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_sfarim.Name = "dataGridView_sfarim";
            this.dataGridView_sfarim.Size = new System.Drawing.Size(444, 257);
            this.dataGridView_sfarim.TabIndex = 0;
            // 
            // booksNameDataGridViewTextBoxColumn
            // 
            this.booksNameDataGridViewTextBoxColumn.DataPropertyName = "book\'s name";
            this.booksNameDataGridViewTextBoxColumn.HeaderText = "book\'s name";
            this.booksNameDataGridViewTextBoxColumn.Name = "booksNameDataGridViewTextBoxColumn";
            // 
            // dateOfBorrowingDataGridViewTextBoxColumn
            // 
            this.dateOfBorrowingDataGridViewTextBoxColumn.DataPropertyName = "date of borrowing";
            this.dateOfBorrowingDataGridViewTextBoxColumn.HeaderText = "date of borrowing";
            this.dateOfBorrowingDataGridViewTextBoxColumn.Name = "dateOfBorrowingDataGridViewTextBoxColumn";
            // 
            // dateToReturnDataGridViewTextBoxColumn
            // 
            this.dateToReturnDataGridViewTextBoxColumn.DataPropertyName = "date to return";
            this.dateToReturnDataGridViewTextBoxColumn.HeaderText = "date to return";
            this.dateToReturnDataGridViewTextBoxColumn.Name = "dateToReturnDataGridViewTextBoxColumn";
            // 
            // iDOfBorrowingKidDataGridViewTextBoxColumn
            // 
            this.iDOfBorrowingKidDataGridViewTextBoxColumn.DataPropertyName = "ID of borrowing kid";
            this.iDOfBorrowingKidDataGridViewTextBoxColumn.HeaderText = "ID of borrowing kid";
            this.iDOfBorrowingKidDataGridViewTextBoxColumn.Name = "iDOfBorrowingKidDataGridViewTextBoxColumn";
            // 
            // sfarimBindingSource
            // 
            this.sfarimBindingSource.DataMember = "sfarim";
            this.sfarimBindingSource.DataSource = this.kindergardenDataSet;
            // 
            // kindergardenDataSet
            // 
            this.kindergardenDataSet.DataSetName = "kindergardenDataSet";
            this.kindergardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sfarimTableAdapter
            // 
            this.sfarimTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_dateToReturn
            // 
            this.lbl_dateToReturn.AutoSize = true;
            this.lbl_dateToReturn.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_dateToReturn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dateToReturn.Location = new System.Drawing.Point(16, 84);
            this.lbl_dateToReturn.Name = "lbl_dateToReturn";
            this.lbl_dateToReturn.Size = new System.Drawing.Size(110, 16);
            this.lbl_dateToReturn.TabIndex = 28;
            this.lbl_dateToReturn.Text = "Date to return";
            // 
            // lbl_dateOfBorrowing
            // 
            this.lbl_dateOfBorrowing.AutoSize = true;
            this.lbl_dateOfBorrowing.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_dateOfBorrowing.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dateOfBorrowing.Location = new System.Drawing.Point(16, 55);
            this.lbl_dateOfBorrowing.Name = "lbl_dateOfBorrowing";
            this.lbl_dateOfBorrowing.Size = new System.Drawing.Size(137, 16);
            this.lbl_dateOfBorrowing.TabIndex = 27;
            this.lbl_dateOfBorrowing.Text = "Date of borrowing";
            // 
            // lbl_nameB
            // 
            this.lbl_nameB.AutoSize = true;
            this.lbl_nameB.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_nameB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nameB.Location = new System.Drawing.Point(18, 27);
            this.lbl_nameB.Name = "lbl_nameB";
            this.lbl_nameB.Size = new System.Drawing.Size(96, 16);
            this.lbl_nameB.TabIndex = 26;
            this.lbl_nameB.Text = "Book\'s name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_ID.Location = new System.Drawing.Point(16, 113);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(147, 16);
            this.lbl_ID.TabIndex = 29;
            this.lbl_ID.Text = "ID of borrowing kid";
            // 
            // txt_booksName
            // 
            this.txt_booksName.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_booksName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_booksName.Location = new System.Drawing.Point(120, 24);
            this.txt_booksName.Name = "txt_booksName";
            this.txt_booksName.Size = new System.Drawing.Size(121, 23);
            this.txt_booksName.TabIndex = 2;
            this.txt_booksName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_booksName_KeyPress);
            // 
            // MoP_toReturn
            // 
            this.MoP_toReturn.Enabled = false;
            this.MoP_toReturn.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MoP_toReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MoP_toReturn.Location = new System.Drawing.Point(156, 78);
            this.MoP_toReturn.MaxDate = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            this.MoP_toReturn.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.MoP_toReturn.Name = "MoP_toReturn";
            this.MoP_toReturn.Size = new System.Drawing.Size(95, 23);
            this.MoP_toReturn.TabIndex = 4;
            this.MoP_toReturn.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.MoP_toReturn.ValueChanged += new System.EventHandler(this.MoP_toReturn_ValueChanged);
            // 
            // MoP_borrowing
            // 
            this.MoP_borrowing.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MoP_borrowing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MoP_borrowing.Location = new System.Drawing.Point(156, 52);
            this.MoP_borrowing.MaxDate = new System.DateTime(2017, 5, 19, 0, 0, 0, 0);
            this.MoP_borrowing.MinDate = new System.DateTime(2017, 3, 17, 0, 0, 0, 0);
            this.MoP_borrowing.Name = "MoP_borrowing";
            this.MoP_borrowing.Size = new System.Drawing.Size(95, 23);
            this.MoP_borrowing.TabIndex = 3;
            this.MoP_borrowing.Value = new System.DateTime(2017, 3, 17, 0, 0, 0, 0);
            this.MoP_borrowing.ValueChanged += new System.EventHandler(this.MoP_borrowing_ValueChanged);
            this.MoP_borrowing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoP_borrowing_KeyPress);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Location = new System.Drawing.Point(49, 233);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 21);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_rf
            // 
            this.btn_rf.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_rf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rf.Location = new System.Drawing.Point(8, 204);
            this.btn_rf.Name = "btn_rf";
            this.btn_rf.Size = new System.Drawing.Size(81, 23);
            this.btn_rf.TabIndex = 7;
            this.btn_rf.Text = "Refresh";
            this.btn_rf.UseVisualStyleBackColor = true;
            this.btn_rf.Click += new System.EventHandler(this.btn_rf_Click);
            // 
            // pnl_results
            // 
            this.pnl_results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_results.Controls.Add(this.btn_closeResults);
            this.pnl_results.Controls.Add(this.dataGridView_search);
            this.pnl_results.Controls.Add(this.lbl_result);
            this.pnl_results.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_results.Location = new System.Drawing.Point(0, 322);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.Size = new System.Drawing.Size(1140, 269);
            this.pnl_results.TabIndex = 43;
            this.pnl_results.Visible = false;
            // 
            // btn_closeResults
            // 
            this.btn_closeResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_closeResults.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_closeResults.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_closeResults.Location = new System.Drawing.Point(0, 222);
            this.btn_closeResults.Name = "btn_closeResults";
            this.btn_closeResults.Size = new System.Drawing.Size(75, 43);
            this.btn_closeResults.TabIndex = 10;
            this.btn_closeResults.Text = "Close";
            this.btn_closeResults.UseVisualStyleBackColor = true;
            this.btn_closeResults.Click += new System.EventHandler(this.btn_closeResults_Click);
            // 
            // dataGridView_search
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_search.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_search.Name = "dataGridView_search";
            this.dataGridView_search.Size = new System.Drawing.Size(1136, 192);
            this.dataGridView_search.TabIndex = 84;
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_result.Location = new System.Drawing.Point(0, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(1136, 30);
            this.lbl_result.TabIndex = 83;
            this.lbl_result.Text = "Search results";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_search.Location = new System.Drawing.Point(125, 4);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_search.Size = new System.Drawing.Size(55, 16);
            this.lbl_search.TabIndex = 87;
            this.lbl_search.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_search.Location = new System.Drawing.Point(186, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(121, 23);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("Narkisim", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Location = new System.Drawing.Point(8, 178);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(171, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add a new borrowing";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_sfarim
            // 
            this.cb_sfarim.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cb_sfarim.FormattingEnabled = true;
            this.cb_sfarim.Location = new System.Drawing.Point(0, 3);
            this.cb_sfarim.Name = "cb_sfarim";
            this.cb_sfarim.Size = new System.Drawing.Size(121, 24);
            this.cb_sfarim.TabIndex = 0;
            this.cb_sfarim.SelectedIndexChanged += new System.EventHandler(this.cb_kitot_SelectedIndexChanged);
            // 
            // txt_IDBorrowingKid
            // 
            this.txt_IDBorrowingKid.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_IDBorrowingKid.Location = new System.Drawing.Point(169, 103);
            this.txt_IDBorrowingKid.Mask = "000000000";
            this.txt_IDBorrowingKid.Name = "txt_IDBorrowingKid";
            this.txt_IDBorrowingKid.Size = new System.Drawing.Size(97, 23);
            this.txt_IDBorrowingKid.TabIndex = 5;
            this.txt_IDBorrowingKid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDBorrowingKid_KeyPress);
            // 
            // pnl_up
            // 
            this.pnl_up.Controls.Add(this.cb_sfarim);
            this.pnl_up.Controls.Add(this.txt_search);
            this.pnl_up.Controls.Add(this.lbl_search);
            this.pnl_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_up.Location = new System.Drawing.Point(0, 0);
            this.pnl_up.Name = "pnl_up";
            this.pnl_up.Size = new System.Drawing.Size(1140, 46);
            this.pnl_up.TabIndex = 102;
            this.pnl_up.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_up_Paint);
            // 
            // pnl_table
            // 
            this.pnl_table.Controls.Add(this.pnl_sadot);
            this.pnl_table.Controls.Add(this.dataGridView_sfarim);
            this.pnl_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_table.Location = new System.Drawing.Point(0, 46);
            this.pnl_table.Name = "pnl_table";
            this.pnl_table.Size = new System.Drawing.Size(1140, 257);
            this.pnl_table.TabIndex = 103;
            this.pnl_table.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_table_Paint);
            // 
            // pnl_sadot
            // 
            this.pnl_sadot.Controls.Add(this.lbl_n);
            this.pnl_sadot.Controls.Add(this.btn_delete);
            this.pnl_sadot.Controls.Add(this.lbl_nameB);
            this.pnl_sadot.Controls.Add(this.lbl_dateOfBorrowing);
            this.pnl_sadot.Controls.Add(this.txt_IDBorrowingKid);
            this.pnl_sadot.Controls.Add(this.lbl_dateToReturn);
            this.pnl_sadot.Controls.Add(this.btn_add);
            this.pnl_sadot.Controls.Add(this.lbl_ID);
            this.pnl_sadot.Controls.Add(this.txt_booksName);
            this.pnl_sadot.Controls.Add(this.btn_rf);
            this.pnl_sadot.Controls.Add(this.MoP_toReturn);
            this.pnl_sadot.Controls.Add(this.btn_save);
            this.pnl_sadot.Controls.Add(this.MoP_borrowing);
            this.pnl_sadot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sadot.Location = new System.Drawing.Point(782, 0);
            this.pnl_sadot.Name = "pnl_sadot";
            this.pnl_sadot.Size = new System.Drawing.Size(358, 257);
            this.pnl_sadot.TabIndex = 1;
            this.pnl_sadot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_sadot_Paint);
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n.Location = new System.Drawing.Point(246, 22);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(20, 25);
            this.lbl_n.TabIndex = 105;
            this.lbl_n.Text = "*";
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Location = new System.Drawing.Point(105, 205);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // FormSfarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 591);
            this.Controls.Add(this.pnl_table);
            this.Controls.Add(this.pnl_up);
            this.Controls.Add(this.pnl_results);
            this.Name = "FormSfarim";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.FormSfarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sfarim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfarimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).EndInit();
            this.pnl_results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).EndInit();
            this.pnl_up.ResumeLayout(false);
            this.pnl_up.PerformLayout();
            this.pnl_table.ResumeLayout(false);
            this.pnl_sadot.ResumeLayout(false);
            this.pnl_sadot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_sfarim;
        private kindergardenDataSet kindergardenDataSet;
        private System.Windows.Forms.BindingSource sfarimBindingSource;
        private kindergardenDataSetTableAdapters.sfarimTableAdapter sfarimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBorrowingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateToReturnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOfBorrowingKidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_dateToReturn;
        private System.Windows.Forms.Label lbl_dateOfBorrowing;
        private System.Windows.Forms.Label lbl_nameB;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_booksName;
        private System.Windows.Forms.DateTimePicker MoP_toReturn;
        private System.Windows.Forms.DateTimePicker MoP_borrowing;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_rf;
        private System.Windows.Forms.Panel pnl_results;
        private System.Windows.Forms.Button btn_closeResults;
        private System.Windows.Forms.DataGridView dataGridView_search;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_sfarim;
        private System.Windows.Forms.MaskedTextBox txt_IDBorrowingKid;
        private System.Windows.Forms.Panel pnl_up;
        private System.Windows.Forms.Panel pnl_table;
        private System.Windows.Forms.Panel pnl_sadot;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_n;
    }
}