namespace WindowsFormsApplication1
{
    partial class frmhazrot
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
            this.brcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemSokhenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhirTzarhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazrotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.hazrotTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.hazrotTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.motzarimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sokhanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sokhanimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.sokhanimTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaAlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaNmcharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miHspakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamaNmharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamaNesharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motzarimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.motzarimTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazrotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motzarimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokhanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brcodeDataGridViewTextBoxColumn,
            this.shemDataGridViewTextBoxColumn,
            this.mikomDataGridViewTextBoxColumn,
            this.comtDataGridViewTextBoxColumn,
            this.shemSokhenDataGridViewTextBoxColumn,
            this.mhirTzarhanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hazrotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // brcodeDataGridViewTextBoxColumn
            // 
            this.brcodeDataGridViewTextBoxColumn.DataPropertyName = "brcode";
            this.brcodeDataGridViewTextBoxColumn.HeaderText = "brcode";
            this.brcodeDataGridViewTextBoxColumn.Name = "brcodeDataGridViewTextBoxColumn";
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "shem";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // mikomDataGridViewTextBoxColumn
            // 
            this.mikomDataGridViewTextBoxColumn.DataPropertyName = "mikom";
            this.mikomDataGridViewTextBoxColumn.HeaderText = "mikom";
            this.mikomDataGridViewTextBoxColumn.Name = "mikomDataGridViewTextBoxColumn";
            // 
            // comtDataGridViewTextBoxColumn
            // 
            this.comtDataGridViewTextBoxColumn.DataPropertyName = "comt";
            this.comtDataGridViewTextBoxColumn.HeaderText = "comt";
            this.comtDataGridViewTextBoxColumn.Name = "comtDataGridViewTextBoxColumn";
            // 
            // shemSokhenDataGridViewTextBoxColumn
            // 
            this.shemSokhenDataGridViewTextBoxColumn.DataPropertyName = "shem sokhen";
            this.shemSokhenDataGridViewTextBoxColumn.HeaderText = "shem sokhen";
            this.shemSokhenDataGridViewTextBoxColumn.Name = "shemSokhenDataGridViewTextBoxColumn";
            // 
            // mhirTzarhanDataGridViewTextBoxColumn
            // 
            this.mhirTzarhanDataGridViewTextBoxColumn.DataPropertyName = "mhir tzarhan";
            this.mhirTzarhanDataGridViewTextBoxColumn.HeaderText = "mhir tzarhan";
            this.mhirTzarhanDataGridViewTextBoxColumn.Name = "mhirTzarhanDataGridViewTextBoxColumn";
            // 
            // hazrotBindingSource
            // 
            this.hazrotBindingSource.DataMember = "hazrot";
            this.hazrotBindingSource.DataSource = this.abedDataSet;
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hazrotTableAdapter
            // 
            this.hazrotTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "shem", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(886, 311);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // motzarimBindingSource
            // 
            this.motzarimBindingSource.DataMember = "motzarim";
            this.motzarimBindingSource.DataSource = this.abedDataSet;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(886, 410);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "cama nmchar", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(886, 498);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1101, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "קוד";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1101, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "שם";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1101, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "מיקום";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1101, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "כמות";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1101, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "שם סוכן";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1101, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "מחיר צרכן";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1101, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "חיפוש";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(886, 193);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 15;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(227, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "עדכון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "הוספה";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1222, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "נקה";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(479, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 59);
            this.button6.TabIndex = 21;
            this.button6.Text = "הוספה";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(886, 262);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 22;
            this.textBox8.Click += new System.EventHandler(this.textBox8_Click);
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(886, 459);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(690, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(690, 381);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 27;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(593, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 42);
            this.label9.TabIndex = 29;
            this.label9.Text = "החזרות";
            // 
            // sokhanimBindingSource
            // 
            this.sokhanimBindingSource.DataMember = "sokhanim";
            this.sokhanimBindingSource.DataSource = this.abedDataSet;
            // 
            // sokhanimTableAdapter
            // 
            this.sokhanimTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.shemDataGridViewTextBoxColumn1,
            this.camaAlotDataGridViewTextBoxColumn,
            this.camaNmcharDataGridViewTextBoxColumn,
            this.miHspakDataGridViewTextBoxColumn,
            this.mikomDataGridViewTextBoxColumn1,
            this.kmotDataGridViewTextBoxColumn,
            this.kamaNmharDataGridViewTextBoxColumn,
            this.kamaNesharDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.motzarimBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1276, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shemDataGridViewTextBoxColumn1
            // 
            this.shemDataGridViewTextBoxColumn1.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn1.HeaderText = "shem";
            this.shemDataGridViewTextBoxColumn1.Name = "shemDataGridViewTextBoxColumn1";
            this.shemDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // camaAlotDataGridViewTextBoxColumn
            // 
            this.camaAlotDataGridViewTextBoxColumn.DataPropertyName = "cama alot";
            this.camaAlotDataGridViewTextBoxColumn.HeaderText = "cama alot";
            this.camaAlotDataGridViewTextBoxColumn.Name = "camaAlotDataGridViewTextBoxColumn";
            this.camaAlotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // camaNmcharDataGridViewTextBoxColumn
            // 
            this.camaNmcharDataGridViewTextBoxColumn.DataPropertyName = "cama nmchar";
            this.camaNmcharDataGridViewTextBoxColumn.HeaderText = "cama nmchar";
            this.camaNmcharDataGridViewTextBoxColumn.Name = "camaNmcharDataGridViewTextBoxColumn";
            this.camaNmcharDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miHspakDataGridViewTextBoxColumn
            // 
            this.miHspakDataGridViewTextBoxColumn.DataPropertyName = "mi hspak";
            this.miHspakDataGridViewTextBoxColumn.HeaderText = "mi hspak";
            this.miHspakDataGridViewTextBoxColumn.Name = "miHspakDataGridViewTextBoxColumn";
            this.miHspakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mikomDataGridViewTextBoxColumn1
            // 
            this.mikomDataGridViewTextBoxColumn1.DataPropertyName = "mikom";
            this.mikomDataGridViewTextBoxColumn1.HeaderText = "mikom";
            this.mikomDataGridViewTextBoxColumn1.Name = "mikomDataGridViewTextBoxColumn1";
            this.mikomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kmotDataGridViewTextBoxColumn
            // 
            this.kmotDataGridViewTextBoxColumn.DataPropertyName = "kmot";
            this.kmotDataGridViewTextBoxColumn.HeaderText = "kmot";
            this.kmotDataGridViewTextBoxColumn.Name = "kmotDataGridViewTextBoxColumn";
            this.kmotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kamaNmharDataGridViewTextBoxColumn
            // 
            this.kamaNmharDataGridViewTextBoxColumn.DataPropertyName = "kama nmhar";
            this.kamaNmharDataGridViewTextBoxColumn.HeaderText = "kama nmhar";
            this.kamaNmharDataGridViewTextBoxColumn.Name = "kamaNmharDataGridViewTextBoxColumn";
            this.kamaNmharDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kamaNesharDataGridViewTextBoxColumn
            // 
            this.kamaNesharDataGridViewTextBoxColumn.DataPropertyName = "kama neshar";
            this.kamaNesharDataGridViewTextBoxColumn.HeaderText = "kama neshar";
            this.kamaNesharDataGridViewTextBoxColumn.Name = "kamaNesharDataGridViewTextBoxColumn";
            this.kamaNesharDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motzarimTableAdapter
            // 
            this.motzarimTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1303, 311);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 31;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "mikom", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(886, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 32;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1303, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 33;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "kama neshar", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(1259, 401);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 34;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(1386, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "כמות המוצר במלאי";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(1259, 493);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 36;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(1424, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "כל הכמות";
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(227, 464);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 56);
            this.button10.TabIndex = 38;
            this.button10.Text = "עדכון";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "code", true));
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(886, 262);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(121, 20);
            this.textBox10.TabIndex = 39;
            this.textBox10.Click += new System.EventHandler(this.textBox10_Click);
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(29, 453);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 47);
            this.button11.TabIndex = 40;
            this.button11.Text = "סיום";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(172, 604);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(216, 23);
            this.button12.TabIndex = 41;
            this.button12.Text = "סיום מערכת";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(886, 538);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(121, 20);
            this.textBox11.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1101, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "מחיר כולל";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1219, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 79);
            this.label12.TabIndex = 44;
            this.label12.Text = "extreme car";
            // 
            // frmhazrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1528, 689);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmhazrot";
            this.Text = "frmhazrot";
            this.Load += new System.EventHandler(this.frmhazrot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazrotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motzarimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sokhanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.BindingSource hazrotBindingSource;
        private abedDataSetTableAdapters.hazrotTableAdapter hazrotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mikomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemSokhenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhirTzarhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource sokhanimBindingSource;
        private abedDataSetTableAdapters.sokhanimTableAdapter sokhanimTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource motzarimBindingSource;
        private abedDataSetTableAdapters.motzarimTableAdapter motzarimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaAlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaNmcharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miHspakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mikomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamaNmharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamaNesharDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}