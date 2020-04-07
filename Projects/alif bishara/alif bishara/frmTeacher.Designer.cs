namespace alif_bishara
{
    partial class frmTeacher
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Alif_s_databaseDataSet = new alif_bishara._Alif_s_databaseDataSet();
            this.lblTtz = new System.Windows.Forms.Label();
            this.lblTsham = new System.Windows.Forms.Label();
            this.lblTshamfamily = new System.Windows.Forms.Label();
            this.lblTtel = new System.Windows.Forms.Label();
            this.lblTsahar = new System.Windows.Forms.Label();
            this.lblTair = new System.Windows.Forms.Label();
            this.btnOkAdd = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnOkDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTair = new System.Windows.Forms.MaskedTextBox();
            this.txtTtz = new System.Windows.Forms.MaskedTextBox();
            this.txtTsahar = new System.Windows.Forms.MaskedTextBox();
            this.txtTtel = new System.Windows.Forms.MaskedTextBox();
            this.txtTshamfamily = new System.Windows.Forms.MaskedTextBox();
            this.txtTsham = new System.Windows.Forms.MaskedTextBox();
            this.btnADdteacher = new System.Windows.Forms.Button();
            this.btnDeleteteacher = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.teachersTableAdapter = new alif_bishara._Alif_s_databaseDataSetTableAdapters.teachersTableAdapter();
            this.btnokupdate = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnupdateteacher = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAirUpdate = new System.Windows.Forms.MaskedTextBox();
            this.txtSaharUpdate = new System.Windows.Forms.MaskedTextBox();
            this.txtTelUpdate = new System.Windows.Forms.MaskedTextBox();
            this.txtTZupdate = new System.Windows.Forms.MaskedTextBox();
            this.lblair = new System.Windows.Forms.Label();
            this.lblsahar = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lbltz2 = new System.Windows.Forms.Label();
            this.btnopenpanelsalary = new System.Windows.Forms.Button();
            this.panelsahar = new System.Windows.Forms.Panel();
            this.btncalall = new System.Windows.Forms.Button();
            this.btncalculate1 = new System.Windows.Forms.Button();
            this.txtsaharcal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combosahar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Alif_s_databaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelsahar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.teachersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 103);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TZ";
            this.dataGridViewTextBoxColumn1.HeaderText = "TZ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sham";
            this.dataGridViewTextBoxColumn2.HeaderText = "sham";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "shamf";
            this.dataGridViewTextBoxColumn3.HeaderText = "shamf";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tel";
            this.dataGridViewTextBoxColumn4.HeaderText = "tel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "sahar";
            this.dataGridViewTextBoxColumn5.HeaderText = "sahar";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "shaot avoda";
            this.dataGridViewTextBoxColumn6.HeaderText = "shaot avoda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "air";
            this.dataGridViewTextBoxColumn7.HeaderText = "air";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this._Alif_s_databaseDataSet;
            // 
            // _Alif_s_databaseDataSet
            // 
            this._Alif_s_databaseDataSet.DataSetName = "_Alif_s_databaseDataSet";
            this._Alif_s_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTtz
            // 
            this.lblTtz.AutoSize = true;
            this.lblTtz.Location = new System.Drawing.Point(242, 3);
            this.lblTtz.Name = "lblTtz";
            this.lblTtz.Size = new System.Drawing.Size(112, 25);
            this.lblTtz.TabIndex = 8;
            this.lblTtz.Text = "תעודת זהות";
            // 
            // lblTsham
            // 
            this.lblTsham.AutoSize = true;
            this.lblTsham.Location = new System.Drawing.Point(246, 28);
            this.lblTsham.Name = "lblTsham";
            this.lblTsham.Size = new System.Drawing.Size(41, 25);
            this.lblTsham.TabIndex = 9;
            this.lblTsham.Text = "שם";
            this.lblTsham.Click += new System.EventHandler(this.lblTsham_Click);
            // 
            // lblTshamfamily
            // 
            this.lblTshamfamily.AutoSize = true;
            this.lblTshamfamily.Location = new System.Drawing.Point(246, 73);
            this.lblTshamfamily.Name = "lblTshamfamily";
            this.lblTshamfamily.Size = new System.Drawing.Size(112, 25);
            this.lblTshamfamily.TabIndex = 10;
            this.lblTshamfamily.Text = "שם משפחה";
            // 
            // lblTtel
            // 
            this.lblTtel.AutoSize = true;
            this.lblTtel.Location = new System.Drawing.Point(242, 99);
            this.lblTtel.Name = "lblTtel";
            this.lblTtel.Size = new System.Drawing.Size(57, 25);
            this.lblTtel.TabIndex = 11;
            this.lblTtel.Text = "טלפון";
            // 
            // lblTsahar
            // 
            this.lblTsahar.AutoSize = true;
            this.lblTsahar.Location = new System.Drawing.Point(242, 140);
            this.lblTsahar.Name = "lblTsahar";
            this.lblTsahar.Size = new System.Drawing.Size(103, 25);
            this.lblTsahar.TabIndex = 12;
            this.lblTsahar.Text = "שכר לשעה";
            this.lblTsahar.Click += new System.EventHandler(this.lblTsahar_Click);
            // 
            // lblTair
            // 
            this.lblTair.AutoSize = true;
            this.lblTair.Location = new System.Drawing.Point(242, 178);
            this.lblTair.Name = "lblTair";
            this.lblTair.Size = new System.Drawing.Size(41, 25);
            this.lblTair.TabIndex = 13;
            this.lblTair.Text = "עיר";
            // 
            // btnOkAdd
            // 
            this.btnOkAdd.BackColor = System.Drawing.Color.Lime;
            this.btnOkAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkAdd.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOkAdd.Location = new System.Drawing.Point(25, 357);
            this.btnOkAdd.Name = "btnOkAdd";
            this.btnOkAdd.Size = new System.Drawing.Size(114, 52);
            this.btnOkAdd.TabIndex = 14;
            this.btnOkAdd.Text = "הוסף";
            this.btnOkAdd.UseVisualStyleBackColor = false;
            this.btnOkAdd.Visible = false;
            this.btnOkAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclean
            // 
            this.btnclean.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnclean.Location = new System.Drawing.Point(159, 353);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(107, 52);
            this.btnclean.TabIndex = 15;
            this.btnclean.Text = "נקה";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Visible = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnOkDelete
            // 
            this.btnOkDelete.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOkDelete.Location = new System.Drawing.Point(25, 415);
            this.btnOkDelete.Name = "btnOkDelete";
            this.btnOkDelete.Size = new System.Drawing.Size(114, 52);
            this.btnOkDelete.TabIndex = 16;
            this.btnOkDelete.Text = "מחק";
            this.btnOkDelete.UseVisualStyleBackColor = true;
            this.btnOkDelete.Visible = false;
            this.btnOkDelete.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTair);
            this.panel1.Controls.Add(this.txtTtz);
            this.panel1.Controls.Add(this.txtTsahar);
            this.panel1.Controls.Add(this.lblTair);
            this.panel1.Controls.Add(this.txtTtel);
            this.panel1.Controls.Add(this.lblTsahar);
            this.panel1.Controls.Add(this.txtTshamfamily);
            this.panel1.Controls.Add(this.lblTtel);
            this.panel1.Controls.Add(this.txtTsham);
            this.panel1.Controls.Add(this.lblTshamfamily);
            this.panel1.Controls.Add(this.lblTsham);
            this.panel1.Controls.Add(this.lblTtz);
            this.panel1.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(12, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 217);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // txtTair
            // 
            this.txtTair.Location = new System.Drawing.Point(42, 175);
            this.txtTair.Mask = "LL???????????????????????";
            this.txtTair.Name = "txtTair";
            this.txtTair.Size = new System.Drawing.Size(173, 32);
            this.txtTair.TabIndex = 31;
            // 
            // txtTtz
            // 
            this.txtTtz.Location = new System.Drawing.Point(42, 0);
            this.txtTtz.Mask = "000000000";
            this.txtTtz.Name = "txtTtz";
            this.txtTtz.Size = new System.Drawing.Size(173, 32);
            this.txtTtz.TabIndex = 28;
            // 
            // txtTsahar
            // 
            this.txtTsahar.Location = new System.Drawing.Point(43, 137);
            this.txtTsahar.Mask = "0999999";
            this.txtTsahar.Name = "txtTsahar";
            this.txtTsahar.Size = new System.Drawing.Size(174, 32);
            this.txtTsahar.TabIndex = 29;
            // 
            // txtTtel
            // 
            this.txtTtel.Location = new System.Drawing.Point(42, 99);
            this.txtTtel.Mask = "0000000009";
            this.txtTtel.Name = "txtTtel";
            this.txtTtel.Size = new System.Drawing.Size(173, 32);
            this.txtTtel.TabIndex = 30;
            // 
            // txtTshamfamily
            // 
            this.txtTshamfamily.Location = new System.Drawing.Point(43, 66);
            this.txtTshamfamily.Mask = "LL????????????????????????????????????";
            this.txtTshamfamily.Name = "txtTshamfamily";
            this.txtTshamfamily.Size = new System.Drawing.Size(173, 32);
            this.txtTshamfamily.TabIndex = 29;
            // 
            // txtTsham
            // 
            this.txtTsham.Location = new System.Drawing.Point(43, 34);
            this.txtTsham.Mask = "LL???????????????????????";
            this.txtTsham.Name = "txtTsham";
            this.txtTsham.Size = new System.Drawing.Size(174, 32);
            this.txtTsham.TabIndex = 28;
            this.txtTsham.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTsham_MaskInputRejected);
            // 
            // btnADdteacher
            // 
            this.btnADdteacher.BackColor = System.Drawing.Color.Lime;
            this.btnADdteacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADdteacher.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnADdteacher.Location = new System.Drawing.Point(993, 170);
            this.btnADdteacher.Name = "btnADdteacher";
            this.btnADdteacher.Size = new System.Drawing.Size(137, 56);
            this.btnADdteacher.TabIndex = 18;
            this.btnADdteacher.Text = "הוסף מורה";
            this.btnADdteacher.UseVisualStyleBackColor = false;
            this.btnADdteacher.Click += new System.EventHandler(this.btnADdStudent_Click);
            // 
            // btnDeleteteacher
            // 
            this.btnDeleteteacher.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteteacher.Location = new System.Drawing.Point(993, 237);
            this.btnDeleteteacher.Name = "btnDeleteteacher";
            this.btnDeleteteacher.Size = new System.Drawing.Size(137, 62);
            this.btnDeleteteacher.TabIndex = 19;
            this.btnDeleteteacher.Text = "מחק מורה";
            this.btnDeleteteacher.UseVisualStyleBackColor = true;
            this.btnDeleteteacher.Click += new System.EventHandler(this.btnDeletestudent_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btncancel.Location = new System.Drawing.Point(294, 353);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(121, 51);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "ביטול";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Visible = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // btnokupdate
            // 
            this.btnokupdate.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnokupdate.Location = new System.Drawing.Point(173, 418);
            this.btnokupdate.Name = "btnokupdate";
            this.btnokupdate.Size = new System.Drawing.Size(107, 46);
            this.btnokupdate.TabIndex = 21;
            this.btnokupdate.Text = "עדכן";
            this.btnokupdate.UseVisualStyleBackColor = true;
            this.btnokupdate.Visible = false;
            this.btnokupdate.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtsearch.Location = new System.Drawing.Point(769, 122);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(145, 32);
            this.txtsearch.TabIndex = 22;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnupdateteacher
            // 
            this.btnupdateteacher.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnupdateteacher.Location = new System.Drawing.Point(994, 309);
            this.btnupdateteacher.Name = "btnupdateteacher";
            this.btnupdateteacher.Size = new System.Drawing.Size(136, 62);
            this.btnupdateteacher.TabIndex = 23;
            this.btnupdateteacher.Text = "עדכן מורה";
            this.btnupdateteacher.UseVisualStyleBackColor = true;
            this.btnupdateteacher.Click += new System.EventHandler(this.btnupdateteacher_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSearch.Location = new System.Drawing.Point(933, 120);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 25);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Text = "חיפוש";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAirUpdate);
            this.panel2.Controls.Add(this.txtSaharUpdate);
            this.panel2.Controls.Add(this.txtTelUpdate);
            this.panel2.Controls.Add(this.txtTZupdate);
            this.panel2.Controls.Add(this.lblair);
            this.panel2.Controls.Add(this.lblsahar);
            this.panel2.Controls.Add(this.lbltel);
            this.panel2.Controls.Add(this.lbltz2);
            this.panel2.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel2.Location = new System.Drawing.Point(416, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 148);
            this.panel2.TabIndex = 27;
            this.panel2.Visible = false;
            // 
            // txtAirUpdate
            // 
            this.txtAirUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAirUpdate.Location = new System.Drawing.Point(40, 106);
            this.txtAirUpdate.Mask = "LL?????????????????";
            this.txtAirUpdate.Name = "txtAirUpdate";
            this.txtAirUpdate.Size = new System.Drawing.Size(151, 32);
            this.txtAirUpdate.TabIndex = 29;
            // 
            // txtSaharUpdate
            // 
            this.txtSaharUpdate.Location = new System.Drawing.Point(40, 75);
            this.txtSaharUpdate.Mask = "009999";
            this.txtSaharUpdate.Name = "txtSaharUpdate";
            this.txtSaharUpdate.Size = new System.Drawing.Size(151, 32);
            this.txtSaharUpdate.TabIndex = 28;
            // 
            // txtTelUpdate
            // 
            this.txtTelUpdate.Location = new System.Drawing.Point(40, 50);
            this.txtTelUpdate.Mask = "0000000009";
            this.txtTelUpdate.Name = "txtTelUpdate";
            this.txtTelUpdate.Size = new System.Drawing.Size(151, 32);
            this.txtTelUpdate.TabIndex = 28;
            // 
            // txtTZupdate
            // 
            this.txtTZupdate.Location = new System.Drawing.Point(40, 22);
            this.txtTZupdate.Mask = "000000000";
            this.txtTZupdate.Name = "txtTZupdate";
            this.txtTZupdate.Size = new System.Drawing.Size(151, 32);
            this.txtTZupdate.TabIndex = 28;
            // 
            // lblair
            // 
            this.lblair.AutoSize = true;
            this.lblair.Location = new System.Drawing.Point(203, 113);
            this.lblair.Name = "lblair";
            this.lblair.Size = new System.Drawing.Size(41, 25);
            this.lblair.TabIndex = 7;
            this.lblair.Text = "עיר";
            // 
            // lblsahar
            // 
            this.lblsahar.AutoSize = true;
            this.lblsahar.Location = new System.Drawing.Point(203, 82);
            this.lblsahar.Name = "lblsahar";
            this.lblsahar.Size = new System.Drawing.Size(103, 25);
            this.lblsahar.TabIndex = 6;
            this.lblsahar.Text = "שכר לשעה";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(209, 53);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(57, 25);
            this.lbltel.TabIndex = 5;
            this.lbltel.Text = "טלפון";
            // 
            // lbltz2
            // 
            this.lbltz2.AutoSize = true;
            this.lbltz2.Location = new System.Drawing.Point(203, 27);
            this.lbltz2.Name = "lbltz2";
            this.lbltz2.Size = new System.Drawing.Size(112, 25);
            this.lbltz2.TabIndex = 4;
            this.lbltz2.Text = "תעודת זהות";
            // 
            // btnopenpanelsalary
            // 
            this.btnopenpanelsalary.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnopenpanelsalary.Location = new System.Drawing.Point(995, 380);
            this.btnopenpanelsalary.Name = "btnopenpanelsalary";
            this.btnopenpanelsalary.Size = new System.Drawing.Size(135, 65);
            this.btnopenpanelsalary.TabIndex = 28;
            this.btnopenpanelsalary.Text = "חישוב משכורות";
            this.btnopenpanelsalary.UseVisualStyleBackColor = true;
            this.btnopenpanelsalary.Click += new System.EventHandler(this.btnopenpanelsalary_Click);
            // 
            // panelsahar
            // 
            this.panelsahar.Controls.Add(this.btncalall);
            this.panelsahar.Controls.Add(this.btncalculate1);
            this.panelsahar.Controls.Add(this.txtsaharcal);
            this.panelsahar.Controls.Add(this.label2);
            this.panelsahar.Controls.Add(this.label1);
            this.panelsahar.Controls.Add(this.combosahar);
            this.panelsahar.Font = new System.Drawing.Font("Guttman Hatzvi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panelsahar.Location = new System.Drawing.Point(524, 317);
            this.panelsahar.Name = "panelsahar";
            this.panelsahar.Size = new System.Drawing.Size(267, 157);
            this.panelsahar.TabIndex = 30;
            this.panelsahar.Visible = false;
            // 
            // btncalall
            // 
            this.btncalall.Location = new System.Drawing.Point(3, 91);
            this.btncalall.Name = "btncalall";
            this.btncalall.Size = new System.Drawing.Size(123, 66);
            this.btncalall.TabIndex = 5;
            this.btncalall.Text = "סה\"כ משכורות";
            this.btncalall.UseVisualStyleBackColor = true;
            this.btncalall.Click += new System.EventHandler(this.btncalall_Click);
            // 
            // btncalculate1
            // 
            this.btncalculate1.BackColor = System.Drawing.Color.Lime;
            this.btncalculate1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncalculate1.Location = new System.Drawing.Point(132, 91);
            this.btncalculate1.Name = "btncalculate1";
            this.btncalculate1.Size = new System.Drawing.Size(109, 66);
            this.btncalculate1.TabIndex = 4;
            this.btncalculate1.Text = "חשב";
            this.btncalculate1.UseVisualStyleBackColor = false;
            this.btncalculate1.Click += new System.EventHandler(this.btncalculate1_Click);
            // 
            // txtsaharcal
            // 
            this.txtsaharcal.Location = new System.Drawing.Point(13, 47);
            this.txtsaharcal.Name = "txtsaharcal";
            this.txtsaharcal.Size = new System.Drawing.Size(121, 32);
            this.txtsaharcal.TabIndex = 3;
            this.txtsaharcal.TextChanged += new System.EventHandler(this.txtsaharcal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "סה\"כ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "תעודת זהות";
            // 
            // combosahar
            // 
            this.combosahar.FormattingEnabled = true;
            this.combosahar.Location = new System.Drawing.Point(13, 13);
            this.combosahar.Name = "combosahar";
            this.combosahar.Size = new System.Drawing.Size(121, 33);
            this.combosahar.TabIndex = 0;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 486);
            this.Controls.Add(this.panelsahar);
            this.Controls.Add(this.btnopenpanelsalary);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnupdateteacher);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnokupdate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnDeleteteacher);
            this.Controls.Add(this.btnADdteacher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOkDelete);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnOkAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTeacher";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Alif_s_databaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelsahar.ResumeLayout(false);
            this.panelsahar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private _Alif_s_databaseDataSetTeachers _Alif_s_databaseDataSetTeachers;
        //private _Alif_s_databaseDataSetTeachersTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shamfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shaotAvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTtz;
        private System.Windows.Forms.Label lblTsham;
        private System.Windows.Forms.Label lblTshamfamily;
        private System.Windows.Forms.Label lblTtel;
        private System.Windows.Forms.Label lblTsahar;
        private System.Windows.Forms.Label lblTair;
        private System.Windows.Forms.Button btnOkAdd;
        private System.Windows.Forms.Button btnclean;
        private _Alif_s_databaseDataSet _Alif_s_databaseDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private _Alif_s_databaseDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.Button btnOkDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnADdteacher;
        private System.Windows.Forms.Button btnDeleteteacher;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnokupdate;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnupdateteacher;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblair;
        private System.Windows.Forms.Label lblsahar;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lbltz2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.MaskedTextBox txtTtz;
        private System.Windows.Forms.MaskedTextBox txtTair;
        private System.Windows.Forms.MaskedTextBox txtTsahar;
        private System.Windows.Forms.MaskedTextBox txtTtel;
        private System.Windows.Forms.MaskedTextBox txtTshamfamily;
        private System.Windows.Forms.MaskedTextBox txtTsham;
        private System.Windows.Forms.MaskedTextBox txtAirUpdate;
        private System.Windows.Forms.MaskedTextBox txtSaharUpdate;
        private System.Windows.Forms.MaskedTextBox txtTelUpdate;
        private System.Windows.Forms.MaskedTextBox txtTZupdate;
        private System.Windows.Forms.Button btnopenpanelsalary;
        private System.Windows.Forms.Panel panelsahar;
        private System.Windows.Forms.Button btncalall;
        private System.Windows.Forms.Button btncalculate1;
        private System.Windows.Forms.TextBox txtsaharcal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combosahar;
    }
}