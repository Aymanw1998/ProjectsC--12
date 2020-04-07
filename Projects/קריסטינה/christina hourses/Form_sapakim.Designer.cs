namespace christina_hourses
{
    partial class Form_sapakim
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
            this.lb_search_horses = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_update_horses = new System.Windows.Forms.Button();
            this.bt_delete_horses = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.shem = new System.Windows.Forms.Label();
            this.ishkesherphone = new System.Windows.Forms.Label();
            this.ktovet = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.txb_ktovet = new System.Windows.Forms.TextBox();
            this.txb_shem = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.misparTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneAishKesherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sapakimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoursesDataSet = new christina_hourses.hoursesDataSet();
            this.sapakimTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.sapakimTableAdapter();
            this.bt_ap = new System.Windows.Forms.Button();
            this.txbup_shem = new System.Windows.Forms.TextBox();
            this.txbup_ctovet = new System.Windows.Forms.TextBox();
            this.up_phone = new System.Windows.Forms.Label();
            this.up_ctovet = new System.Windows.Forms.Label();
            this.up_ishkesherphone = new System.Windows.Forms.Label();
            this.up_shem = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.txbde_shem = new System.Windows.Forms.TextBox();
            this.txbde_phone = new System.Windows.Forms.TextBox();
            this.txbde_ctovet = new System.Windows.Forms.TextBox();
            this.txbde_ishkesherphone = new System.Windows.Forms.TextBox();
            this.de_phone = new System.Windows.Forms.Label();
            this.de_ctovet = new System.Windows.Forms.Label();
            this.de_ishkesherphone = new System.Windows.Forms.Label();
            this.de_shem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_ishkeshrphone = new System.Windows.Forms.MaskedTextBox();
            this.txb_phone = new System.Windows.Forms.MaskedTextBox();
            this.txbup_ishkesherphone = new System.Windows.Forms.MaskedTextBox();
            this.txbup_phone = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.before = new System.Windows.Forms.Button();
            this.haba = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_search_horses
            // 
            this.lb_search_horses.AutoSize = true;
            this.lb_search_horses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_search_horses.Location = new System.Drawing.Point(730, 389);
            this.lb_search_horses.Name = "lb_search_horses";
            this.lb_search_horses.Size = new System.Drawing.Size(60, 24);
            this.lb_search_horses.TabIndex = 14;
            this.lb_search_horses.Text = "חיפוש";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(501, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(770, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "הוספה";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_update_horses
            // 
            this.bt_update_horses.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_update_horses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_update_horses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_update_horses.Location = new System.Drawing.Point(549, 464);
            this.bt_update_horses.Name = "bt_update_horses";
            this.bt_update_horses.Size = new System.Drawing.Size(147, 52);
            this.bt_update_horses.TabIndex = 17;
            this.bt_update_horses.Text = "עדכון";
            this.bt_update_horses.UseVisualStyleBackColor = false;
            this.bt_update_horses.Click += new System.EventHandler(this.bt_update_horses_Click);
            // 
            // bt_delete_horses
            // 
            this.bt_delete_horses.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_delete_horses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_delete_horses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_delete_horses.Location = new System.Drawing.Point(331, 464);
            this.bt_delete_horses.Name = "bt_delete_horses";
            this.bt_delete_horses.Size = new System.Drawing.Size(147, 52);
            this.bt_delete_horses.TabIndex = 18;
            this.bt_delete_horses.Text = "מחיקה";
            this.bt_delete_horses.UseVisualStyleBackColor = false;
            this.bt_delete_horses.Click += new System.EventHandler(this.bt_delete_horses_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_close.Location = new System.Drawing.Point(20, 790);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(129, 75);
            this.bt_close.TabIndex = 19;
            this.bt_close.Text = "חזרה לדף הראשי";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // shem
            // 
            this.shem.AutoSize = true;
            this.shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shem.Location = new System.Drawing.Point(1058, 562);
            this.shem.Name = "shem";
            this.shem.Size = new System.Drawing.Size(41, 25);
            this.shem.TabIndex = 21;
            this.shem.Text = "שם";
            this.shem.Visible = false;
            // 
            // ishkesherphone
            // 
            this.ishkesherphone.AutoSize = true;
            this.ishkesherphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ishkesherphone.Location = new System.Drawing.Point(928, 692);
            this.ishkesherphone.Name = "ishkesherphone";
            this.ishkesherphone.Size = new System.Drawing.Size(171, 25);
            this.ishkesherphone.TabIndex = 22;
            this.ishkesherphone.Text = "פלאפון איש קשר";
            this.ishkesherphone.Visible = false;
            // 
            // ktovet
            // 
            this.ktovet.AutoSize = true;
            this.ktovet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ktovet.Location = new System.Drawing.Point(1026, 650);
            this.ktovet.Name = "ktovet";
            this.ktovet.Size = new System.Drawing.Size(73, 25);
            this.ktovet.TabIndex = 23;
            this.ktovet.Text = "כתובת";
            this.ktovet.Visible = false;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.phone.Location = new System.Drawing.Point(1019, 605);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(80, 25);
            this.phone.TabIndex = 24;
            this.phone.Text = "פלאפון";
            this.phone.Visible = false;
            // 
            // txb_ktovet
            // 
            this.txb_ktovet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_ktovet.Location = new System.Drawing.Point(764, 657);
            this.txb_ktovet.Name = "txb_ktovet";
            this.txb_ktovet.Size = new System.Drawing.Size(143, 20);
            this.txb_ktovet.TabIndex = 2;
            this.txb_ktovet.Visible = false;
            this.txb_ktovet.WordWrap = false;
            // 
            // txb_shem
            // 
            this.txb_shem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_shem.Location = new System.Drawing.Point(764, 563);
            this.txb_shem.Name = "txb_shem";
            this.txb_shem.Size = new System.Drawing.Size(143, 20);
            this.txb_shem.TabIndex = 0;
            this.txb_shem.Visible = false;
            this.txb_shem.WordWrap = false;
            this.txb_shem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_shem_KeyPress);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_add.ForeColor = System.Drawing.Color.Snow;
            this.bt_add.Location = new System.Drawing.Point(764, 762);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(113, 35);
            this.bt_add.TabIndex = 41;
            this.bt_add.Text = "הוסף";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Visible = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shemDataGridViewTextBoxColumn,
            this.misparTelephoneDataGridViewTextBoxColumn,
            this.ktovetDataGridViewTextBoxColumn,
            this.telephoneAishKesherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sapakimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(362, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 215);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "שם";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // misparTelephoneDataGridViewTextBoxColumn
            // 
            this.misparTelephoneDataGridViewTextBoxColumn.DataPropertyName = "mispar telephone";
            this.misparTelephoneDataGridViewTextBoxColumn.HeaderText = "פלאפון";
            this.misparTelephoneDataGridViewTextBoxColumn.Name = "misparTelephoneDataGridViewTextBoxColumn";
            // 
            // ktovetDataGridViewTextBoxColumn
            // 
            this.ktovetDataGridViewTextBoxColumn.DataPropertyName = "ktovet";
            this.ktovetDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.ktovetDataGridViewTextBoxColumn.Name = "ktovetDataGridViewTextBoxColumn";
            // 
            // telephoneAishKesherDataGridViewTextBoxColumn
            // 
            this.telephoneAishKesherDataGridViewTextBoxColumn.DataPropertyName = "telephone aish kesher";
            this.telephoneAishKesherDataGridViewTextBoxColumn.HeaderText = "פלאפון איש קשר";
            this.telephoneAishKesherDataGridViewTextBoxColumn.Name = "telephoneAishKesherDataGridViewTextBoxColumn";
            // 
            // sapakimBindingSource
            // 
            this.sapakimBindingSource.DataMember = "sapakim";
            this.sapakimBindingSource.DataSource = this.hoursesDataSet;
            // 
            // hoursesDataSet
            // 
            this.hoursesDataSet.DataSetName = "hoursesDataSet";
            this.hoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sapakimTableAdapter
            // 
            this.sapakimTableAdapter.ClearBeforeFill = true;
            // 
            // bt_ap
            // 
            this.bt_ap.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_ap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_ap.ForeColor = System.Drawing.Color.Snow;
            this.bt_ap.Location = new System.Drawing.Point(476, 762);
            this.bt_ap.Name = "bt_ap";
            this.bt_ap.Size = new System.Drawing.Size(113, 35);
            this.bt_ap.TabIndex = 51;
            this.bt_ap.Text = "עדכן";
            this.bt_ap.UseVisualStyleBackColor = false;
            this.bt_ap.Visible = false;
            this.bt_ap.Click += new System.EventHandler(this.bt_ap_Click);
            // 
            // txbup_shem
            // 
            this.txbup_shem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbup_shem.Location = new System.Drawing.Point(476, 563);
            this.txbup_shem.Name = "txbup_shem";
            this.txbup_shem.Size = new System.Drawing.Size(143, 20);
            this.txbup_shem.TabIndex = 4;
            this.txbup_shem.Visible = false;
            this.txbup_shem.WordWrap = false;
            this.txbup_shem.TextChanged += new System.EventHandler(this.txbup_shem_TextChanged);
            this.txbup_shem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbup_shem_KeyPress);
            // 
            // txbup_ctovet
            // 
            this.txbup_ctovet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbup_ctovet.Location = new System.Drawing.Point(476, 657);
            this.txbup_ctovet.Name = "txbup_ctovet";
            this.txbup_ctovet.Size = new System.Drawing.Size(143, 20);
            this.txbup_ctovet.TabIndex = 6;
            this.txbup_ctovet.Visible = false;
            this.txbup_ctovet.WordWrap = false;
            // 
            // up_phone
            // 
            this.up_phone.AutoSize = true;
            this.up_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.up_phone.Location = new System.Drawing.Point(726, 606);
            this.up_phone.Name = "up_phone";
            this.up_phone.Size = new System.Drawing.Size(80, 25);
            this.up_phone.TabIndex = 46;
            this.up_phone.Text = "פלאפון";
            this.up_phone.Visible = false;
            // 
            // up_ctovet
            // 
            this.up_ctovet.AutoSize = true;
            this.up_ctovet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.up_ctovet.Location = new System.Drawing.Point(733, 651);
            this.up_ctovet.Name = "up_ctovet";
            this.up_ctovet.Size = new System.Drawing.Size(73, 25);
            this.up_ctovet.TabIndex = 45;
            this.up_ctovet.Text = "כתובת";
            this.up_ctovet.Visible = false;
            // 
            // up_ishkesherphone
            // 
            this.up_ishkesherphone.AutoSize = true;
            this.up_ishkesherphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.up_ishkesherphone.Location = new System.Drawing.Point(635, 693);
            this.up_ishkesherphone.Name = "up_ishkesherphone";
            this.up_ishkesherphone.Size = new System.Drawing.Size(171, 25);
            this.up_ishkesherphone.TabIndex = 44;
            this.up_ishkesherphone.Text = "פלאפון איש קשר";
            this.up_ishkesherphone.Visible = false;
            // 
            // up_shem
            // 
            this.up_shem.AutoSize = true;
            this.up_shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.up_shem.Location = new System.Drawing.Point(765, 563);
            this.up_shem.Name = "up_shem";
            this.up_shem.Size = new System.Drawing.Size(41, 25);
            this.up_shem.TabIndex = 43;
            this.up_shem.Text = "שם";
            this.up_shem.Visible = false;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_delete.ForeColor = System.Drawing.Color.Snow;
            this.bt_delete.Location = new System.Drawing.Point(173, 762);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(113, 35);
            this.bt_delete.TabIndex = 60;
            this.bt_delete.Text = "מחק";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Visible = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // txbde_shem
            // 
            this.txbde_shem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbde_shem.Location = new System.Drawing.Point(174, 568);
            this.txbde_shem.Name = "txbde_shem";
            this.txbde_shem.Size = new System.Drawing.Size(143, 20);
            this.txbde_shem.TabIndex = 8;
            this.txbde_shem.Visible = false;
            this.txbde_shem.WordWrap = false;
            // 
            // txbde_phone
            // 
            this.txbde_phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbde_phone.Location = new System.Drawing.Point(173, 611);
            this.txbde_phone.Name = "txbde_phone";
            this.txbde_phone.Size = new System.Drawing.Size(143, 20);
            this.txbde_phone.TabIndex = 9;
            this.txbde_phone.Visible = false;
            this.txbde_phone.WordWrap = false;
            // 
            // txbde_ctovet
            // 
            this.txbde_ctovet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbde_ctovet.Location = new System.Drawing.Point(173, 657);
            this.txbde_ctovet.Name = "txbde_ctovet";
            this.txbde_ctovet.Size = new System.Drawing.Size(143, 20);
            this.txbde_ctovet.TabIndex = 10;
            this.txbde_ctovet.Visible = false;
            this.txbde_ctovet.WordWrap = false;
            // 
            // txbde_ishkesherphone
            // 
            this.txbde_ishkesherphone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbde_ishkesherphone.Location = new System.Drawing.Point(173, 698);
            this.txbde_ishkesherphone.Name = "txbde_ishkesherphone";
            this.txbde_ishkesherphone.Size = new System.Drawing.Size(144, 20);
            this.txbde_ishkesherphone.TabIndex = 11;
            this.txbde_ishkesherphone.Visible = false;
            this.txbde_ishkesherphone.WordWrap = false;
            // 
            // de_phone
            // 
            this.de_phone.AutoSize = true;
            this.de_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.de_phone.Location = new System.Drawing.Point(423, 606);
            this.de_phone.Name = "de_phone";
            this.de_phone.Size = new System.Drawing.Size(80, 25);
            this.de_phone.TabIndex = 55;
            this.de_phone.Text = "פלאפון";
            this.de_phone.Visible = false;
            // 
            // de_ctovet
            // 
            this.de_ctovet.AutoSize = true;
            this.de_ctovet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.de_ctovet.Location = new System.Drawing.Point(430, 651);
            this.de_ctovet.Name = "de_ctovet";
            this.de_ctovet.Size = new System.Drawing.Size(73, 25);
            this.de_ctovet.TabIndex = 54;
            this.de_ctovet.Text = "כתובת";
            this.de_ctovet.Visible = false;
            // 
            // de_ishkesherphone
            // 
            this.de_ishkesherphone.AutoSize = true;
            this.de_ishkesherphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.de_ishkesherphone.Location = new System.Drawing.Point(332, 693);
            this.de_ishkesherphone.Name = "de_ishkesherphone";
            this.de_ishkesherphone.Size = new System.Drawing.Size(171, 25);
            this.de_ishkesherphone.TabIndex = 53;
            this.de_ishkesherphone.Text = "פלאפון איש קשר";
            this.de_ishkesherphone.Visible = false;
            // 
            // de_shem
            // 
            this.de_shem.AutoSize = true;
            this.de_shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.de_shem.Location = new System.Drawing.Point(462, 563);
            this.de_shem.Name = "de_shem";
            this.de_shem.Size = new System.Drawing.Size(41, 25);
            this.de_shem.TabIndex = 52;
            this.de_shem.Text = "שם";
            this.de_shem.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(913, 698);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "**";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.em1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(913, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "**";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(913, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "**";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(913, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "**";
            this.label3.Visible = false;
            // 
            // txb_ishkeshrphone
            // 
            this.txb_ishkeshrphone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_ishkeshrphone.Location = new System.Drawing.Point(763, 697);
            this.txb_ishkeshrphone.Mask = "000-0000000";
            this.txb_ishkeshrphone.Name = "txb_ishkeshrphone";
            this.txb_ishkeshrphone.Size = new System.Drawing.Size(144, 20);
            this.txb_ishkeshrphone.TabIndex = 3;
            this.txb_ishkeshrphone.Visible = false;
            this.txb_ishkeshrphone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txb_ishkeshrphone_MaskInputRejected);
            this.txb_ishkeshrphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_ishkeshrphone_KeyPress);
            // 
            // txb_phone
            // 
            this.txb_phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_phone.Location = new System.Drawing.Point(764, 610);
            this.txb_phone.Mask = "000-0000000";
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(144, 20);
            this.txb_phone.TabIndex = 1;
            this.txb_phone.Visible = false;
            this.txb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_phone_KeyPress);
            // 
            // txbup_ishkesherphone
            // 
            this.txbup_ishkesherphone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbup_ishkesherphone.Location = new System.Drawing.Point(475, 700);
            this.txbup_ishkesherphone.Mask = "000-0000000";
            this.txbup_ishkesherphone.Name = "txbup_ishkesherphone";
            this.txbup_ishkesherphone.Size = new System.Drawing.Size(144, 20);
            this.txbup_ishkesherphone.TabIndex = 7;
            this.txbup_ishkesherphone.Visible = false;
            this.txbup_ishkesherphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbup_ishkesherphone_KeyPress);
            // 
            // txbup_phone
            // 
            this.txbup_phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbup_phone.Location = new System.Drawing.Point(475, 610);
            this.txbup_phone.Mask = "000-0000000";
            this.txbup_phone.Name = "txbup_phone";
            this.txbup_phone.Size = new System.Drawing.Size(144, 20);
            this.txbup_phone.TabIndex = 5;
            this.txbup_phone.Visible = false;
            this.txbup_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbup_phone_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(620, 700);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 20);
            this.label14.TabIndex = 90;
            this.label14.Text = "**";
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(620, 657);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 89;
            this.label13.Text = "**";
            this.label13.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(620, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 88;
            this.label11.Text = "**";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(620, 611);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 20);
            this.label12.TabIndex = 87;
            this.label12.Text = "**";
            this.label12.Visible = false;
            // 
            // last
            // 
            this.last.BackColor = System.Drawing.SystemColors.Highlight;
            this.last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.last.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.last.Location = new System.Drawing.Point(917, 327);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(115, 32);
            this.last.TabIndex = 119;
            this.last.Text = "האחרון";
            this.last.UseVisualStyleBackColor = false;
            this.last.Click += new System.EventHandler(this.last_Click_1);
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.Highlight;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.first.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.first.Location = new System.Drawing.Point(916, 279);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(115, 32);
            this.first.TabIndex = 118;
            this.first.Text = "הראשון";
            this.first.UseVisualStyleBackColor = false;
            this.first.Click += new System.EventHandler(this.first_Click_1);
            // 
            // before
            // 
            this.before.BackColor = System.Drawing.SystemColors.Highlight;
            this.before.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.before.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.before.Location = new System.Drawing.Point(916, 233);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(115, 30);
            this.before.TabIndex = 117;
            this.before.Text = "הקודם";
            this.before.UseVisualStyleBackColor = false;
            this.before.Click += new System.EventHandler(this.before_Click_1);
            // 
            // haba
            // 
            this.haba.BackColor = System.Drawing.SystemColors.Highlight;
            this.haba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.haba.ForeColor = System.Drawing.Color.AliceBlue;
            this.haba.Location = new System.Drawing.Point(916, 187);
            this.haba.Name = "haba";
            this.haba.Size = new System.Drawing.Size(116, 32);
            this.haba.TabIndex = 116;
            this.haba.Text = "הבא";
            this.haba.UseVisualStyleBackColor = false;
            this.haba.Click += new System.EventHandler(this.haba_Click_1);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(512, 38);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(216, 79);
            this.lb.TabIndex = 121;
            this.lb.Text = "ספקים";
            // 
            // Form_sapakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1249, 882);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.before);
            this.Controls.Add(this.haba);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbup_phone);
            this.Controls.Add(this.txbup_ishkesherphone);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.txb_ishkeshrphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.txbde_shem);
            this.Controls.Add(this.txbde_phone);
            this.Controls.Add(this.txbde_ctovet);
            this.Controls.Add(this.txbde_ishkesherphone);
            this.Controls.Add(this.de_phone);
            this.Controls.Add(this.de_ctovet);
            this.Controls.Add(this.de_ishkesherphone);
            this.Controls.Add(this.de_shem);
            this.Controls.Add(this.bt_ap);
            this.Controls.Add(this.txbup_shem);
            this.Controls.Add(this.txbup_ctovet);
            this.Controls.Add(this.up_phone);
            this.Controls.Add(this.up_ctovet);
            this.Controls.Add(this.up_ishkesherphone);
            this.Controls.Add(this.up_shem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.txb_shem);
            this.Controls.Add(this.txb_ktovet);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.ktovet);
            this.Controls.Add(this.ishkesherphone);
            this.Controls.Add(this.shem);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_delete_horses);
            this.Controls.Add(this.bt_update_horses);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_search_horses);
            this.Name = "Form_sapakim";
            this.Text = "Form_sapakim";
            this.Load += new System.EventHandler(this.Form_sapakim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_search_horses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_update_horses;
        private System.Windows.Forms.Button bt_delete_horses;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label shem;
        private System.Windows.Forms.Label ishkesherphone;
        private System.Windows.Forms.Label ktovet;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox txb_ktovet;
        private System.Windows.Forms.TextBox txb_shem;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hoursesDataSet hoursesDataSet;
        private System.Windows.Forms.BindingSource sapakimBindingSource;
        private hoursesDataSetTableAdapters.sapakimTableAdapter sapakimTableAdapter;
        private System.Windows.Forms.Button bt_ap;
        private System.Windows.Forms.TextBox txbup_shem;
        private System.Windows.Forms.TextBox txbup_ctovet;
        private System.Windows.Forms.Label up_phone;
        private System.Windows.Forms.Label up_ctovet;
        private System.Windows.Forms.Label up_ishkesherphone;
        private System.Windows.Forms.Label up_shem;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox txbde_shem;
        private System.Windows.Forms.TextBox txbde_phone;
        private System.Windows.Forms.TextBox txbde_ctovet;
        private System.Windows.Forms.TextBox txbde_ishkesherphone;
        private System.Windows.Forms.Label de_phone;
        private System.Windows.Forms.Label de_ctovet;
        private System.Windows.Forms.Label de_ishkesherphone;
        private System.Windows.Forms.Label de_shem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txb_ishkeshrphone;
        private System.Windows.Forms.MaskedTextBox txb_phone;
        private System.Windows.Forms.MaskedTextBox txbup_ishkesherphone;
        private System.Windows.Forms.MaskedTextBox txbup_phone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneAishKesherDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button before;
        private System.Windows.Forms.Button haba;
        private System.Windows.Forms.Label lb;
    }
}