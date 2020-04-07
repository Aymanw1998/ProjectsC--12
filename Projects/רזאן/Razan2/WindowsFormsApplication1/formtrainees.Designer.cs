namespace WindowsFormsApplication1
{
    partial class formtrainees
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
            this.yeshuv = new System.Windows.Forms.TextBox();
            this.mitamneem2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razan22DataSet1 = new WindowsFormsApplication1.razan22DataSet1();
            this.hug = new System.Windows.Forms.Label();
            this.hiov = new System.Windows.Forms.Label();
            this.yeshuvmitamen = new System.Windows.Forms.Label();
            this.lblbdaymitamen = new System.Windows.Forms.Label();
            this.lblminmitamen = new System.Windows.Forms.Label();
            this.lblgilmitamen = new System.Windows.Forms.Label();
            this.lblktovetmitamen = new System.Windows.Forms.Label();
            this.lbltelmitamen = new System.Windows.Forms.Label();
            this.lblmishmitamen = new System.Windows.Forms.Label();
            this.lblshemmitamen = new System.Windows.Forms.Label();
            this.lbltzmitamen = new System.Windows.Forms.Label();
            this.gilmitamen = new System.Windows.Forms.TextBox();
            this.tzmitamen = new System.Windows.Forms.TextBox();
            this.shemmitamen = new System.Windows.Forms.TextBox();
            this.mishmitamen = new System.Windows.Forms.TextBox();
            this.ktovetmitamen = new System.Windows.Forms.TextBox();
            this.lblstrainees = new System.Windows.Forms.Label();
            this.tbtrainees = new System.Windows.Forms.TextBox();
            this.lblS = new System.Windows.Forms.Label();
            this.btnbktrainees = new System.Windows.Forms.Button();
            this.btnmamidk = new System.Windows.Forms.Button();
            this.btnmtamh = new System.Windows.Forms.Button();
            this.btnmtaho = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mishpahaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeshuvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitamneem2TableAdapter = new WindowsFormsApplication1.razan22DataSet1TableAdapters.mitamneem2TableAdapter();
            this.lbltokef = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.telmitamen = new System.Windows.Forms.MaskedTextBox();
            this.minmitamen = new System.Windows.Forms.ComboBox();
            this.bdaymitamen = new System.Windows.Forms.MaskedTextBox();
            this.hiovmitamen = new System.Windows.Forms.MaskedTextBox();
            this.tokefmitamen = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tzmitamen2 = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.hugmitamen = new System.Windows.Forms.ComboBox();
            this.hugeem2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hugeem2TableAdapter = new WindowsFormsApplication1.razan22DataSet1TableAdapters.hugeem2TableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mitamneem2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razan22DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hugeem2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // yeshuv
            // 
            this.yeshuv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "yeshuv", true));
            this.yeshuv.Enabled = false;
            this.yeshuv.Location = new System.Drawing.Point(1040, 503);
            this.yeshuv.Name = "yeshuv";
            this.yeshuv.Size = new System.Drawing.Size(151, 20);
            this.yeshuv.TabIndex = 9;
            this.yeshuv.TextChanged += new System.EventHandler(this.yeshuv_TextChanged);
            this.yeshuv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yeshuv_KeyPress);
            // 
            // mitamneem2BindingSource
            // 
            this.mitamneem2BindingSource.DataMember = "mitamneem2";
            this.mitamneem2BindingSource.DataSource = this.razan22DataSet1;
            // 
            // razan22DataSet1
            // 
            this.razan22DataSet1.DataSetName = "razan22DataSet1";
            this.razan22DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hug
            // 
            this.hug.AutoSize = true;
            this.hug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hug.Location = new System.Drawing.Point(1291, 593);
            this.hug.Name = "hug";
            this.hug.Size = new System.Drawing.Size(31, 20);
            this.hug.TabIndex = 99;
            this.hug.Text = "חוג";
            // 
            // hiov
            // 
            this.hiov.AutoSize = true;
            this.hiov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hiov.Location = new System.Drawing.Point(1285, 551);
            this.hiov.Name = "hiov";
            this.hiov.Size = new System.Drawing.Size(38, 20);
            this.hiov.TabIndex = 97;
            this.hiov.Text = "חיוב";
            // 
            // yeshuvmitamen
            // 
            this.yeshuvmitamen.AutoSize = true;
            this.yeshuvmitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.yeshuvmitamen.Location = new System.Drawing.Point(1284, 503);
            this.yeshuvmitamen.Name = "yeshuvmitamen";
            this.yeshuvmitamen.Size = new System.Drawing.Size(39, 20);
            this.yeshuvmitamen.TabIndex = 96;
            this.yeshuvmitamen.Text = "ישוב";
            // 
            // lblbdaymitamen
            // 
            this.lblbdaymitamen.AutoSize = true;
            this.lblbdaymitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblbdaymitamen.Location = new System.Drawing.Point(1238, 457);
            this.lblbdaymitamen.Name = "lblbdaymitamen";
            this.lblbdaymitamen.Size = new System.Drawing.Size(88, 20);
            this.lblbdaymitamen.TabIndex = 94;
            this.lblbdaymitamen.Text = "תאריך לידה";
            this.lblbdaymitamen.Click += new System.EventHandler(this.lblbdaymitamen_Click);
            // 
            // lblminmitamen
            // 
            this.lblminmitamen.AutoSize = true;
            this.lblminmitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblminmitamen.Location = new System.Drawing.Point(1292, 412);
            this.lblminmitamen.Name = "lblminmitamen";
            this.lblminmitamen.Size = new System.Drawing.Size(31, 20);
            this.lblminmitamen.TabIndex = 92;
            this.lblminmitamen.Text = "מין";
            // 
            // lblgilmitamen
            // 
            this.lblgilmitamen.AutoSize = true;
            this.lblgilmitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblgilmitamen.Location = new System.Drawing.Point(1292, 360);
            this.lblgilmitamen.Name = "lblgilmitamen";
            this.lblgilmitamen.Size = new System.Drawing.Size(30, 20);
            this.lblgilmitamen.TabIndex = 91;
            this.lblgilmitamen.Text = "גיל";
            // 
            // lblktovetmitamen
            // 
            this.lblktovetmitamen.AutoSize = true;
            this.lblktovetmitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblktovetmitamen.Location = new System.Drawing.Point(1276, 314);
            this.lblktovetmitamen.Name = "lblktovetmitamen";
            this.lblktovetmitamen.Size = new System.Drawing.Size(51, 20);
            this.lblktovetmitamen.TabIndex = 90;
            this.lblktovetmitamen.Text = "כתובת";
            // 
            // lbltelmitamen
            // 
            this.lbltelmitamen.AutoSize = true;
            this.lbltelmitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbltelmitamen.Location = new System.Drawing.Point(1232, 261);
            this.lbltelmitamen.Name = "lbltelmitamen";
            this.lbltelmitamen.Size = new System.Drawing.Size(96, 20);
            this.lbltelmitamen.TabIndex = 89;
            this.lbltelmitamen.Text = "מספר פלאפון";
            this.lbltelmitamen.Click += new System.EventHandler(this.lbltelmitamen_Click);
            // 
            // lblmishmitamen
            // 
            this.lblmishmitamen.AutoSize = true;
            this.lblmishmitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblmishmitamen.Location = new System.Drawing.Point(1247, 215);
            this.lblmishmitamen.Name = "lblmishmitamen";
            this.lblmishmitamen.Size = new System.Drawing.Size(81, 20);
            this.lblmishmitamen.TabIndex = 88;
            this.lblmishmitamen.Text = "שם משפחה";
            this.lblmishmitamen.Click += new System.EventHandler(this.lblmishmitamen_Click);
            // 
            // lblshemmitamen
            // 
            this.lblshemmitamen.AutoSize = true;
            this.lblshemmitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblshemmitamen.Location = new System.Drawing.Point(1246, 170);
            this.lblshemmitamen.Name = "lblshemmitamen";
            this.lblshemmitamen.Size = new System.Drawing.Size(80, 20);
            this.lblshemmitamen.TabIndex = 87;
            this.lblshemmitamen.Text = "שם מתאמן";
            this.lblshemmitamen.Click += new System.EventHandler(this.lblshemmitamen_Click);
            // 
            // lbltzmitamen
            // 
            this.lbltzmitamen.AutoSize = true;
            this.lbltzmitamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbltzmitamen.Location = new System.Drawing.Point(1241, 125);
            this.lbltzmitamen.Name = "lbltzmitamen";
            this.lbltzmitamen.Size = new System.Drawing.Size(87, 20);
            this.lbltzmitamen.TabIndex = 86;
            this.lbltzmitamen.Text = "תעודת זהות";
            this.lbltzmitamen.Click += new System.EventHandler(this.lbltzmitamen_Click);
            // 
            // gilmitamen
            // 
            this.gilmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "gil", true));
            this.gilmitamen.Enabled = false;
            this.gilmitamen.Location = new System.Drawing.Point(1040, 358);
            this.gilmitamen.Name = "gilmitamen";
            this.gilmitamen.Size = new System.Drawing.Size(151, 20);
            this.gilmitamen.TabIndex = 6;
            this.gilmitamen.TextChanged += new System.EventHandler(this.gilmitamen_TextChanged);
            this.gilmitamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gilmitamen_KeyPress);
            // 
            // tzmitamen
            // 
            this.tzmitamen.Enabled = false;
            this.tzmitamen.Location = new System.Drawing.Point(1040, 125);
            this.tzmitamen.Name = "tzmitamen";
            this.tzmitamen.Size = new System.Drawing.Size(151, 20);
            this.tzmitamen.TabIndex = 1;
            this.tzmitamen.TextChanged += new System.EventHandler(this.tzmitamen_TextChanged);
            this.tzmitamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tzmitamen_KeyPress);
            // 
            // shemmitamen
            // 
            this.shemmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "shem", true));
            this.shemmitamen.Enabled = false;
            this.shemmitamen.Location = new System.Drawing.Point(1039, 170);
            this.shemmitamen.Name = "shemmitamen";
            this.shemmitamen.Size = new System.Drawing.Size(151, 20);
            this.shemmitamen.TabIndex = 2;
            this.shemmitamen.TextChanged += new System.EventHandler(this.shemmitamen_TextChanged);
            this.shemmitamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shemmitamen_KeyPress);
            // 
            // mishmitamen
            // 
            this.mishmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "mishpaha", true));
            this.mishmitamen.Enabled = false;
            this.mishmitamen.Location = new System.Drawing.Point(1040, 217);
            this.mishmitamen.Name = "mishmitamen";
            this.mishmitamen.Size = new System.Drawing.Size(151, 20);
            this.mishmitamen.TabIndex = 3;
            this.mishmitamen.TextChanged += new System.EventHandler(this.mishmitamen_TextChanged);
            this.mishmitamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mishmitamen_KeyPress);
            // 
            // ktovetmitamen
            // 
            this.ktovetmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "ktovet", true));
            this.ktovetmitamen.Enabled = false;
            this.ktovetmitamen.Location = new System.Drawing.Point(1040, 314);
            this.ktovetmitamen.Name = "ktovetmitamen";
            this.ktovetmitamen.Size = new System.Drawing.Size(151, 20);
            this.ktovetmitamen.TabIndex = 5;
            this.ktovetmitamen.TextChanged += new System.EventHandler(this.ktovetmitamen_TextChanged);
            this.ktovetmitamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktovetmitamen_KeyPress);
            // 
            // lblstrainees
            // 
            this.lblstrainees.AutoSize = true;
            this.lblstrainees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblstrainees.Location = new System.Drawing.Point(1280, 65);
            this.lblstrainees.Name = "lblstrainees";
            this.lblstrainees.Size = new System.Drawing.Size(48, 20);
            this.lblstrainees.TabIndex = 78;
            this.lblstrainees.Text = "חיפוש";
            this.lblstrainees.Click += new System.EventHandler(this.lblstrainees_Click);
            // 
            // tbtrainees
            // 
            this.tbtrainees.Location = new System.Drawing.Point(1037, 65);
            this.tbtrainees.Name = "tbtrainees";
            this.tbtrainees.Size = new System.Drawing.Size(210, 20);
            this.tbtrainees.TabIndex = 13;
            this.tbtrainees.TextChanged += new System.EventHandler(this.tbtrainees_TextChanged);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(552, 20);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(285, 113);
            this.lblS.TabIndex = 101;
            this.lblS.Text = "Trainees";
            // 
            // btnbktrainees
            // 
            this.btnbktrainees.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbktrainees.ForeColor = System.Drawing.Color.Purple;
            this.btnbktrainees.Location = new System.Drawing.Point(12, 623);
            this.btnbktrainees.Name = "btnbktrainees";
            this.btnbktrainees.Size = new System.Drawing.Size(166, 69);
            this.btnbktrainees.TabIndex = 105;
            this.btnbktrainees.Text = "חזרה לדף הראשי";
            this.btnbktrainees.UseVisualStyleBackColor = true;
            this.btnbktrainees.Click += new System.EventHandler(this.btnbktrainees_Click);
            // 
            // btnmamidk
            // 
            this.btnmamidk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmamidk.ForeColor = System.Drawing.Color.Purple;
            this.btnmamidk.Location = new System.Drawing.Point(748, 541);
            this.btnmamidk.Name = "btnmamidk";
            this.btnmamidk.Size = new System.Drawing.Size(166, 69);
            this.btnmamidk.TabIndex = 104;
            this.btnmamidk.Text = "עדכן";
            this.btnmamidk.UseVisualStyleBackColor = true;
            this.btnmamidk.Click += new System.EventHandler(this.btnmamidk_Click);
            // 
            // btnmtamh
            // 
            this.btnmtamh.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmtamh.ForeColor = System.Drawing.Color.Purple;
            this.btnmtamh.Location = new System.Drawing.Point(462, 544);
            this.btnmtamh.Name = "btnmtamh";
            this.btnmtamh.Size = new System.Drawing.Size(166, 69);
            this.btnmtamh.TabIndex = 103;
            this.btnmtamh.Text = "מחק";
            this.btnmtamh.UseVisualStyleBackColor = true;
            this.btnmtamh.Click += new System.EventHandler(this.btnmtamh_Click);
            // 
            // btnmtaho
            // 
            this.btnmtaho.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmtaho.ForeColor = System.Drawing.Color.Purple;
            this.btnmtaho.Location = new System.Drawing.Point(202, 544);
            this.btnmtaho.Name = "btnmtaho";
            this.btnmtaho.Size = new System.Drawing.Size(166, 69);
            this.btnmtaho.TabIndex = 102;
            this.btnmtaho.Text = "הוסף";
            this.btnmtaho.UseVisualStyleBackColor = true;
            this.btnmtaho.Click += new System.EventHandler(this.btnmtaho_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tzDataGridViewTextBoxColumn,
            this.shemDataGridViewTextBoxColumn,
            this.mishpahaDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.ktovetDataGridViewTextBoxColumn,
            this.gilDataGridViewTextBoxColumn,
            this.minDataGridViewTextBoxColumn,
            this.tarikhDataGridViewTextBoxColumn,
            this.yeshuvDataGridViewTextBoxColumn,
            this.hiovDataGridViewTextBoxColumn,
            this.hugDataGridViewTextBoxColumn,
            this.tokefDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mitamneem2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(151, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 329);
            this.dataGridView1.TabIndex = 106;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tzDataGridViewTextBoxColumn
            // 
            this.tzDataGridViewTextBoxColumn.DataPropertyName = "tz";
            this.tzDataGridViewTextBoxColumn.HeaderText = "תעודת זהות";
            this.tzDataGridViewTextBoxColumn.Name = "tzDataGridViewTextBoxColumn";
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "שם מתאמן";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // mishpahaDataGridViewTextBoxColumn
            // 
            this.mishpahaDataGridViewTextBoxColumn.DataPropertyName = "mishpaha";
            this.mishpahaDataGridViewTextBoxColumn.HeaderText = "משפחה";
            this.mishpahaDataGridViewTextBoxColumn.Name = "mishpahaDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "מספר פלאפון";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // ktovetDataGridViewTextBoxColumn
            // 
            this.ktovetDataGridViewTextBoxColumn.DataPropertyName = "ktovet";
            this.ktovetDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.ktovetDataGridViewTextBoxColumn.Name = "ktovetDataGridViewTextBoxColumn";
            // 
            // gilDataGridViewTextBoxColumn
            // 
            this.gilDataGridViewTextBoxColumn.DataPropertyName = "gil";
            this.gilDataGridViewTextBoxColumn.HeaderText = "גיל";
            this.gilDataGridViewTextBoxColumn.Name = "gilDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            this.minDataGridViewTextBoxColumn.DataPropertyName = "min";
            this.minDataGridViewTextBoxColumn.HeaderText = "מין";
            this.minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // tarikhDataGridViewTextBoxColumn
            // 
            this.tarikhDataGridViewTextBoxColumn.DataPropertyName = "tarikh";
            this.tarikhDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.tarikhDataGridViewTextBoxColumn.Name = "tarikhDataGridViewTextBoxColumn";
            // 
            // yeshuvDataGridViewTextBoxColumn
            // 
            this.yeshuvDataGridViewTextBoxColumn.DataPropertyName = "yeshuv";
            this.yeshuvDataGridViewTextBoxColumn.HeaderText = "ישוב";
            this.yeshuvDataGridViewTextBoxColumn.Name = "yeshuvDataGridViewTextBoxColumn";
            // 
            // hiovDataGridViewTextBoxColumn
            // 
            this.hiovDataGridViewTextBoxColumn.DataPropertyName = "hiov";
            this.hiovDataGridViewTextBoxColumn.HeaderText = "חיוב";
            this.hiovDataGridViewTextBoxColumn.Name = "hiovDataGridViewTextBoxColumn";
            // 
            // hugDataGridViewTextBoxColumn
            // 
            this.hugDataGridViewTextBoxColumn.DataPropertyName = "hug";
            this.hugDataGridViewTextBoxColumn.HeaderText = "חוג";
            this.hugDataGridViewTextBoxColumn.Name = "hugDataGridViewTextBoxColumn";
            // 
            // tokefDataGridViewTextBoxColumn
            // 
            this.tokefDataGridViewTextBoxColumn.DataPropertyName = "tokef";
            this.tokefDataGridViewTextBoxColumn.HeaderText = "תוקף מנוי";
            this.tokefDataGridViewTextBoxColumn.Name = "tokefDataGridViewTextBoxColumn";
            // 
            // mitamneem2TableAdapter
            // 
            this.mitamneem2TableAdapter.ClearBeforeFill = true;
            // 
            // lbltokef
            // 
            this.lbltokef.AutoSize = true;
            this.lbltokef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbltokef.Location = new System.Drawing.Point(1255, 635);
            this.lbltokef.Name = "lbltokef";
            this.lbltokef.Size = new System.Drawing.Size(72, 20);
            this.lbltokef.TabIndex = 108;
            this.lbltokef.Text = "תוקף מנוי";
            this.lbltokef.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1016, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "**";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1015, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "**";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1016, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "**";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1016, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "**";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1016, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "**";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1016, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 115;
            this.label6.Text = "**";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1016, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 116;
            this.label7.Text = "**";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1020, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 117;
            this.label8.Text = "**";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1019, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 118;
            this.label9.Text = "**";
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1019, 551);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 16);
            this.label10.TabIndex = 119;
            this.label10.Text = "**";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1018, 643);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 16);
            this.label11.TabIndex = 120;
            this.label11.Text = "**";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1016, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 16);
            this.label12.TabIndex = 121;
            this.label12.Text = "**";
            this.label12.Visible = false;
            // 
            // telmitamen
            // 
            this.telmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "tel", true));
            this.telmitamen.Enabled = false;
            this.telmitamen.Location = new System.Drawing.Point(1040, 263);
            this.telmitamen.Mask = "000-0000000";
            this.telmitamen.Name = "telmitamen";
            this.telmitamen.Size = new System.Drawing.Size(152, 20);
            this.telmitamen.TabIndex = 4;
            this.telmitamen.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telmitamen_MaskInputRejected);
            // 
            // minmitamen
            // 
            this.minmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "min", true));
            this.minmitamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minmitamen.Enabled = false;
            this.minmitamen.FormattingEnabled = true;
            this.minmitamen.Items.AddRange(new object[] {
            "זכר",
            "נקבה"});
            this.minmitamen.Location = new System.Drawing.Point(1041, 409);
            this.minmitamen.Name = "minmitamen";
            this.minmitamen.Size = new System.Drawing.Size(151, 21);
            this.minmitamen.TabIndex = 7;
            this.minmitamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minmitamen_KeyPress);
            // 
            // bdaymitamen
            // 
            this.bdaymitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "tarikh", true));
            this.bdaymitamen.Enabled = false;
            this.bdaymitamen.Location = new System.Drawing.Point(1040, 457);
            this.bdaymitamen.Mask = "00/00/0000";
            this.bdaymitamen.Name = "bdaymitamen";
            this.bdaymitamen.Size = new System.Drawing.Size(151, 20);
            this.bdaymitamen.TabIndex = 8;
            this.bdaymitamen.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.bdaymitamen_MaskInputRejected);
            // 
            // hiovmitamen
            // 
            this.hiovmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "hiov", true));
            this.hiovmitamen.Enabled = false;
            this.hiovmitamen.Location = new System.Drawing.Point(1040, 547);
            this.hiovmitamen.Mask = "0999";
            this.hiovmitamen.Name = "hiovmitamen";
            this.hiovmitamen.Size = new System.Drawing.Size(152, 20);
            this.hiovmitamen.TabIndex = 10;
            this.hiovmitamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hiovmitamen_KeyPress);
            // 
            // tokefmitamen
            // 
            this.tokefmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "tokef", true));
            this.tokefmitamen.Enabled = false;
            this.tokefmitamen.Location = new System.Drawing.Point(1039, 637);
            this.tokefmitamen.Mask = "00/00/0000";
            this.tokefmitamen.Name = "tokefmitamen";
            this.tokefmitamen.Size = new System.Drawing.Size(151, 20);
            this.tokefmitamen.TabIndex = 12;
            this.tokefmitamen.ValidatingType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(35, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 129;
            this.button2.Text = "אחרון";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(35, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 128;
            this.button1.Text = "ראשון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(35, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 46);
            this.button4.TabIndex = 131;
            this.button4.Text = "הבא";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(35, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 46);
            this.button3.TabIndex = 130;
            this.button3.Text = "הקודם";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tzmitamen2
            // 
            this.tzmitamen2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "tz", true));
            this.tzmitamen2.Enabled = false;
            this.tzmitamen2.Location = new System.Drawing.Point(1041, 124);
            this.tzmitamen2.Mask = "000000000";
            this.tzmitamen2.Name = "tzmitamen2";
            this.tzmitamen2.Size = new System.Drawing.Size(150, 20);
            this.tzmitamen2.TabIndex = 0;
            this.tzmitamen2.Click += new System.EventHandler(this.tzmitamen2_Click_2);
            this.tzmitamen2.TextChanged += new System.EventHandler(this.tzmitamen2_TextChanged_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Purple;
            this.button5.Location = new System.Drawing.Point(748, 541);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 69);
            this.button5.TabIndex = 133;
            this.button5.Text = "עדכן";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Purple;
            this.button6.Location = new System.Drawing.Point(202, 544);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 69);
            this.button6.TabIndex = 134;
            this.button6.Text = "הוסף";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hugmitamen
            // 
            this.hugmitamen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitamneem2BindingSource, "hug", true));
            this.hugmitamen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hugmitamen.Enabled = false;
            this.hugmitamen.FormattingEnabled = true;
            this.hugmitamen.Location = new System.Drawing.Point(1039, 593);
            this.hugmitamen.Name = "hugmitamen";
            this.hugmitamen.Size = new System.Drawing.Size(151, 21);
            this.hugmitamen.TabIndex = 11;
            // 
            // hugeem2BindingSource
            // 
            this.hugeem2BindingSource.DataMember = "hugeem2";
            this.hugeem2BindingSource.DataSource = this.razan22DataSet1;
            // 
            // hugeem2TableAdapter
            // 
            this.hugeem2TableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Edwardian Script ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 33);
            this.label13.TabIndex = 135;
            this.label13.Text = "R.a Fitness";
            // 
            // formtrainees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 704);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.hugmitamen);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tzmitamen2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tokefmitamen);
            this.Controls.Add(this.hiovmitamen);
            this.Controls.Add(this.bdaymitamen);
            this.Controls.Add(this.minmitamen);
            this.Controls.Add(this.telmitamen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltokef);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbktrainees);
            this.Controls.Add(this.btnmamidk);
            this.Controls.Add(this.btnmtamh);
            this.Controls.Add(this.btnmtaho);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.yeshuv);
            this.Controls.Add(this.hug);
            this.Controls.Add(this.hiov);
            this.Controls.Add(this.yeshuvmitamen);
            this.Controls.Add(this.lblbdaymitamen);
            this.Controls.Add(this.lblminmitamen);
            this.Controls.Add(this.lblgilmitamen);
            this.Controls.Add(this.lblktovetmitamen);
            this.Controls.Add(this.lbltelmitamen);
            this.Controls.Add(this.lblmishmitamen);
            this.Controls.Add(this.lblshemmitamen);
            this.Controls.Add(this.lbltzmitamen);
            this.Controls.Add(this.gilmitamen);
            this.Controls.Add(this.tzmitamen);
            this.Controls.Add(this.shemmitamen);
            this.Controls.Add(this.mishmitamen);
            this.Controls.Add(this.ktovetmitamen);
            this.Controls.Add(this.lblstrainees);
            this.Controls.Add(this.tbtrainees);
            this.Name = "formtrainees";
            this.Text = "formtrainees";
            this.Load += new System.EventHandler(this.formtrainees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mitamneem2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razan22DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hugeem2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yeshuv;
        private System.Windows.Forms.Label hug;
        private System.Windows.Forms.Label hiov;
        private System.Windows.Forms.Label yeshuvmitamen;
        private System.Windows.Forms.Label lblbdaymitamen;
        private System.Windows.Forms.Label lblminmitamen;
        private System.Windows.Forms.Label lblgilmitamen;
        private System.Windows.Forms.Label lblktovetmitamen;
        private System.Windows.Forms.Label lbltelmitamen;
        private System.Windows.Forms.Label lblmishmitamen;
        private System.Windows.Forms.Label lblshemmitamen;
        private System.Windows.Forms.Label lbltzmitamen;
        private System.Windows.Forms.TextBox gilmitamen;
        private System.Windows.Forms.TextBox tzmitamen;
        private System.Windows.Forms.TextBox shemmitamen;
        private System.Windows.Forms.TextBox mishmitamen;
        private System.Windows.Forms.TextBox ktovetmitamen;
        private System.Windows.Forms.Label lblstrainees;
        private System.Windows.Forms.TextBox tbtrainees;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Button btnbktrainees;
        private System.Windows.Forms.Button btnmamidk;
        private System.Windows.Forms.Button btnmtamh;
        private System.Windows.Forms.Button btnmtaho;
        private System.Windows.Forms.DataGridView dataGridView1;
        private razan22DataSet1 razan22DataSet1;
        private System.Windows.Forms.BindingSource mitamneem2BindingSource;
        private razan22DataSet1TableAdapters.mitamneem2TableAdapter mitamneem2TableAdapter;
        private System.Windows.Forms.Label lbltokef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox telmitamen;
        private System.Windows.Forms.ComboBox minmitamen;
        private System.Windows.Forms.MaskedTextBox bdaymitamen;
        private System.Windows.Forms.MaskedTextBox hiovmitamen;
        private System.Windows.Forms.MaskedTextBox tokefmitamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mishpahaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarikhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeshuvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokefDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox tzmitamen2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox hugmitamen;
        private System.Windows.Forms.BindingSource hugeem2BindingSource;
        private razan22DataSet1TableAdapters.hugeem2TableAdapter hugeem2TableAdapter;
        private System.Windows.Forms.Label label13;
    }
}