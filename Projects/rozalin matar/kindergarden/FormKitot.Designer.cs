namespace kindergarden
{
    partial class FormKitot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_kitot = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfKidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergardenDataSet = new kindergarden.kindergardenDataSet();
            this.btn_rf = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_nuMofKids = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kitotTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.kitotTableAdapter();
            this.lbl_minAge = new System.Windows.Forms.Label();
            this.lbl_maxAge = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_results = new System.Windows.Forms.Panel();
            this.btn_closeResults = new System.Windows.Forms.Button();
            this.dataGridView_search = new System.Windows.Forms.DataGridView();
            this.lbl_result = new System.Windows.Forms.Label();
            this.cb_kitot = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_minAge = new System.Windows.Forms.MaskedTextBox();
            this.txt_maxAge = new System.Windows.Forms.MaskedTextBox();
            this.txt_nuMofKids = new System.Windows.Forms.MaskedTextBox();
            this.pnl_up = new System.Windows.Forms.Panel();
            this.pnl_table = new System.Windows.Forms.Panel();
            this.pnl_sadot = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_n = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kitot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).BeginInit();
            this.pnl_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).BeginInit();
            this.pnl_up.SuspendLayout();
            this.pnl_table.SuspendLayout();
            this.pnl_sadot.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_kitot
            // 
            this.dataGridView_kitot.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_kitot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_kitot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberOfKidsDataGridViewTextBoxColumn,
            this.minAgeDataGridViewTextBoxColumn,
            this.maxAgeDataGridViewTextBoxColumn});
            this.dataGridView_kitot.DataSource = this.kitotBindingSource;
            this.dataGridView_kitot.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_kitot.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_kitot.Name = "dataGridView_kitot";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_kitot.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dataGridView_kitot.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_kitot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_kitot.Size = new System.Drawing.Size(546, 347);
            this.dataGridView_kitot.TabIndex = 14;
            this.dataGridView_kitot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kitot_CellContentClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numberOfKidsDataGridViewTextBoxColumn
            // 
            this.numberOfKidsDataGridViewTextBoxColumn.DataPropertyName = "number of kids";
            this.numberOfKidsDataGridViewTextBoxColumn.HeaderText = "number of kids";
            this.numberOfKidsDataGridViewTextBoxColumn.Name = "numberOfKidsDataGridViewTextBoxColumn";
            // 
            // minAgeDataGridViewTextBoxColumn
            // 
            this.minAgeDataGridViewTextBoxColumn.DataPropertyName = "min age";
            this.minAgeDataGridViewTextBoxColumn.HeaderText = "Min age";
            this.minAgeDataGridViewTextBoxColumn.Name = "minAgeDataGridViewTextBoxColumn";
            // 
            // maxAgeDataGridViewTextBoxColumn
            // 
            this.maxAgeDataGridViewTextBoxColumn.DataPropertyName = "max age";
            this.maxAgeDataGridViewTextBoxColumn.HeaderText = "Max age";
            this.maxAgeDataGridViewTextBoxColumn.Name = "maxAgeDataGridViewTextBoxColumn";
            // 
            // kitotBindingSource
            // 
            this.kitotBindingSource.DataMember = "kitot";
            this.kitotBindingSource.DataSource = this.kindergardenDataSet;
            // 
            // kindergardenDataSet
            // 
            this.kindergardenDataSet.DataSetName = "kindergardenDataSet";
            this.kindergardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_rf
            // 
            this.btn_rf.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_rf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rf.Location = new System.Drawing.Point(0, 196);
            this.btn_rf.Name = "btn_rf";
            this.btn_rf.Size = new System.Drawing.Size(75, 23);
            this.btn_rf.TabIndex = 8;
            this.btn_rf.Text = "Refresh";
            this.btn_rf.UseVisualStyleBackColor = true;
            this.btn_rf.Click += new System.EventHandler(this.btn_rf_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Location = new System.Drawing.Point(40, 226);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_code.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_code.Location = new System.Drawing.Point(61, 24);
            this.txt_code.MaxLength = 9;
            this.txt_code.Multiline = true;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 20);
            this.txt_code.TabIndex = 2;
            this.txt_code.TextChanged += new System.EventHandler(this.txt_code_TextChanged);
            this.txt_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_code_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_name.Location = new System.Drawing.Point(61, 53);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_code.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_code.Location = new System.Drawing.Point(5, 31);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(45, 16);
            this.lbl_code.TabIndex = 6;
            this.lbl_code.Text = "Code";
            this.lbl_code.Click += new System.EventHandler(this.lbl_code_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_name.Location = new System.Drawing.Point(5, 59);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(50, 16);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_nuMofKids
            // 
            this.lbl_nuMofKids.AutoSize = true;
            this.lbl_nuMofKids.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_nuMofKids.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nuMofKids.Location = new System.Drawing.Point(5, 85);
            this.lbl_nuMofKids.Name = "lbl_nuMofKids";
            this.lbl_nuMofKids.Size = new System.Drawing.Size(118, 16);
            this.lbl_nuMofKids.TabIndex = 8;
            this.lbl_nuMofKids.Text = "Number of kids";
            this.lbl_nuMofKids.Click += new System.EventHandler(this.lbl_nuMofKids_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitotTableAdapter
            // 
            this.kitotTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_minAge
            // 
            this.lbl_minAge.AutoSize = true;
            this.lbl_minAge.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_minAge.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_minAge.Location = new System.Drawing.Point(5, 111);
            this.lbl_minAge.Name = "lbl_minAge";
            this.lbl_minAge.Size = new System.Drawing.Size(64, 16);
            this.lbl_minAge.TabIndex = 11;
            this.lbl_minAge.Text = "Min age";
            // 
            // lbl_maxAge
            // 
            this.lbl_maxAge.AutoSize = true;
            this.lbl_maxAge.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_maxAge.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_maxAge.Location = new System.Drawing.Point(8, 135);
            this.lbl_maxAge.Name = "lbl_maxAge";
            this.lbl_maxAge.Size = new System.Drawing.Size(67, 16);
            this.lbl_maxAge.TabIndex = 12;
            this.lbl_maxAge.Text = "Max age";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_search.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_search.Location = new System.Drawing.Point(121, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_search.Size = new System.Drawing.Size(55, 16);
            this.lbl_search.TabIndex = 94;
            this.lbl_search.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_search.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_search.Location = new System.Drawing.Point(176, 0);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(121, 23);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // pnl_results
            // 
            this.pnl_results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_results.Controls.Add(this.btn_closeResults);
            this.pnl_results.Controls.Add(this.dataGridView_search);
            this.pnl_results.Controls.Add(this.lbl_result);
            this.pnl_results.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_results.Location = new System.Drawing.Point(0, 393);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.Size = new System.Drawing.Size(1194, 241);
            this.pnl_results.TabIndex = 92;
            this.pnl_results.Visible = false;
            // 
            // btn_closeResults
            // 
            this.btn_closeResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_closeResults.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_closeResults.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_closeResults.Location = new System.Drawing.Point(0, 210);
            this.btn_closeResults.Name = "btn_closeResults";
            this.btn_closeResults.Size = new System.Drawing.Size(75, 27);
            this.btn_closeResults.TabIndex = 11;
            this.btn_closeResults.Text = "Close";
            this.btn_closeResults.UseVisualStyleBackColor = true;
            this.btn_closeResults.Click += new System.EventHandler(this.btn_closeResults_Click);
            // 
            // dataGridView_search
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_search.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_search.Name = "dataGridView_search";
            this.dataGridView_search.Size = new System.Drawing.Size(1190, 180);
            this.dataGridView_search.TabIndex = 84;
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_result.Location = new System.Drawing.Point(0, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(1190, 30);
            this.lbl_result.TabIndex = 83;
            this.lbl_result.Text = "Search results";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_kitot
            // 
            this.cb_kitot.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_kitot.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cb_kitot.FormattingEnabled = true;
            this.cb_kitot.Location = new System.Drawing.Point(0, 0);
            this.cb_kitot.Name = "cb_kitot";
            this.cb_kitot.Size = new System.Drawing.Size(121, 24);
            this.cb_kitot.TabIndex = 0;
            this.cb_kitot.SelectedIndexChanged += new System.EventHandler(this.cb_kitot_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Location = new System.Drawing.Point(0, 167);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(153, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add a new class";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Location = new System.Drawing.Point(78, 197);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_minAge
            // 
            this.txt_minAge.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_minAge.Location = new System.Drawing.Point(78, 103);
            this.txt_minAge.Mask = "0";
            this.txt_minAge.Name = "txt_minAge";
            this.txt_minAge.Size = new System.Drawing.Size(40, 23);
            this.txt_minAge.TabIndex = 5;
            // 
            // txt_maxAge
            // 
            this.txt_maxAge.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_maxAge.Location = new System.Drawing.Point(78, 135);
            this.txt_maxAge.Mask = "0";
            this.txt_maxAge.Name = "txt_maxAge";
            this.txt_maxAge.Size = new System.Drawing.Size(40, 23);
            this.txt_maxAge.TabIndex = 6;
            // 
            // txt_nuMofKids
            // 
            this.txt_nuMofKids.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_nuMofKids.Location = new System.Drawing.Point(129, 75);
            this.txt_nuMofKids.Mask = "00";
            this.txt_nuMofKids.Name = "txt_nuMofKids";
            this.txt_nuMofKids.Size = new System.Drawing.Size(32, 23);
            this.txt_nuMofKids.TabIndex = 4;
            // 
            // pnl_up
            // 
            this.pnl_up.Controls.Add(this.txt_search);
            this.pnl_up.Controls.Add(this.lbl_search);
            this.pnl_up.Controls.Add(this.cb_kitot);
            this.pnl_up.Controls.Add(this.button1);
            this.pnl_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_up.Location = new System.Drawing.Point(0, 0);
            this.pnl_up.Name = "pnl_up";
            this.pnl_up.Size = new System.Drawing.Size(1194, 46);
            this.pnl_up.TabIndex = 98;
            // 
            // pnl_table
            // 
            this.pnl_table.Controls.Add(this.pnl_sadot);
            this.pnl_table.Controls.Add(this.dataGridView_kitot);
            this.pnl_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_table.Location = new System.Drawing.Point(0, 46);
            this.pnl_table.Name = "pnl_table";
            this.pnl_table.Size = new System.Drawing.Size(1194, 347);
            this.pnl_table.TabIndex = 99;
            this.pnl_table.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_table_Paint);
            // 
            // pnl_sadot
            // 
            this.pnl_sadot.Controls.Add(this.label4);
            this.pnl_sadot.Controls.Add(this.label3);
            this.pnl_sadot.Controls.Add(this.label2);
            this.pnl_sadot.Controls.Add(this.label1);
            this.pnl_sadot.Controls.Add(this.lbl_n);
            this.pnl_sadot.Controls.Add(this.txt_code);
            this.pnl_sadot.Controls.Add(this.lbl_minAge);
            this.pnl_sadot.Controls.Add(this.btn_rf);
            this.pnl_sadot.Controls.Add(this.lbl_maxAge);
            this.pnl_sadot.Controls.Add(this.btn_add);
            this.pnl_sadot.Controls.Add(this.btn_delete);
            this.pnl_sadot.Controls.Add(this.txt_nuMofKids);
            this.pnl_sadot.Controls.Add(this.btn_save);
            this.pnl_sadot.Controls.Add(this.lbl_nuMofKids);
            this.pnl_sadot.Controls.Add(this.lbl_name);
            this.pnl_sadot.Controls.Add(this.txt_maxAge);
            this.pnl_sadot.Controls.Add(this.lbl_code);
            this.pnl_sadot.Controls.Add(this.txt_name);
            this.pnl_sadot.Controls.Add(this.txt_minAge);
            this.pnl_sadot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sadot.Location = new System.Drawing.Point(933, 0);
            this.pnl_sadot.Name = "pnl_sadot";
            this.pnl_sadot.Size = new System.Drawing.Size(261, 347);
            this.pnl_sadot.TabIndex = 98;
            this.pnl_sadot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_sadot_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(168, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 102;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(168, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(124, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(124, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "*";
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n.Location = new System.Drawing.Point(168, 24);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(20, 25);
            this.lbl_n.TabIndex = 98;
            this.lbl_n.Text = "*";
            // 
            // FormKitot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 634);
            this.Controls.Add(this.pnl_table);
            this.Controls.Add(this.pnl_up);
            this.Controls.Add(this.pnl_results);
            this.Name = "FormKitot";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.FormKitot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kitot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitotBindingSource)).EndInit();
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

        private System.Windows.Forms.DataGridView dataGridView_kitot;
        private System.Windows.Forms.Button btn_rf;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_nuMofKids;
        private System.Windows.Forms.Button button1;
        private kindergardenDataSet kindergardenDataSet;
        private System.Windows.Forms.BindingSource kitotBindingSource;
        private kindergardenDataSetTableAdapters.kitotTableAdapter kitotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfKidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_minAge;
        private System.Windows.Forms.Label lbl_maxAge;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel pnl_results;
        private System.Windows.Forms.Button btn_closeResults;
        private System.Windows.Forms.DataGridView dataGridView_search;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.ComboBox cb_kitot;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.MaskedTextBox txt_minAge;
        private System.Windows.Forms.MaskedTextBox txt_maxAge;
        private System.Windows.Forms.MaskedTextBox txt_nuMofKids;
        private System.Windows.Forms.Panel pnl_up;
        private System.Windows.Forms.Panel pnl_table;
        private System.Windows.Forms.Panel pnl_sadot;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}