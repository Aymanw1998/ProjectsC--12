namespace WindowsFormsApplication1
{
    partial class mikom
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
            this.mikomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shrmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abedDataSet = new WindowsFormsApplication1.abedDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.motzarimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.mikomTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.mikomTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mstextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaAlotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camaNmcharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miHspakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamaNmharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamaNesharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motzarimTableAdapter = new WindowsFormsApplication1.abedDataSetTableAdapters.motzarimTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motzarimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mikomDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.shrmDataGridViewTextBoxColumn,
            this.cmotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mikomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(344, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mikomDataGridViewTextBoxColumn
            // 
            this.mikomDataGridViewTextBoxColumn.DataPropertyName = "mikom";
            this.mikomDataGridViewTextBoxColumn.HeaderText = "מיקום";
            this.mikomDataGridViewTextBoxColumn.Name = "mikomDataGridViewTextBoxColumn";
            this.mikomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "קוד מוצר";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shrmDataGridViewTextBoxColumn
            // 
            this.shrmDataGridViewTextBoxColumn.DataPropertyName = "shrm";
            this.shrmDataGridViewTextBoxColumn.HeaderText = "שם מוצר";
            this.shrmDataGridViewTextBoxColumn.Name = "shrmDataGridViewTextBoxColumn";
            this.shrmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmotDataGridViewTextBoxColumn
            // 
            this.cmotDataGridViewTextBoxColumn.DataPropertyName = "cmot";
            this.cmotDataGridViewTextBoxColumn.HeaderText = "כמות";
            this.cmotDataGridViewTextBoxColumn.Name = "cmotDataGridViewTextBoxColumn";
            this.cmotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mikomBindingSource
            // 
            this.mikomBindingSource.DataMember = "mikom";
            this.mikomBindingSource.DataSource = this.abedDataSet;
            // 
            // abedDataSet
            // 
            this.abedDataSet.DataSetName = "abedDataSet";
            this.abedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1384, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "סגור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(803, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "הוסף קוד";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(606, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "מחק מוצר";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(329, 623);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "עדכן";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1382, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "מיקום";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1369, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "קוד מוצר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1371, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "שם מוצר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1387, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "כמות";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "shem", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(1242, 435);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // motzarimBindingSource
            // 
            this.motzarimBindingSource.DataMember = "motzarim";
            this.motzarimBindingSource.DataSource = this.abedDataSet;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "kmot", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(1243, 479);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // mikomTableAdapter
            // 
            this.mikomTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(865, 255);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1005, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "חיפוש במדפים";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(-138, 13);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // txt1
            // 
            this.txt1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mikomBindingSource, "mikom", true));
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(1242, 340);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 16;
            this.txt1.Click += new System.EventHandler(this.textBox7_Click);
            this.txt1.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(396, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 42);
            this.label6.TabIndex = 18;
            this.label6.Text = "מדפים";
            // 
            // mstextBox2
            // 
            this.mstextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "code", true));
            this.mstextBox2.Enabled = false;
            this.mstextBox2.Location = new System.Drawing.Point(1243, 389);
            this.mstextBox2.Name = "mstextBox2";
            this.mstextBox2.Size = new System.Drawing.Size(100, 20);
            this.mstextBox2.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(803, 634);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 59);
            this.button5.TabIndex = 20;
            this.button5.Text = "הוסף קוד";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(616, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "נקה";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button7.Location = new System.Drawing.Point(329, 603);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 79);
            this.button7.TabIndex = 22;
            this.button7.Text = "עדכן";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button8.Location = new System.Drawing.Point(606, 633);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 59);
            this.button8.TabIndex = 23;
            this.button8.Text = "מחק מוצר";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button9.Location = new System.Drawing.Point(48, 342);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 64);
            this.button9.TabIndex = 24;
            this.button9.Text = "סיום";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(926, 309);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 24);
            this.button10.TabIndex = 25;
            this.button10.Text = "ראשון";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(926, 359);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 24);
            this.button11.TabIndex = 26;
            this.button11.Text = "הבא";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(926, 408);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 24);
            this.button12.TabIndex = 27;
            this.button12.Text = "לפני";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(926, 453);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 24);
            this.button13.TabIndex = 28;
            this.button13.Text = "האחרון";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button14.Location = new System.Drawing.Point(0, 680);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(176, 64);
            this.button14.TabIndex = 29;
            this.button14.Text = "סיום מערכת";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn1,
            this.shemDataGridViewTextBoxColumn,
            this.camaAlotDataGridViewTextBoxColumn,
            this.camaNmcharDataGridViewTextBoxColumn,
            this.miHspakDataGridViewTextBoxColumn,
            this.mikomDataGridViewTextBoxColumn1,
            this.kmotDataGridViewTextBoxColumn,
            this.kamaNmharDataGridViewTextBoxColumn,
            this.kamaNesharDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.motzarimBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1230, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 150);
            this.dataGridView2.TabIndex = 30;
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "קוד";
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            // 
            // shemDataGridViewTextBoxColumn
            // 
            this.shemDataGridViewTextBoxColumn.DataPropertyName = "shem";
            this.shemDataGridViewTextBoxColumn.HeaderText = "שם מוצר";
            this.shemDataGridViewTextBoxColumn.Name = "shemDataGridViewTextBoxColumn";
            // 
            // camaAlotDataGridViewTextBoxColumn
            // 
            this.camaAlotDataGridViewTextBoxColumn.DataPropertyName = "cama alot";
            this.camaAlotDataGridViewTextBoxColumn.HeaderText = "מחיר עלות";
            this.camaAlotDataGridViewTextBoxColumn.Name = "camaAlotDataGridViewTextBoxColumn";
            // 
            // camaNmcharDataGridViewTextBoxColumn
            // 
            this.camaNmcharDataGridViewTextBoxColumn.DataPropertyName = "cama nmchar";
            this.camaNmcharDataGridViewTextBoxColumn.HeaderText = "מחיר צרכן";
            this.camaNmcharDataGridViewTextBoxColumn.Name = "camaNmcharDataGridViewTextBoxColumn";
            // 
            // miHspakDataGridViewTextBoxColumn
            // 
            this.miHspakDataGridViewTextBoxColumn.DataPropertyName = "mi hspak";
            this.miHspakDataGridViewTextBoxColumn.HeaderText = "שם ספק";
            this.miHspakDataGridViewTextBoxColumn.Name = "miHspakDataGridViewTextBoxColumn";
            // 
            // mikomDataGridViewTextBoxColumn1
            // 
            this.mikomDataGridViewTextBoxColumn1.DataPropertyName = "mikom";
            this.mikomDataGridViewTextBoxColumn1.HeaderText = "מיקום";
            this.mikomDataGridViewTextBoxColumn1.Name = "mikomDataGridViewTextBoxColumn1";
            // 
            // kmotDataGridViewTextBoxColumn
            // 
            this.kmotDataGridViewTextBoxColumn.DataPropertyName = "kmot";
            this.kmotDataGridViewTextBoxColumn.HeaderText = "כמות";
            this.kmotDataGridViewTextBoxColumn.Name = "kmotDataGridViewTextBoxColumn";
            // 
            // kamaNmharDataGridViewTextBoxColumn
            // 
            this.kamaNmharDataGridViewTextBoxColumn.DataPropertyName = "kama nmhar";
            this.kamaNmharDataGridViewTextBoxColumn.HeaderText = "כמה נמכר";
            this.kamaNmharDataGridViewTextBoxColumn.Name = "kamaNmharDataGridViewTextBoxColumn";
            // 
            // kamaNesharDataGridViewTextBoxColumn
            // 
            this.kamaNesharDataGridViewTextBoxColumn.DataPropertyName = "kama neshar";
            this.kamaNesharDataGridViewTextBoxColumn.HeaderText = "כמה נשאר";
            this.kamaNesharDataGridViewTextBoxColumn.Name = "kamaNesharDataGridViewTextBoxColumn";
            // 
            // motzarimTableAdapter
            // 
            this.motzarimTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1622, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "חיפוש מוצר";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1482, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button15
            // 
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button15.Location = new System.Drawing.Point(219, 706);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 60);
            this.button15.TabIndex = 33;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motzarimBindingSource, "mikom", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(1479, 340);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1611, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "מיקום המוצר";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(457, 687);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 70);
            this.button16.TabIndex = 36;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1360, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 79);
            this.label9.TabIndex = 37;
            this.label9.Text = "extreme car";
            // 
            // mikom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1681, 769);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.mstextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mikom";
            this.Text = "-";
            this.Load += new System.EventHandler(this.mikom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motzarimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private abedDataSet abedDataSet;
        private System.Windows.Forms.BindingSource mikomBindingSource;
        private abedDataSetTableAdapters.mikomTableAdapter mikomTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mikomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shrmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmotDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mstextBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource motzarimBindingSource;
        private abedDataSetTableAdapters.motzarimTableAdapter motzarimTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaAlotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camaNmcharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miHspakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mikomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamaNmharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamaNesharDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label9;
    }
}