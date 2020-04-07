namespace christina_hourses
{
    partial class Form_lekohot
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
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_update_horses = new System.Windows.Forms.Button();
            this.bt_delete_horses = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_search_horses = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.shem = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.txb_shem = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lakohotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoursesDataSet = new christina_hourses.hoursesDataSet();
            this.lakohotTableAdapter = new christina_hourses.hoursesDataSetTableAdapters.lakohotTableAdapter();
            this.bt_up = new System.Windows.Forms.Button();
            this.txup_shem = new System.Windows.Forms.TextBox();
            this.up_id = new System.Windows.Forms.Label();
            this.up_phone = new System.Windows.Forms.Label();
            this.up_shem = new System.Windows.Forms.Label();
            this.bt_de = new System.Windows.Forms.Button();
            this.txde_phone = new System.Windows.Forms.TextBox();
            this.txde_shem = new System.Windows.Forms.TextBox();
            this.de_id = new System.Windows.Forms.Label();
            this.de_phone = new System.Windows.Forms.Label();
            this.de_shem = new System.Windows.Forms.Label();
            this.txb_id = new System.Windows.Forms.MaskedTextBox();
            this.txde_id = new System.Windows.Forms.MaskedTextBox();
            this.txup_id = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_phone = new System.Windows.Forms.MaskedTextBox();
            this.txup_phone = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.before = new System.Windows.Forms.Button();
            this.haba = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakohotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_ok.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_ok.Location = new System.Drawing.Point(823, 463);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(144, 52);
            this.bt_ok.TabIndex = 8;
            this.bt_ok.Text = "הוספה";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_update_horses
            // 
            this.bt_update_horses.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_update_horses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_update_horses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_update_horses.Location = new System.Drawing.Point(570, 464);
            this.bt_update_horses.Name = "bt_update_horses";
            this.bt_update_horses.Size = new System.Drawing.Size(147, 52);
            this.bt_update_horses.TabIndex = 9;
            this.bt_update_horses.Text = "עדכון";
            this.bt_update_horses.UseVisualStyleBackColor = false;
            this.bt_update_horses.Click += new System.EventHandler(this.bt_update_horses_Click);
            // 
            // bt_delete_horses
            // 
            this.bt_delete_horses.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_delete_horses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_delete_horses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_delete_horses.Location = new System.Drawing.Point(309, 464);
            this.bt_delete_horses.Name = "bt_delete_horses";
            this.bt_delete_horses.Size = new System.Drawing.Size(147, 52);
            this.bt_delete_horses.TabIndex = 10;
            this.bt_delete_horses.Text = "מחיקה";
            this.bt_delete_horses.UseVisualStyleBackColor = false;
            this.bt_delete_horses.Click += new System.EventHandler(this.bt_delete_horses_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(477, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_search_horses
            // 
            this.lb_search_horses.AutoSize = true;
            this.lb_search_horses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_search_horses.Location = new System.Drawing.Point(670, 411);
            this.lb_search_horses.Name = "lb_search_horses";
            this.lb_search_horses.Size = new System.Drawing.Size(60, 24);
            this.lb_search_horses.TabIndex = 12;
            this.lb_search_horses.Text = "חיפוש";
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_close.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_close.Location = new System.Drawing.Point(35, 769);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(129, 75);
            this.bt_close.TabIndex = 13;
            this.bt_close.Text = "חזרה לדף הראשי";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // shem
            // 
            this.shem.AutoSize = true;
            this.shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shem.Location = new System.Drawing.Point(1067, 566);
            this.shem.Name = "shem";
            this.shem.Size = new System.Drawing.Size(41, 25);
            this.shem.TabIndex = 15;
            this.shem.Text = "שם";
            this.shem.Visible = false;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.phone.Location = new System.Drawing.Point(1026, 615);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(80, 25);
            this.phone.TabIndex = 16;
            this.phone.Text = "פלאפון";
            this.phone.Visible = false;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.id.Location = new System.Drawing.Point(978, 660);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(126, 25);
            this.id.TabIndex = 17;
            this.id.Text = "תעודת זהות";
            this.id.Visible = false;
            // 
            // txb_shem
            // 
            this.txb_shem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_shem.Location = new System.Drawing.Point(835, 572);
            this.txb_shem.Name = "txb_shem";
            this.txb_shem.Size = new System.Drawing.Size(143, 20);
            this.txb_shem.TabIndex = 0;
            this.txb_shem.Visible = false;
            this.txb_shem.WordWrap = false;
            this.txb_shem.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txb_shem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_shem_KeyPress);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_add.ForeColor = System.Drawing.Color.Snow;
            this.bt_add.Location = new System.Drawing.Point(851, 716);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(113, 35);
            this.bt_add.TabIndex = 38;
            this.bt_add.Text = "הוסף";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Visible = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shemDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lakohotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(407, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 249);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lakohotBindingSource
            // 
            this.lakohotBindingSource.DataMember = "lakohot";
            this.lakohotBindingSource.DataSource = this.hoursesDataSet;
            // 
            // hoursesDataSet
            // 
            this.hoursesDataSet.DataSetName = "hoursesDataSet";
            this.hoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lakohotTableAdapter
            // 
            this.lakohotTableAdapter.ClearBeforeFill = true;
            // 
            // bt_up
            // 
            this.bt_up.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_up.ForeColor = System.Drawing.Color.Snow;
            this.bt_up.Location = new System.Drawing.Point(570, 716);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(113, 35);
            this.bt_up.TabIndex = 46;
            this.bt_up.Text = "עדכן";
            this.bt_up.UseVisualStyleBackColor = false;
            this.bt_up.Visible = false;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // txup_shem
            // 
            this.txup_shem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txup_shem.Location = new System.Drawing.Point(540, 572);
            this.txup_shem.Name = "txup_shem";
            this.txup_shem.Size = new System.Drawing.Size(143, 20);
            this.txup_shem.TabIndex = 3;
            this.txup_shem.Visible = false;
            this.txup_shem.WordWrap = false;
            this.txup_shem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txup_shem_KeyPress);
            // 
            // up_id
            // 
            this.up_id.AutoSize = true;
            this.up_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.up_id.Location = new System.Drawing.Point(682, 661);
            this.up_id.Name = "up_id";
            this.up_id.Size = new System.Drawing.Size(126, 25);
            this.up_id.TabIndex = 42;
            this.up_id.Text = "תעודת זהות";
            this.up_id.Visible = false;
            // 
            // up_phone
            // 
            this.up_phone.AutoSize = true;
            this.up_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.up_phone.Location = new System.Drawing.Point(728, 615);
            this.up_phone.Name = "up_phone";
            this.up_phone.Size = new System.Drawing.Size(80, 25);
            this.up_phone.TabIndex = 41;
            this.up_phone.Text = "פלאפון";
            this.up_phone.Visible = false;
            // 
            // up_shem
            // 
            this.up_shem.AutoSize = true;
            this.up_shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.up_shem.Location = new System.Drawing.Point(767, 565);
            this.up_shem.Name = "up_shem";
            this.up_shem.Size = new System.Drawing.Size(41, 25);
            this.up_shem.TabIndex = 40;
            this.up_shem.Text = "שם";
            this.up_shem.Visible = false;
            // 
            // bt_de
            // 
            this.bt_de.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bt_de.ForeColor = System.Drawing.Color.Snow;
            this.bt_de.Location = new System.Drawing.Point(255, 715);
            this.bt_de.Name = "bt_de";
            this.bt_de.Size = new System.Drawing.Size(113, 35);
            this.bt_de.TabIndex = 53;
            this.bt_de.Text = "מחק";
            this.bt_de.UseVisualStyleBackColor = false;
            this.bt_de.Visible = false;
            this.bt_de.Click += new System.EventHandler(this.bt_de_Click);
            // 
            // txde_phone
            // 
            this.txde_phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txde_phone.Location = new System.Drawing.Point(239, 620);
            this.txde_phone.Name = "txde_phone";
            this.txde_phone.Size = new System.Drawing.Size(143, 20);
            this.txde_phone.TabIndex = 7;
            this.txde_phone.Visible = false;
            this.txde_phone.WordWrap = false;
            // 
            // txde_shem
            // 
            this.txde_shem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txde_shem.Location = new System.Drawing.Point(239, 571);
            this.txde_shem.Name = "txde_shem";
            this.txde_shem.Size = new System.Drawing.Size(143, 20);
            this.txde_shem.TabIndex = 6;
            this.txde_shem.Visible = false;
            this.txde_shem.WordWrap = false;
            // 
            // de_id
            // 
            this.de_id.AutoSize = true;
            this.de_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.de_id.Location = new System.Drawing.Point(388, 662);
            this.de_id.Name = "de_id";
            this.de_id.Size = new System.Drawing.Size(126, 25);
            this.de_id.TabIndex = 49;
            this.de_id.Text = "תעודת זהות";
            this.de_id.Visible = false;
            // 
            // de_phone
            // 
            this.de_phone.AutoSize = true;
            this.de_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.de_phone.Location = new System.Drawing.Point(434, 614);
            this.de_phone.Name = "de_phone";
            this.de_phone.Size = new System.Drawing.Size(80, 25);
            this.de_phone.TabIndex = 48;
            this.de_phone.Text = "פלאפון";
            this.de_phone.Visible = false;
            // 
            // de_shem
            // 
            this.de_shem.AutoSize = true;
            this.de_shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.de_shem.Location = new System.Drawing.Point(473, 565);
            this.de_shem.Name = "de_shem";
            this.de_shem.Size = new System.Drawing.Size(41, 25);
            this.de_shem.TabIndex = 47;
            this.de_shem.Text = "שם";
            this.de_shem.Visible = false;
            // 
            // txb_id
            // 
            this.txb_id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_id.Location = new System.Drawing.Point(839, 669);
            this.txb_id.Mask = "000000000";
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(139, 20);
            this.txb_id.TabIndex = 2;
            this.txb_id.Visible = false;
            this.txb_id.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txb_id_MaskInputRejected);
            this.txb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_id_KeyPress);
            // 
            // txde_id
            // 
            this.txde_id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txde_id.Location = new System.Drawing.Point(239, 666);
            this.txde_id.Mask = "000000000";
            this.txde_id.Name = "txde_id";
            this.txde_id.Size = new System.Drawing.Size(139, 20);
            this.txde_id.TabIndex = 8;
            this.txde_id.Visible = false;
            // 
            // txup_id
            // 
            this.txup_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txup_id.Location = new System.Drawing.Point(544, 669);
            this.txup_id.Mask = "000000000";
            this.txup_id.Name = "txup_id";
            this.txup_id.Size = new System.Drawing.Size(139, 20);
            this.txup_id.TabIndex = 5;
            this.txup_id.Visible = false;
            this.txup_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txup_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(814, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "**";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(814, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "**";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(812, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "**";
            this.label3.Visible = false;
            // 
            // txb_phone
            // 
            this.txb_phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txb_phone.Location = new System.Drawing.Point(835, 621);
            this.txb_phone.Mask = "000-0000000";
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(144, 20);
            this.txb_phone.TabIndex = 1;
            this.txb_phone.Visible = false;
            this.txb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_phone_KeyPress);
            // 
            // txup_phone
            // 
            this.txup_phone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txup_phone.Location = new System.Drawing.Point(544, 621);
            this.txup_phone.Mask = "000-0000000";
            this.txup_phone.Name = "txup_phone";
            this.txup_phone.Size = new System.Drawing.Size(144, 20);
            this.txup_phone.TabIndex = 4;
            this.txup_phone.Visible = false;
            this.txup_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txup_phone_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(520, 669);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 111;
            this.label13.Text = "**";
            this.label13.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(520, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 110;
            this.label11.Text = "**";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(520, 621);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 20);
            this.label12.TabIndex = 109;
            this.label12.Text = "**";
            this.label12.Visible = false;
            // 
            // last
            // 
            this.last.BackColor = System.Drawing.SystemColors.Highlight;
            this.last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.last.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.last.Location = new System.Drawing.Point(850, 310);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(115, 32);
            this.last.TabIndex = 115;
            this.last.Text = "האחרון";
            this.last.UseVisualStyleBackColor = false;
            this.last.Click += new System.EventHandler(this.last_Click_1);
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.Highlight;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.first.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.first.Location = new System.Drawing.Point(849, 262);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(115, 32);
            this.first.TabIndex = 114;
            this.first.Text = "הראשון";
            this.first.UseVisualStyleBackColor = false;
            this.first.Click += new System.EventHandler(this.first_Click_1);
            // 
            // before
            // 
            this.before.BackColor = System.Drawing.SystemColors.Highlight;
            this.before.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.before.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.before.Location = new System.Drawing.Point(849, 216);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(115, 30);
            this.before.TabIndex = 113;
            this.before.Text = "הקודם";
            this.before.UseVisualStyleBackColor = false;
            this.before.Click += new System.EventHandler(this.before_Click);
            // 
            // haba
            // 
            this.haba.BackColor = System.Drawing.SystemColors.Highlight;
            this.haba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.haba.ForeColor = System.Drawing.Color.AliceBlue;
            this.haba.Location = new System.Drawing.Point(849, 170);
            this.haba.Name = "haba";
            this.haba.Size = new System.Drawing.Size(116, 32);
            this.haba.TabIndex = 112;
            this.haba.Text = "הבא";
            this.haba.UseVisualStyleBackColor = false;
            this.haba.Click += new System.EventHandler(this.haba_Click_1);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(488, 9);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(235, 79);
            this.lb.TabIndex = 121;
            this.lb.Text = "לקוחות";
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "שם";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "פלאפון";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "תעודת זהות";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Form_lekohot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1234, 857);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.before);
            this.Controls.Add(this.haba);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txup_phone);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txup_id);
            this.Controls.Add(this.txde_id);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.bt_de);
            this.Controls.Add(this.txde_phone);
            this.Controls.Add(this.txde_shem);
            this.Controls.Add(this.de_id);
            this.Controls.Add(this.de_phone);
            this.Controls.Add(this.de_shem);
            this.Controls.Add(this.bt_up);
            this.Controls.Add(this.txup_shem);
            this.Controls.Add(this.up_id);
            this.Controls.Add(this.up_phone);
            this.Controls.Add(this.up_shem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.txb_shem);
            this.Controls.Add(this.id);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.shem);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.lb_search_horses);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_delete_horses);
            this.Controls.Add(this.bt_update_horses);
            this.Controls.Add(this.bt_ok);
            this.Name = "Form_lekohot";
            this.Text = "Form_lekohot";
            this.Load += new System.EventHandler(this.Form_lekohot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakohotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_update_horses;
        private System.Windows.Forms.Button bt_delete_horses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_search_horses;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label shem;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txb_shem;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hoursesDataSet hoursesDataSet;
        private System.Windows.Forms.BindingSource lakohotBindingSource;
        private hoursesDataSetTableAdapters.lakohotTableAdapter lakohotTableAdapter;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.TextBox txup_shem;
        private System.Windows.Forms.Label up_id;
        private System.Windows.Forms.Label up_phone;
        private System.Windows.Forms.Label up_shem;
        private System.Windows.Forms.Button bt_de;
        private System.Windows.Forms.TextBox txde_phone;
        private System.Windows.Forms.TextBox txde_shem;
        private System.Windows.Forms.Label de_id;
        private System.Windows.Forms.Label de_phone;
        private System.Windows.Forms.Label de_shem;
        private System.Windows.Forms.MaskedTextBox txb_id;
        private System.Windows.Forms.MaskedTextBox txde_id;
        private System.Windows.Forms.MaskedTextBox txup_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txb_phone;
        private System.Windows.Forms.MaskedTextBox txup_phone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button before;
        private System.Windows.Forms.Button haba;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}