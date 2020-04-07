namespace kindergarden
{
    partial class FormHogim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView_hogim = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participatingClassesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayAWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneMeetingLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hogimBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.kindergardenDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergardenDataSet = new kindergarden.kindergardenDataSet();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_pC = new System.Windows.Forms.Label();
            this.lbl_lN = new System.Windows.Forms.Label();
            this.lbl_dAW = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_lN = new System.Windows.Forms.TextBox();
            this.btn_rf = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_results = new System.Windows.Forms.Panel();
            this.btn_closeResults = new System.Windows.Forms.Button();
            this.dataGridView_search = new System.Windows.Forms.DataGridView();
            this.lbl_result = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.comboBox_dayAWeek = new System.Windows.Forms.ComboBox();
            this.cbl_participatingClasses = new System.Windows.Forms.CheckedListBox();
            this.kitotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.hourOfStarting = new System.Windows.Forms.DateTimePicker();
            this.hogimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_hogim = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_oneMeetingLength = new System.Windows.Forms.Label();
            this.comboBox_oneMeetingLength = new System.Windows.Forms.ComboBox();
            this.pnl_up = new System.Windows.Forms.Panel();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.pnl_sadot = new System.Windows.Forms.Panel();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.lbl_n = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.kitotTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.kitotTableAdapter();
            this.hogimTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.hogimTableAdapter();
            this.hogimTableAdapter1 = new kindergarden.kindergardenDataSetTableAdapters.hogimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hogim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogimBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).BeginInit();
            this.pnl_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogimBindingSource)).BeginInit();
            this.pnl_up.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.pnl_sadot.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Location = new System.Drawing.Point(59, 354);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView_hogim
            // 
            this.dataGridView_hogim.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_hogim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_hogim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hogim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.participatingClassesDataGridViewTextBoxColumn,
            this.lecturersNameDataGridViewTextBoxColumn,
            this.dayAWeekDataGridViewTextBoxColumn,
            this.startingHourDataGridViewTextBoxColumn,
            this.oneMeetingLengthDataGridViewTextBoxColumn});
            this.dataGridView_hogim.DataSource = this.hogimBindingSource3;
            this.dataGridView_hogim.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_hogim.Enabled = false;
            this.dataGridView_hogim.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_hogim.Name = "dataGridView_hogim";
            this.dataGridView_hogim.Size = new System.Drawing.Size(844, 388);
            this.dataGridView_hogim.TabIndex = 4;
            this.dataGridView_hogim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "from";
            this.fromDataGridViewTextBoxColumn.HeaderText = "from";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "to";
            this.toDataGridViewTextBoxColumn.HeaderText = "to";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            // 
            // participatingClassesDataGridViewTextBoxColumn
            // 
            this.participatingClassesDataGridViewTextBoxColumn.DataPropertyName = "participating classes";
            this.participatingClassesDataGridViewTextBoxColumn.HeaderText = "participating classes";
            this.participatingClassesDataGridViewTextBoxColumn.Name = "participatingClassesDataGridViewTextBoxColumn";
            // 
            // lecturersNameDataGridViewTextBoxColumn
            // 
            this.lecturersNameDataGridViewTextBoxColumn.DataPropertyName = "lecturer\'s name";
            this.lecturersNameDataGridViewTextBoxColumn.HeaderText = "lecturer\'s name";
            this.lecturersNameDataGridViewTextBoxColumn.Name = "lecturersNameDataGridViewTextBoxColumn";
            // 
            // dayAWeekDataGridViewTextBoxColumn
            // 
            this.dayAWeekDataGridViewTextBoxColumn.DataPropertyName = "day a week";
            this.dayAWeekDataGridViewTextBoxColumn.HeaderText = "day a week";
            this.dayAWeekDataGridViewTextBoxColumn.Name = "dayAWeekDataGridViewTextBoxColumn";
            // 
            // startingHourDataGridViewTextBoxColumn
            // 
            this.startingHourDataGridViewTextBoxColumn.DataPropertyName = "starting hour";
            this.startingHourDataGridViewTextBoxColumn.HeaderText = "starting hour";
            this.startingHourDataGridViewTextBoxColumn.Name = "startingHourDataGridViewTextBoxColumn";
            // 
            // oneMeetingLengthDataGridViewTextBoxColumn
            // 
            this.oneMeetingLengthDataGridViewTextBoxColumn.DataPropertyName = "one meeting length";
            this.oneMeetingLengthDataGridViewTextBoxColumn.HeaderText = "one meeting length";
            this.oneMeetingLengthDataGridViewTextBoxColumn.Name = "oneMeetingLengthDataGridViewTextBoxColumn";
            // 
            // hogimBindingSource3
            // 
            this.hogimBindingSource3.DataMember = "hogim";
            this.hogimBindingSource3.DataSource = this.kindergardenDataSetBindingSource;
            // 
            // kindergardenDataSetBindingSource
            // 
            this.kindergardenDataSetBindingSource.DataSource = this.kindergardenDataSet;
            this.kindergardenDataSetBindingSource.Position = 0;
            // 
            // kindergardenDataSet
            // 
            this.kindergardenDataSet.DataSetName = "kindergardenDataSet";
            this.kindergardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_name.Location = new System.Drawing.Point(3, 12);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(50, 16);
            this.lbl_name.TabIndex = 15;
            this.lbl_name.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_name.Location = new System.Drawing.Point(59, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_from.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_from.Location = new System.Drawing.Point(3, 41);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(44, 16);
            this.lbl_from.TabIndex = 16;
            this.lbl_from.Text = "From";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_to.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_to.Location = new System.Drawing.Point(3, 70);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(27, 16);
            this.lbl_to.TabIndex = 17;
            this.lbl_to.Text = "To";
            // 
            // lbl_pC
            // 
            this.lbl_pC.AutoSize = true;
            this.lbl_pC.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_pC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_pC.Location = new System.Drawing.Point(3, 96);
            this.lbl_pC.Name = "lbl_pC";
            this.lbl_pC.Size = new System.Drawing.Size(147, 16);
            this.lbl_pC.TabIndex = 18;
            this.lbl_pC.Text = "Participating classes";
            // 
            // lbl_lN
            // 
            this.lbl_lN.AutoSize = true;
            this.lbl_lN.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_lN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_lN.Location = new System.Drawing.Point(3, 187);
            this.lbl_lN.Name = "lbl_lN";
            this.lbl_lN.Size = new System.Drawing.Size(121, 16);
            this.lbl_lN.TabIndex = 19;
            this.lbl_lN.Text = "Lecturer\'s name";
            // 
            // lbl_dAW
            // 
            this.lbl_dAW.AutoSize = true;
            this.lbl_dAW.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_dAW.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_dAW.Location = new System.Drawing.Point(3, 218);
            this.lbl_dAW.Name = "lbl_dAW";
            this.lbl_dAW.Size = new System.Drawing.Size(88, 16);
            this.lbl_dAW.TabIndex = 20;
            this.lbl_dAW.Text = "Day a week";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_time.Location = new System.Drawing.Point(3, 247);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(101, 16);
            this.lbl_time.TabIndex = 21;
            this.lbl_time.Text = "Starting hour";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
            // 
            // txt_lN
            // 
            this.txt_lN.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_lN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_lN.Location = new System.Drawing.Point(127, 187);
            this.txt_lN.Name = "txt_lN";
            this.txt_lN.Size = new System.Drawing.Size(104, 23);
            this.txt_lN.TabIndex = 6;
            this.txt_lN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lN_KeyPress);
            // 
            // btn_rf
            // 
            this.btn_rf.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_rf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rf.Location = new System.Drawing.Point(17, 325);
            this.btn_rf.Name = "btn_rf";
            this.btn_rf.Size = new System.Drawing.Size(75, 23);
            this.btn_rf.TabIndex = 10;
            this.btn_rf.Text = "refresh";
            this.btn_rf.UseVisualStyleBackColor = true;
            this.btn_rf.Click += new System.EventHandler(this.btn_rf_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_search.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_search.Location = new System.Drawing.Point(0, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_search.Size = new System.Drawing.Size(55, 16);
            this.lbl_search.TabIndex = 89;
            this.lbl_search.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_search.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_search.Location = new System.Drawing.Point(55, 0);
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
            this.pnl_results.Location = new System.Drawing.Point(0, 433);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.Size = new System.Drawing.Size(1182, 281);
            this.pnl_results.TabIndex = 90;
            this.pnl_results.Visible = false;
            // 
            // btn_closeResults
            // 
            this.btn_closeResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_closeResults.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_closeResults.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_closeResults.Location = new System.Drawing.Point(0, 222);
            this.btn_closeResults.Name = "btn_closeResults";
            this.btn_closeResults.Size = new System.Drawing.Size(75, 55);
            this.btn_closeResults.TabIndex = 14;
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
            this.dataGridView_search.Size = new System.Drawing.Size(1178, 192);
            this.dataGridView_search.TabIndex = 84;
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_result.Location = new System.Drawing.Point(0, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(1178, 30);
            this.lbl_result.TabIndex = 83;
            this.lbl_result.Text = "Search results";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_from.Location = new System.Drawing.Point(59, 37);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_from.TabIndex = 3;
            this.dateTimePicker_from.ValueChanged += new System.EventHandler(this.dateTimePicker_from_ValueChanged);
            this.dateTimePicker_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker_from_KeyPress);
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_to.Location = new System.Drawing.Point(59, 65);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_to.TabIndex = 4;
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker_to_ValueChanged);
            this.dateTimePicker_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker_to_KeyPress);
            // 
            // comboBox_dayAWeek
            // 
            this.comboBox_dayAWeek.FormattingEnabled = true;
            this.comboBox_dayAWeek.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.comboBox_dayAWeek.Location = new System.Drawing.Point(110, 213);
            this.comboBox_dayAWeek.Name = "comboBox_dayAWeek";
            this.comboBox_dayAWeek.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dayAWeek.TabIndex = 7;
            this.comboBox_dayAWeek.SelectedIndexChanged += new System.EventHandler(this.comboBox_dayAWeek_SelectedIndexChanged);
            // 
            // cbl_participatingClasses
            // 
            this.cbl_participatingClasses.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbl_participatingClasses.FormattingEnabled = true;
            this.cbl_participatingClasses.Location = new System.Drawing.Point(147, 93);
            this.cbl_participatingClasses.Name = "cbl_participatingClasses";
            this.cbl_participatingClasses.Size = new System.Drawing.Size(141, 94);
            this.cbl_participatingClasses.TabIndex = 5;
            this.cbl_participatingClasses.SelectedIndexChanged += new System.EventHandler(this.cbl_participatingClasses_SelectedIndexChanged);
            // 
            // kitotBindingSource
            // 
            this.kitotBindingSource.DataMember = "kitot";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 96;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // hourOfStarting
            // 
            this.hourOfStarting.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hourOfStarting.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.hourOfStarting.Font = new System.Drawing.Font("Narkisim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hourOfStarting.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hourOfStarting.Location = new System.Drawing.Point(110, 237);
            this.hourOfStarting.Name = "hourOfStarting";
            this.hourOfStarting.ShowUpDown = true;
            this.hourOfStarting.Size = new System.Drawing.Size(121, 31);
            this.hourOfStarting.TabIndex = 8;
            this.hourOfStarting.ValueChanged += new System.EventHandler(this.hourOfStarting_ValueChanged);
            // 
            // cb_hogim
            // 
            this.cb_hogim.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_hogim.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cb_hogim.FormattingEnabled = true;
            this.cb_hogim.Location = new System.Drawing.Point(176, 0);
            this.cb_hogim.Name = "cb_hogim";
            this.cb_hogim.Size = new System.Drawing.Size(121, 24);
            this.cb_hogim.TabIndex = 0;
            this.cb_hogim.SelectedIndexChanged += new System.EventHandler(this.cb_hogim_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Location = new System.Drawing.Point(17, 296);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(155, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add a new course";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_oneMeetingLength
            // 
            this.lbl_oneMeetingLength.AutoSize = true;
            this.lbl_oneMeetingLength.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_oneMeetingLength.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_oneMeetingLength.Location = new System.Drawing.Point(3, 277);
            this.lbl_oneMeetingLength.Name = "lbl_oneMeetingLength";
            this.lbl_oneMeetingLength.Size = new System.Drawing.Size(149, 16);
            this.lbl_oneMeetingLength.TabIndex = 22;
            this.lbl_oneMeetingLength.Text = "One meeting length";
            // 
            // comboBox_oneMeetingLength
            // 
            this.comboBox_oneMeetingLength.FormattingEnabled = true;
            this.comboBox_oneMeetingLength.Items.AddRange(new object[] {
            "1 hour",
            "2 hours",
            "3 hours",
            "Whole day"});
            this.comboBox_oneMeetingLength.Location = new System.Drawing.Point(158, 272);
            this.comboBox_oneMeetingLength.Name = "comboBox_oneMeetingLength";
            this.comboBox_oneMeetingLength.Size = new System.Drawing.Size(73, 21);
            this.comboBox_oneMeetingLength.TabIndex = 9;
            // 
            // pnl_up
            // 
            this.pnl_up.Controls.Add(this.cb_hogim);
            this.pnl_up.Controls.Add(this.txt_search);
            this.pnl_up.Controls.Add(this.button1);
            this.pnl_up.Controls.Add(this.lbl_search);
            this.pnl_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_up.Location = new System.Drawing.Point(0, 0);
            this.pnl_up.Name = "pnl_up";
            this.pnl_up.Size = new System.Drawing.Size(1182, 44);
            this.pnl_up.TabIndex = 102;
            this.pnl_up.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_up_Paint);
            // 
            // pnl_center
            // 
            this.pnl_center.Controls.Add(this.pnl_sadot);
            this.pnl_center.Controls.Add(this.dataGridView_hogim);
            this.pnl_center.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_center.Location = new System.Drawing.Point(0, 44);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(1182, 388);
            this.pnl_center.TabIndex = 103;
            this.pnl_center.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_center_Paint);
            // 
            // pnl_sadot
            // 
            this.pnl_sadot.Controls.Add(this.txt_to);
            this.pnl_sadot.Controls.Add(this.txt_from);
            this.pnl_sadot.Controls.Add(this.lbl_n7);
            this.pnl_sadot.Controls.Add(this.lbl_n2);
            this.pnl_sadot.Controls.Add(this.lbl_n3);
            this.pnl_sadot.Controls.Add(this.lbl_n4);
            this.pnl_sadot.Controls.Add(this.lbl_5);
            this.pnl_sadot.Controls.Add(this.lbl_n6);
            this.pnl_sadot.Controls.Add(this.lbl_n);
            this.pnl_sadot.Controls.Add(this.btn_delete);
            this.pnl_sadot.Controls.Add(this.lbl_name);
            this.pnl_sadot.Controls.Add(this.txt_name);
            this.pnl_sadot.Controls.Add(this.btn_add);
            this.pnl_sadot.Controls.Add(this.lbl_from);
            this.pnl_sadot.Controls.Add(this.comboBox_oneMeetingLength);
            this.pnl_sadot.Controls.Add(this.lbl_to);
            this.pnl_sadot.Controls.Add(this.btn_rf);
            this.pnl_sadot.Controls.Add(this.lbl_oneMeetingLength);
            this.pnl_sadot.Controls.Add(this.btn_save);
            this.pnl_sadot.Controls.Add(this.lbl_pC);
            this.pnl_sadot.Controls.Add(this.lbl_lN);
            this.pnl_sadot.Controls.Add(this.hourOfStarting);
            this.pnl_sadot.Controls.Add(this.lbl_dAW);
            this.pnl_sadot.Controls.Add(this.lbl_time);
            this.pnl_sadot.Controls.Add(this.cbl_participatingClasses);
            this.pnl_sadot.Controls.Add(this.txt_lN);
            this.pnl_sadot.Controls.Add(this.comboBox_dayAWeek);
            this.pnl_sadot.Controls.Add(this.dateTimePicker_from);
            this.pnl_sadot.Controls.Add(this.dateTimePicker_to);
            this.pnl_sadot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sadot.Location = new System.Drawing.Point(891, 0);
            this.pnl_sadot.Name = "pnl_sadot";
            this.pnl_sadot.Size = new System.Drawing.Size(291, 388);
            this.pnl_sadot.TabIndex = 5;
            this.pnl_sadot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_sadot_Paint);
            // 
            // txt_to
            // 
            this.txt_to.Enabled = false;
            this.txt_to.Location = new System.Drawing.Point(59, 65);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(69, 20);
            this.txt_to.TabIndex = 111;
            this.txt_to.Visible = false;
            // 
            // txt_from
            // 
            this.txt_from.Enabled = false;
            this.txt_from.Location = new System.Drawing.Point(59, 37);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(73, 20);
            this.txt_from.TabIndex = 110;
            this.txt_from.Visible = false;
            this.txt_from.TextChanged += new System.EventHandler(this.txt_from_TextChanged);
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n7.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n7.Location = new System.Drawing.Point(237, 268);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(20, 25);
            this.lbl_n7.TabIndex = 109;
            this.lbl_n7.Text = "*";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n2.Location = new System.Drawing.Point(165, 35);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(20, 25);
            this.lbl_n2.TabIndex = 108;
            this.lbl_n2.Text = "*";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n3.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n3.Location = new System.Drawing.Point(165, 60);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(20, 25);
            this.lbl_n3.TabIndex = 107;
            this.lbl_n3.Text = "*";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n4.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n4.Location = new System.Drawing.Point(237, 190);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(20, 25);
            this.lbl_n4.TabIndex = 106;
            this.lbl_n4.Text = "*";
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_5.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_5.Location = new System.Drawing.Point(237, 215);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(20, 25);
            this.lbl_5.TabIndex = 105;
            this.lbl_5.Text = "*";
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n6.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n6.Location = new System.Drawing.Point(237, 243);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(20, 25);
            this.lbl_n6.TabIndex = 104;
            this.lbl_n6.Text = "*";
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n.Location = new System.Drawing.Point(165, 5);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(20, 25);
            this.lbl_n.TabIndex = 103;
            this.lbl_n.Text = "*";
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Location = new System.Drawing.Point(97, 325);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // kitotTableAdapter
            // 
            this.kitotTableAdapter.ClearBeforeFill = true;
            // 
            // hogimTableAdapter
            // 
            this.hogimTableAdapter.ClearBeforeFill = true;
            // 
            // hogimTableAdapter1
            // 
            this.hogimTableAdapter1.ClearBeforeFill = true;
            // 
            // FormHogim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 714);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnl_up);
            this.Controls.Add(this.pnl_results);
            this.Name = "FormHogim";
            this.Text = " courses";
            this.Load += new System.EventHandler(this.FormHogim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hogim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogimBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).EndInit();
            this.pnl_results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hogimBindingSource)).EndInit();
            this.pnl_up.ResumeLayout(false);
            this.pnl_up.PerformLayout();
            this.pnl_center.ResumeLayout(false);
            this.pnl_sadot.ResumeLayout(false);
            this.pnl_sadot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfActivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_hogim;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_pC;
        private System.Windows.Forms.Label lbl_lN;
        private System.Windows.Forms.Label lbl_dAW;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_lN;
        private System.Windows.Forms.Button btn_rf;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel pnl_results;
        private System.Windows.Forms.Button btn_closeResults;
        private System.Windows.Forms.DataGridView dataGridView_search;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.ComboBox comboBox_dayAWeek;
        private System.Windows.Forms.CheckedListBox cbl_participatingClasses;
        private System.Windows.Forms.BindingSource kitotBindingSource;
        private kindergardenDataSetTableAdapters.kitotTableAdapter kitotTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker hourOfStarting;
        private kindergardenDataSet kindergardenDataSet;
        private kindergardenDataSetTableAdapters.hogimTableAdapter hogimTableAdapter;
        private System.Windows.Forms.BindingSource hogimBindingSource3;
        private System.Windows.Forms.BindingSource kindergardenDataSetBindingSource;
        private System.Windows.Forms.BindingSource hogimBindingSource;
        private kindergardenDataSetTableAdapters.hogimTableAdapter hogimTableAdapter1;
        private System.Windows.Forms.ComboBox cb_hogim;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participatingClassesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturersNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayAWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneMeetingLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_oneMeetingLength;
        private System.Windows.Forms.ComboBox comboBox_oneMeetingLength;
        private System.Windows.Forms.Panel pnl_up;
        private System.Windows.Forms.Panel pnl_center;
        private System.Windows.Forms.Panel pnl_sadot;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Label lbl_n7;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_from;
    }
}

