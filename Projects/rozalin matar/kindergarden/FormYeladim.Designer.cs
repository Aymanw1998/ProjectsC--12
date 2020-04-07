namespace kindergarden
{
    partial class FormYeladim
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
            this.lbl_lN = new System.Windows.Forms.Label();
            this.lbl_fN = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_eP1 = new System.Windows.Forms.Label();
            this.lbl_eP2 = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_bD = new System.Windows.Forms.Label();
            this.dateTimePicker_BD = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_rf = new System.Windows.Forms.Button();
            this.yeladimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergardenDataSet = new kindergarden.kindergardenDataSet();
            this.yeladimTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.yeladimTableAdapter();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_results = new System.Windows.Forms.Panel();
            this.btn_closeResults = new System.Windows.Forms.Button();
            this.dataGridView_search = new System.Windows.Forms.DataGridView();
            this.lbl_result = new System.Windows.Forms.Label();
            this.dataGridView_yeladim = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyPhone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_yeladim = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.MaskedTextBox();
            this.txt_eP = new System.Windows.Forms.MaskedTextBox();
            this.txt_eP2 = new System.Windows.Forms.MaskedTextBox();
            this.pnl_up = new System.Windows.Forms.Panel();
            this.pnl_center = new System.Windows.Forms.Panel();
            this.pnl_sadot = new System.Windows.Forms.Panel();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.lbl_n = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yeladimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).BeginInit();
            this.pnl_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_yeladim)).BeginInit();
            this.pnl_up.SuspendLayout();
            this.pnl_center.SuspendLayout();
            this.pnl_sadot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_lN
            // 
            this.lbl_lN.AutoSize = true;
            this.lbl_lN.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_lN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_lN.Location = new System.Drawing.Point(3, 70);
            this.lbl_lN.Name = "lbl_lN";
            this.lbl_lN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_lN.Size = new System.Drawing.Size(80, 16);
            this.lbl_lN.TabIndex = 21;
            this.lbl_lN.Text = "Last name";
            // 
            // lbl_fN
            // 
            this.lbl_fN.AutoSize = true;
            this.lbl_fN.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_fN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_fN.Location = new System.Drawing.Point(3, 44);
            this.lbl_fN.Name = "lbl_fN";
            this.lbl_fN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_fN.Size = new System.Drawing.Size(81, 16);
            this.lbl_fN.TabIndex = 20;
            this.lbl_fN.Text = "First name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_firstName.Location = new System.Drawing.Point(90, 40);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(111, 23);
            this.txt_firstName.TabIndex = 3;
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            this.txt_firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_firstName_KeyPress);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_lastName.Location = new System.Drawing.Point(90, 66);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(111, 23);
            this.txt_lastName.TabIndex = 4;
            this.txt_lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lastName_KeyPress);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_ID.Location = new System.Drawing.Point(3, 18);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ID.Size = new System.Drawing.Size(25, 16);
            this.lbl_ID.TabIndex = 16;
            this.lbl_ID.Text = "ID";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox_gender.Location = new System.Drawing.Point(90, 91);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(111, 24);
            this.comboBox_gender.TabIndex = 5;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_gender.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_gender.Location = new System.Drawing.Point(3, 93);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_gender.Size = new System.Drawing.Size(60, 16);
            this.lbl_gender.TabIndex = 24;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_eP1
            // 
            this.lbl_eP1.AutoSize = true;
            this.lbl_eP1.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_eP1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_eP1.Location = new System.Drawing.Point(3, 149);
            this.lbl_eP1.Name = "lbl_eP1";
            this.lbl_eP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_eP1.Size = new System.Drawing.Size(134, 16);
            this.lbl_eP1.TabIndex = 25;
            this.lbl_eP1.Text = "Emergency phone";
            this.lbl_eP1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_eP2
            // 
            this.lbl_eP2.AutoSize = true;
            this.lbl_eP2.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_eP2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_eP2.Location = new System.Drawing.Point(3, 172);
            this.lbl_eP2.Name = "lbl_eP2";
            this.lbl_eP2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_eP2.Size = new System.Drawing.Size(142, 16);
            this.lbl_eP2.TabIndex = 26;
            this.lbl_eP2.Text = "Emergency phone2";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_address.Location = new System.Drawing.Point(3, 199);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_address.Size = new System.Drawing.Size(64, 16);
            this.lbl_address.TabIndex = 28;
            this.lbl_address.Text = "Address";
            // 
            // lbl_bD
            // 
            this.lbl_bD.AutoSize = true;
            this.lbl_bD.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_bD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_bD.Location = new System.Drawing.Point(3, 118);
            this.lbl_bD.Name = "lbl_bD";
            this.lbl_bD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_bD.Size = new System.Drawing.Size(103, 16);
            this.lbl_bD.TabIndex = 29;
            this.lbl_bD.Text = "Birthday date";
            // 
            // dateTimePicker_BD
            // 
            this.dateTimePicker_BD.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker_BD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_BD.Location = new System.Drawing.Point(112, 118);
            this.dateTimePicker_BD.MaxDate = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_BD.Name = "dateTimePicker_BD";
            this.dateTimePicker_BD.Size = new System.Drawing.Size(89, 23);
            this.dateTimePicker_BD.TabIndex = 6;
            this.dateTimePicker_BD.Value = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_BD.ValueChanged += new System.EventHandler(this.dateTimePicker_BD_ValueChanged);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Location = new System.Drawing.Point(35, 300);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 21);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_address.Location = new System.Drawing.Point(73, 195);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 23);
            this.txt_address.TabIndex = 9;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_address_KeyPress);
            // 
            // btn_rf
            // 
            this.btn_rf.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_rf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rf.Location = new System.Drawing.Point(6, 271);
            this.btn_rf.Name = "btn_rf";
            this.btn_rf.Size = new System.Drawing.Size(75, 23);
            this.btn_rf.TabIndex = 11;
            this.btn_rf.Text = "Refresh";
            this.btn_rf.UseVisualStyleBackColor = true;
            this.btn_rf.Click += new System.EventHandler(this.btn_rf_Click);
            // 
            // yeladimBindingSource
            // 
            this.yeladimBindingSource.DataMember = "yeladim";
            this.yeladimBindingSource.DataSource = this.kindergardenDataSet;
            // 
            // kindergardenDataSet
            // 
            this.kindergardenDataSet.DataSetName = "kindergardenDataSet";
            this.kindergardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yeladimTableAdapter
            // 
            this.yeladimTableAdapter.ClearBeforeFill = true;
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
            this.pnl_results.Location = new System.Drawing.Point(0, 404);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.Size = new System.Drawing.Size(1245, 269);
            this.pnl_results.TabIndex = 42;
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
            this.btn_closeResults.TabIndex = 14;
            this.btn_closeResults.Text = "Close";
            this.btn_closeResults.UseVisualStyleBackColor = true;
            this.btn_closeResults.Click += new System.EventHandler(this.btn_closeResults_Click);
            // 
            // dataGridView_search
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_search.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_search.Name = "dataGridView_search";
            this.dataGridView_search.Size = new System.Drawing.Size(1241, 192);
            this.dataGridView_search.TabIndex = 84;
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_result.Location = new System.Drawing.Point(0, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(1241, 30);
            this.lbl_result.TabIndex = 83;
            this.lbl_result.Text = "Search results";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_yeladim
            // 
            this.dataGridView_yeladim.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_yeladim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_yeladim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_yeladim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdayDateDataGridViewTextBoxColumn,
            this.emergencyPhoneDataGridViewTextBoxColumn,
            this.emergencyPhone2DataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView_yeladim.DataSource = this.yeladimBindingSource;
            this.dataGridView_yeladim.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_yeladim.Enabled = false;
            this.dataGridView_yeladim.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_yeladim.Name = "dataGridView_yeladim";
            this.dataGridView_yeladim.Size = new System.Drawing.Size(849, 365);
            this.dataGridView_yeladim.TabIndex = 37;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "first name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "first name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "last name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "last name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthdayDateDataGridViewTextBoxColumn
            // 
            this.birthdayDateDataGridViewTextBoxColumn.DataPropertyName = "Birthday date";
            this.birthdayDateDataGridViewTextBoxColumn.HeaderText = "Birthday date";
            this.birthdayDateDataGridViewTextBoxColumn.Name = "birthdayDateDataGridViewTextBoxColumn";
            // 
            // emergencyPhoneDataGridViewTextBoxColumn
            // 
            this.emergencyPhoneDataGridViewTextBoxColumn.DataPropertyName = "emergency phone";
            this.emergencyPhoneDataGridViewTextBoxColumn.HeaderText = "emergency phone";
            this.emergencyPhoneDataGridViewTextBoxColumn.Name = "emergencyPhoneDataGridViewTextBoxColumn";
            // 
            // emergencyPhone2DataGridViewTextBoxColumn
            // 
            this.emergencyPhone2DataGridViewTextBoxColumn.DataPropertyName = "emergency phone2";
            this.emergencyPhone2DataGridViewTextBoxColumn.HeaderText = "emergency phone2";
            this.emergencyPhone2DataGridViewTextBoxColumn.Name = "emergencyPhone2DataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
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
            this.lbl_search.TabIndex = 85;
            this.lbl_search.Text = "Search";
            this.lbl_search.Click += new System.EventHandler(this.lbl_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Location = new System.Drawing.Point(6, 242);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(156, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add a new kid";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_yeladim
            // 
            this.cb_yeladim.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_yeladim.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cb_yeladim.FormattingEnabled = true;
            this.cb_yeladim.Location = new System.Drawing.Point(0, 0);
            this.cb_yeladim.Name = "cb_yeladim";
            this.cb_yeladim.Size = new System.Drawing.Size(121, 24);
            this.cb_yeladim.TabIndex = 0;
            this.cb_yeladim.SelectedIndexChanged += new System.EventHandler(this.cb_yeladim_SelectedIndexChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Location = new System.Drawing.Point(87, 271);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_ID.Location = new System.Drawing.Point(90, 14);
            this.txt_ID.Mask = "000000000";
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(111, 23);
            this.txt_ID.TabIndex = 2;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // txt_eP
            // 
            this.txt_eP.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_eP.Location = new System.Drawing.Point(151, 145);
            this.txt_eP.Mask = "0000000009";
            this.txt_eP.Name = "txt_eP";
            this.txt_eP.Size = new System.Drawing.Size(103, 23);
            this.txt_eP.TabIndex = 7;
            this.txt_eP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_eP_KeyPress);
            // 
            // txt_eP2
            // 
            this.txt_eP2.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_eP2.Location = new System.Drawing.Point(151, 172);
            this.txt_eP2.Mask = "0000000009";
            this.txt_eP2.Name = "txt_eP2";
            this.txt_eP2.Size = new System.Drawing.Size(100, 23);
            this.txt_eP2.TabIndex = 8;
            this.txt_eP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_eP2_KeyPress);
            // 
            // pnl_up
            // 
            this.pnl_up.Controls.Add(this.txt_search);
            this.pnl_up.Controls.Add(this.lbl_search);
            this.pnl_up.Controls.Add(this.cb_yeladim);
            this.pnl_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_up.Location = new System.Drawing.Point(0, 0);
            this.pnl_up.Name = "pnl_up";
            this.pnl_up.Size = new System.Drawing.Size(1245, 39);
            this.pnl_up.TabIndex = 106;
            // 
            // pnl_center
            // 
            this.pnl_center.Controls.Add(this.pnl_sadot);
            this.pnl_center.Controls.Add(this.dataGridView_yeladim);
            this.pnl_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_center.Location = new System.Drawing.Point(0, 39);
            this.pnl_center.Name = "pnl_center";
            this.pnl_center.Size = new System.Drawing.Size(1245, 365);
            this.pnl_center.TabIndex = 107;
            this.pnl_center.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_center_Paint);
            // 
            // pnl_sadot
            // 
            this.pnl_sadot.Controls.Add(this.lbl_n6);
            this.pnl_sadot.Controls.Add(this.lbl_n4);
            this.pnl_sadot.Controls.Add(this.lbl_n2);
            this.pnl_sadot.Controls.Add(this.lbl_n3);
            this.pnl_sadot.Controls.Add(this.lbl_n5);
            this.pnl_sadot.Controls.Add(this.lbl_n);
            this.pnl_sadot.Controls.Add(this.lbl_ID);
            this.pnl_sadot.Controls.Add(this.txt_lastName);
            this.pnl_sadot.Controls.Add(this.txt_firstName);
            this.pnl_sadot.Controls.Add(this.btn_delete);
            this.pnl_sadot.Controls.Add(this.txt_eP2);
            this.pnl_sadot.Controls.Add(this.btn_add);
            this.pnl_sadot.Controls.Add(this.lbl_fN);
            this.pnl_sadot.Controls.Add(this.txt_eP);
            this.pnl_sadot.Controls.Add(this.btn_rf);
            this.pnl_sadot.Controls.Add(this.lbl_lN);
            this.pnl_sadot.Controls.Add(this.btn_save);
            this.pnl_sadot.Controls.Add(this.txt_ID);
            this.pnl_sadot.Controls.Add(this.comboBox_gender);
            this.pnl_sadot.Controls.Add(this.lbl_gender);
            this.pnl_sadot.Controls.Add(this.lbl_eP1);
            this.pnl_sadot.Controls.Add(this.lbl_eP2);
            this.pnl_sadot.Controls.Add(this.lbl_address);
            this.pnl_sadot.Controls.Add(this.lbl_bD);
            this.pnl_sadot.Controls.Add(this.txt_address);
            this.pnl_sadot.Controls.Add(this.dateTimePicker_BD);
            this.pnl_sadot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sadot.Location = new System.Drawing.Point(907, 0);
            this.pnl_sadot.Name = "pnl_sadot";
            this.pnl_sadot.Size = new System.Drawing.Size(338, 365);
            this.pnl_sadot.TabIndex = 108;
            this.pnl_sadot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_sadot_Paint);
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n6.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n6.Location = new System.Drawing.Point(257, 145);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(20, 25);
            this.lbl_n6.TabIndex = 111;
            this.lbl_n6.Text = "*";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n4.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n4.Location = new System.Drawing.Point(196, 87);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(20, 25);
            this.lbl_n4.TabIndex = 110;
            this.lbl_n4.Text = "*";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n2.Location = new System.Drawing.Point(197, 40);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(20, 25);
            this.lbl_n2.TabIndex = 109;
            this.lbl_n2.Text = "*";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n3.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n3.Location = new System.Drawing.Point(197, 61);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(20, 25);
            this.lbl_n3.TabIndex = 108;
            this.lbl_n3.Text = "*";
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n5.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n5.Location = new System.Drawing.Point(196, 115);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(20, 25);
            this.lbl_n5.TabIndex = 107;
            this.lbl_n5.Text = "*";
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_n.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_n.Location = new System.Drawing.Point(196, 10);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(20, 25);
            this.lbl_n.TabIndex = 106;
            this.lbl_n.Text = "*";
            // 
            // FormYeladim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 673);
            this.Controls.Add(this.pnl_center);
            this.Controls.Add(this.pnl_up);
            this.Controls.Add(this.pnl_results);
            this.Name = "FormYeladim";
            this.Text = "Children";
            this.Load += new System.EventHandler(this.FormYeladim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yeladimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).EndInit();
            this.pnl_results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_yeladim)).EndInit();
            this.pnl_up.ResumeLayout(false);
            this.pnl_up.PerformLayout();
            this.pnl_center.ResumeLayout(false);
            this.pnl_sadot.ResumeLayout(false);
            this.pnl_sadot.PerformLayout();
            this.ResumeLayout(false);

        }

        private void comboSearch_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_lN;
        private System.Windows.Forms.Label lbl_fN;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_eP1;
        private System.Windows.Forms.Label lbl_eP2;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_bD;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BD;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_rf;
        private kindergardenDataSet kindergardenDataSet;
        private System.Windows.Forms.BindingSource yeladimBindingSource;
        private kindergardenDataSetTableAdapters.yeladimTableAdapter yeladimTableAdapter;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel pnl_results;
        private System.Windows.Forms.Button btn_closeResults;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.DataGridView dataGridView_yeladim;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyPhone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hMoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_yeladim;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.MaskedTextBox txt_ID;
        private System.Windows.Forms.MaskedTextBox txt_eP;
        private System.Windows.Forms.MaskedTextBox txt_eP2;
        private System.Windows.Forms.Panel pnl_up;
        private System.Windows.Forms.Panel pnl_center;
        private System.Windows.Forms.Panel pnl_sadot;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Label lbl_n6;
    }
}