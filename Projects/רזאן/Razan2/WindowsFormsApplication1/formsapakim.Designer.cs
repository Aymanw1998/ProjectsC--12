namespace WindowsFormsApplication1
{
    partial class formsapakim
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
            this.lblS = new System.Windows.Forms.Label();
            this.btnbksu = new System.Windows.Forms.Button();
            this.btnsapidk = new System.Windows.Forms.Button();
            this.btnsapma = new System.Windows.Forms.Button();
            this.btnsapho = new System.Windows.Forms.Button();
            this.lblssuppliers = new System.Windows.Forms.Label();
            this.tbsuppliers = new System.Windows.Forms.TextBox();
            this.bcsapak = new System.Windows.Forms.Button();
            this.lblmissapak = new System.Windows.Forms.Label();
            this.lblyeshuvsapak = new System.Windows.Forms.Label();
            this.lblktovetsapak = new System.Windows.Forms.Label();
            this.lbltelsapak = new System.Windows.Forms.Label();
            this.lblshemsapak = new System.Windows.Forms.Label();
            this.missapak = new System.Windows.Forms.TextBox();
            this.shemsapak = new System.Windows.Forms.TextBox();
            this.ktovetsapak = new System.Windows.Forms.TextBox();
            this.yeshuvsapak = new System.Windows.Forms.TextBox();
            this.shemsapak2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.hazmana = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.razan22DataSet1 = new WindowsFormsApplication1.razan22DataSet1();
            this.sapakim2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sapakim2TableAdapter = new WindowsFormsApplication1.razan22DataSet1TableAdapters.sapakim2TableAdapter();
            this.sapakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktovetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeshuvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.misparDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razan22DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakim2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Edwardian Script ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(384, 9);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(297, 113);
            this.lblS.TabIndex = 2;
            this.lblS.Text = "Suppliers";
            this.lblS.Click += new System.EventHandler(this.lblS_Click);
            // 
            // btnbksu
            // 
            this.btnbksu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbksu.ForeColor = System.Drawing.Color.Purple;
            this.btnbksu.Location = new System.Drawing.Point(12, 573);
            this.btnbksu.Name = "btnbksu";
            this.btnbksu.Size = new System.Drawing.Size(166, 69);
            this.btnbksu.TabIndex = 9;
            this.btnbksu.Text = "חזרה לדף הראשי";
            this.btnbksu.UseVisualStyleBackColor = true;
            this.btnbksu.Click += new System.EventHandler(this.btnbksu_Click);
            // 
            // btnsapidk
            // 
            this.btnsapidk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsapidk.ForeColor = System.Drawing.Color.Purple;
            this.btnsapidk.Location = new System.Drawing.Point(681, 452);
            this.btnsapidk.Name = "btnsapidk";
            this.btnsapidk.Size = new System.Drawing.Size(166, 69);
            this.btnsapidk.TabIndex = 12;
            this.btnsapidk.Text = "עדכן";
            this.btnsapidk.UseVisualStyleBackColor = true;
            this.btnsapidk.Click += new System.EventHandler(this.btnsapidk_Click);
            // 
            // btnsapma
            // 
            this.btnsapma.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsapma.ForeColor = System.Drawing.Color.Purple;
            this.btnsapma.Location = new System.Drawing.Point(426, 452);
            this.btnsapma.Name = "btnsapma";
            this.btnsapma.Size = new System.Drawing.Size(166, 69);
            this.btnsapma.TabIndex = 11;
            this.btnsapma.Text = "מחק";
            this.btnsapma.UseVisualStyleBackColor = true;
            this.btnsapma.Click += new System.EventHandler(this.btnsapma_Click);
            // 
            // btnsapho
            // 
            this.btnsapho.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsapho.ForeColor = System.Drawing.Color.Purple;
            this.btnsapho.Location = new System.Drawing.Point(173, 452);
            this.btnsapho.Name = "btnsapho";
            this.btnsapho.Size = new System.Drawing.Size(166, 69);
            this.btnsapho.TabIndex = 10;
            this.btnsapho.Text = "הוסף";
            this.btnsapho.UseVisualStyleBackColor = true;
            this.btnsapho.Click += new System.EventHandler(this.btnsapho_Click);
            // 
            // lblssuppliers
            // 
            this.lblssuppliers.AutoSize = true;
            this.lblssuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblssuppliers.Location = new System.Drawing.Point(1121, 74);
            this.lblssuppliers.Name = "lblssuppliers";
            this.lblssuppliers.Size = new System.Drawing.Size(48, 20);
            this.lblssuppliers.TabIndex = 14;
            this.lblssuppliers.Text = "חיפוש";
            this.lblssuppliers.Click += new System.EventHandler(this.lblssuppliers_Click);
            // 
            // tbsuppliers
            // 
            this.tbsuppliers.Location = new System.Drawing.Point(888, 74);
            this.tbsuppliers.Name = "tbsuppliers";
            this.tbsuppliers.Size = new System.Drawing.Size(210, 20);
            this.tbsuppliers.TabIndex = 7;
            this.tbsuppliers.TextChanged += new System.EventHandler(this.tbsauppliers_TextChanged);
            // 
            // bcsapak
            // 
            this.bcsapak.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcsapak.ForeColor = System.Drawing.Color.Purple;
            this.bcsapak.Location = new System.Drawing.Point(216, 573);
            this.bcsapak.Name = "bcsapak";
            this.bcsapak.Size = new System.Drawing.Size(166, 69);
            this.bcsapak.TabIndex = 15;
            this.bcsapak.Text = "חזרה לדף המנהל";
            this.bcsapak.UseVisualStyleBackColor = true;
            this.bcsapak.Click += new System.EventHandler(this.bcsapak_Click);
            // 
            // lblmissapak
            // 
            this.lblmissapak.AutoSize = true;
            this.lblmissapak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblmissapak.Location = new System.Drawing.Point(1088, 339);
            this.lblmissapak.Name = "lblmissapak";
            this.lblmissapak.Size = new System.Drawing.Size(93, 20);
            this.lblmissapak.TabIndex = 61;
            this.lblmissapak.Text = "כמות מוצרים";
            // 
            // lblyeshuvsapak
            // 
            this.lblyeshuvsapak.AutoSize = true;
            this.lblyeshuvsapak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblyeshuvsapak.Location = new System.Drawing.Point(1137, 284);
            this.lblyeshuvsapak.Name = "lblyeshuvsapak";
            this.lblyeshuvsapak.Size = new System.Drawing.Size(39, 20);
            this.lblyeshuvsapak.TabIndex = 60;
            this.lblyeshuvsapak.Text = "ישוב";
            // 
            // lblktovetsapak
            // 
            this.lblktovetsapak.AutoSize = true;
            this.lblktovetsapak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblktovetsapak.Location = new System.Drawing.Point(1125, 234);
            this.lblktovetsapak.Name = "lblktovetsapak";
            this.lblktovetsapak.Size = new System.Drawing.Size(51, 20);
            this.lblktovetsapak.TabIndex = 58;
            this.lblktovetsapak.Text = "כתובת";
            // 
            // lbltelsapak
            // 
            this.lbltelsapak.AutoSize = true;
            this.lbltelsapak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbltelsapak.Location = new System.Drawing.Point(1080, 182);
            this.lbltelsapak.Name = "lbltelsapak";
            this.lbltelsapak.Size = new System.Drawing.Size(96, 20);
            this.lbltelsapak.TabIndex = 57;
            this.lbltelsapak.Text = "מספר פלאפון";
            // 
            // lblshemsapak
            // 
            this.lblshemsapak.AutoSize = true;
            this.lblshemsapak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblshemsapak.Location = new System.Drawing.Point(1117, 129);
            this.lblshemsapak.Name = "lblshemsapak";
            this.lblshemsapak.Size = new System.Drawing.Size(59, 20);
            this.lblshemsapak.TabIndex = 56;
            this.lblshemsapak.Text = "שם ספק";
            // 
            // missapak
            // 
            this.missapak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sapakim2BindingSource, "mispar", true));
            this.missapak.Enabled = false;
            this.missapak.Location = new System.Drawing.Point(888, 341);
            this.missapak.Name = "missapak";
            this.missapak.Size = new System.Drawing.Size(151, 20);
            this.missapak.TabIndex = 6;
            this.missapak.TextChanged += new System.EventHandler(this.missapak_TextChanged);
            this.missapak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.missapak_KeyPress);
            // 
            // shemsapak
            // 
            this.shemsapak.Enabled = false;
            this.shemsapak.Location = new System.Drawing.Point(888, 131);
            this.shemsapak.Name = "shemsapak";
            this.shemsapak.Size = new System.Drawing.Size(151, 20);
            this.shemsapak.TabIndex = 1;
            this.shemsapak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shemsapak_KeyPress);
            // 
            // ktovetsapak
            // 
            this.ktovetsapak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sapakim2BindingSource, "ktovet", true));
            this.ktovetsapak.Enabled = false;
            this.ktovetsapak.Location = new System.Drawing.Point(888, 236);
            this.ktovetsapak.Name = "ktovetsapak";
            this.ktovetsapak.Size = new System.Drawing.Size(151, 20);
            this.ktovetsapak.TabIndex = 3;
            this.ktovetsapak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktovetsapak_KeyPress);
            // 
            // yeshuvsapak
            // 
            this.yeshuvsapak.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sapakim2BindingSource, "yeshuv", true));
            this.yeshuvsapak.Enabled = false;
            this.yeshuvsapak.Location = new System.Drawing.Point(888, 286);
            this.yeshuvsapak.Name = "yeshuvsapak";
            this.yeshuvsapak.Size = new System.Drawing.Size(151, 20);
            this.yeshuvsapak.TabIndex = 5;
            this.yeshuvsapak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yeshuvsapak_KeyPress);
            // 
            // shemsapak2
            // 
            this.shemsapak2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sapakim2BindingSource, "sapak", true));
            this.shemsapak2.Enabled = false;
            this.shemsapak2.Location = new System.Drawing.Point(888, 131);
            this.shemsapak2.Name = "shemsapak2";
            this.shemsapak2.Size = new System.Drawing.Size(151, 20);
            this.shemsapak2.TabIndex = 0;
            this.shemsapak2.Click += new System.EventHandler(this.shemsapak2_Click);
            this.shemsapak2.TextChanged += new System.EventHandler(this.shemsapak2_TextChanged);
            this.shemsapak2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shemsapak2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(864, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "**";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(864, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "**";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(864, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "**";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(864, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 91;
            this.label4.Text = "**";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(864, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 92;
            this.label5.Text = "**";
            this.label5.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sapakim2BindingSource, "tel", true));
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(888, 184);
            this.maskedTextBox1.Mask = "000-0000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(151, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Purple;
            this.button2.Location = new System.Drawing.Point(72, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 99;
            this.button2.Text = "אחרון";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(72, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 98;
            this.button1.Text = "ראשון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(72, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 46);
            this.button4.TabIndex = 101;
            this.button4.Text = "הבא";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Purple;
            this.button3.Location = new System.Drawing.Point(72, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 46);
            this.button3.TabIndex = 100;
            this.button3.Text = "הקודם";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Purple;
            this.button5.Location = new System.Drawing.Point(681, 452);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 69);
            this.button5.TabIndex = 102;
            this.button5.Text = "עדכן";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Purple;
            this.button6.Location = new System.Drawing.Point(173, 452);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 69);
            this.button6.TabIndex = 103;
            this.button6.Text = "הוסף";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // hazmana
            // 
            this.hazmana.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hazmana.ForeColor = System.Drawing.Color.Purple;
            this.hazmana.Location = new System.Drawing.Point(1092, 573);
            this.hazmana.Name = "hazmana";
            this.hazmana.Size = new System.Drawing.Size(166, 69);
            this.hazmana.TabIndex = 104;
            this.hazmana.Text = "בצע הזמנה";
            this.hazmana.UseVisualStyleBackColor = true;
            this.hazmana.Click += new System.EventHandler(this.hazmana_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Edwardian Script ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 33);
            this.label7.TabIndex = 105;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sapakDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.ktovetDataGridViewTextBoxColumn,
            this.yeshuvDataGridViewTextBoxColumn,
            this.misparDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sapakim2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(232, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 241);
            this.dataGridView1.TabIndex = 106;
            // 
            // razan22DataSet1
            // 
            this.razan22DataSet1.DataSetName = "razan22DataSet1";
            this.razan22DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sapakim2BindingSource
            // 
            this.sapakim2BindingSource.DataMember = "sapakim2";
            this.sapakim2BindingSource.DataSource = this.razan22DataSet1;
            // 
            // sapakim2TableAdapter
            // 
            this.sapakim2TableAdapter.ClearBeforeFill = true;
            // 
            // sapakDataGridViewTextBoxColumn
            // 
            this.sapakDataGridViewTextBoxColumn.DataPropertyName = "sapak";
            this.sapakDataGridViewTextBoxColumn.HeaderText = "שם ספק";
            this.sapakDataGridViewTextBoxColumn.Name = "sapakDataGridViewTextBoxColumn";
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
            this.ktovetDataGridViewTextBoxColumn.HeaderText = "כתובת ספק";
            this.ktovetDataGridViewTextBoxColumn.Name = "ktovetDataGridViewTextBoxColumn";
            // 
            // yeshuvDataGridViewTextBoxColumn
            // 
            this.yeshuvDataGridViewTextBoxColumn.DataPropertyName = "yeshuv";
            this.yeshuvDataGridViewTextBoxColumn.HeaderText = "ישוב";
            this.yeshuvDataGridViewTextBoxColumn.Name = "yeshuvDataGridViewTextBoxColumn";
            // 
            // misparDataGridViewTextBoxColumn
            // 
            this.misparDataGridViewTextBoxColumn.DataPropertyName = "mispar";
            this.misparDataGridViewTextBoxColumn.HeaderText = "כמות מכשירים";
            this.misparDataGridViewTextBoxColumn.Name = "misparDataGridViewTextBoxColumn";
            // 
            // formsapakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hazmana);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shemsapak2);
            this.Controls.Add(this.lblmissapak);
            this.Controls.Add(this.lblyeshuvsapak);
            this.Controls.Add(this.lblktovetsapak);
            this.Controls.Add(this.lbltelsapak);
            this.Controls.Add(this.lblshemsapak);
            this.Controls.Add(this.missapak);
            this.Controls.Add(this.shemsapak);
            this.Controls.Add(this.ktovetsapak);
            this.Controls.Add(this.yeshuvsapak);
            this.Controls.Add(this.bcsapak);
            this.Controls.Add(this.lblssuppliers);
            this.Controls.Add(this.tbsuppliers);
            this.Controls.Add(this.btnsapidk);
            this.Controls.Add(this.btnsapma);
            this.Controls.Add(this.btnsapho);
            this.Controls.Add(this.btnbksu);
            this.Controls.Add(this.lblS);
            this.Name = "formsapakim";
            this.Text = "formsapakim";
            this.Load += new System.EventHandler(this.formsapakim_Load);
            this.Click += new System.EventHandler(this.formsapakim_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razan22DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sapakim2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Button btnbksu;
        private System.Windows.Forms.Button btnsapidk;
        private System.Windows.Forms.Button btnsapma;
        private System.Windows.Forms.Button btnsapho;
        private System.Windows.Forms.Label lblssuppliers;
        private System.Windows.Forms.TextBox tbsuppliers;
        private System.Windows.Forms.Button bcsapak;
        private System.Windows.Forms.Label lblmissapak;
        private System.Windows.Forms.Label lblyeshuvsapak;
        private System.Windows.Forms.Label lblktovetsapak;
        private System.Windows.Forms.Label lbltelsapak;
        private System.Windows.Forms.Label lblshemsapak;
        private System.Windows.Forms.TextBox missapak;
        private System.Windows.Forms.TextBox shemsapak;
        private System.Windows.Forms.TextBox ktovetsapak;
        private System.Windows.Forms.TextBox yeshuvsapak;
        private System.Windows.Forms.TextBox shemsapak2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button hazmana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private razan22DataSet1 razan22DataSet1;
        private System.Windows.Forms.BindingSource sapakim2BindingSource;
        private razan22DataSet1TableAdapters.sapakim2TableAdapter sapakim2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sapakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktovetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeshuvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn misparDataGridViewTextBoxColumn;
    }
}