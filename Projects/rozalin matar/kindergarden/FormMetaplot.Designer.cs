namespace kindergarden
{
    partial class formMetaplot
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
            this.dataGridView_metaplot = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bithdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaplotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindergardenDataSet = new kindergarden.kindergardenDataSet();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_fN = new System.Windows.Forms.Label();
            this.lbl_lN = new System.Windows.Forms.Label();
            this.lbl_housePhone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.dateTimePicker_Birthday = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_rf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_usename = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.metaplotTableAdapter = new kindergarden.kindergardenDataSetTableAdapters.metaplotTableAdapter();
            this.lbl_mustFill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_results = new System.Windows.Forms.Panel();
            this.btn_closeResults = new System.Windows.Forms.Button();
            this.dataGridView_search = new System.Windows.Forms.DataGridView();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_metaplot = new System.Windows.Forms.ComboBox();
            this.txt_phone = new System.Windows.Forms.MaskedTextBox();
            this.txt_housePhone = new System.Windows.Forms.MaskedTextBox();
            this.txt_ID = new System.Windows.Forms.MaskedTextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pnl_up = new System.Windows.Forms.Panel();
            this.pnl_sadot = new System.Windows.Forms.Panel();
            this.pnl_table = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_metaplot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaplotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).BeginInit();
            this.pnl_results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).BeginInit();
            this.pnl_up.SuspendLayout();
            this.pnl_sadot.SuspendLayout();
            this.pnl_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_metaplot
            // 
            this.dataGridView_metaplot.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_metaplot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_metaplot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_metaplot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.housePhoneDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.bithdayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView_metaplot.DataSource = this.metaplotBindingSource;
            this.dataGridView_metaplot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_metaplot.Enabled = false;
            this.dataGridView_metaplot.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_metaplot.Name = "dataGridView_metaplot";
            this.dataGridView_metaplot.Size = new System.Drawing.Size(892, 297);
            this.dataGridView_metaplot.TabIndex = 14;
            this.dataGridView_metaplot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_metaplot.DoubleClick += new System.EventHandler(this.dataGridView_metaplot_DoubleClick);
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
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // housePhoneDataGridViewTextBoxColumn
            // 
            this.housePhoneDataGridViewTextBoxColumn.DataPropertyName = "house phone";
            this.housePhoneDataGridViewTextBoxColumn.HeaderText = "house phone";
            this.housePhoneDataGridViewTextBoxColumn.Name = "housePhoneDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // bithdayDataGridViewTextBoxColumn
            // 
            this.bithdayDataGridViewTextBoxColumn.DataPropertyName = "Bithday";
            this.bithdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.bithdayDataGridViewTextBoxColumn.Name = "bithdayDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // metaplotBindingSource
            // 
            this.metaplotBindingSource.DataMember = "metaplot";
            this.metaplotBindingSource.DataSource = this.kindergardenDataSet;
            // 
            // kindergardenDataSet
            // 
            this.kindergardenDataSet.DataSetName = "kindergardenDataSet";
            this.kindergardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_ID.Location = new System.Drawing.Point(7, 12);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(25, 16);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_lastName.Location = new System.Drawing.Point(93, 62);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(100, 23);
            this.txt_lastName.TabIndex = 4;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            this.txt_lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lastName_KeyPress);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_firstName.Location = new System.Drawing.Point(93, 34);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(100, 23);
            this.txt_firstName.TabIndex = 3;
            this.txt_firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_firstName_KeyPress);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_address.Location = new System.Drawing.Point(235, 0);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 23);
            this.txt_address.TabIndex = 10;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_address_KeyPress);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_phone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_phone.Location = new System.Drawing.Point(7, 92);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(51, 16);
            this.lbl_phone.TabIndex = 13;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_fN
            // 
            this.lbl_fN.AutoSize = true;
            this.lbl_fN.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_fN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_fN.Location = new System.Drawing.Point(7, 38);
            this.lbl_fN.Name = "lbl_fN";
            this.lbl_fN.Size = new System.Drawing.Size(81, 16);
            this.lbl_fN.TabIndex = 14;
            this.lbl_fN.Text = "First name";
            // 
            // lbl_lN
            // 
            this.lbl_lN.AutoSize = true;
            this.lbl_lN.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_lN.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_lN.Location = new System.Drawing.Point(7, 66);
            this.lbl_lN.Name = "lbl_lN";
            this.lbl_lN.Size = new System.Drawing.Size(80, 16);
            this.lbl_lN.TabIndex = 15;
            this.lbl_lN.Text = "Last name";
            // 
            // lbl_housePhone
            // 
            this.lbl_housePhone.AutoSize = true;
            this.lbl_housePhone.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_housePhone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_housePhone.Location = new System.Drawing.Point(7, 114);
            this.lbl_housePhone.Name = "lbl_housePhone";
            this.lbl_housePhone.Size = new System.Drawing.Size(101, 16);
            this.lbl_housePhone.TabIndex = 16;
            this.lbl_housePhone.Text = "House phone";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_address.Location = new System.Drawing.Point(168, 4);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(64, 16);
            this.lbl_address.TabIndex = 20;
            this.lbl_address.Text = "Address";
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_birthday.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_birthday.Location = new System.Drawing.Point(7, 191);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(67, 16);
            this.lbl_birthday.TabIndex = 21;
            this.lbl_birthday.Text = "Birthday";
            // 
            // dateTimePicker_Birthday
            // 
            this.dateTimePicker_Birthday.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Birthday.Location = new System.Drawing.Point(83, 186);
            this.dateTimePicker_Birthday.MaxDate = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Birthday.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            this.dateTimePicker_Birthday.Size = new System.Drawing.Size(101, 23);
            this.dateTimePicker_Birthday.TabIndex = 9;
            this.dateTimePicker_Birthday.Value = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Birthday.ValueChanged += new System.EventHandler(this.dateTimePicker_Birthday_ValueChanged);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Location = new System.Drawing.Point(141, 270);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.Leave += new System.EventHandler(this.btn_save_Leave);
            // 
            // btn_rf
            // 
            this.btn_rf.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_rf.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rf.Location = new System.Drawing.Point(105, 241);
            this.btn_rf.Name = "btn_rf";
            this.btn_rf.Size = new System.Drawing.Size(75, 23);
            this.btn_rf.TabIndex = 12;
            this.btn_rf.Text = "Refresh";
            this.btn_rf.UseVisualStyleBackColor = true;
            this.btn_rf.Click += new System.EventHandler(this.btn_rf_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_usename
            // 
            this.lbl_usename.AutoSize = true;
            this.lbl_usename.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_usename.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_usename.Location = new System.Drawing.Point(7, 163);
            this.lbl_usename.Name = "lbl_usename";
            this.lbl_usename.Size = new System.Drawing.Size(78, 16);
            this.lbl_usename.TabIndex = 19;
            this.lbl_usename.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_password.Location = new System.Drawing.Point(84, 132);
            this.txt_password.MaxLength = 10;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 23);
            this.txt_password.TabIndex = 7;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_password.Location = new System.Drawing.Point(7, 139);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(71, 16);
            this.lbl_password.TabIndex = 18;
            this.lbl_password.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_username.Location = new System.Drawing.Point(84, 158);
            this.txt_username.MaxLength = 10;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 23);
            this.txt_username.TabIndex = 8;
            // 
            // metaplotTableAdapter
            // 
            this.metaplotTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_mustFill
            // 
            this.lbl_mustFill.AutoSize = true;
            this.lbl_mustFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_mustFill.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_mustFill.Location = new System.Drawing.Point(197, 88);
            this.lbl_mustFill.Name = "lbl_mustFill";
            this.lbl_mustFill.Size = new System.Drawing.Size(17, 24);
            this.lbl_mustFill.TabIndex = 26;
            this.lbl_mustFill.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(527, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(197, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(197, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(144, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "*";
            // 
            // pnl_results
            // 
            this.pnl_results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_results.Controls.Add(this.btn_closeResults);
            this.pnl_results.Controls.Add(this.dataGridView_search);
            this.pnl_results.Controls.Add(this.lbl_result);
            this.pnl_results.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_results.Location = new System.Drawing.Point(0, 348);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.Size = new System.Drawing.Size(1269, 258);
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
            this.btn_closeResults.Size = new System.Drawing.Size(75, 32);
            this.btn_closeResults.TabIndex = 15;
            this.btn_closeResults.Text = "Close";
            this.btn_closeResults.UseVisualStyleBackColor = true;
            this.btn_closeResults.Click += new System.EventHandler(this.btn_closeResults_Click);
            // 
            // dataGridView_search
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_search.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_search.Name = "dataGridView_search";
            this.dataGridView_search.Size = new System.Drawing.Size(1265, 192);
            this.dataGridView_search.TabIndex = 84;
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_result.Location = new System.Drawing.Point(0, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(1265, 30);
            this.lbl_result.TabIndex = 83;
            this.lbl_result.Text = "Search results";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbl_search.TabIndex = 87;
            this.lbl_search.Text = "Search";
            this.lbl_search.Click += new System.EventHandler(this.lbl_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_search.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_search.Location = new System.Drawing.Point(55, 0);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(121, 23);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Location = new System.Drawing.Point(105, 212);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(153, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add a new teacher";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_metaplot
            // 
            this.cb_metaplot.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_metaplot.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cb_metaplot.FormattingEnabled = true;
            this.cb_metaplot.Location = new System.Drawing.Point(176, 0);
            this.cb_metaplot.Name = "cb_metaplot";
            this.cb_metaplot.Size = new System.Drawing.Size(121, 24);
            this.cb_metaplot.TabIndex = 1;
            this.cb_metaplot.SelectedIndexChanged += new System.EventHandler(this.cb_kitot_SelectedIndexChanged);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_phone.Location = new System.Drawing.Point(93, 86);
            this.txt_phone.Mask = "000-000-0000";
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 23);
            this.txt_phone.TabIndex = 5;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // txt_housePhone
            // 
            this.txt_housePhone.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_housePhone.Location = new System.Drawing.Point(114, 109);
            this.txt_housePhone.Mask = "00-0000000";
            this.txt_housePhone.Name = "txt_housePhone";
            this.txt_housePhone.PromptChar = '-';
            this.txt_housePhone.Size = new System.Drawing.Size(100, 23);
            this.txt_housePhone.TabIndex = 6;
            this.txt_housePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_housePhone_KeyPress);
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_ID.Location = new System.Drawing.Point(50, 6);
            this.txt_ID.Mask = "0000000000";
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(88, 23);
            this.txt_ID.TabIndex = 2;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Location = new System.Drawing.Point(183, 241);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pnl_up
            // 
            this.pnl_up.Controls.Add(this.cb_metaplot);
            this.pnl_up.Controls.Add(this.txt_search);
            this.pnl_up.Controls.Add(this.lbl_search);
            this.pnl_up.Controls.Add(this.button1);
            this.pnl_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_up.Location = new System.Drawing.Point(0, 0);
            this.pnl_up.Name = "pnl_up";
            this.pnl_up.Size = new System.Drawing.Size(1269, 51);
            this.pnl_up.TabIndex = 104;
            // 
            // pnl_sadot
            // 
            this.pnl_sadot.Controls.Add(this.lbl_ID);
            this.pnl_sadot.Controls.Add(this.txt_lastName);
            this.pnl_sadot.Controls.Add(this.btn_delete);
            this.pnl_sadot.Controls.Add(this.txt_firstName);
            this.pnl_sadot.Controls.Add(this.txt_ID);
            this.pnl_sadot.Controls.Add(this.btn_add);
            this.pnl_sadot.Controls.Add(this.txt_address);
            this.pnl_sadot.Controls.Add(this.btn_save);
            this.pnl_sadot.Controls.Add(this.txt_username);
            this.pnl_sadot.Controls.Add(this.btn_rf);
            this.pnl_sadot.Controls.Add(this.txt_housePhone);
            this.pnl_sadot.Controls.Add(this.txt_password);
            this.pnl_sadot.Controls.Add(this.txt_phone);
            this.pnl_sadot.Controls.Add(this.lbl_phone);
            this.pnl_sadot.Controls.Add(this.lbl_fN);
            this.pnl_sadot.Controls.Add(this.lbl_lN);
            this.pnl_sadot.Controls.Add(this.label7);
            this.pnl_sadot.Controls.Add(this.lbl_housePhone);
            this.pnl_sadot.Controls.Add(this.label6);
            this.pnl_sadot.Controls.Add(this.lbl_password);
            this.pnl_sadot.Controls.Add(this.label5);
            this.pnl_sadot.Controls.Add(this.lbl_usename);
            this.pnl_sadot.Controls.Add(this.lbl_address);
            this.pnl_sadot.Controls.Add(this.lbl_birthday);
            this.pnl_sadot.Controls.Add(this.dateTimePicker_Birthday);
            this.pnl_sadot.Controls.Add(this.label1);
            this.pnl_sadot.Controls.Add(this.lbl_mustFill);
            this.pnl_sadot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sadot.Location = new System.Drawing.Point(945, 51);
            this.pnl_sadot.Name = "pnl_sadot";
            this.pnl_sadot.Size = new System.Drawing.Size(324, 297);
            this.pnl_sadot.TabIndex = 105;
            this.pnl_sadot.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_sadot_Paint);
            // 
            // pnl_table
            // 
            this.pnl_table.Controls.Add(this.dataGridView_metaplot);
            this.pnl_table.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_table.Location = new System.Drawing.Point(0, 51);
            this.pnl_table.Name = "pnl_table";
            this.pnl_table.Size = new System.Drawing.Size(892, 297);
            this.pnl_table.TabIndex = 106;
            // 
            // formMetaplot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 606);
            this.Controls.Add(this.pnl_table);
            this.Controls.Add(this.pnl_sadot);
            this.Controls.Add(this.pnl_up);
            this.Controls.Add(this.pnl_results);
            this.Name = "formMetaplot";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.FormMetaplot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_metaplot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaplotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindergardenDataSet)).EndInit();
            this.pnl_results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_search)).EndInit();
            this.pnl_up.ResumeLayout(false);
            this.pnl_up.PerformLayout();
            this.pnl_sadot.ResumeLayout(false);
            this.pnl_sadot.PerformLayout();
            this.pnl_table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_metaplot;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_fN;
        private System.Windows.Forms.Label lbl_lN;
        private System.Windows.Forms.Label lbl_housePhone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthday;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_rf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_usename;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private kindergardenDataSet kindergardenDataSet;
        private System.Windows.Forms.BindingSource metaplotBindingSource;
        private kindergardenDataSetTableAdapters.metaplotTableAdapter metaplotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bithdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_mustFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_results;
        private System.Windows.Forms.Button btn_closeResults;
        private System.Windows.Forms.DataGridView dataGridView_search;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_metaplot;
        private System.Windows.Forms.MaskedTextBox txt_phone;
        private System.Windows.Forms.MaskedTextBox txt_housePhone;
        private System.Windows.Forms.MaskedTextBox txt_ID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel pnl_up;
        private System.Windows.Forms.Panel pnl_sadot;
        private System.Windows.Forms.Panel pnl_table;
    }
}