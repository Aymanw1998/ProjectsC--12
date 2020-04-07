namespace DarQuran
{
    partial class Korsim
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
            this.dataGridViewKorsim = new System.Windows.Forms.DataGridView();
            this.InFormKors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemKorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemMoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOpenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCloseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InKors = new System.Windows.Forms.DataGridViewButtonColumn();
            this.korsimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darQuranDataSet = new DarQuran.DarQuranDataSet();
            this.korsimTableAdapter = new DarQuran.DarQuranDataSetTableAdapters.korsimTableAdapter();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.buttonE = new System.Windows.Forms.Button();
            this.comboBoxETeacher = new System.Windows.Forms.ComboBox();
            this.comboBoxEDay = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEClose = new System.Windows.Forms.DateTimePicker();
            this.lblEClose = new System.Windows.Forms.Label();
            this.lblEDay = new System.Windows.Forms.Label();
            this.labelEDay = new System.Windows.Forms.Label();
            this.labelENameTeacher = new System.Windows.Forms.Label();
            this.textBoxEID = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerEOpen = new System.Windows.Forms.DateTimePicker();
            this.labelEKors = new System.Windows.Forms.Label();
            this.lblEOpen = new System.Windows.Forms.Label();
            this.lblETeacher = new System.Windows.Forms.Label();
            this.lblEKors = new System.Windows.Forms.Label();
            this.lblEID = new System.Windows.Forms.Label();
            this.textBoxENameKors = new System.Windows.Forms.TextBox();
            this.buttonDeleteK = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonNewK = new System.Windows.Forms.Button();
            this.panelNewK = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePickerClose = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.buttonInKorsim = new System.Windows.Forms.Button();
            this.labelNameTeacher = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerOpen = new System.Windows.Forms.DateTimePicker();
            this.labelKors = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblKors = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.textBoxNameKors = new System.Windows.Forms.TextBox();
            this.saveTimeAndDateTableAdapter1 = new DarQuran.DarQuranDataSetTableAdapters.SaveTimeAndDateTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorsim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korsimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.panelNewK.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKorsim
            // 
            this.dataGridViewKorsim.AutoGenerateColumns = false;
            this.dataGridViewKorsim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorsim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InFormKors,
            this.shemKorsDataGridViewTextBoxColumn,
            this.shemMoraDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.timeOpenDataGridViewTextBoxColumn,
            this.timeCloseDataGridViewTextBoxColumn,
            this.InKors});
            this.dataGridViewKorsim.DataSource = this.korsimBindingSource;
            this.dataGridViewKorsim.Location = new System.Drawing.Point(220, 50);
            this.dataGridViewKorsim.Name = "dataGridViewKorsim";
            this.dataGridViewKorsim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewKorsim.Size = new System.Drawing.Size(772, 150);
            this.dataGridViewKorsim.TabIndex = 0;
            this.dataGridViewKorsim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKorsim_CellContentClick);
            this.dataGridViewKorsim.DoubleClick += new System.EventHandler(this.dataGridViewKorsim_DoubleClick);
            // 
            // InFormKors
            // 
            this.InFormKors.DataPropertyName = "tzKors";
            this.InFormKors.HeaderText = "الرقم الخاص";
            this.InFormKors.Name = "InFormKors";
            // 
            // shemKorsDataGridViewTextBoxColumn
            // 
            this.shemKorsDataGridViewTextBoxColumn.DataPropertyName = "shemKors";
            this.shemKorsDataGridViewTextBoxColumn.HeaderText = "الدورة";
            this.shemKorsDataGridViewTextBoxColumn.Name = "shemKorsDataGridViewTextBoxColumn";
            // 
            // shemMoraDataGridViewTextBoxColumn
            // 
            this.shemMoraDataGridViewTextBoxColumn.DataPropertyName = "shemMora";
            this.shemMoraDataGridViewTextBoxColumn.HeaderText = "الاستاذ";
            this.shemMoraDataGridViewTextBoxColumn.Name = "shemMoraDataGridViewTextBoxColumn";
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "يوم تعليم";
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            // 
            // timeOpenDataGridViewTextBoxColumn
            // 
            this.timeOpenDataGridViewTextBoxColumn.DataPropertyName = "TimeOpen";
            this.timeOpenDataGridViewTextBoxColumn.HeaderText = "وقت البدء";
            this.timeOpenDataGridViewTextBoxColumn.Name = "timeOpenDataGridViewTextBoxColumn";
            // 
            // timeCloseDataGridViewTextBoxColumn
            // 
            this.timeCloseDataGridViewTextBoxColumn.DataPropertyName = "TimeClose";
            this.timeCloseDataGridViewTextBoxColumn.HeaderText = "وقت الانتهاء";
            this.timeCloseDataGridViewTextBoxColumn.Name = "timeCloseDataGridViewTextBoxColumn";
            // 
            // InKors
            // 
            this.InKors.HeaderText = "ادخل";
            this.InKors.Name = "InKors";
            this.InKors.Text = "ادخل";
            this.InKors.ToolTipText = "ادخل";
            this.InKors.UseColumnTextForButtonValue = true;
            // 
            // korsimBindingSource
            // 
            this.korsimBindingSource.DataMember = "korsim";
            this.korsimBindingSource.DataSource = this.darQuranDataSet;
            // 
            // darQuranDataSet
            // 
            this.darQuranDataSet.DataSetName = "DarQuranDataSet";
            this.darQuranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korsimTableAdapter
            // 
            this.korsimTableAdapter.ClearBeforeFill = true;
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Yellow;
            this.panelEdit.Controls.Add(this.buttonE);
            this.panelEdit.Controls.Add(this.comboBoxETeacher);
            this.panelEdit.Controls.Add(this.comboBoxEDay);
            this.panelEdit.Controls.Add(this.dateTimePickerEClose);
            this.panelEdit.Controls.Add(this.lblEClose);
            this.panelEdit.Controls.Add(this.lblEDay);
            this.panelEdit.Controls.Add(this.labelEDay);
            this.panelEdit.Controls.Add(this.labelENameTeacher);
            this.panelEdit.Controls.Add(this.textBoxEID);
            this.panelEdit.Controls.Add(this.dateTimePickerEOpen);
            this.panelEdit.Controls.Add(this.labelEKors);
            this.panelEdit.Controls.Add(this.lblEOpen);
            this.panelEdit.Controls.Add(this.lblETeacher);
            this.panelEdit.Controls.Add(this.lblEKors);
            this.panelEdit.Controls.Add(this.lblEID);
            this.panelEdit.Controls.Add(this.textBoxENameKors);
            this.panelEdit.Controls.Add(this.buttonDeleteK);
            this.panelEdit.Controls.Add(this.buttonEdit);
            this.panelEdit.Location = new System.Drawing.Point(719, 253);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(311, 312);
            this.panelEdit.TabIndex = 32;
            this.panelEdit.Visible = false;
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Red;
            this.buttonE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.ForeColor = System.Drawing.Color.Blue;
            this.buttonE.Location = new System.Drawing.Point(3, 2);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(75, 38);
            this.buttonE.TabIndex = 59;
            this.buttonE.Text = "اغلاق صفحة التعديل";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // comboBoxETeacher
            // 
            this.comboBoxETeacher.FormattingEnabled = true;
            this.comboBoxETeacher.Location = new System.Drawing.Point(114, 101);
            this.comboBoxETeacher.Name = "comboBoxETeacher";
            this.comboBoxETeacher.Size = new System.Drawing.Size(112, 21);
            this.comboBoxETeacher.TabIndex = 58;
            this.comboBoxETeacher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxETeacher_KeyDown);
            // 
            // comboBoxEDay
            // 
            this.comboBoxEDay.FormattingEnabled = true;
            this.comboBoxEDay.Items.AddRange(new object[] {
            "الاحد",
            "الاثنين",
            "الثلاثاء",
            "الاربعاء",
            "الخميس",
            "الجمعة ",
            "السبت"});
            this.comboBoxEDay.Location = new System.Drawing.Point(114, 145);
            this.comboBoxEDay.Name = "comboBoxEDay";
            this.comboBoxEDay.Size = new System.Drawing.Size(111, 21);
            this.comboBoxEDay.TabIndex = 57;
            this.comboBoxEDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEDay_KeyDown);
            // 
            // dateTimePickerEClose
            // 
            this.dateTimePickerEClose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimePickerEClose.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerEClose.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEClose.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerEClose.Location = new System.Drawing.Point(114, 222);
            this.dateTimePickerEClose.Name = "dateTimePickerEClose";
            this.dateTimePickerEClose.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerEClose.TabIndex = 56;
            this.dateTimePickerEClose.Value = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            this.dateTimePickerEClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerEClose_KeyDown);
            // 
            // lblEClose
            // 
            this.lblEClose.AutoSize = true;
            this.lblEClose.Location = new System.Drawing.Point(246, 229);
            this.lblEClose.Name = "lblEClose";
            this.lblEClose.Size = new System.Drawing.Size(63, 13);
            this.lblEClose.TabIndex = 54;
            this.lblEClose.Text = "وقت الانتهاء";
            // 
            // lblEDay
            // 
            this.lblEDay.AutoSize = true;
            this.lblEDay.Location = new System.Drawing.Point(243, 151);
            this.lblEDay.Name = "lblEDay";
            this.lblEDay.Size = new System.Drawing.Size(53, 13);
            this.lblEDay.TabIndex = 53;
            this.lblEDay.Text = "يوم التعليم";
            // 
            // labelEDay
            // 
            this.labelEDay.AutoSize = true;
            this.labelEDay.Enabled = false;
            this.labelEDay.ForeColor = System.Drawing.Color.Red;
            this.labelEDay.Location = new System.Drawing.Point(119, 168);
            this.labelEDay.Name = "labelEDay";
            this.labelEDay.Size = new System.Drawing.Size(41, 13);
            this.labelEDay.TabIndex = 51;
            this.labelEDay.Text = "label24";
            this.labelEDay.Visible = false;
            // 
            // labelENameTeacher
            // 
            this.labelENameTeacher.AutoSize = true;
            this.labelENameTeacher.Enabled = false;
            this.labelENameTeacher.ForeColor = System.Drawing.Color.Red;
            this.labelENameTeacher.Location = new System.Drawing.Point(119, 127);
            this.labelENameTeacher.Name = "labelENameTeacher";
            this.labelENameTeacher.Size = new System.Drawing.Size(41, 13);
            this.labelENameTeacher.TabIndex = 52;
            this.labelENameTeacher.Text = "label26";
            this.labelENameTeacher.Visible = false;
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(114, 21);
            this.textBoxEID.Mask = "000009999";
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(111, 20);
            this.textBoxEID.TabIndex = 47;
            // 
            // dateTimePickerEOpen
            // 
            this.dateTimePickerEOpen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimePickerEOpen.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerEOpen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEOpen.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerEOpen.Location = new System.Drawing.Point(114, 181);
            this.dateTimePickerEOpen.Name = "dateTimePickerEOpen";
            this.dateTimePickerEOpen.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerEOpen.TabIndex = 43;
            this.dateTimePickerEOpen.Value = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            this.dateTimePickerEOpen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerEOpen_KeyDown);
            // 
            // labelEKors
            // 
            this.labelEKors.AutoSize = true;
            this.labelEKors.Enabled = false;
            this.labelEKors.ForeColor = System.Drawing.Color.Red;
            this.labelEKors.Location = new System.Drawing.Point(119, 86);
            this.labelEKors.Name = "labelEKors";
            this.labelEKors.Size = new System.Drawing.Size(41, 13);
            this.labelEKors.TabIndex = 49;
            this.labelEKors.Text = "label20";
            this.labelEKors.Visible = false;
            // 
            // lblEOpen
            // 
            this.lblEOpen.AutoSize = true;
            this.lblEOpen.Location = new System.Drawing.Point(246, 186);
            this.lblEOpen.Name = "lblEOpen";
            this.lblEOpen.Size = new System.Drawing.Size(51, 13);
            this.lblEOpen.TabIndex = 46;
            this.lblEOpen.Text = "وقت البدء";
            // 
            // lblETeacher
            // 
            this.lblETeacher.AutoSize = true;
            this.lblETeacher.Location = new System.Drawing.Point(243, 107);
            this.lblETeacher.Name = "lblETeacher";
            this.lblETeacher.Size = new System.Drawing.Size(38, 13);
            this.lblETeacher.TabIndex = 45;
            this.lblETeacher.Text = "الاستاذ";
            // 
            // lblEKors
            // 
            this.lblEKors.AutoSize = true;
            this.lblEKors.Location = new System.Drawing.Point(243, 63);
            this.lblEKors.Name = "lblEKors";
            this.lblEKors.Size = new System.Drawing.Size(35, 13);
            this.lblEKors.TabIndex = 44;
            this.lblEKors.Text = "الدورة";
            // 
            // lblEID
            // 
            this.lblEID.AutoSize = true;
            this.lblEID.Location = new System.Drawing.Point(237, 24);
            this.lblEID.Name = "lblEID";
            this.lblEID.Size = new System.Drawing.Size(54, 13);
            this.lblEID.TabIndex = 42;
            this.lblEID.Text = "رقم الخاص";
            // 
            // textBoxENameKors
            // 
            this.textBoxENameKors.Location = new System.Drawing.Point(115, 60);
            this.textBoxENameKors.Name = "textBoxENameKors";
            this.textBoxENameKors.Size = new System.Drawing.Size(111, 20);
            this.textBoxENameKors.TabIndex = 41;
            this.textBoxENameKors.TextChanged += new System.EventHandler(this.textBoxENameKors_TextChanged);
            this.textBoxENameKors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxENameKors_KeyDown);
            this.textBoxENameKors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxENameKors_KeyPress);
            // 
            // buttonDeleteK
            // 
            this.buttonDeleteK.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteK.Location = new System.Drawing.Point(29, 274);
            this.buttonDeleteK.Name = "buttonDeleteK";
            this.buttonDeleteK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDeleteK.Size = new System.Drawing.Size(100, 36);
            this.buttonDeleteK.TabIndex = 29;
            this.buttonDeleteK.Text = "حذف";
            this.buttonDeleteK.UseVisualStyleBackColor = false;
            this.buttonDeleteK.Click += new System.EventHandler(this.buttonDeleteK_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Lime;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(177, 274);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonEdit.Size = new System.Drawing.Size(100, 36);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.buttonSearch.BackColor = System.Drawing.Color.Gold;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(30, 626);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(671, 23);
            this.buttonSearch.TabIndex = 31;
            this.buttonSearch.Text = "بحث عن دورة ";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Gold;
            this.panelSearch.Controls.Add(this.button1);
            this.panelSearch.Controls.Add(this.dataGridViewSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Location = new System.Drawing.Point(30, 208);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(671, 420);
            this.panelSearch.TabIndex = 30;
            this.panelSearch.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(596, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 59;
            this.button1.Text = "أغلق بحث الكرس";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewSearch.Size = new System.Drawing.Size(671, 329);
            this.dataGridViewSearch.TabIndex = 10;
            this.dataGridViewSearch.Visible = false;
            this.dataGridViewSearch.DoubleClick += new System.EventHandler(this.dataGridViewSearch_DoubleClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxSearch.Location = new System.Drawing.Point(91, 49);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(257, 29);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Miriam Fixed", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSearch.ForeColor = System.Drawing.Color.Red;
            this.labelSearch.Location = new System.Drawing.Point(389, 45);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(59, 35);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "بحث";
            // 
            // buttonNewK
            // 
            this.buttonNewK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonNewK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNewK.Location = new System.Drawing.Point(1049, 603);
            this.buttonNewK.Name = "buttonNewK";
            this.buttonNewK.Size = new System.Drawing.Size(308, 46);
            this.buttonNewK.TabIndex = 29;
            this.buttonNewK.Text = "ادخال دورة جديد";
            this.buttonNewK.UseVisualStyleBackColor = false;
            this.buttonNewK.Click += new System.EventHandler(this.buttonNewK_Click);
            // 
            // panelNewK
            // 
            this.panelNewK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelNewK.Controls.Add(this.button2);
            this.panelNewK.Controls.Add(this.dateTimePickerClose);
            this.panelNewK.Controls.Add(this.comboBoxTeacher);
            this.panelNewK.Controls.Add(this.comboBoxDay);
            this.panelNewK.Controls.Add(this.lblClose);
            this.panelNewK.Controls.Add(this.lblDay);
            this.panelNewK.Controls.Add(this.labelDay);
            this.panelNewK.Controls.Add(this.buttonInKorsim);
            this.panelNewK.Controls.Add(this.labelNameTeacher);
            this.panelNewK.Controls.Add(this.textBoxID);
            this.panelNewK.Controls.Add(this.dateTimePickerOpen);
            this.panelNewK.Controls.Add(this.labelKors);
            this.panelNewK.Controls.Add(this.labelID);
            this.panelNewK.Controls.Add(this.lblOpen);
            this.panelNewK.Controls.Add(this.lblTeacher);
            this.panelNewK.Controls.Add(this.lblKors);
            this.panelNewK.Controls.Add(this.lblID);
            this.panelNewK.Controls.Add(this.textBoxNameKors);
            this.panelNewK.Location = new System.Drawing.Point(1046, 357);
            this.panelNewK.Name = "panelNewK";
            this.panelNewK.Size = new System.Drawing.Size(308, 249);
            this.panelNewK.TabIndex = 28;
            this.panelNewK.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 60;
            this.button2.Text = "أغلق ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePickerClose
            // 
            this.dateTimePickerClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerClose.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerClose.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerClose.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerClose.Location = new System.Drawing.Point(110, 203);
            this.dateTimePickerClose.Name = "dateTimePickerClose";
            this.dateTimePickerClose.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerClose.TabIndex = 41;
            this.dateTimePickerClose.Value = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            this.dateTimePickerClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerClose_KeyDown);
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(109, 83);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(112, 21);
            this.comboBoxTeacher.TabIndex = 40;
            this.comboBoxTeacher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxTeacher_KeyDown);
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "الاحد",
            "الاثنين",
            "الثلاثاء",
            "الاربعاء",
            "الخميس",
            "الجمعة ",
            "السبت"});
            this.comboBoxDay.Location = new System.Drawing.Point(109, 127);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(111, 21);
            this.comboBoxDay.TabIndex = 39;
            this.comboBoxDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxDay_KeyDown);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(241, 211);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(63, 13);
            this.lblClose.TabIndex = 36;
            this.lblClose.Text = "وقت الانتهاء";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(238, 133);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(53, 13);
            this.lblDay.TabIndex = 28;
            this.lblDay.Text = "يوم التعليم";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.ForeColor = System.Drawing.Color.Red;
            this.labelDay.Location = new System.Drawing.Point(102, 149);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(41, 13);
            this.labelDay.TabIndex = 25;
            this.labelDay.Text = "label24";
            this.labelDay.Visible = false;
            // 
            // buttonInKorsim
            // 
            this.buttonInKorsim.BackColor = System.Drawing.Color.Lime;
            this.buttonInKorsim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInKorsim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInKorsim.Location = new System.Drawing.Point(3, 204);
            this.buttonInKorsim.Name = "buttonInKorsim";
            this.buttonInKorsim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonInKorsim.Size = new System.Drawing.Size(82, 36);
            this.buttonInKorsim.TabIndex = 12;
            this.buttonInKorsim.Text = "ادخال ";
            this.buttonInKorsim.UseVisualStyleBackColor = false;
            this.buttonInKorsim.Click += new System.EventHandler(this.buttonInKorsim_Click);
            // 
            // labelNameTeacher
            // 
            this.labelNameTeacher.AutoSize = true;
            this.labelNameTeacher.ForeColor = System.Drawing.Color.Red;
            this.labelNameTeacher.Location = new System.Drawing.Point(102, 108);
            this.labelNameTeacher.Name = "labelNameTeacher";
            this.labelNameTeacher.Size = new System.Drawing.Size(41, 13);
            this.labelNameTeacher.TabIndex = 27;
            this.labelNameTeacher.Text = "label26";
            this.labelNameTeacher.Visible = false;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(109, 3);
            this.textBoxID.Mask = "000009999";
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(111, 20);
            this.textBoxID.TabIndex = 14;
            this.textBoxID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxID_KeyDown);
            // 
            // dateTimePickerOpen
            // 
            this.dateTimePickerOpen.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dateTimePickerOpen.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerOpen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerOpen.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerOpen.Location = new System.Drawing.Point(109, 163);
            this.dateTimePickerOpen.Name = "dateTimePickerOpen";
            this.dateTimePickerOpen.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerOpen.TabIndex = 6;
            this.dateTimePickerOpen.Tag = "00:00:00";
            this.dateTimePickerOpen.UseWaitCursor = true;
            this.dateTimePickerOpen.Value = new System.DateTime(2016, 12, 6, 0, 0, 0, 0);
            this.dateTimePickerOpen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerOpen_KeyDown);
            // 
            // labelKors
            // 
            this.labelKors.AutoSize = true;
            this.labelKors.ForeColor = System.Drawing.Color.Red;
            this.labelKors.Location = new System.Drawing.Point(102, 67);
            this.labelKors.Name = "labelKors";
            this.labelKors.Size = new System.Drawing.Size(41, 13);
            this.labelKors.TabIndex = 21;
            this.labelKors.Text = "label20";
            this.labelKors.Visible = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.Color.Red;
            this.labelID.Location = new System.Drawing.Point(102, 25);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 13);
            this.labelID.TabIndex = 20;
            this.labelID.Text = "label19";
            this.labelID.Visible = false;
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(238, 169);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(51, 13);
            this.lblOpen.TabIndex = 10;
            this.lblOpen.Text = "وقت البدء";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(238, 89);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(38, 13);
            this.lblTeacher.TabIndex = 9;
            this.lblTeacher.Text = "الاستاذ";
            // 
            // lblKors
            // 
            this.lblKors.AutoSize = true;
            this.lblKors.Location = new System.Drawing.Point(238, 45);
            this.lblKors.Name = "lblKors";
            this.lblKors.Size = new System.Drawing.Size(35, 13);
            this.lblKors.TabIndex = 7;
            this.lblKors.Text = "الدورة";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(232, 6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(54, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "رقم الخاص";
            // 
            // textBoxNameKors
            // 
            this.textBoxNameKors.Location = new System.Drawing.Point(110, 42);
            this.textBoxNameKors.Name = "textBoxNameKors";
            this.textBoxNameKors.Size = new System.Drawing.Size(111, 20);
            this.textBoxNameKors.TabIndex = 5;
            this.textBoxNameKors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNameKors_KeyDown);
            this.textBoxNameKors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameKors_KeyPress);
            // 
            // saveTimeAndDateTableAdapter1
            // 
            this.saveTimeAndDateTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(572, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 42);
            this.label1.TabIndex = 33;
            this.label1.Text = "الدورات";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(1061, 77);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(250, 50);
            this.label12.TabIndex = 36;
            this.label12.Text = "أضغط مرتيين متتاليتان على السطر\r\n الذي تريد تعديله او حذفه\r\n";
            // 
            // Korsim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 661);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.buttonNewK);
            this.Controls.Add(this.panelNewK);
            this.Controls.Add(this.dataGridViewKorsim);
            this.Name = "Korsim";
            this.Text = "Korsim";
            this.Load += new System.EventHandler(this.Korsim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorsim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korsimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darQuranDataSet)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.panelNewK.ResumeLayout(false);
            this.panelNewK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKorsim;
        private DarQuranDataSet darQuranDataSet;
        private System.Windows.Forms.BindingSource korsimBindingSource;
        private DarQuranDataSetTableAdapters.korsimTableAdapter korsimTableAdapter;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button buttonDeleteK;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonNewK;
        private System.Windows.Forms.Panel panelNewK;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button buttonInKorsim;
        private System.Windows.Forms.Label labelNameTeacher;
        private System.Windows.Forms.MaskedTextBox textBoxID;
        private System.Windows.Forms.DateTimePicker dateTimePickerOpen;
        private System.Windows.Forms.Label labelKors;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblKors;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBoxNameKors;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxETeacher;
        private System.Windows.Forms.ComboBox comboBoxEDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerEClose;
        private System.Windows.Forms.Label lblEClose;
        private System.Windows.Forms.Label lblEDay;
        private System.Windows.Forms.Label labelEDay;
        private System.Windows.Forms.Label labelENameTeacher;
        private System.Windows.Forms.MaskedTextBox textBoxEID;
        private System.Windows.Forms.DateTimePicker dateTimePickerEOpen;
        private System.Windows.Forms.Label labelEKors;
        private System.Windows.Forms.Label lblEOpen;
        private System.Windows.Forms.Label lblETeacher;
        private System.Windows.Forms.Label lblEKors;
        private System.Windows.Forms.Label lblEID;
        private System.Windows.Forms.TextBox textBoxENameKors;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemKorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemMoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOpenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCloseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn InKors;
        private System.Windows.Forms.DateTimePicker dateTimePickerClose;
        public System.Windows.Forms.DataGridViewTextBoxColumn InFormKors;
        private DarQuranDataSetTableAdapters.SaveTimeAndDateTableAdapter saveTimeAndDateTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonE;
    }
}