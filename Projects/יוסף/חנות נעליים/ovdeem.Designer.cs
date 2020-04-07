namespace חנות_נעליים
{
    partial class ovdeem
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
            this.ovdimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoe_shopDataSet = new חנות_נעליים.shoe_shopDataSet();
            this.ovdimTableAdapter = new חנות_נעליים.shoe_shopDataSetTableAdapters.ovdimTableAdapter();
            this.shem = new System.Windows.Forms.TextBox();
            this.meshpaha = new System.Windows.Forms.TextBox();
            this.gil = new System.Windows.Forms.TextBox();
            this.ktovet = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.lb_tz = new System.Windows.Forms.Label();
            this.lb_shem = new System.Windows.Forms.Label();
            this.lb_meshpaha = new System.Windows.Forms.Label();
            this.lb_gil = new System.Windows.Forms.Label();
            this.lb_bday = new System.Windows.Forms.Label();
            this.lb_maskoret = new System.Windows.Forms.Label();
            this.lb_mespar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bday = new System.Windows.Forms.MaskedTextBox();
            this.maskoret = new System.Windows.Forms.MaskedTextBox();
            this.tz = new System.Windows.Forms.MaskedTextBox();
            this.back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mespar1 = new System.Windows.Forms.MaskedTextBox();
            this.tz1 = new System.Windows.Forms.MaskedTextBox();
            this.maskoret1 = new System.Windows.Forms.MaskedTextBox();
            this.bday1 = new System.Windows.Forms.MaskedTextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.ktovet1 = new System.Windows.Forms.TextBox();
            this.gil1 = new System.Windows.Forms.TextBox();
            this.meshpaha1 = new System.Windows.Forms.TextBox();
            this.shem1 = new System.Windows.Forms.TextBox();
            this.edkon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mespar = new System.Windows.Forms.MaskedTextBox();
            this.mishmarotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mishmarotTableAdapter = new חנות_נעליים.shoe_shopDataSetTableAdapters.mishmarotTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meshpahaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskoretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesparDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovdimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.shemDataGridViewTextBoxColumn,
            this.meshpahaDataGridViewTextBoxColumn,
            this.gilDataGridViewTextBoxColumn,
            this.bdayDataGridViewTextBoxColumn,
            this.maskoretDataGridViewTextBoxColumn,
            this.mesparDataGridViewTextBoxColumn,
            this.ktovetDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ovdimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ovdimBindingSource
            // 
            this.ovdimBindingSource.DataMember = "ovdim";
            this.ovdimBindingSource.DataSource = this.shoe_shopDataSet;
            // 
            // shoe_shopDataSet
            // 
            this.shoe_shopDataSet.DataSetName = "shoe_shopDataSet";
            this.shoe_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ovdimTableAdapter
            // 
            this.ovdimTableAdapter.ClearBeforeFill = true;
            // 
            // shem
            // 
            this.shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shem.Location = new System.Drawing.Point(1310, 259);
            this.shem.Name = "shem";
            this.shem.Size = new System.Drawing.Size(200, 23);
            this.shem.TabIndex = 2;
            this.shem.TextChanged += new System.EventHandler(this.shem_TextChanged);
            this.shem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shem_KeyDown);
            this.shem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shem_KeyPress);
            // 
            // meshpaha
            // 
            this.meshpaha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meshpaha.Location = new System.Drawing.Point(1310, 309);
            this.meshpaha.Name = "meshpaha";
            this.meshpaha.Size = new System.Drawing.Size(200, 23);
            this.meshpaha.TabIndex = 3;
            this.meshpaha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.meshpaha_KeyDown);
            this.meshpaha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.meshpaha_KeyPress);
            // 
            // gil
            // 
            this.gil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gil.Location = new System.Drawing.Point(1310, 359);
            this.gil.Name = "gil";
            this.gil.Size = new System.Drawing.Size(200, 23);
            this.gil.TabIndex = 4;
            this.gil.TextChanged += new System.EventHandler(this.gil_TextChanged);
            this.gil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gil_KeyDown);
            this.gil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gil_KeyPress);
            // 
            // ktovet
            // 
            this.ktovet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ktovet.Location = new System.Drawing.Point(1310, 559);
            this.ktovet.Name = "ktovet";
            this.ktovet.Size = new System.Drawing.Size(200, 23);
            this.ktovet.TabIndex = 7;
            this.ktovet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktovet_KeyDown);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.password.Location = new System.Drawing.Point(1310, 609);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 23);
            this.password.TabIndex = 8;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.add.Location = new System.Drawing.Point(802, 652);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(115, 44);
            this.add.TabIndex = 10;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.delete.Location = new System.Drawing.Point(496, 652);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 44);
            this.delete.TabIndex = 11;
            this.delete.Text = "מחק";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // lb_tz
            // 
            this.lb_tz.AutoSize = true;
            this.lb_tz.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_tz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_tz.Location = new System.Drawing.Point(1521, 209);
            this.lb_tz.Name = "lb_tz";
            this.lb_tz.Size = new System.Drawing.Size(103, 25);
            this.lb_tz.TabIndex = 12;
            this.lb_tz.Text = "תעודת זהות";
            this.lb_tz.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_shem
            // 
            this.lb_shem.AutoSize = true;
            this.lb_shem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_shem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_shem.Location = new System.Drawing.Point(1589, 255);
            this.lb_shem.Name = "lb_shem";
            this.lb_shem.Size = new System.Drawing.Size(35, 25);
            this.lb_shem.TabIndex = 13;
            this.lb_shem.Text = "שם";
            // 
            // lb_meshpaha
            // 
            this.lb_meshpaha.AutoSize = true;
            this.lb_meshpaha.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_meshpaha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_meshpaha.Location = new System.Drawing.Point(1529, 305);
            this.lb_meshpaha.Name = "lb_meshpaha";
            this.lb_meshpaha.Size = new System.Drawing.Size(95, 25);
            this.lb_meshpaha.TabIndex = 14;
            this.lb_meshpaha.Text = "שם משפחה";
            // 
            // lb_gil
            // 
            this.lb_gil.AutoSize = true;
            this.lb_gil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_gil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_gil.Location = new System.Drawing.Point(1980, 372);
            this.lb_gil.Name = "lb_gil";
            this.lb_gil.Size = new System.Drawing.Size(36, 25);
            this.lb_gil.TabIndex = 15;
            this.lb_gil.Text = "גיל";
            this.lb_gil.Click += new System.EventHandler(this.label4_Click);
            // 
            // lb_bday
            // 
            this.lb_bday.AutoSize = true;
            this.lb_bday.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_bday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_bday.Location = new System.Drawing.Point(1523, 409);
            this.lb_bday.Name = "lb_bday";
            this.lb_bday.Size = new System.Drawing.Size(101, 25);
            this.lb_bday.TabIndex = 16;
            this.lb_bday.Text = "תאריך לידה";
            // 
            // lb_maskoret
            // 
            this.lb_maskoret.AutoSize = true;
            this.lb_maskoret.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_maskoret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_maskoret.Location = new System.Drawing.Point(1553, 459);
            this.lb_maskoret.Name = "lb_maskoret";
            this.lb_maskoret.Size = new System.Drawing.Size(71, 25);
            this.lb_maskoret.TabIndex = 17;
            this.lb_maskoret.Text = "משכורת";
            // 
            // lb_mespar
            // 
            this.lb_mespar.AutoSize = true;
            this.lb_mespar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_mespar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lb_mespar.Location = new System.Drawing.Point(1539, 504);
            this.lb_mespar.Name = "lb_mespar";
            this.lb_mespar.Size = new System.Drawing.Size(85, 25);
            this.lb_mespar.TabIndex = 18;
            this.lb_mespar.Text = "מס\' פלפון";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(1564, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "כתובת";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(1584, 605);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "קוד";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bday
            // 
            this.bday.Location = new System.Drawing.Point(1310, 409);
            this.bday.Mask = "00/00/\\2\\000";
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(200, 20);
            this.bday.TabIndex = 21;
            this.bday.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.bday_MaskInputRejected);
            this.bday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bday_KeyDown);
            // 
            // maskoret
            // 
            this.maskoret.Location = new System.Drawing.Point(1310, 459);
            this.maskoret.Mask = "00.00₪";
            this.maskoret.Name = "maskoret";
            this.maskoret.Size = new System.Drawing.Size(200, 20);
            this.maskoret.TabIndex = 22;
            this.maskoret.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskoret_MaskInputRejected);
            this.maskoret.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskoret_KeyDown);
            // 
            // tz
            // 
            this.tz.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tz.Location = new System.Drawing.Point(1310, 209);
            this.tz.Mask = "000000000";
            this.tz.Name = "tz";
            this.tz.Size = new System.Drawing.Size(200, 20);
            this.tz.TabIndex = 23;
            this.tz.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tz_MaskInputRejected);
            this.tz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tz_KeyDown);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.back.Location = new System.Drawing.Point(12, 631);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(87, 75);
            this.back.TabIndex = 24;
            this.back.Text = "חזרה";
            this.back.UseMnemonic = false;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1112, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1424, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "נקה פירוט";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(648, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "עדכון";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mespar1
            // 
            this.mespar1.Location = new System.Drawing.Point(1042, 509);
            this.mespar1.Mask = "\\0\\50-0000000";
            this.mespar1.Name = "mespar1";
            this.mespar1.Size = new System.Drawing.Size(200, 20);
            this.mespar1.TabIndex = 37;
            this.mespar1.Visible = false;
            // 
            // tz1
            // 
            this.tz1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tz1.Location = new System.Drawing.Point(1042, 209);
            this.tz1.Mask = "000000000";
            this.tz1.Name = "tz1";
            this.tz1.Size = new System.Drawing.Size(200, 20);
            this.tz1.TabIndex = 36;
            this.tz1.Visible = false;
            // 
            // maskoret1
            // 
            this.maskoret1.Location = new System.Drawing.Point(1042, 459);
            this.maskoret1.Mask = "00.00₪";
            this.maskoret1.Name = "maskoret1";
            this.maskoret1.Size = new System.Drawing.Size(200, 20);
            this.maskoret1.TabIndex = 35;
            this.maskoret1.Visible = false;
            // 
            // bday1
            // 
            this.bday1.Location = new System.Drawing.Point(1042, 409);
            this.bday1.Mask = "00/00/\\2\\000";
            this.bday1.Name = "bday1";
            this.bday1.Size = new System.Drawing.Size(200, 20);
            this.bday1.TabIndex = 34;
            this.bday1.Visible = false;
            // 
            // password1
            // 
            this.password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.password1.Location = new System.Drawing.Point(1042, 609);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(200, 23);
            this.password1.TabIndex = 33;
            this.password1.Visible = false;
            // 
            // ktovet1
            // 
            this.ktovet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ktovet1.Location = new System.Drawing.Point(1042, 559);
            this.ktovet1.Name = "ktovet1";
            this.ktovet1.Size = new System.Drawing.Size(200, 23);
            this.ktovet1.TabIndex = 32;
            this.ktovet1.Visible = false;
            // 
            // gil1
            // 
            this.gil1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gil1.Location = new System.Drawing.Point(1042, 359);
            this.gil1.Name = "gil1";
            this.gil1.Size = new System.Drawing.Size(200, 23);
            this.gil1.TabIndex = 31;
            this.gil1.Visible = false;
            // 
            // meshpaha1
            // 
            this.meshpaha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meshpaha1.Location = new System.Drawing.Point(1042, 309);
            this.meshpaha1.Name = "meshpaha1";
            this.meshpaha1.Size = new System.Drawing.Size(200, 23);
            this.meshpaha1.TabIndex = 30;
            this.meshpaha1.Visible = false;
            this.meshpaha1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.meshpaha1_KeyPress);
            // 
            // shem1
            // 
            this.shem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.shem1.Location = new System.Drawing.Point(1042, 259);
            this.shem1.Name = "shem1";
            this.shem1.Size = new System.Drawing.Size(200, 23);
            this.shem1.TabIndex = 29;
            this.shem1.Visible = false;
            this.shem1.TextChanged += new System.EventHandler(this.shem1_TextChanged);
            this.shem1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shem1_KeyPress);
            // 
            // edkon
            // 
            this.edkon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.edkon.Location = new System.Drawing.Point(1141, 651);
            this.edkon.Name = "edkon";
            this.edkon.Size = new System.Drawing.Size(101, 47);
            this.edkon.TabIndex = 38;
            this.edkon.Text = "עדכן";
            this.edkon.UseVisualStyleBackColor = true;
            this.edkon.Visible = false;
            this.edkon.Click += new System.EventHandler(this.edkon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1349, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "חיפוש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1530, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 40;
            this.label2.Text = "00:00:00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mespar
            // 
            this.mespar.Location = new System.Drawing.Point(1310, 509);
            this.mespar.Mask = "\\0\\50-0000000";
            this.mespar.Name = "mespar";
            this.mespar.Size = new System.Drawing.Size(200, 20);
            this.mespar.TabIndex = 25;
            this.mespar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mespar_MaskInputRejected);
            this.mespar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mespar_KeyDown);
            // 
            // mishmarotBindingSource
            // 
            this.mishmarotBindingSource.DataMember = "mishmarot";
            this.mishmarotBindingSource.DataSource = this.shoe_shopDataSet;
            // 
            // mishmarotTableAdapter
            // 
            this.mishmarotTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(1588, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "גיל";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tz";
            this.dataGridViewTextBoxColumn1.HeaderText = "תעודת זהות";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "שם";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // meshpahaDataGridViewTextBoxColumn
            // 
            this.meshpahaDataGridViewTextBoxColumn.DataPropertyName = "meshpaha";
            this.meshpahaDataGridViewTextBoxColumn.HeaderText = "משפחה";
            this.meshpahaDataGridViewTextBoxColumn.Name = "meshpahaDataGridViewTextBoxColumn";
            // 
            // gilDataGridViewTextBoxColumn
            // 
            this.gilDataGridViewTextBoxColumn.DataPropertyName = "gil";
            this.gilDataGridViewTextBoxColumn.HeaderText = "גיל";
            this.gilDataGridViewTextBoxColumn.Name = "gilDataGridViewTextBoxColumn";
            // 
            // bdayDataGridViewTextBoxColumn
            // 
            this.bdayDataGridViewTextBoxColumn.DataPropertyName = "bday";
            this.bdayDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.bdayDataGridViewTextBoxColumn.Name = "bdayDataGridViewTextBoxColumn";
            // 
            // maskoretDataGridViewTextBoxColumn
            // 
            this.maskoretDataGridViewTextBoxColumn.DataPropertyName = "maskoret";
            this.maskoretDataGridViewTextBoxColumn.HeaderText = "משכורת";
            this.maskoretDataGridViewTextBoxColumn.Name = "maskoretDataGridViewTextBoxColumn";
            // 
            // mesparDataGridViewTextBoxColumn
            // 
            this.mesparDataGridViewTextBoxColumn.DataPropertyName = "mespar";
            this.mesparDataGridViewTextBoxColumn.HeaderText = "מספר פלאפון";
            this.mesparDataGridViewTextBoxColumn.Name = "mesparDataGridViewTextBoxColumn";
            // 
            // ktovetDataGridViewTextBoxColumn
            // 
            this.ktovetDataGridViewTextBoxColumn.DataPropertyName = "ktovet";
            this.ktovetDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.ktovetDataGridViewTextBoxColumn.Name = "ktovetDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "מספר עובד";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // ovdeem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1662, 718);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edkon);
            this.Controls.Add(this.mespar1);
            this.Controls.Add(this.tz1);
            this.Controls.Add(this.maskoret1);
            this.Controls.Add(this.bday1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.ktovet1);
            this.Controls.Add(this.gil1);
            this.Controls.Add(this.meshpaha1);
            this.Controls.Add(this.shem1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mespar);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tz);
            this.Controls.Add(this.maskoret);
            this.Controls.Add(this.bday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_mespar);
            this.Controls.Add(this.lb_maskoret);
            this.Controls.Add(this.lb_bday);
            this.Controls.Add(this.lb_gil);
            this.Controls.Add(this.lb_meshpaha);
            this.Controls.Add(this.lb_shem);
            this.Controls.Add(this.lb_tz);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ktovet);
            this.Controls.Add(this.gil);
            this.Controls.Add(this.meshpaha);
            this.Controls.Add(this.shem);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ovdeem";
            this.Load += new System.EventHandler(this.ovdeem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovdimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoe_shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mishmarotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private shoe_shopDataSet shoe_shopDataSet;
        private System.Windows.Forms.BindingSource ovdimBindingSource;
        private shoe_shopDataSetTableAdapters.ovdimTableAdapter ovdimTableAdapter;
        private System.Windows.Forms.TextBox shem;
        private System.Windows.Forms.TextBox meshpaha;
        private System.Windows.Forms.TextBox gil;
        private System.Windows.Forms.TextBox ktovet;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label lb_tz;
        private System.Windows.Forms.Label lb_shem;
        private System.Windows.Forms.Label lb_meshpaha;
        private System.Windows.Forms.Label lb_gil;
        private System.Windows.Forms.Label lb_bday;
        private System.Windows.Forms.Label lb_maskoret;
        private System.Windows.Forms.Label lb_mespar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox bday;
        private System.Windows.Forms.MaskedTextBox maskoret;
        private System.Windows.Forms.MaskedTextBox tz;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox mespar1;
        private System.Windows.Forms.MaskedTextBox tz1;
        private System.Windows.Forms.MaskedTextBox maskoret1;
        private System.Windows.Forms.MaskedTextBox bday1;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox ktovet1;
        private System.Windows.Forms.TextBox gil1;
        private System.Windows.Forms.TextBox meshpaha1;
        private System.Windows.Forms.TextBox shem1;
        private System.Windows.Forms.Button edkon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mespar;
        private System.Windows.Forms.BindingSource mishmarotBindingSource;
        private shoe_shopDataSetTableAdapters.mishmarotTableAdapter mishmarotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meshpahaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskoretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesparDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;




    }
}